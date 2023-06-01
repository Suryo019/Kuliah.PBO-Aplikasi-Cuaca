using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kuliah.PBO_Aplikasi_Cuaca
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int startpoint = 0;


        private void progresbar_timer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progresbar.Value = startpoint;
            if (progresbar.Value == 100)
            {
                progresbar.Value = 0;
                progresbar_timer.Stop();
                Tampilan_Utama tampilan_utama = new Tampilan_Utama();
                this.Hide();
                tampilan_utama.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            progresbar_timer.Start();
        }
        private void Loading_Screen_Click(object sender, EventArgs e)
        {

        }
    }
}
