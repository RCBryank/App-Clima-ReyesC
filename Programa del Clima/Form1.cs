using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Newtonsoft.Json;

namespace Programa_del_Clima
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            RunAsync();
            FillCBCity(Cities);
            CB_City.SelectedIndex = 0;

        }

        string[] Cities = { "London", "Monterrey" };

        static HttpClient client = new HttpClient();

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=f9c530fc04bca6018e7f703777604a85");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }


        void FillCBCity(string[] _cities)
        {
            for(int i = 0; i < _cities.Length; i++)
            {
                CB_City.Items.Add(_cities[i]);
            }
        }


        static async Task<City_Weather> GetWeather(string path)
        {
            City_Weather _weather = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string _sweather = await response.Content.ReadAsStringAsync();
                JObject _obj = JObject.Parse(_sweather);
                _weather = JsonConvert.DeserializeObject<City_Weather>(_sweather);
                
            }
            return _weather;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // GetWeather("http://api.openweathermap.org/geo/1.0/direct?q=London&limit=5&appid=f9c530fc04bca6018e7f703777604a85");
            string _citie = "https://api.openweathermap.org/data/2.5/weather?q=" + CB_City.Text + "&appid=f9c530fc04bca6018e7f703777604a85&units=metric&lang=sp";
            City_Weather _weather = Task.Run(()=> GetWeather(_citie)).Result;
            //var result = Task.Run(() => asyncGetValue()).Result;

            Lbl_Min.Text = _weather.Main.temp_min.ToString() + "°";
            Lbl_Max.Text = _weather.Main.temp_max.ToString() + "°";
            Lbl_Act.Text = _weather.Main.temp.ToString() + "°";
        }

        private void Lbl_Min_Click(object sender, EventArgs e)
        {

        }
    }


    public class City_Weather
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public main Main { get; set; }

        public City_Weather()
        {
            ID = 0;
            CityName = "City";
            Main = new main();
        }

        public struct main
        {
            public float temp { get; set; }
            public float feels_like { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public float pressure { get; set; }
            public float humidity { get; set; }
        }

    }
}
