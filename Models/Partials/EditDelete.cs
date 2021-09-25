namespace ZeroXTeam.Models.Partials
{
    public class EditDelete
    {
        public string AspController { get; set; }
        public string AspAction { get; set; }
        public int RouteId { get; set; }
        public string DeleteRoute { get; set; }
        public bool HasEditPermission { get; set; } = true;
    }
}