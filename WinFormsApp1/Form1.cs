namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region Example of use

        #endregion
        public Form1()
        {
            InitializeComponent();
            Size=new Size(500, 500);

            StateButton b = new StateButton();
            b.StateChanged += (sender, e) => this.Text = b.IsActive.ToString();

            this.Controls.Add( b); 
        }
    }
}