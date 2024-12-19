using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculatorApp
{
    public partial class StdCalculatorApp : Form
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        //private readonly double[] operand = [Double.MaxValue, Double.MaxValue];
        private double result = Double.MaxValue;
        private string specialOperation = "";
        public StdCalculatorApp()
        {
            InitializeComponent();
        }

        private void StdCalculatorApp_Load(object sender, EventArgs e)
        {

        }
        private enum ErrorCode
        {
            None,
            DivideByZero,
            NegativeSquareRoot
        }
        private readonly string[] errorText =
        {
            "No Error",
            "Cannot divide by zero",
            "Invalid input"
        };
                
        private const string precisionFormat = "##############0.##############";
        private bool clearFirstTime = false;
        private void MainDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(textMainDisplay.Handle);
        }

        private void ButtonNumbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //textMainDisplay.Text += button.Text;
            //MessageBox.Show($"Button {button.Text} clicked", caption: "Number clicked");
            if (textMainDisplay.Text == result.ToString(precisionFormat) && clearFirstTime == false)
            {

                clearFirstTime = true;
            }

            if (textMainDisplay.TextLength < 13 + Convert.ToInt32(textMainDisplay.Text.Contains(btnDot.Text)) + Convert.ToInt32(textMainDisplay.Text.Contains("-")))
            {
                if (textMainDisplay.Text.Equals("0"))
                {
                    textMainDisplay.Text = button.Text;
                }
                else
                {
                    textMainDisplay.Text += button.Text;
                }
            }
        }
    }
}
