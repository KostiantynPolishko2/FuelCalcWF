using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelCalcLibrary.Models;
using WF.Models;
using WF.Views.UserControls;
using WF.Resources;
using CmdDbMSSQL.Controllers;
using CmdDbMSSQL.Models;

namespace WF.Views
{
    public partial class FuelCalc : Form
    {
        private FuelCost FuelCostObject;
        private BtnChangeTheme btnTheme;
        private Graphics g;
        private List<ImgApp> imgsApp;
        private Point lastMousePosition;
        private DbController db;
        private List<Auto_db>? autoDbs { get; set; } = null;
        public FuelCalc()
        {
            InitializeComponent();

            topPanel.Dock = DockStyle.Top;
            topPanel.Height = calcBtn.Top + calcBtn.Height + 20;

            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = (int)(Size.Height) / 6;

            InitializeCustomComponent();
            FuelCostObject = new FuelCost();
            btnTheme = new BtnChangeTheme();
            setViewController();
            topPanel.Controls.Add(this.btnTheme);

            imgsApp = new List<ImgApp>(6);
            setImgsApp();

            db = new DbController();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FuelCalc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastMousePosition.X;
                Top += e.Y - lastMousePosition.Y;
            }
        }

        private void FuelCalc_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = new Point(e.X, e.Y);
        }

        private void FuelCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void closeLabel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.DarkRed;
        }

        private void distanceTB_Leave(object sender, EventArgs e)
        {
            float TargetValue = 0.0f;
            if (distanceTB.Text != "") { TreatInPutData(FuelCost.IsValue(distanceTB.Text), ref TargetValue, ref distanceTB, (int)TbName.Distance); }

            if (TargetValue != 0) { FuelCostObject.Distance = TargetValue; }
        }

        private void consumeTB_Leave(object sender, EventArgs e)
        {
            float TargetValue = 0.0f;
            if (consumeTB.Text != "") { TreatInPutData(FuelCost.IsValue(consumeTB.Text), ref TargetValue, ref consumeTB, (int)TbName.Consume); }

            if (TargetValue != 0) { FuelCostObject.Consumption = TargetValue; }
        }

        private void priceTB_Leave(object sender, EventArgs e)
        {
            float TargetValue = 0.0f;
            if (priceTB.Text != "") { TreatInPutData(FuelCost.IsValue(priceTB.Text), ref TargetValue, ref priceTB, (int)TbName.Price); }

            if (TargetValue != 0) { FuelCostObject.Price = TargetValue; }
        }

        private void txBxVEngine_Leave(object sender, EventArgs e)
        {
            float TargetValue = 0.0f;
            if (txBxVEngine.Text != "") { TreatInPutData(FuelCost.IsValue(txBxVEngine.Text), ref TargetValue, ref txBxVEngine, (int)TbName.Vengine); }

            if (isEmpty(txBxMarkAuto, txBxModelAuto, txBxVEngine)) { return; }

            consumeTB.Enabled = false;
            consumeTB.BackColor = Color.FromArgb(224, 224, 224);
            string txt = getConsumeFuel().ToString();
            consumeTB.Enabled = true;
            consumeTB.BackColor = Color.White;

            consumeTB.Text = txt;
        }

        private void calcBtn_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = false;

            if (distanceTB.Text == "" || consumeTB.Text == "" || priceTB.Text == "")
            {
                MessageBox.Show("Input data in empty fields");
                flag = true;
            }

            if (!flag)
            {
                FuelCostObject.FuelCalculation();
                FuelCostObject.CostCalculation();

                ShowLabel(ref resultcalc_infoLabel);

                resultcalc_infoLabel.Text =
                    $"�� ������� ����������� {FuelCost.GetTxtHundreths(FuelCostObject.TotalFuelVolume)} � �������. " +
                    $"��� �������� � {(int)FuelCostObject.TotalCost} ��� {FuelCost.GetIntHundredths(FuelCostObject.TotalCost)} ������.";
            }
        }

        private void clearBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ClearTextBox(distanceTB, consumeTB, priceTB);
            ClearTextBox(txBxMarkAuto, txBxModelAuto, txBxVEngine);

            HideLabel(ref resultcalc_infoLabel);
            resultcalcLabel.Text = "���������� �������";
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            foreach (var img in imgsApp)
            {
                g.DrawImage(img.bmp, img.ptn);
            }
        }

        private void FuelCalc_Load(object sender, EventArgs e)
        {
            if (!db.Database.CanConnect())
            {
                setAbility(false, txBxMarkAuto, txBxModelAuto, txBxVEngine, saveBtn);
                MessageBox.Show("No connection Db");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty(txBxMarkAuto, txBxModelAuto, txBxVEngine, consumeTB)) { MessageBox.Show("TextBox is empty"); return; }

            float enginePower = 0.0f, fuelConsumption = 0.0f;
            if (txBxVEngine.Text != "") { TreatInPutData(FuelCost.IsValue(txBxVEngine.Text), ref enginePower, ref txBxVEngine, (int)TbName.Vengine); }
            if (txBxVEngine.Text != "") { TreatInPutData(FuelCost.IsValue(consumeTB.Text), ref fuelConsumption, ref consumeTB, (int)TbName.Consume); }

            if (enginePower == 0 || fuelConsumption == 0) { return; }

            this.db.Auto_dbs.Add(new Auto_db()
            {
                mark = txBxMarkAuto.Text.ToLower(),
                model = txBxModelAuto.Text.ToLower(),
                engine_power = enginePower,
                fuel_consumption = fuelConsumption
            });

            (bool flag, string msg) = db.isSaveChanges();
            if (!flag)
            {
                MessageBox.Show(msg);
                return;
            }
            MessageBox.Show("Info saved to DB!");
            ShowLabel(ref resultcalc_infoLabel, false);

            ClearTextBox(distanceTB, consumeTB, priceTB);
            ClearTextBox(txBxMarkAuto, txBxModelAuto, txBxVEngine);

        }
    }
}
