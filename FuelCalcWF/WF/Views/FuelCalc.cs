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

namespace WF.Views
{
    public partial class FuelCalc : Form
    {
        private Point lastMousePosition;
        private FuelCost FuelCostObject;
        private BtnChangeTheme btnTheme;
        private Graphics g;
        private List<ImgApp> imgsApp;
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
            btnTheme.Location = new Point(5, 5);
            btnTheme.TabIndex = 0;
            btnTheme.themeColor += setThemeColor;

            topPanel.Controls.Add(this.btnTheme);
            imgsApp = new List<ImgApp>(6);
            setImgsApp();
            //iconApp = new ImgApp(IconsApp.AutoMark, new Point(10, lbMarkAuto.Top));
        }

        private void setImgsApp()
        {
            imgsApp.Add(new ImgApp(IconsApp.AutoMark, new Point(txBxMarkAuto.Left - 40 - 10, txBxMarkAuto.Top)));
            imgsApp.Add(new ImgApp(IconsApp.AutoMark, new Point(txBxModelAuto.Left - 40 - 10, txBxMarkAuto.Top)));
            imgsApp.Add(new ImgApp(IconsApp.AutoVolumeEngine, new Point(txBxVEngine.Left - 40 - 10, txBxVEngine.Top)));
            imgsApp.Add(new ImgApp(IconsApp.TripDistance, new Point(distanceTB.Left - 40 - 10, distanceTB.Top)));
            imgsApp.Add(new ImgApp(IconsApp.FuelConsumance, new Point(consumeTB.Left - 40 - 10, consumeTB.Top)));
            imgsApp.Add(new ImgApp(IconsApp.CostCharge, new Point(priceTB.Left - 40 - 10, priceTB.Top)));
        }

        private void setThemeColor()
        {
            if (btnTheme.isChanded)
            {
                topPanel.BackColor = Color.FromArgb(255, 153, 0);
                this.BackColor = Color.White;
                bottomPanel.BackColor = Color.FromArgb(255, 204, 136);
            }
            else
            {
                topPanel.BackColor = Color.FromArgb(96, 96, 96);
                this.BackColor = Color.FromArgb(160, 160, 160);
                bottomPanel.BackColor = Color.FromArgb(128, 128, 128);
            }

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

            if (TargetValue != 0) { FuelCostObject.Price = TargetValue; }
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

    }
}
