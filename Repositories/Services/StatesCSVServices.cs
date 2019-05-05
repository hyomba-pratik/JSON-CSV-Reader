using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositories.Models;
using System.IO;

namespace Repositories.Services
{
    public class StatesCSVServices : IStates
    {
        string path;

        public StatesCSVServices() {
            path = AppDomain.CurrentDomain.BaseDirectory + "Source/states.csv";
        }

     
        public IEnumerable<States> GetStates()
        {
            var states = new List<States>();
            if (File.Exists(path)) {
                var sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null) {
                    var elems = line.Split(',');
                    var state = new States()
                    {
                        Title = elems[0],
                        Abbreviation = elems[1]
                    };
                    states.Add(state);
                }
            }

            return states;
        }
    }
}