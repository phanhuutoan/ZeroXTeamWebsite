using System.Collections.Generic;

namespace ZeroXTeam.Models.Partials
{
    public class SortingOption 
    {
    public SortingOption(string value, string display)
    {
      Value = value;
      Display = display;
    }

    public string Value { get; set; }
        public string Display { get; set; }
    }
    public class ClientSorting
    {
        public string AspAction { get; set; }
        public string AspController { get; set; }
        public int CurrentPage { get; set; }
        public string SortBy { get; set; }
        public List<SortingOption> SortingOptions { get; set; }
    }
}