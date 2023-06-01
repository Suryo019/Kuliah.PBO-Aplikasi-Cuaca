namespace Kuliah.PBO_Aplikasi_Cuaca
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            Loading_Screen = new PictureBox();
            progresbar = new ProgressBar();
            progresbar_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Loading_Screen).BeginInit();
            SuspendLayout();
            // 
            // Loading_Screen
            // 
            Loading_Screen.Image = (Image)resources.GetObject("Loading_Screen.Image");
            Loading_Screen.Location = new Point(1, 1);
            Loading_Screen.Name = "Loading_Screen";
            Loading_Screen.Size = new Size(735, 550);
            Loading_Screen.SizeMode = PictureBoxSizeMode.Zoom;
            Loading_Screen.TabIndex = 1;
            Loading_Screen.TabStop = false;
            Loading_Screen.Click += Loading_Screen_Click;
            // 
            // progresbar
            // 
            progresbar.Location = new Point(1, 541);
            progresbar.Name = "progresbar";
            progresbar.Size = new Size(735, 10);
            progresbar.TabIndex = 2;
            // 
            // progresbar_timer
            // 
            progresbar_timer.Tick += progresbar_timer_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(737, 553);
            ControlBox = false;
            Controls.Add(progresbar);
            Controls.Add(Loading_Screen);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading...";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)Loading_Screen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Loading_Screen;
        private ProgressBar progresbar;
        private System.Windows.Forms.Timer progresbar_timer;
    }
}