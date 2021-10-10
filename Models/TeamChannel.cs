using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroXTeam.Models
{
    public class TeamChannel
    {
    public TeamChannel(string name, string desc, string link, string sVG)
    {
      Name = name;
      Desc = desc;
      Link = link;
      SVG = sVG;
    }

    public string Name { get; set; }
        public string Desc { get; set; }
        public string Link { get; set; }
        public string  SVG { get; set; }
    }
}