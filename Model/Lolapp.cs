using System;
using lolapp.Controller;

namespace lolapp.Model{
    public class Lolapp    {
        static void Main(string[] args)        {
            Console.WriteLine("Ingrese nombre de invocador: ");
            string name = Console.ReadLine();
            string key = "Wara";
            Request API = new Request(key);
            string basics = API.basicData(name);

        }
    }
}