namespace QuizApp
{
    partial class Form2
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblPrev = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBasla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(98, 200);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(166, 55);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(456, 200);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(166, 55);
            this.btnB.TabIndex = 2;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(98, 276);
            this.btnC.Name = "btnC";
            this.btnC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnC.Size = new System.Drawing.Size(166, 55);
            this.btnC.TabIndex = 3;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(456, 276);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(166, 55);
            this.btnD.TabIndex = 4;
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(98, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 107);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(571, 374);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(29, 13);
            this.lblNext.TabIndex = 6;
            this.lblNext.Text = "Next";
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.Location = new System.Drawing.Point(98, 374);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(29, 13);
            this.lblPrev.TabIndex = 7;
            this.lblPrev.Text = "Prev";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(589, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sec";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBasla
            // 
            this.lblBasla.AutoSize = true;
            this.lblBasla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBasla.Location = new System.Drawing.Point(644, 13);
            this.lblBasla.Name = "lblBasla";
            this.lblBasla.Size = new System.Drawing.Size(33, 13);
            this.lblBasla.TabIndex = 11;
            this.lblBasla.Text = "Basla";
            this.lblBasla.Click += new System.EventHandler(this.lblBasla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBasla;
    }
}