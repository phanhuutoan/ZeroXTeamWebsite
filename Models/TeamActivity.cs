using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroXTeam.Models
{
    public class TeamActivity
    {
        public TeamActivity(string svgLink, string name, string desc)
        {
        SvgLink = svgLink;
        Name = name;
        Desc = desc;
        }

        public string SvgLink { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}