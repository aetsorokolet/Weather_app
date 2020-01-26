using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WeatherApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                //backlog: giving user option to seach by location (searchTerm)
                //using Windows Forms functionality
                //string baseUrl = "https://api.openweathermap.org/data/2.5/weather?q=";
                //string searchTerm = "Viimsi";
                //string end = "&units=metric&appid=67bbdb33a6f88e7165c2f893a0d695d8";
                //string url = string.Format(baseUrl + searchTerm + end);
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Viimsi&units=metric&appid=67bbdb33a6f88e7165c2f893a0d695d8");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Ilm.Root>(json);
                Ilm.Root kuva = result;
                label1.Text = string.Format($"Location: {kuva.name}");
                label2.Text = string.Format($"Conditions: {kuva.weather[0].description}");
                label3.Text = string.Format($"Temperature: {kuva.main.temp} °C");
                label4.Text = string.Format($"Humidity: {kuva.main.humidity} %");              

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }
    }
}
