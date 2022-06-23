namespace Banking_adm_pn
{
    partial class FDform1
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
            this.label1 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.rupeestxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.interesttxt = new System.Windows.Forms.TextBox();
            this.modetxt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(533, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(607, 57);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 17);
            this.datelbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rupees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Period(day)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interest(%)";
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(171, 120);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(225, 22);
            this.accnotxt.TabIndex = 7;
            // 
            // rupeestxt
            // 
            this.rupeestxt.Location = new System.Drawing.Point(171, 266);
            this.rupeestxt.Name = "rupeestxt";
            this.rupeestxt.Size = new System.Drawing.Size(225, 22);
            this.rupeestxt.TabIndex = 8;
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(171, 338);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(225, 22);
            this.periodtxt.TabIndex = 9;
            // 
            // interesttxt
            // 
            this.interesttxt.Location = new System.Drawing.Point(171, 413);
            this.interesttxt.Name = "interesttxt";
            this.interesttxt.Size = new System.Drawing.Size(225, 22);
            this.interesttxt.TabIndex = 10;
            // 
            // modetxt
            // 
            this.modetxt.FormattingEnabled = true;
            this.modetxt.Location = new System.Drawing.Point(171, 189);
            this.modetxt.Name = "modetxt";
            this.modetxt.Size = new System.Drawing.Size(225, 24);
            this.modetxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FDform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modetxt);
            this.Controls.Add(this.interesttxt);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.rupeestxt);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label1);
            this.Name = "FDform1";
            this.Text = "FDform1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.TextBox rupeestxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox interesttxt;
        private System.Windows.Forms.ComboBox modetxt;
        private System.Windows.Forms.Button button1;
    }
}