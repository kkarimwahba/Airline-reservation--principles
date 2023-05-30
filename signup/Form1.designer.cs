
namespace signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flight2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Reserve_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flight2)).BeginInit();
            this.SuspendLayout();
            // 
            // flight2
            // 
            this.flight2.AllowUserToAddRows = false;
            this.flight2.AllowUserToDeleteRows = false;
            this.flight2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flight2.Location = new System.Drawing.Point(62, 192);
            this.flight2.Name = "flight2";
            this.flight2.ReadOnly = true;
            this.flight2.RowHeadersWidth = 51;
            this.flight2.RowTemplate.Height = 24;
            this.flight2.Size = new System.Drawing.Size(737, 149);
            this.flight2.TabIndex = 5;
            this.flight2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Upcoming Flights:";
            // 
            // Reserve_btn
            // 
            this.Reserve_btn.Location = new System.Drawing.Point(387, 392);
            this.Reserve_btn.Name = "Reserve_btn";
            this.Reserve_btn.Size = new System.Drawing.Size(116, 45);
            this.Reserve_btn.TabIndex = 7;
            this.Reserve_btn.Text = "Reservation";
            this.Reserve_btn.UseVisualStyleBackColor = true;
            this.Reserve_btn.Click += new System.EventHandler(this.Reserve_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.Reserve_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flight2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.flight2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView flight2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reserve_btn;
    }
}

