namespace Kuliah.PBO_Aplikasi_Cuaca
{
    partial class Tampilan_Utama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tampilan_Utama));
            pictureBox1 = new PictureBox();
            search_button = new Button();
            city_box = new TextBox();
            conditions_box = new TextBox();
            detail_box = new TextBox();
            sunrise_box = new TextBox();
            sunset_box = new TextBox();
            pressure_box = new TextBox();
            wind_box = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // search_button
            // 
            search_button.FlatStyle = FlatStyle.Flat;
            search_button.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            search_button.Location = new Point(466, 130);
            search_button.Name = "search_button";
            search_button.Size = new Size(82, 27);
            search_button.TabIndex = 1;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // city_box
            // 
            city_box.BackColor = Color.White;
            city_box.BorderStyle = BorderStyle.FixedSingle;
            city_box.Location = new Point(235, 130);
            city_box.Name = "city_box";
            city_box.Size = new Size(190, 27);
            city_box.TabIndex = 2;
            // 
            // conditions_box
            // 
            conditions_box.BackColor = Color.White;
            conditions_box.BorderStyle = BorderStyle.FixedSingle;
            conditions_box.Enabled = false;
            conditions_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            conditions_box.ForeColor = SystemColors.ControlText;
            conditions_box.Location = new Point(235, 186);
            conditions_box.Name = "conditions_box";
            conditions_box.Size = new Size(114, 27);
            conditions_box.TabIndex = 3;
            // 
            // detail_box
            // 
            detail_box.BackColor = Color.White;
            detail_box.BorderStyle = BorderStyle.FixedSingle;
            detail_box.Enabled = false;
            detail_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            detail_box.Location = new Point(235, 228);
            detail_box.Name = "detail_box";
            detail_box.Size = new Size(114, 27);
            detail_box.TabIndex = 4;
            // 
            // sunrise_box
            // 
            sunrise_box.BackColor = Color.White;
            sunrise_box.BorderStyle = BorderStyle.FixedSingle;
            sunrise_box.Enabled = false;
            sunrise_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sunrise_box.Location = new Point(235, 271);
            sunrise_box.Name = "sunrise_box";
            sunrise_box.Size = new Size(175, 27);
            sunrise_box.TabIndex = 5;
            // 
            // sunset_box
            // 
            sunset_box.BackColor = Color.White;
            sunset_box.BorderStyle = BorderStyle.FixedSingle;
            sunset_box.Enabled = false;
            sunset_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sunset_box.Location = new Point(235, 316);
            sunset_box.Name = "sunset_box";
            sunset_box.Size = new Size(175, 27);
            sunset_box.TabIndex = 6;
            // 
            // pressure_box
            // 
            pressure_box.BackColor = Color.White;
            pressure_box.BorderStyle = BorderStyle.FixedSingle;
            pressure_box.Enabled = false;
            pressure_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pressure_box.Location = new Point(466, 228);
            pressure_box.Name = "pressure_box";
            pressure_box.Size = new Size(114, 27);
            pressure_box.TabIndex = 8;
            // 
            // wind_box
            // 
            wind_box.BackColor = Color.White;
            wind_box.BorderStyle = BorderStyle.FixedSingle;
            wind_box.Enabled = false;
            wind_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            wind_box.Location = new Point(466, 186);
            wind_box.Name = "wind_box";
            wind_box.Size = new Size(114, 27);
            wind_box.TabIndex = 7;
            // 
            // Tampilan_Utama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(737, 553);
            Controls.Add(pressure_box);
            Controls.Add(wind_box);
            Controls.Add(sunset_box);
            Controls.Add(sunrise_box);
            Controls.Add(detail_box);
            Controls.Add(conditions_box);
            Controls.Add(city_box);
            Controls.Add(search_button);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Tampilan_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Weather";
            Load += Tampilan_Utama_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button search_button;
        private TextBox city_box;
        private TextBox conditions_box;
        private TextBox detail_box;
        private TextBox sunrise_box;
        private TextBox sunset_box;
        private TextBox pressure_box;
        private TextBox wind_box;
    }
}