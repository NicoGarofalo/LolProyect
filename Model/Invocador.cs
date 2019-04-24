using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lolapp.Model
{
    internal class Invocador
    {
        private JObject basics;
        private string id;
        private string accId;
        private string nombre;
        private long nivel;

        public Invocador(JObject basics)
        {
            this.basics = basics;
            
        }
    }
}