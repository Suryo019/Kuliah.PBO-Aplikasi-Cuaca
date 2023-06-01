using System;
using System.Net;
using Newtonsoft.Json;

namespace Kuliah.PBO_Aplikasi_Cuaca
{
    public partial class Tampilan_Utama : Form
    {
        public Tampilan_Utama()
        {
            InitializeComponent();
        }

        string api_key = "22da74b1a1ef06e52dc03a644ba51a6a";

        private void Tampilan_Utama_Load(object sender, EventArgs e)
        {

        }

        private void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city_box.Text, api_key);
                    var json = web.DownloadString(url);
                    Info_Cuaca.root info = JsonConvert.DeserializeObject<Info_Cuaca.root>(json);
                    conditions_box.Text = info.weather[0].main;
                    detail_box.Text = info.weather[0].description;
                    sunrise_box.Text = convertDateTime(info.sys.sunrise).ToString();
                    sunset_box.Text = convertDateTime(info.sys.sunset).ToString();
                    wind_box.Text = info.wind.speed.ToString();
                    pressure_box.Text = info.main.pressure.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DateTime convertDateTime(long millisec)

        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            getWeather();
        }
    }
}