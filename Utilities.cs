using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BotDiscord
{
    class Utilities
    {
        static Utilities()
        {
            string json = File.ReadAllText("SystemLang/alerts.json");
        }
    }
}
