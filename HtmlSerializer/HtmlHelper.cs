using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HtmlSerializer
{
    internal class HtmlHelper
    {
        // Singleton pattern
        private readonly static HtmlHelper _instance = new HtmlHelper();
        public static HtmlHelper Instance => _instance;

        public string[] htmlTags { get; private set; }
        public string[] htmlVoidTags { get; private set; }

        private HtmlHelper()
        {
            string jsonContent;
            jsonContent = File.ReadAllText("JSON Files/HtmlTags.json");
            htmlTags = JsonSerializer.Deserialize<string[]>(jsonContent);
            jsonContent = File.ReadAllText("JSON Files/HtmlVoidTags.json");
            htmlVoidTags = JsonSerializer.Deserialize<string[]>(jsonContent);
        }
    }
}
