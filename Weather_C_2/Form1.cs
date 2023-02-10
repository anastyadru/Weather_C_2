using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Weather_C_2
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&appid=d6bfd60ae10dc578300a860f105ed749");

            request.Method = "POST";

            request.ContentType = " ";
                
            WebResponse response = await request.GetResponseAsync();
                
            string answer = String.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            
            response.Close();

            richTextDox1.Text = answer;
        }
    }
}