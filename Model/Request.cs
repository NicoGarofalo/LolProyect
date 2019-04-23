using System;
using System.Net;
using System.IO;
using System.Text;
namespace lolapp.Model{
    public class Request{
        private string APIKey = "warawar";

        public Request(string api_key){
            APIKey = api_key;
        }
        public string basicData(string name){
            string CURL = "https://la2.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name + "?api_key=" + APIKey;
            string datosInvocador = request(CURL);

            return datosInvocador;
        }

        private string request (string CURL){

            WebRequest request = WebRequest.Create(@CURL);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            return json;

            
            
        }
    }
}