namespace yazlab
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbitir = new System.Windows.Forms.Button();
            this.btnbasla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "THREADS";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(481, 124);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 13);
            this.lblsonuc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sonuç:";
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Location = new System.Drawing.Point(481, 99);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(0, 13);
            this.lblsayi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sıradaki Sayı:";
            // 
            // btnbitir
            // 
            this.btnbitir.BackColor = System.Drawing.Color.Red;
            this.btnbitir.Location = new System.Drawing.Point(453, 27);
            this.btnbitir.Name = "btnbitir";
            this.btnbitir.Size = new System.Drawing.Size(84, 33);
            this.btnbitir.TabIndex = 8;
            this.btnbitir.Text = "Bitir";
            this.btnbitir.UseVisualStyleBackColor = false;
            this.btnbitir.Click += new System.EventHandler(this.btnbitir_Click);
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.Color.Red;
            this.btnbasla.Location = new System.Drawing.Point(359, 27);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(88, 33);
            this.btnbasla.TabIndex = 7;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Araştırılan Sayı:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(359, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 68);
            this.label9.TabIndex = 19;
            this.label9.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 95);
            this.listBox1.TabIndex = 21;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(691, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(129, 199);
            this.listBox2.TabIndex = 22;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID   -   Asal Sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbitir);
            this.Controls.Add(this.btnbasla);
            this.Name = "Form1";
            this.Text = "YAZ-LAB II";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbitir;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
    }
}

