using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Views.UserControls
{
    public partial class BtnChangeTheme : UserControl
    {
        public delegate void ThemeHandler();
        public event ThemeHandler? themeColor;
        public bool isChanded { get; private set; } = true;
        public BtnChangeTheme()
        {
            InitializeComponent();
        }

        private void BtnChangeTheme_Click(object sender, EventArgs e)
        {
            isChanded = !isChanded;
            pcBxTheme.Location = (isChanded == true ? new Point (5, 5) : new Point(Width - pcBxTheme.Width - 5, 5));

            themeColor?.Invoke();
        }
    }
}
