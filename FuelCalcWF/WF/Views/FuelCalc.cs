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
                    $"На поездку потребуется {FuelCost.GetTxtHundreths(FuelCostObject.TotalFuelVolume)} л топлива. " +
                    $"Она обойдётся в {(int)FuelCostObject.TotalCost} грн {FuelCost.GetIntHundredths(FuelCostObject.TotalCost)} копеек.";
            }
        }

        private void clearBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ClearTextBox(distanceTB, consumeTB, priceTB);
            ClearTextBox(txBxMarkAuto, txBxModelAuto, txBxVEngine);

            HideLabel(ref resultcalc_infoLabel);
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
            this.db.Auto_dbs.Add(new Auto_db() 
            { mark = txBxMarkAuto.Text, model = txBxModelAuto.Text, 
                engine_power =  2.2, fuel_consumption = 5.5 });

            (bool flag, string msg) = db.isSaveChanges();
            if (!flag) 
            {
                MessageBox.Show(msg);
                return;
            }
            else { MessageBox.Show("Info saved to DB!"); }
        }
    }
}
