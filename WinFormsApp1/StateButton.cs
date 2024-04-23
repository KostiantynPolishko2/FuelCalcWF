using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StateButton : UserControl
    {
        /// <summary>
        ///     state of component 
        ///     boolean
        /// </summary>
        public bool IsActive { get; set; } = false;
        /// <summary>
        ///    event for change of IsActive
        ///     call in 40 row of code
        /// </summary>

        public event Action<object , EventArgs> StateChanged;

        public StateButton()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            IsActive = !IsActive;

            BackColor = IsActive == true ? Color.Green : Color.Red;

            panel1.Location = IsActive == true ? new Point(this.Size.Width - panel1.Size.Width, this.Size.Height - (int)(panel1.Size.Height * 1.1)) : new Point(0, this.Size.Height - (int)(panel1.Size.Height * 1.1));

            StateChanged?.Invoke(sender, e);
        }
    }
}
