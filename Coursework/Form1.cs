using System;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            try
            {
                StringFunction func = new StringFunction("Ln(Sin(x)) + 1");
                double result = RootFinder.FindRoot(1, 3, 0.001, func.AsFunction());
                MessageBox.Show(result.ToString());
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
