using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coursework
{
    class Logger
    {

        readonly RichTextBox output;
        private readonly string PREFIX = "> ";

        public Logger(RichTextBox outputBox)
        {
            output = outputBox;
        }

        public void Error(string text)
        {
            StartPrint();
                Print("Ошибка: ", Color.Red);
                Print(text);
            EndPrint();
        }

        public void Info(string text)
        {
            StartPrint().
                Print(text).
            EndPrint();
        }

        public void Clear()
        {
            output.Clear();
        }

        public Logger StartPrint()
        {
            Print(PREFIX, Color.Gray);
            return this;
        }

        public void EndPrint()
        {
            output.AppendText(Environment.NewLine);
        }

        public Logger Print(string text, Color color)
        {
            output.SelectionStart = output.TextLength;
            output.SelectionLength = 0;
            output.SelectionColor = color;
            output.AppendText(text);
            output.SelectionColor = output.ForeColor;
            return this;
        }

        public Logger Print(string text, Font font)
        {
            output.SelectionStart = output.TextLength;
            output.SelectionLength = 0;
            output.SelectionFont = font;
            output.AppendText(text);
            output.SelectionColor = output.ForeColor;
            return this;
        }

        public Logger Print(string text)
        {
            output.AppendText(text);
            return this;
        }

    }
}
