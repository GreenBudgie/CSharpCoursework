using Antlr.Runtime;
using System;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {

        Logger logger;
        public double Epsilon { get; set; }
        GraphDrawer graphDrawer = null;

        public Form1()
        {
            InitializeComponent();
            logger = new Logger(outputBox);
            graphPanel.Refresh();
        }

        private double GetEpsilon(int input)
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
            Epsilon = GetEpsilon(epsSelector.Value);
            epsLabel.Text = ((decimal)Epsilon).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEpsilonValue();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                string function = functionInput.Text.Trim();
                double intervalA = (double) aInput.Value;
                double intervalB = (double) bInput.Value;
                StringFunction func = new StringFunction(function);
                decimal result = RootFinder.FindRoot(intervalA, intervalB, Epsilon, func.AsFunction());
                decimal roundedResult = decimal.Round(result, Epsilon.ToString().Length - 1);
                logger.Info("Корень: " + roundedResult);
            } catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void tryRedraw()
        {
            if (updateGraphCheckbox.Checked)
            {
                if (updateGraphDrawer())
                {
                    graphPanel.Refresh();
                }
            }
        }

        private bool updateGraphDrawer()
        {
            string function = functionInput.Text.Trim();
            try
            {
                graphDrawer.Function = new StringFunction(function).AsFunction();
                graphDrawer.SetInterval((double)aInput.Value, (double)bInput.Value);
            }
            catch (Exception) 
            {
                return false;
            }
            return true;
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            if (graphDrawer == null) graphDrawer = new GraphDrawer((Panel)sender);
            graphDrawer.Redraw(e.Graphics);
        }

        private void functionInput_TextChanged(object sender, EventArgs e)
        {
            tryRedraw();
        }

        private void aInput_ValueChanged(object sender, EventArgs e)
        {
            tryRedraw();
        }

        private void bInput_ValueChanged(object sender, EventArgs e)
        {
            tryRedraw();
        }

        private void updateGraphCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            tryRedraw();
        }
    }
}
