using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JLCS.SB.CapaEntidad;
using System.Net;
using Nancy.Json;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.Openwheater
{
    public class WeatherModel : PageModel
    {
        //[HttpPost]
        public WeatherViewModel WeatherDetail(string City)
        {
            //Assign API KEY
            string appId = "c44d8aa0c5e588db11ac6191c0bc6a60";
            //API path with CITY parameter
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}",City,appId);
            using(WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                //Converting to object from json string
                RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);
                //special VIEWMODEL design to send only required fields not all fields recivied
                WeatherViewModel rslt = new WeatherViewModel();
                rslt.Country = weatherInfo.sys.country;
                rslt.City = weatherInfo.name;
                rslt.Lat = Convert.ToString(weatherInfo.coord.lat);
                rslt.Lon = Convert.ToString(weatherInfo.coord.lon);
                rslt.Description = weatherInfo.weather[0].description;
                rslt.Humidity = Convert.ToString(weatherInfo.main.humidity);
                rslt.Temp = Convert.ToString(weatherInfo.main.temp);
                rslt.TempFeelsLike = Convert.ToString(weatherInfo.main.feels_like);
                rslt.TempMax = Convert.ToString(weatherInfo.main.temp_max);
                rslt.TempMin = Convert.ToString(weatherInfo.main.temp_min);
                rslt.WeatherIcon = weatherInfo.weather[0].icon;

                //converting object to json string
                //Return JSON string
                return rslt;
            }
        }
        public WeatherViewModel tiempo { get; set; }
        public void OnGet()
        {
            tiempo = WeatherDetail("Huanuco");
        }
        public void OnPost()
        {
            tiempo = WeatherDetail("Huanuco");
        }
    }
}
