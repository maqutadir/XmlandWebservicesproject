﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGroupProject
{

    public class Weather
    {
        [JsonProperty("id")]
        private string id;
        [JsonProperty("main")]
        private string main;
        [JsonProperty("icon")]
        private string icon;


        public string Id { get => id; set => id = value; }
        public string Main { get => main; set => main = value; }
        public string Icon { get => icon; set => icon = value; }

    }
  
    public class Main
    {
        [JsonProperty("temp")]
        private string temp;
        [JsonProperty("pressure")]
        private string pressure;
        [JsonProperty("humidity")]
        private string humidity;
        [JsonProperty("temp_min")]
        private string temp_min;
        [JsonProperty("temp_max")]
        private string temp_max;


        public string Temp { get => temp; set => temp = value; }
        public string Pressure { get => pressure; set => pressure = value; }
        public string Humidity { get => humidity; set => humidity = value; }
        public string Temp_min { get => temp_min; set => temp_min = value; }
        public string Temp_max { get => temp_max; set => temp_max = value; }

    }
 
    public class Wind
    {
        [JsonProperty("speed")]
        private string speed;
        [JsonProperty("deg")]
        private string deg;



        public string Speed { get => speed; set => speed = value; }
        public string Deg { get => deg; set => deg = value; }


    }
    public class Clouds
    {
        [JsonProperty("all")]
        private string all;

        public string All { get => all; set => all = value; }
    }

    public class Sys
    {
       
        [JsonProperty("country")]
        private string country;
        [JsonProperty("sunrise")]
        private string sunrise;
        [JsonProperty("sunset")]
        private string sunset;


        public string Country { get => country; set => country = value; }
        public string Sunrise { get => sunrise; set => sunrise = value; }
        public string Sunset { get => sunset; set => sunset = value; }

    }

    public class allinone
    {
    

        [JsonProperty("weather")]
        public List<Weather> Weathers { get; set; }

        [JsonProperty("base")]
        public String BaseValue { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public String Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

  

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("cod")]
        public String Cod { get; set; }

    }
}