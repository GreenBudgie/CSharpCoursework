
namespace Coursework
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graphPanel = new System.Windows.Forms.Panel();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.epsSelector = new System.Windows.Forms.TrackBar();
            this.aInput = new System.Windows.Forms.NumericUpDown();
            this.bInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.epsLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.graphPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graphPanel.Location = new System.Drawing.Point(392, 17);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(593, 586);
            this.graphPanel.TabIndex = 0;
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(12, 40);
            this.functionInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.functionInput.MaxLength = 128;
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(292, 28);
            this.functionInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Функция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интервал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Точность (Eps)";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 267);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(144, 46);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти корень";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // epsSelector
            // 
            this.epsSelector.Location = new System.Drawing.Point(160, 211);
            this.epsSelector.Maximum = 5;
            this.epsSelector.Minimum = 1;
            this.epsSelector.Name = "epsSelector";
            this.epsSelector.Size = new System.Drawing.Size(144, 56);
            this.epsSelector.TabIndex = 4;
            this.epsSelector.Value = 1;
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(47, 130);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(107, 28);
            this.aInput.TabIndex = 2;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(197, 130);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(107, 28);
            this.bInput.TabIndex = 3;
            this.bInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Вывод:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(262, 339);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 35);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // epsLabel
            // 
            this.epsLabel.AutoSize = true;
            this.epsLabel.Location = new System.Drawing.Point(193, 243);
            this.epsLabel.Name = "epsLabel";
            this.epsLabel.Size = new System.Drawing.Size(75, 24);
            this.epsLabel.TabIndex = 13;
            this.epsLabel.Text = "0.00001";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 380);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(367, 223);
            this.outputBox.TabIndex = 14;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.epsLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.epsSelector);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.functionInput);
            this.Controls.Add(this.graphPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Вычисление корня функции";
            ((System.ComponentModel.ISupportInitialize)(this.epsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.TextBox functionInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TrackBar epsSelector;
        private System.Windows.Forms.NumericUpDown aInput;
        private System.Windows.Forms.NumericUpDown bInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label epsLabel;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

