using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp5.WeatherData;
using static WindowsFormsApp5.SettingForm;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class WeatherService
    {
        private HttpClient httpClient = new HttpClient();
        private string apiKey = MyStrings.APIKEY;
        private WeatherSettings settings;

        public  WeatherService(WeatherSettings settings)
        {
            this.settings = settings;
        }

        public async Task<string> GetWeatherData(string city)
        {
            try
            {
                string url = String.Format(MyStrings.WeatherAPIUrl,city, apiKey);
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(String.Format(MyStrings.HttpExceptionMessage,city, ex.Message));
                return null;
            }
        }

      
    }
}
