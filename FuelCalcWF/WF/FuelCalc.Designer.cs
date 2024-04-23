using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    partial class FuelCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.topPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.consumeTB = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.distanceTB = new System.Windows.Forms.TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.consumeLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.resultcalc_infoLabel = new System.Windows.Forms.Label();
            this.resultcalcLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.topPanel.Controls.Add(this.saveBtn);
            this.topPanel.Controls.Add(this.priceTB);
            this.topPanel.Controls.Add(this.consumeTB);
            this.topPanel.Controls.Add(this.clearBtn);
            this.topPanel.Controls.Add(this.calcBtn);
            this.topPanel.Controls.Add(this.distanceTB);
            this.topPanel.Controls.Add(this.closeLabel);
            this.topPanel.Controls.Add(this.priceLabel);
            this.topPanel.Controls.Add(this.consumeLabel);
            this.topPanel.Controls.Add(this.distanceLabel);
            this.topPanel.Location = new System.Drawing.Point(0, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(801, 173);
            this.topPanel.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(598, 123);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 40);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "СОХРАНИТЬ";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(598, 84);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(124, 22);
            this.priceTB.TabIndex = 7;
            this.priceTB.Leave += new System.EventHandler(this.priceTB_Leave);
            // 
            // consumeTB
            // 
            this.consumeTB.Location = new System.Drawing.Point(271, 84);
            this.consumeTB.Name = "consumeTB";
            this.consumeTB.Size = new System.Drawing.Size(124, 22);
            this.consumeTB.TabIndex = 6;
            this.consumeTB.Leave += new System.EventHandler(this.consumeTB_Leave);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.Color.Blue;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(271, 123);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 40);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "ОЧИСТИТЬ";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearBtn_MouseDown);
            // 
            // calcBtn
            // 
            this.calcBtn.AutoSize = true;
            this.calcBtn.BackColor = System.Drawing.Color.Black;
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calcBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBtn.ForeColor = System.Drawing.Color.White;
            this.calcBtn.Location = new System.Drawing.Point(31, 123);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(128, 40);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "РАССЧИТАТЬ";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calcBtn_MouseDown);
            // 
            // distanceTB
            // 
            this.distanceTB.Location = new System.Drawing.Point(31, 84);
            this.distanceTB.Name = "distanceTB";
            this.distanceTB.Size = new System.Drawing.Size(124, 22);
            this.distanceTB.TabIndex = 5;
            this.distanceTB.Leave += new System.EventHandler(this.distanceTB_Leave);
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(766, 0);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(35, 35);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click_1);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(576, 41);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(181, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Стоимость 1л топлива, грн";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumeLabel
            // 
            this.consumeLabel.AutoSize = true;
            this.consumeLabel.Location = new System.Drawing.Point(250, 41);
            this.consumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.consumeLabel.Name = "consumeLabel";
            this.consumeLabel.Size = new System.Drawing.Size(165, 16);
            this.consumeLabel.TabIndex = 2;
            this.consumeLabel.Text = "Расход толива на 100 км";
            this.consumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(12, 41);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(164, 16);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Расстояние поездки, км";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.bottomPanel.Controls.Add(this.resultcalc_infoLabel);
            this.bottomPanel.Location = new System.Drawing.Point(0, 213);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(801, 53);
            this.bottomPanel.TabIndex = 1;
            // 
            // resultcalc_infoLabel
            // 
            this.resultcalc_infoLabel.AutoSize = true;
            this.resultcalc_infoLabel.Location = new System.Drawing.Point(28, 16);
            this.resultcalc_infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resultcalc_infoLabel.Name = "resultcalc_infoLabel";
            this.resultcalc_infoLabel.Size = new System.Drawing.Size(126, 16);
            this.resultcalc_infoLabel.TabIndex = 0;
            this.resultcalc_infoLabel.Text = "resultcalc_infoLabel";
            this.resultcalc_infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultcalcLabel
            // 
            this.resultcalcLabel.AutoSize = true;
            this.resultcalcLabel.Location = new System.Drawing.Point(12, 185);
            this.resultcalcLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resultcalcLabel.Name = "resultcalcLabel";
            this.resultcalcLabel.Size = new System.Drawing.Size(143, 16);
            this.resultcalcLabel.TabIndex = 2;
            this.resultcalcLabel.Text = "Результаты расчёта";
            this.resultcalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FuelCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.resultcalcLabel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FuelCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Calculation";
            this.Load += new System.EventHandler(this.FuelCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FuelCalc_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FuelCalc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FuelCalc_MouseMove);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

