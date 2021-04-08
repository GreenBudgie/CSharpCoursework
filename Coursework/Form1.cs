using System;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {

        Logger logger;
        double epsilon;

        public Form1()
        {
            InitializeComponent();
            logger = new Logger(outputBox);
            try
            {
                StringFunction func = new StringFunction("Ln(Sin(x)) + 1");
                double result = RootFinder.FindRoot(1, 3, 0.001, func.AsFunction());
                //MessageBox.Show(result.ToString());
            } catch(Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        public double GetEpsilon(int input)
        {
            switch(input)
            {
                case 5: return 0.00001;
                case 4: return 0.0001;
                case 3: return 0.001;
                case 2: return 0.01;
                case 1: return 0.1;
            }
            throw new ArgumentException("Invalid epsilon input");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logger.Clear();
        }

        private void epsSelector_Scroll(object sender, EventArgs e)
        {
            UpdateEpsilonValue();
        }

        private void UpdateEpsilonValue()
        {
            epsilon = GetEpsilon(epsSelector.Value);
            epsLabel.Text = ((decimal)epsilon).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEpsilonValue();
        }
    }
}
