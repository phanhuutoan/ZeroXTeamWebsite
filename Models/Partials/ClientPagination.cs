namespace ZeroXTeam.Models.Partials
{
    public class ClientPagination
    {
        public string AspAction { get; set; }
        public string AspController { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SortBy { get; set; }
    }
}