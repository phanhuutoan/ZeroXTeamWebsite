namespace ZeroXTeam.DTOs
{
    public class PaginationParams
    {
        private int _itemPerPage { get; set; } = 5;

        public int ItemPerPage
        {
            get { return _itemPerPage; }
            set { _itemPerPage = value > 50 ? 50 : value; }
        }

        public int PageNumber { get; set; } = 1;
        public string SortBy { get; set; } = "Id";
    }
}