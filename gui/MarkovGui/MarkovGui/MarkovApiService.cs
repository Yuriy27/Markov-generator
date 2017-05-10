using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MarkovGui
{
    class MarkovApiService
    {
        private byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public string SendRequest(int maxLength, string data)
        {
            string json = "{\"max_length\": \"" + maxLength + "\",\"model_data\": \"" + data + "\"}";
            byte[] body = Encoding.UTF8.GetBytes(json);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://localhost:5000/api/markov");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = body.Length;
            
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(body, 0, body.Length);
            }
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            
            string responseText = null;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string text = reader.ReadToEnd();
                dynamic js = Newtonsoft.Json.JsonConvert.DeserializeObject(text);
                responseText = (string)js.text;
            }
            response.Close();

            return responseText;
        }
    }
}