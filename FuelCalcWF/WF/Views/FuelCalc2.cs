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

namespace WF.Views
{
    public partial class FuelCalc : Form
    {
        private void InitializeCustomComponent()
        {
            resultcalc_infoLabel.Visible = false;
            setLabelFontBold(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);
            setLabelFontName(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);

            setLabelFontSize(10, distanceLabel, consumeLabel, priceLabel, resultcalc_infoLabel);
            setLabelFontSize(14, resultcalcLabel);

            //set position of labels
            int space = 15;
            consumeLabel.Location = new Point((int)(Size.Width - consumeLabel.Width) / 2, space);
            distanceLabel.Location = new Point(consumeLabel.Location.X - distanceLabel.Width - 15, space);
            priceLabel.Location = new Point(consumeLabel.Location.X + consumeLabel.Width + 15, space);

            //set position of textbox
            distanceTB.Location = SetPositionTB(distanceLabel, distanceTB, 10);
            consumeTB.Location = SetPositionTB(consumeLabel, consumeTB, 10);
            priceTB.Location = SetPositionTB(priceLabel, priceTB, 10);

            //set position of button
            calcBtn.Location = SetPositionBtn(distanceLabel, calcBtn, distanceTB, 0);
            clearBtn.Location = SetPositionBtn(consumeLabel, clearBtn, consumeTB, 0);
            saveBtn.Location = SetPositionBtn(priceLabel, saveBtn, priceTB, 0);
        }

        private Point SetPositionTB(in Label label, in TextBox TB, int space)
        {
            return new Point(label.Location.X + (label.Width - TB.Width) / 2, label.Location.Y + TB.Height + space);
        } 
        
        private Point SetPositionBtn(in Label label, in Button Btn, in TextBox TB, int space)
        {
            return new Point(label.Location.X + (label.Width - Btn.Width) / 2, TB.Location.Y + Btn.Height + space);
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

        private void ClearTextBox(ref TextBox fieldTB)
        {
            fieldTB.Clear();
        }

        private void ShowLabel(ref Label fieldLabel)
        {
            fieldLabel.Visible = true;
        }

        private void HideLabel(ref Label fieldLabel)
        {
            fieldLabel.Visible = false;
        }
    }
}
