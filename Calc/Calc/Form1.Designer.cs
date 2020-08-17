namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.Nol = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Pov = new System.Windows.Forms.Button();
            this.Minnus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.ChangeSys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(424, 22);
            this.Input.TabIndex = 0;
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(353, 37);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(16, 17);
            this.Output.TabIndex = 1;
            this.Output.Text = "0";
            // 
            // Nol
            // 
            this.Nol.BackColor = System.Drawing.SystemColors.Highlight;
            this.Nol.Location = new System.Drawing.Point(98, 302);
            this.Nol.Name = "Nol";
            this.Nol.Size = new System.Drawing.Size(166, 67);
            this.Nol.TabIndex = 2;
            this.Nol.Text = "0";
            this.Nol.UseVisualStyleBackColor = false;
            this.Nol.Click += new System.EventHandler(this.Nol_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.SystemColors.Highlight;
            this.One.Location = new System.Drawing.Point(12, 231);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(80, 67);
            this.One.TabIndex = 3;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.SystemColors.Highlight;
            this.Nine.Location = new System.Drawing.Point(184, 85);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(80, 67);
            this.Nine.TabIndex = 4;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.SystemColors.Highlight;
            this.Eight.Location = new System.Drawing.Point(98, 85);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(80, 67);
            this.Eight.TabIndex = 5;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.SystemColors.Highlight;
            this.Seven.Location = new System.Drawing.Point(12, 85);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(80, 67);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.SystemColors.Highlight;
            this.Six.Location = new System.Drawing.Point(184, 158);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(80, 67);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.SystemColors.Highlight;
            this.Five.Location = new System.Drawing.Point(98, 158);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(80, 67);
            this.Five.TabIndex = 8;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.SystemColors.Highlight;
            this.Four.Location = new System.Drawing.Point(12, 158);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(80, 67);
            this.Four.TabIndex = 9;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.SystemColors.Highlight;
            this.Three.Location = new System.Drawing.Point(184, 231);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(80, 67);
            this.Three.TabIndex = 10;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.SystemColors.Highlight;
            this.Two.Location = new System.Drawing.Point(98, 231);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(80, 67);
            this.Two.TabIndex = 11;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.SystemColors.Highlight;
            this.Dot.Location = new System.Drawing.Point(12, 302);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(80, 67);
            this.Dot.TabIndex = 12;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.Clear.ForeColor = System.Drawing.Color.Red;
            this.Clear.Location = new System.Drawing.Point(356, 85);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 67);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.GrayText;
            this.Div.Location = new System.Drawing.Point(356, 158);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(80, 67);
            this.Div.TabIndex = 14;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.SystemColors.GrayText;
            this.Mult.Location = new System.Drawing.Point(356, 231);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(80, 67);
            this.Mult.TabIndex = 15;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GrayText;
            this.button14.Location = new System.Drawing.Point(270, 302);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(166, 67);
            this.button14.TabIndex = 16;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Pov
            // 
            this.Pov.BackColor = System.Drawing.SystemColors.GrayText;
            this.Pov.Location = new System.Drawing.Point(270, 85);
            this.Pov.Name = "Pov";
            this.Pov.Size = new System.Drawing.Size(80, 67);
            this.Pov.TabIndex = 17;
            this.Pov.Text = "^";
            this.Pov.UseVisualStyleBackColor = false;
            this.Pov.Click += new System.EventHandler(this.Pov_Click);
            // 
            // Minnus
            // 
            this.Minnus.BackColor = System.Drawing.SystemColors.GrayText;
            this.Minnus.Location = new System.Drawing.Point(270, 158);
            this.Minnus.Name = "Minnus";
            this.Minnus.Size = new System.Drawing.Size(80, 67);
            this.Minnus.TabIndex = 18;
            this.Minnus.Text = "-";
            this.Minnus.UseVisualStyleBackColor = false;
            this.Minnus.Click += new System.EventHandler(this.Minnus_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.GrayText;
            this.Plus.Location = new System.Drawing.Point(270, 231);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(80, 67);
            this.Plus.TabIndex = 19;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // ChangeSys
            // 
            this.ChangeSys.Location = new System.Drawing.Point(12, 49);
            this.ChangeSys.Name = "ChangeSys";
            this.ChangeSys.Size = new System.Drawing.Size(79, 27);
            this.ChangeSys.TabIndex = 20;
            this.ChangeSys.Text = "E/A";
            this.ChangeSys.UseVisualStyleBackColor = true;
            this.ChangeSys.Click += new System.EventHandler(this.ChangeSys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.ChangeSys);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minnus);
            this.Controls.Add(this.Pov);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Nol);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button Nol;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button Pov;
        private System.Windows.Forms.Button Minnus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button ChangeSys;
    }
}

