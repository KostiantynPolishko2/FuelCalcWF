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
using CmdDbMSSQL.Models;
using FuelCalcLibrary.Models;
using WF.Models;
using WF.Resources;

namespace WF.Views
{
    public partial class FuelCalc : Form
    {
        private void InitializeCustomComponent()
        {
            resultcalc_infoLabel.Visible = false;
            setLabelFontBold(lbMarkAuto, lbModelAuto, lbVEngine);
            setLabelFontBold(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);
            setLabelFontName(lbMarkAuto, lbModelAuto, lbVEngine);
            setLabelFontName(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);
            setLabelFontSize(10, lbMarkAuto, lbModelAuto, lbVEngine);
            setLabelFontSize(10, distanceLabel, consumeLabel, priceLabel, resultcalc_infoLabel);
            setLabelFontSize(14, resultcalcLabel);

            int space = 15;

            //set position of labels for model Auto
            lbModelAuto.Location = new Point((int)(Width - lbModelAuto.Width) / 2, space);
            lbVEngine.Location = new Point((int)(Width * 3/4), space);
            lbMarkAuto.Location = new Point((int)(Width/4 - lbMarkAuto.Width), space);

            //set position of textbox for model Auto
            txBxMarkAuto.Location = setPositionObj(lbMarkAuto, txBxMarkAuto, 5);
            txBxModelAuto.Location = setPositionObj(lbModelAuto, txBxModelAuto, 5);
            txBxVEngine.Location = setPositionObj(lbVEngine, txBxVEngine, 5);

            //set position of labels for model Trip
            distanceLabel.Location = setPositionObj(txBxMarkAuto, distanceLabel, 40);
            consumeLabel.Location = setPositionObj(txBxModelAuto, consumeLabel, 40);
            priceLabel.Location = setPositionObj(txBxVEngine, priceLabel, 40);

            //set position of textbox
            distanceTB.Location = setPositionObj(distanceLabel, distanceTB, 5);
            consumeTB.Location = setPositionObj(consumeLabel, consumeTB, 5);
            priceTB.Location = setPositionObj(priceLabel, priceTB, 5);

            //set position of button
            calcBtn.Location = setPositionObj(distanceTB, calcBtn, 40);
            clearBtn.Location = setPositionObj(consumeTB, clearBtn, 40);
            saveBtn.Location = setPositionObj(priceTB, saveBtn, 40);
        }

        private Point setPositionObj(in Control mainObj, in Control referObj, int space)
        {
            return new Point(mainObj.Left + (mainObj.Width - referObj.Width) / 2, mainObj.Top +mainObj.Height + space);
        }

        private void setLabelFontBold(params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            { 
                label[i].Font = new Font(label[i].Font.Name, label[i].Font.Size, FontStyle.Bold);
            }
        }

        private void setLabelFontName(params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Font = new Font("Calibri", label[i].Font.Size, label[i].Font.Style);
            }
        }

        private void setLabelFontSize(in int size, params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Font = new Font(label[i].Font.Name, size, label[i].Font.Style);
            }
        }

        private void TreatInPutData((bool flag, float treatValue) tuple, ref float TargetValue, ref TextBox fieldTB, int i)
        {
            if (!tuple.flag) { MessageBox.Show($"{FuelCost.Message[i]} is in uncorrect format"); }
            else
            {
                TargetValue = tuple.treatValue;
                fieldTB.Text = tuple.treatValue.ToString();
            }
        }

        private bool isEmpty(params Control[] items)
        {
            foreach(var item in items) { if (item.Text == string.Empty) { return true; } }
            return false;
        }

        private void ClearTextBox(params TextBox[] fields)
        {
            foreach(var field in fields) { field.Clear(); }
        }

        private void setAbility(bool flag, params Control[] items)
        {
            foreach (var item in items) 
            { 
                item.Enabled = flag;
                if(item is TextBox) { item.BackColor = Color.FromArgb(224, 224, 224); }
            }
        }

        private void ShowLabel(ref Label fieldLabel, bool flag = true)
        {
            fieldLabel.Visible = flag;
            resultcalcLabel.Text = $"Auto: Model {txBxMarkAuto.Text} | Mark {txBxModelAuto.Text} | Engine {txBxVEngine.Text} | Consume {consumeTB.Text}";
        }

        private void HideLabel(ref Label fieldLabel) => fieldLabel.Visible = false;

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

        private void setViewController()
        {
            btnTheme.Location = new Point(5, 5);
            btnTheme.TabIndex = 0;
            btnTheme.themeColor += setThemeColor;
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

        public double getConsumeFuel()
        {
            List<Auto_db>? all = db.getAllAutoDb();
            double.TryParse(txBxVEngine.Text, out double VEngine);

            Auto_db? result = all?.FirstOrDefault(
                item => item.mark.ToLower().Equals(txBxMarkAuto.Text.ToLower()) &&
                item.model.ToLower().Equals(txBxModelAuto.Text.ToLower()) &&
                item.engine_power.Equals(VEngine)
                );

            return result == null ? 0 : (double)result.fuel_consumption;
        }
    }
}
