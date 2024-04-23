namespace WF.Views.UserControls
{
    partial class BtnChangeTheme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pcBxTheme = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcBxTheme).BeginInit();
            SuspendLayout();
            // 
            // pcBxTheme
            // 
            pcBxTheme.BackColor = Color.FromArgb(0, 102, 204);
            pcBxTheme.Location = new Point(5, 5);
            pcBxTheme.Name = "pcBxTheme";
            pcBxTheme.Size = new Size(20, 20);
            pcBxTheme.TabIndex = 0;
            pcBxTheme.TabStop = false;
            // 
            // BtnChangeTheme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 229, 255);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pcBxTheme);
            Margin = new Padding(0);
            Name = "BtnChangeTheme";
            Size = new Size(90, 30);
            Click += BtnChangeTheme_Click;
            ((System.ComponentModel.ISupportInitialize)pcBxTheme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcBxTheme;
    }
}
