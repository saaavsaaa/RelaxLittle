using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaxLitte.Util
{
    public class JsonOpt
    {
        public static Dictionary<string, string> GetAllInJson(string jsonText)
        {
            JsonReader reader = new JsonTextReader(new StringReader(jsonText));

            while (reader.Read())
            {
                Console.WriteLine(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value + "\r\n");
            }
            Console.ReadKey();
        }
    }
}
