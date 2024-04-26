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

        private void ClearTextBox(params TextBox[] fields)
        {
            foreach(var field in fields) { field.Clear(); }
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
