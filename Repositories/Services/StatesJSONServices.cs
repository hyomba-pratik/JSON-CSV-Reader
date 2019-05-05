using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositories.Models;
using System.IO;
using Newtonsoft.Json;

namespace Repositories.Services
{
    public class StatesJSONServices : IStates
    {
        string path;

        public StatesJSONServices()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Source/states.json";
        }

        public IEnumerable<States> GetStates()
        {
            var states = new List<States>();
            if (File.Exists(path))
            {
                String JSONtxt = File.ReadAllText(path);
                states = JsonConvert.DeserializeObject<List<States>>(JSONtxt);
            }

            return states;
        }
    }
}