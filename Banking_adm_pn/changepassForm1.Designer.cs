namespace Banking_adm_pn
{
    partial class changepassForm1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.oldpasstxt = new System.Windows.Forms.TextBox();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.retypepasstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(249, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Old Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Retype Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(167, 123);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(230, 22);
            this.usernametxt.TabIndex = 5;
            // 
            // oldpasstxt
            // 
            this.oldpasstxt.Location = new System.Drawing.Point(167, 173);
            this.oldpasstxt.Name = "oldpasstxt";
            this.oldpasstxt.Size = new System.Drawing.Size(230, 22);
            this.oldpasstxt.TabIndex = 6;
            // 
            // newpasstxt
            // 
            this.newpasstxt.Location = new System.Drawing.Point(167, 236);
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.Size = new System.Drawing.Size(230, 22);
            this.newpasstxt.TabIndex = 7;
            // 
            // retypepasstxt
            // 
            this.retypepasstxt.Location = new System.Drawing.Point(167, 283);
            this.retypepasstxt.Name = "retypepasstxt";
            this.retypepasstxt.Size = new System.Drawing.Size(230, 22);
            this.retypepasstxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changepassForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.retypepasstxt);
            this.Controls.Add(this.newpasstxt);
            this.Controls.Add(this.oldpasstxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changepassForm1";
            this.Text = "changepassForm1";
            this.Load += new System.EventHandler(this.changepassForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox oldpasstxt;
        private System.Windows.Forms.TextBox newpasstxt;
        private System.Windows.Forms.TextBox retypepasstxt;
        private System.Windows.Forms.Button button1;
    }
}