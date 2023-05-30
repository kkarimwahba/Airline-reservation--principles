
namespace signup
{
    partial class adminhome
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.addFlights_btn = new System.Windows.Forms.Button();
            this.viewReser_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome_label.Location = new System.Drawing.Point(237, 112);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(310, 44);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome, Admin";
            // 
            // addFlights_btn
            // 
            this.addFlights_btn.Location = new System.Drawing.Point(157, 225);
            this.addFlights_btn.Name = "addFlights_btn";
            this.addFlights_btn.Size = new System.Drawing.Size(105, 45);
            this.addFlights_btn.TabIndex = 2;
            this.addFlights_btn.Text = "Add Fligths";
            this.addFlights_btn.UseVisualStyleBackColor = true;
            this.addFlights_btn.Click += new System.EventHandler(this.addFlights_btn_Click);
            // 
            // viewReser_btn
            // 
            this.viewReser_btn.Location = new System.Drawing.Point(448, 225);
            this.viewReser_btn.Name = "viewReser_btn";
            this.viewReser_btn.Size = new System.Drawing.Size(145, 45);
            this.viewReser_btn.TabIndex = 3;
            this.viewReser_btn.Text = "View Reservations";
            this.viewReser_btn.UseVisualStyleBackColor = true;
            this.viewReser_btn.Click += new System.EventHandler(this.viewReser_btn_Click);
            // 
            // adminhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::signup.Properties.Resources.WhatsApp_Image_2023_05_30_at_02_41_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewReser_btn);
            this.Controls.Add(this.addFlights_btn);
            this.Controls.Add(this.welcome_label);
            this.Name = "adminhome";
            this.Text = "adminhome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button addFlights_btn;
        private System.Windows.Forms.Button viewReser_btn;
    }
}