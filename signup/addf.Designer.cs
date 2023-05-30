
namespace signup
{
    partial class addf
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flightt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.flightt)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(486, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(256, 275);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(100, 22);
            this.departureTextBox.TabIndex = 2;
            this.departureTextBox.TextChanged += new System.EventHandler(this.departureTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(434, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arrival";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(158, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.BackColor = System.Drawing.Color.Transparent;
            this.departure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departure.Location = new System.Drawing.Point(161, 278);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(72, 17);
            this.departure.TabIndex = 5;
            this.departure.Text = "Departure";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(256, 325);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.Location = new System.Drawing.Point(537, 275);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.Size = new System.Drawing.Size(100, 22);
            this.arrivalTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(434, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(537, 325);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(66, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add Flight";
            // 
            // flightt
            // 
            this.flightt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightt.Location = new System.Drawing.Point(43, 122);
            this.flightt.Name = "flightt";
            this.flightt.RowHeadersWidth = 51;
            this.flightt.RowTemplate.Height = 24;
            this.flightt.Size = new System.Drawing.Size(614, 132);
            this.flightt.TabIndex = 13;
            this.flightt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightt_CellContentClick_1);
            // 
            // addf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::signup.Properties.Resources.WhatsApp_Image_2023_05_30_at_02_41_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flightt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivalTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "addf";
            this.Text = "addf";
            this.Load += new System.EventHandler(this.addf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label departure;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView flightt;
    }
}