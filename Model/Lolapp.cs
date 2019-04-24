using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using lolapp.Controller;

namespace lolapp.Model{
    public class Lolapp    {      

        static void Main(string[] args)        {
            Console.WriteLine("Ingrese nombre de invocador: ");
            string name = Console.ReadLine();
            Request API = new Request();
            JObject basics = API.basicData(name);
            string accId = (string) basics["accountId"];
            JObject history = API.summonerHistory(accId);
            Console.WriteLine("Un historial: " + history);
            Invocador invocadorBasico = new Invocador(basics);

        }
    }
}