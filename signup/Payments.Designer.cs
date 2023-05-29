
namespace signup
{
    partial class Payments
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
            this.holdername_label = new System.Windows.Forms.Label();
            this.holdername_text = new System.Windows.Forms.TextBox();
            this.cardNum_text = new System.Windows.Forms.TextBox();
            this.cvv_text = new System.Windows.Forms.TextBox();
            this.cardNum_label = new System.Windows.Forms.Label();
            this.expireDate_label = new System.Windows.Forms.Label();
            this.cvv_label = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.expDate_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // holdername_label
            // 
            this.holdername_label.AutoSize = true;
            this.holdername_label.BackColor = System.Drawing.Color.Transparent;
            this.holdername_label.Location = new System.Drawing.Point(200, 169);
            this.holdername_label.Name = "holdername_label";
            this.holdername_label.Size = new System.Drawing.Size(127, 17);
            this.holdername_label.TabIndex = 1;
            this.holdername_label.Text = "Cardholder Name: ";
            // 
            // holdername_text
            // 
            this.holdername_text.Location = new System.Drawing.Point(331, 169);
            this.holdername_text.Name = "holdername_text";
            this.holdername_text.Size = new System.Drawing.Size(176, 22);
            this.holdername_text.TabIndex = 5;
            // 
            // cardNum_text
            // 
            this.cardNum_text.Location = new System.Drawing.Point(331, 213);
            this.cardNum_text.Name = "cardNum_text";
            this.cardNum_text.Size = new System.Drawing.Size(176, 22);
            this.cardNum_text.TabIndex = 6;
            // 
            // cvv_text
            // 
            this.cvv_text.Location = new System.Drawing.Point(331, 295);
            this.cvv_text.Name = "cvv_text";
            this.cvv_text.Size = new System.Drawing.Size(176, 22);
            this.cvv_text.TabIndex = 8;
            // 
            // cardNum_label
            // 
            this.cardNum_label.AutoSize = true;
            this.cardNum_label.BackColor = System.Drawing.Color.Transparent;
            this.cardNum_label.Location = new System.Drawing.Point(200, 216);
            this.cardNum_label.Name = "cardNum_label";
            this.cardNum_label.Size = new System.Drawing.Size(100, 17);
            this.cardNum_label.TabIndex = 9;
            this.cardNum_label.Text = "Card Number: ";
            // 
            // expireDate_label
            // 
            this.expireDate_label.AutoSize = true;
            this.expireDate_label.BackColor = System.Drawing.Color.Transparent;
            this.expireDate_label.Location = new System.Drawing.Point(200, 295);
            this.expireDate_label.Name = "expireDate_label";
            this.expireDate_label.Size = new System.Drawing.Size(85, 17);
            this.expireDate_label.TabIndex = 10;
            this.expireDate_label.Text = "Expire Date:";
            // 
            // cvv_label
            // 
            this.cvv_label.AutoSize = true;
            this.cvv_label.BackColor = System.Drawing.Color.Transparent;
            this.cvv_label.Location = new System.Drawing.Point(200, 258);
            this.cvv_label.Name = "cvv_label";
            this.cvv_label.Size = new System.Drawing.Size(43, 17);
            this.cvv_label.TabIndex = 11;
            this.cvv_label.Text = "CVV: ";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(331, 364);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(124, 42);
            this.Submit_btn.TabIndex = 13;
            this.Submit_btn.Text = "Checkout";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // expDate_text
            // 
            this.expDate_text.Location = new System.Drawing.Point(331, 255);
            this.expDate_text.Name = "expDate_text";
            this.expDate_text.Size = new System.Drawing.Size(176, 22);
            this.expDate_text.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "15000EGP";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(331, 135);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(176, 22);
            this.username_text.TabIndex = 18;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Location = new System.Drawing.Point(200, 135);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Name:";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::signup.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expDate_text);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.cvv_label);
            this.Controls.Add(this.expireDate_label);
            this.Controls.Add(this.cardNum_label);
            this.Controls.Add(this.cvv_text);
            this.Controls.Add(this.cardNum_text);
            this.Controls.Add(this.holdername_text);
            this.Controls.Add(this.holdername_label);
            this.Controls.Add(this.label1);
            this.Name = "Payments";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label holdername_label;
        private System.Windows.Forms.TextBox holdername_text;
        private System.Windows.Forms.TextBox cardNum_text;
        private System.Windows.Forms.TextBox cvv_text;
        private System.Windows.Forms.Label cardNum_label;
        private System.Windows.Forms.Label expireDate_label;
        private System.Windows.Forms.Label cvv_label;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox expDate_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label name_label;
    }
}