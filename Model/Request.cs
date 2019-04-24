using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace lolapp.Model{
    public class Request{
        private string APIKey;

        public Request(){
            this.APIKey =  "RGAPI-5239d21d-60eb-4bfa-a03a-52fb57bb683a";
        }
        public JObject basicData(string name){
            string CURL = "https://la2.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name + "?api_key=" + APIKey;
            JObject summonerData = request(CURL);

            return summonerData;
        }

        public JObject summonerHistory(string accId){
            String CURL = "https://la2.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accId + "?api_key=" + APIKey;
            JObject datosHistorial = request(CURL);
            return datosHistorial;
        }

        private JObject request (string CURL){

            WebRequest request = WebRequest.Create(@CURL);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string jstring = reader.ReadToEnd();
            JObject jobj = JObject.Parse(jstring);
            return jobj;            
        }
    }
}