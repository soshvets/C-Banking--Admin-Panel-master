namespace Banking_adm_pn
{
    partial class depositForm
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
            this.acctxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.depamounttxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detailsbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date:";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(356, 36);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 17);
            this.datelbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Old Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deposit Amount";
            // 
            // acctxt
            // 
            this.acctxt.Location = new System.Drawing.Point(185, 82);
            this.acctxt.Name = "acctxt";
            this.acctxt.Size = new System.Drawing.Size(243, 22);
            this.acctxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(185, 140);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(243, 22);
            this.nametxt.TabIndex = 8;
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(185, 207);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(243, 22);
            this.balancetxt.TabIndex = 9;
            // 
            // depamounttxt
            // 
            this.depamounttxt.Location = new System.Drawing.Point(185, 346);
            this.depamounttxt.Name = "depamounttxt";
            this.depamounttxt.Size = new System.Drawing.Size(243, 22);
            this.depamounttxt.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // detailsbutton
            // 
            this.detailsbutton.Location = new System.Drawing.Point(518, 82);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(160, 37);
            this.detailsbutton.TabIndex = 12;
            this.detailsbutton.Text = "Get Details";
            this.detailsbutton.UseVisualStyleBackColor = true;
            this.detailsbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.detailsbutton_Click);
            // 
            // depositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailsbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.depamounttxt);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.acctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label1);
            this.Name = "depositForm";
            this.Text = "depositForm";
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
        private System.Windows.Forms.TextBox acctxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.TextBox depamounttxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button detailsbutton;
        private System.Windows.Forms.Button button1;
    }
}