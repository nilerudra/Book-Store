namespace OnlineBookStore
{
    partial class New_user
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_mail = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.conform_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OnlineBookStore.Properties.Resources.WhatsApp_Image_2022_05_18_at_2_57_17_PM;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(318, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATE ACCOUNT.";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // user_mail
            // 
            this.user_mail.BackColor = System.Drawing.Color.LemonChiffon;
            this.user_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_mail.ForeColor = System.Drawing.Color.Silver;
            this.user_mail.Location = new System.Drawing.Point(551, 299);
            this.user_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_mail.Multiline = true;
            this.user_mail.Name = "user_mail";
            this.user_mail.Size = new System.Drawing.Size(424, 48);
            this.user_mail.TabIndex = 6;
            this.user_mail.Text = "Enter User ID";
            this.user_mail.TextChanged += new System.EventHandler(this.user_mail_TextChanged);
            this.user_mail.Enter += new System.EventHandler(this.user_mail_Enter);
            this.user_mail.Leave += new System.EventHandler(this.user_mail_Leave);
            // 
            // user_pass
            // 
            this.user_pass.BackColor = System.Drawing.Color.LemonChiffon;
            this.user_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.ForeColor = System.Drawing.Color.Silver;
            this.user_pass.Location = new System.Drawing.Point(551, 371);
            this.user_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_pass.Multiline = true;
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(424, 48);
            this.user_pass.TabIndex = 9;
            this.user_pass.Text = "Password";
            this.user_pass.TextChanged += new System.EventHandler(this.user_pass_TextChanged);
            this.user_pass.Enter += new System.EventHandler(this.user_pass_Enter);
            this.user_pass.Leave += new System.EventHandler(this.user_pass_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::OnlineBookStore.Properties.Resources.WhatsApp_Image_2022_05_18_at_2_57_17_PM;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 726);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conform_pass
            // 
            this.conform_pass.BackColor = System.Drawing.Color.LemonChiffon;
            this.conform_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conform_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conform_pass.ForeColor = System.Drawing.Color.Silver;
            this.conform_pass.Location = new System.Drawing.Point(551, 444);
            this.conform_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conform_pass.Multiline = true;
            this.conform_pass.Name = "conform_pass";
            this.conform_pass.Size = new System.Drawing.Size(424, 48);
            this.conform_pass.TabIndex = 13;
            this.conform_pass.Text = "Conform Password";
            this.conform_pass.Enter += new System.EventHandler(this.textBox1_Enter);
            this.conform_pass.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Conform Password :";
            // 
            // New_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::OnlineBookStore.Properties.Resources.WhatsApp_Image_2022_05_18_at_2_57_17_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1699, 1006);
            this.Controls.Add(this.conform_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_user";
            this.Text = "New_user";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.New_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_mail;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox conform_pass;
        private System.Windows.Forms.Label label4;
    }
}