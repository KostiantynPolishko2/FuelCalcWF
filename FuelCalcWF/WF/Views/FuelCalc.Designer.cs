using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Views
{
    partial class FuelCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topPanel = new Panel();
            lbVEngine = new Label();
            lbModelAuto = new Label();
            lbMarkAuto = new Label();
            saveBtn = new Button();
            priceTB = new TextBox();
            consumeTB = new TextBox();
            clearBtn = new Button();
            calcBtn = new Button();
            distanceTB = new TextBox();
            closeLabel = new Label();
            priceLabel = new Label();
            consumeLabel = new Label();
            distanceLabel = new Label();
            bottomPanel = new Panel();
            resultcalc_infoLabel = new Label();
            resultcalcLabel = new Label();
            txBxMarkAuto = new TextBox();
            txBxModelAuto = new TextBox();
            txBxVEngine = new TextBox();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(255, 153, 0);
            topPanel.Controls.Add(txBxVEngine);
            topPanel.Controls.Add(txBxModelAuto);
            topPanel.Controls.Add(txBxMarkAuto);
            topPanel.Controls.Add(lbVEngine);
            topPanel.Controls.Add(lbModelAuto);
            topPanel.Controls.Add(lbMarkAuto);
            topPanel.Controls.Add(saveBtn);
            topPanel.Controls.Add(priceTB);
            topPanel.Controls.Add(consumeTB);
            topPanel.Controls.Add(clearBtn);
            topPanel.Controls.Add(calcBtn);
            topPanel.Controls.Add(distanceTB);
            topPanel.Controls.Add(closeLabel);
            topPanel.Controls.Add(priceLabel);
            topPanel.Controls.Add(consumeLabel);
            topPanel.Controls.Add(distanceLabel);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(701, 205);
            topPanel.TabIndex = 0;
            // 
            // lbVEngine
            // 
            lbVEngine.AutoSize = true;
            lbVEngine.Location = new Point(500, 18);
            lbVEngine.Margin = new Padding(0);
            lbVEngine.Name = "lbVEngine";
            lbVEngine.Size = new Size(102, 15);
            lbVEngine.TabIndex = 13;
            lbVEngine.Text = "Объём двигателя";
            lbVEngine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbModelAuto
            // 
            lbModelAuto.AutoSize = true;
            lbModelAuto.Location = new Point(215, 18);
            lbModelAuto.Margin = new Padding(0);
            lbModelAuto.Name = "lbModelAuto";
            lbModelAuto.Size = new Size(77, 15);
            lbModelAuto.TabIndex = 12;
            lbModelAuto.Text = "Модель авто";
            lbModelAuto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMarkAuto
            // 
            lbMarkAuto.AutoSize = true;
            lbMarkAuto.Location = new Point(10, 18);
            lbMarkAuto.Margin = new Padding(0);
            lbMarkAuto.Name = "lbMarkAuto";
            lbMarkAuto.Size = new Size(70, 15);
            lbMarkAuto.TabIndex = 11;
            lbMarkAuto.Text = "Марка авто";
            lbMarkAuto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.Green;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatAppearance.BorderColor = Color.White;
            saveBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(519, 157);
            saveBtn.Margin = new Padding(0);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(112, 38);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "СОХРАНИТЬ";
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(519, 120);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(109, 23);
            priceTB.TabIndex = 7;
            priceTB.Leave += priceTB_Leave;
            // 
            // consumeTB
            // 
            consumeTB.Location = new Point(233, 120);
            consumeTB.Name = "consumeTB";
            consumeTB.Size = new Size(109, 23);
            consumeTB.TabIndex = 6;
            consumeTB.Leave += consumeTB_Leave;
            // 
            // clearBtn
            // 
            clearBtn.AutoSize = true;
            clearBtn.BackColor = Color.Blue;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderColor = Color.White;
            clearBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(233, 157);
            clearBtn.Margin = new Padding(0);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(112, 38);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "ОЧИСТИТЬ";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.MouseDown += clearBtn_MouseDown;
            // 
            // calcBtn
            // 
            calcBtn.AutoSize = true;
            calcBtn.BackColor = Color.Black;
            calcBtn.Cursor = Cursors.Hand;
            calcBtn.FlatAppearance.BorderColor = Color.White;
            calcBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calcBtn.ForeColor = Color.White;
            calcBtn.Location = new Point(23, 157);
            calcBtn.Margin = new Padding(0);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(112, 38);
            calcBtn.TabIndex = 8;
            calcBtn.Text = "РАССЧИТАТЬ";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.MouseDown += calcBtn_MouseDown;
            // 
            // distanceTB
            // 
            distanceTB.Location = new Point(23, 120);
            distanceTB.Name = "distanceTB";
            distanceTB.Size = new Size(109, 23);
            distanceTB.TabIndex = 5;
            distanceTB.Leave += distanceTB_Leave;
            // 
            // closeLabel
            // 
            closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeLabel.BackColor = Color.Red;
            closeLabel.Cursor = Cursors.Hand;
            closeLabel.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            closeLabel.ForeColor = Color.White;
            closeLabel.Location = new Point(670, 0);
            closeLabel.Margin = new Padding(0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(31, 33);
            closeLabel.TabIndex = 4;
            closeLabel.Text = "X";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            closeLabel.Click += closeLabel_Click_1;
            closeLabel.MouseLeave += closeLabel_MouseLeave;
            closeLabel.MouseHover += closeLabel_MouseHover;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(500, 102);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(156, 15);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Стоимость 1л топлива, грн";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consumeLabel
            // 
            consumeLabel.AutoSize = true;
            consumeLabel.Location = new Point(215, 102);
            consumeLabel.Margin = new Padding(0);
            consumeLabel.Name = "consumeLabel";
            consumeLabel.Size = new Size(141, 15);
            consumeLabel.TabIndex = 2;
            consumeLabel.Text = "Расход толива на 100 км";
            consumeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new Point(6, 102);
            distanceLabel.Margin = new Padding(0);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(138, 15);
            distanceLabel.TabIndex = 1;
            distanceLabel.Text = "Расстояние поездки, км";
            distanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(255, 204, 136);
            bottomPanel.Controls.Add(resultcalc_infoLabel);
            bottomPanel.Location = new Point(0, 250);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(701, 50);
            bottomPanel.TabIndex = 1;
            // 
            // resultcalc_infoLabel
            // 
            resultcalc_infoLabel.AutoSize = true;
            resultcalc_infoLabel.Location = new Point(24, 15);
            resultcalc_infoLabel.Margin = new Padding(0);
            resultcalc_infoLabel.Name = "resultcalc_infoLabel";
            resultcalc_infoLabel.Size = new Size(111, 15);
            resultcalc_infoLabel.TabIndex = 0;
            resultcalc_infoLabel.Text = "resultcalc_infoLabel";
            resultcalc_infoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultcalcLabel
            // 
            resultcalcLabel.AutoSize = true;
            resultcalcLabel.Location = new Point(10, 219);
            resultcalcLabel.Margin = new Padding(0);
            resultcalcLabel.Name = "resultcalcLabel";
            resultcalcLabel.Size = new Size(115, 15);
            resultcalcLabel.TabIndex = 2;
            resultcalcLabel.Text = "Результаты расчёта";
            resultcalcLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txBxMarkAuto
            // 
            txBxMarkAuto.Location = new Point(6, 36);
            txBxMarkAuto.Name = "txBxMarkAuto";
            txBxMarkAuto.Size = new Size(109, 23);
            txBxMarkAuto.TabIndex = 14;
            // 
            // txBxModelAuto
            // 
            txBxModelAuto.Location = new Point(215, 36);
            txBxModelAuto.Name = "txBxModelAuto";
            txBxModelAuto.Size = new Size(109, 23);
            txBxModelAuto.TabIndex = 15;
            // 
            // txBxVEngine
            // 
            txBxVEngine.Location = new Point(493, 36);
            txBxVEngine.Name = "txBxVEngine";
            txBxVEngine.Size = new Size(109, 23);
            txBxVEngine.TabIndex = 16;
            // 
            // FuelCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 300);
            Controls.Add(resultcalcLabel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuelCalc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fuel Calculation";
            Load += FuelCalc_Load;
            KeyDown += FuelCalc_KeyDown;
            MouseDown += FuelCalc_MouseDown;
            MouseMove += FuelCalc_MouseMove;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Panel bottomPanel;
        private Label resultcalcLabel;
        private Label priceLabel;
        private Label consumeLabel;
        private Label distanceLabel;
        private Label resultcalc_infoLabel;
        private Label closeLabel;
        private TextBox priceTB;
        private TextBox consumeTB;
        private TextBox distanceTB;
        private Button calcBtn;
        private Button saveBtn;
        private Button clearBtn;
        private Label lbMarkAuto;
        private Label lbVEngine;
        private Label lbModelAuto;
        private TextBox txBxVEngine;
        private TextBox txBxModelAuto;
        private TextBox txBxMarkAuto;
    }
}

