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
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(255, 153, 0);
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
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(801, 216);
            topPanel.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.Green;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatAppearance.BorderColor = Color.White;
            saveBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(598, 154);
            saveBtn.Margin = new Padding(0);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(128, 50);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "СОХРАНИТЬ";
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(598, 105);
            priceTB.Margin = new Padding(3, 4, 3, 4);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(124, 27);
            priceTB.TabIndex = 7;
            priceTB.Leave += priceTB_Leave;
            // 
            // consumeTB
            // 
            consumeTB.Location = new Point(271, 105);
            consumeTB.Margin = new Padding(3, 4, 3, 4);
            consumeTB.Name = "consumeTB";
            consumeTB.Size = new Size(124, 27);
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
            clearBtn.Location = new Point(271, 154);
            clearBtn.Margin = new Padding(0);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(128, 50);
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
            calcBtn.Location = new Point(31, 154);
            calcBtn.Margin = new Padding(0);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(128, 50);
            calcBtn.TabIndex = 8;
            calcBtn.Text = "РАССЧИТАТЬ";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.MouseDown += calcBtn_MouseDown;
            // 
            // distanceTB
            // 
            distanceTB.Location = new Point(31, 105);
            distanceTB.Margin = new Padding(3, 4, 3, 4);
            distanceTB.Name = "distanceTB";
            distanceTB.Size = new Size(124, 27);
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
            closeLabel.Location = new Point(766, 0);
            closeLabel.Margin = new Padding(0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(35, 44);
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
            priceLabel.Location = new Point(576, 51);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(195, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Стоимость 1л топлива, грн";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consumeLabel
            // 
            consumeLabel.AutoSize = true;
            consumeLabel.Location = new Point(250, 51);
            consumeLabel.Margin = new Padding(0);
            consumeLabel.Name = "consumeLabel";
            consumeLabel.Size = new Size(179, 20);
            consumeLabel.TabIndex = 2;
            consumeLabel.Text = "Расход толива на 100 км";
            consumeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new Point(12, 51);
            distanceLabel.Margin = new Padding(0);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(174, 20);
            distanceLabel.TabIndex = 1;
            distanceLabel.Text = "Расстояние поездки, км";
            distanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(255, 204, 136);
            bottomPanel.Controls.Add(resultcalc_infoLabel);
            bottomPanel.Location = new Point(0, 266);
            bottomPanel.Margin = new Padding(3, 4, 3, 4);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(801, 66);
            bottomPanel.TabIndex = 1;
            // 
            // resultcalc_infoLabel
            // 
            resultcalc_infoLabel.AutoSize = true;
            resultcalc_infoLabel.Location = new Point(28, 20);
            resultcalc_infoLabel.Margin = new Padding(0);
            resultcalc_infoLabel.Name = "resultcalc_infoLabel";
            resultcalc_infoLabel.Size = new Size(139, 20);
            resultcalc_infoLabel.TabIndex = 0;
            resultcalc_infoLabel.Text = "resultcalc_infoLabel";
            resultcalc_infoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultcalcLabel
            // 
            resultcalcLabel.AutoSize = true;
            resultcalcLabel.Location = new Point(12, 231);
            resultcalcLabel.Margin = new Padding(0);
            resultcalcLabel.Name = "resultcalcLabel";
            resultcalcLabel.Size = new Size(144, 20);
            resultcalcLabel.TabIndex = 2;
            resultcalcLabel.Text = "Результаты расчёта";
            resultcalcLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FuelCalc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 330);
            Controls.Add(resultcalcLabel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}

