using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static WindowsFormsApp5.SettingForm;


namespace WindowsFormsApp5
{
    public partial class WeatherData : Form
    {
        private WeatherService weatherService;
        private int panelIndex = 0;
        private int totalCities = 0;
        private WeatherSettings settings;

        public WeatherData(WeatherSettings settings)
        {
            InitializeComponent();
            InitializeFormSize();
            this.settings = settings;
            this.weatherService = new WeatherService(settings);
            if (settings != null && settings.Cities != null && settings.RefreshTime != null)
            {
                totalCities = settings.Cities.Count;
                timer1.Interval = Int32.Parse(settings.RefreshTime) * 1000;
            }
            RefreshWeatherInfo();
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            panelIndex++;
            if (panelIndex >= totalCities)
            {
                panelIndex = 0;
            }
            RefreshWeatherInfo();
        }

        private async void RefreshWeatherInfo()
        {
            if (settings != null && settings.Cities != null && settings.Cities.Any())
            {
                var city = settings.Cities.ElementAt(panelIndex);
                var weatherData = await weatherService.GetWeatherData(city);
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(weatherData);
                double temperature = json.main.temp;
                double humidity = json.main.humidity;
                double pressure = json.main.pressure;
                UpdateLabels(city, temperature, humidity, pressure);
            }
        }
       
        private void UpdateLabels(string city, double temperature, double humidity, double pressure)
        {
            label1.Text = city;
            lblHumidity.Text = String.Format(MyStrings.HumidityText, humidity);
            lblAtmosphere.Text = String.Format(MyStrings.AtmoshphereText, pressure);
            lblTemperature.Text = String.Format(MyStrings.TemperatureText, temperature);
        }

        private async void DisplayWeatherDataForm()
        {
            var settingsForm = new SettingForm();

            settingsForm.ShowDialog();
            if (settingsForm.Settings != null)
            {
                weatherService = new WeatherService(settingsForm.Settings);
                settings = settingsForm.Settings;
                if (settings.Cities != null)
                {
                    totalCities = settings.Cities.Count;
                }
                timer1.Interval = Int32.Parse(settings.RefreshTime) * 1000;
                await Task.Delay(2000);
                RefreshWeatherInfo();
                timer1.Start();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var newSettingsForm = new SettingForm();
                newSettingsForm.ShowDialog();

                if (newSettingsForm.Settings != null)
                {
                    weatherService = new WeatherService(newSettingsForm.Settings);
                    settings = newSettingsForm.Settings;
                    if (settings.Cities != null)
                    {
                        totalCities = settings.Cities.Count;

                    }
                    timer1.Interval = Int32.Parse(newSettingsForm.Settings.RefreshTime) * 1000;
                    RefreshWeatherInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(MyStrings.BtnSettingExceptionErrorMessage, ex.Message), MyStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeFormSize()
        {
            this.Width = 700;
            this.Height = 550;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
        }

        private async void WeatherData_Load(object sender, EventArgs e)
        {
            DisplayWeatherDataForm();
        }
    }
}









