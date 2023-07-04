namespace OnlineBookStore.Admin
{
    partial class BookInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_author_name = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.lbl_book_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_book_name.Location = new System.Drawing.Point(12, 24);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(209, 29);
            this.lbl_book_name.TabIndex = 0;
            this.lbl_book_name.Text = "Book Name here";
            // 
            // lbl_author_name
            // 
            this.lbl_author_name.AutoSize = true;
            this.lbl_author_name.Location = new System.Drawing.Point(22, 60);
            this.lbl_author_name.Name = "lbl_author_name";
            this.lbl_author_name.Size = new System.Drawing.Size(139, 20);
            this.lbl_author_name.TabIndex = 1;
            this.lbl_author_name.Text = "Author Name here";
            // 
            // btn_buy
            // 
            this.btn_buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(3, 146);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(264, 35);
            this.btn_buy.TabIndex = 2;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(3, 187);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(264, 35);
            this.btn_addToCart.TabIndex = 3;
            this.btn_addToCart.Text = "Add to Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // lbl_book_price
            // 
            this.lbl_book_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_book_price.AutoSize = true;
            this.lbl_book_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_book_price.Location = new System.Drawing.Point(106, 114);
            this.lbl_book_price.Name = "lbl_book_price";
            this.lbl_book_price.Size = new System.Drawing.Size(55, 29);
            this.lbl_book_price.TabIndex = 4;
            this.lbl_book_price.Text = "500";
            // 
            // BookInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.lbl_book_price);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_author_name);
            this.Controls.Add(this.lbl_book_name);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "BookInfo";
            this.Size = new System.Drawing.Size(270, 225);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_author_name;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Label lbl_book_price;
    }
}
