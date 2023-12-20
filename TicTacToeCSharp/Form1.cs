using System.Security.Cryptography;

namespace TicTacToeCSharp
{
    public partial class Form1 : Form
    {
        private bool _isCircle = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;

            SetText((Button)sender);
        }

        private void SetText(Button btn)
        {
            btn.Text = _isCircle ? "O" : "X";
            _isCircle = !_isCircle;
            btn.Enabled = false;
        }
    }
}