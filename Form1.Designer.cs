
namespace Collins_FibonacciSeries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Explaination_label = new System.Windows.Forms.Label();
            this.numberN_label = new System.Windows.Forms.Label();
            this.NumberN_textbox = new System.Windows.Forms.TextBox();
            this.Answer_label = new System.Windows.Forms.Label();
            this.Answer_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fibonacci Series Calculator";
            // 
            // Calculate_button
            // 
            this.Calculate_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Calculate_button.Location = new System.Drawing.Point(679, 328);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(150, 73);
            this.Calculate_button.TabIndex = 1;
            this.Calculate_button.Text = "Calculate!";
            this.Calculate_button.UseVisualStyleBackColor = false;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Explaination_label
            // 
            this.Explaination_label.AutoSize = true;
            this.Explaination_label.BackColor = System.Drawing.Color.Transparent;
            this.Explaination_label.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Explaination_label.Location = new System.Drawing.Point(98, 102);
            this.Explaination_label.Name = "Explaination_label";
            this.Explaination_label.Size = new System.Drawing.Size(299, 172);
            this.Explaination_label.TabIndex = 2;
            this.Explaination_label.Text = "Enter a number of \r\nseries you would \r\nlike to be \r\ncalculated!\r\n";
            // 
            // numberN_label
            // 
            this.numberN_label.AutoSize = true;
            this.numberN_label.BackColor = System.Drawing.Color.Transparent;
            this.numberN_label.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberN_label.Location = new System.Drawing.Point(505, 267);
            this.numberN_label.Name = "numberN_label";
            this.numberN_label.Size = new System.Drawing.Size(225, 32);
            this.numberN_label.TabIndex = 3;
            this.numberN_label.Text = "Number of Series:";
            // 
            // NumberN_textbox
            // 
            this.NumberN_textbox.Location = new System.Drawing.Point(736, 264);
            this.NumberN_textbox.Name = "NumberN_textbox";
            this.NumberN_textbox.Size = new System.Drawing.Size(93, 39);
            this.NumberN_textbox.TabIndex = 4;
            this.NumberN_textbox.TextChanged += new System.EventHandler(this.NumberN_textbox_TextChanged);
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.BackColor = System.Drawing.Color.Transparent;
            this.Answer_label.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Answer_label.Location = new System.Drawing.Point(234, 428);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(207, 32);
            this.Answer_label.TabIndex = 5;
            this.Answer_label.Text = "Fibonacci Series:";
            this.Answer_label.Visible = false;
            // 
            // Answer_textbox
            // 
            this.Answer_textbox.Location = new System.Drawing.Point(448, 428);
            this.Answer_textbox.Multiline = true;
            this.Answer_textbox.Name = "Answer_textbox";
            this.Answer_textbox.Size = new System.Drawing.Size(381, 86);
            this.Answer_textbox.TabIndex = 6;
            this.Answer_textbox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(679, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 848);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer_textbox);
            this.Controls.Add(this.Answer_label);
            this.Controls.Add(this.NumberN_textbox);
            this.Controls.Add(this.numberN_label);
            this.Controls.Add(this.Explaination_label);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Label Explaination_label;
        private System.Windows.Forms.Label numberN_label;
        private System.Windows.Forms.TextBox NumberN_textbox;
        private System.Windows.Forms.Label Answer_label;
        private System.Windows.Forms.TextBox Answer_textbox;
        private System.Windows.Forms.Button button1;
    }
}

