namespace QuizApp
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxToplam = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.tbxFenn = new System.Windows.Forms.TextBox();
            this.lblFenn = new System.Windows.Forms.Label();
            this.btnaddsual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxFenntipi = new System.Windows.Forms.TextBox();
            this.lblTipi = new System.Windows.Forms.Label();
            this.tbxDuzCavab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.tbxSual = new System.Windows.Forms.TextBox();
            this.lblSual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxFenntipi);
            this.panel1.Controls.Add(this.lblTipi);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbxDuzCavab);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxD);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Controls.Add(this.lblSual);
            this.panel1.Controls.Add(this.tbxC);
            this.panel1.Controls.Add(this.tbxSual);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.tbxB);
            this.panel1.Controls.Add(this.tbxA);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 354);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbxToplam
            // 
            this.tbxToplam.Location = new System.Drawing.Point(255, 122);
            this.tbxToplam.Name = "tbxToplam";
            this.tbxToplam.Size = new System.Drawing.Size(100, 20);
            this.tbxToplam.TabIndex = 22;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(129, 122);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(60, 13);
            this.lblToplam.TabIndex = 21;
            this.lblToplam.Text = "Toplam Bal";
            // 
            // tbxFenn
            // 
            this.tbxFenn.Location = new System.Drawing.Point(255, 96);
            this.tbxFenn.Name = "tbxFenn";
            this.tbxFenn.Size = new System.Drawing.Size(100, 20);
            this.tbxFenn.TabIndex = 20;
            // 
            // lblFenn
            // 
            this.lblFenn.AutoSize = true;
            this.lblFenn.Location = new System.Drawing.Point(129, 96);
            this.lblFenn.Name = "lblFenn";
            this.lblFenn.Size = new System.Drawing.Size(49, 13);
            this.lblFenn.TabIndex = 19;
            this.lblFenn.Text = "Fenn Adi";
            // 
            // btnaddsual
            // 
            this.btnaddsual.Location = new System.Drawing.Point(181, 169);
            this.btnaddsual.Name = "btnaddsual";
            this.btnaddsual.Size = new System.Drawing.Size(122, 23);
            this.btnaddsual.TabIndex = 18;
            this.btnaddsual.Text = "Add Sual Tipi";
            this.btnaddsual.UseVisualStyleBackColor = true;
            this.btnaddsual.Click += new System.EventHandler(this.btnaddsual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Istediyiniz Fennin adini ve balini qeyd edin.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnaddsual);
            this.panel2.Controls.Add(this.lblFenn);
            this.panel2.Controls.Add(this.tbxToplam);
            this.panel2.Controls.Add(this.tbxFenn);
            this.panel2.Controls.Add(this.lblToplam);
            this.panel2.Location = new System.Drawing.Point(687, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 354);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbxFenntipi
            // 
            this.tbxFenntipi.Location = new System.Drawing.Point(293, 228);
            this.tbxFenntipi.Name = "tbxFenntipi";
            this.tbxFenntipi.Size = new System.Drawing.Size(100, 20);
            this.tbxFenntipi.TabIndex = 33;
            // 
            // lblTipi
            // 
            this.lblTipi.AutoSize = true;
            this.lblTipi.Location = new System.Drawing.Point(177, 235);
            this.lblTipi.Name = "lblTipi";
            this.lblTipi.Size = new System.Drawing.Size(48, 13);
            this.lblTipi.TabIndex = 32;
            this.lblTipi.Text = "FennTipi";
            // 
            // tbxDuzCavab
            // 
            this.tbxDuzCavab.Location = new System.Drawing.Point(293, 194);
            this.tbxDuzCavab.Name = "tbxDuzCavab";
            this.tbxDuzCavab.Size = new System.Drawing.Size(100, 20);
            this.tbxDuzCavab.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "DuzgunCavab";
            // 
            // tbxD
            // 
            this.tbxD.Location = new System.Drawing.Point(453, 146);
            this.tbxD.Name = "tbxD";
            this.tbxD.Size = new System.Drawing.Size(100, 20);
            this.tbxD.TabIndex = 29;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(410, 149);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(15, 13);
            this.lblD.TabIndex = 28;
            this.lblD.Text = "D";
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(180, 142);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 20);
            this.tbxC.TabIndex = 27;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(144, 149);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 26;
            this.lblC.Text = "C";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(453, 97);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 25;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(411, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 24;
            this.lblB.Text = "B";
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(180, 97);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 23;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(144, 97);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 22;
            this.lblA.Text = "A";
            // 
            // tbxSual
            // 
            this.tbxSual.Location = new System.Drawing.Point(147, 25);
            this.tbxSual.Multiline = true;
            this.tbxSual.Name = "tbxSual";
            this.tbxSual.Size = new System.Drawing.Size(406, 49);
            this.tbxSual.TabIndex = 21;
            // 
            // lblSual
            // 
            this.lblSual.AutoSize = true;
            this.lblSual.Location = new System.Drawing.Point(54, 25);
            this.lblSual.Name = "lblSual";
            this.lblSual.Size = new System.Drawing.Size(28, 13);
            this.lblSual.TabIndex = 20;
            this.lblSual.Text = "Sual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox tbxFenn;
        private System.Windows.Forms.Label lblFenn;
        private System.Windows.Forms.Button btnaddsual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxFenntipi;
        private System.Windows.Forms.Label lblTipi;
        private System.Windows.Forms.TextBox tbxDuzCavab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox tbxSual;
        private System.Windows.Forms.Label lblSual;
    }
}

