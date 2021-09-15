using System.Collections.Generic;

namespace ZeroXTeam.Models.Partials
{
    public class SortOption
    {
        public SortOption(string value, string displayText)
        {
            Value = value;
            DisplayText = displayText;
        }

        public string Value { get; set; }
        public string DisplayText { get; set; }
    }
    public class PaginationAndSort
    {
        public string AspController { get; set; }
        public string AspAction { get; set; } = "Index";
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string SortBy { get; set; }
        public int ItemPerPage { get; set; }
        public List<SortOption> SortOptions { get; set; }
    }
}