
namespace signup
{
    partial class home
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
            this.Home_title = new System.Windows.Forms.Label();
            this.Flights_button = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home_title
            // 
            this.Home_title.AutoSize = true;
            this.Home_title.BackColor = System.Drawing.Color.Transparent;
            this.Home_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_title.Location = new System.Drawing.Point(131, 77);
            this.Home_title.Name = "Home_title";
            this.Home_title.Size = new System.Drawing.Size(491, 38);
            this.Home_title.TabIndex = 0;
            this.Home_title.Text = "WELCOME TO OUR AIRLINES ";
            // 
            // Flights_button
            // 
            this.Flights_button.Location = new System.Drawing.Point(176, 468);
            this.Flights_button.Name = "Flights_button";
            this.Flights_button.Size = new System.Drawing.Size(94, 33);
            this.Flights_button.TabIndex = 1;
            this.Flights_button.Text = "Flights";
            this.Flights_button.UseVisualStyleBackColor = true;
            this.Flights_button.Click += new System.EventHandler(this.Flights_button_Click);
            // 
            // Signout
            // 
            this.Signout.Location = new System.Drawing.Point(478, 468);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(83, 35);
            this.Signout.TabIndex = 2;
            this.Signout.Text = "Signout";
            this.Signout.UseVisualStyleBackColor = true;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::signup.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.ClientSize = new System.Drawing.Size(799, 551);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Flights_button);
            this.Controls.Add(this.Home_title);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home_title;
        private System.Windows.Forms.Button Flights_button;
        private System.Windows.Forms.Button Signout;
    }
}