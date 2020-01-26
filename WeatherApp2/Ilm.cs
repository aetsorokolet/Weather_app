using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp2
{
    class Ilm
    {

		public class Weather
		{
			public string description { get; set; }
		}

		public class Main
		{
			public double temp { get; set; }

			public int humidity { get; set; }
		}
		public class Wind
		{
			public double speed { get; set; }
		}


		public class Root
		{
			public List<Weather> weather { get; set; }
			public Main main { get; set; }
			public Wind wind { get; set; }

			public string name { get; set; }
		}
	}
}
