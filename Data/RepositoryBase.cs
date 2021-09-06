namespace ZeroXTeam.Data
{
  public abstract class RepositoryBase
  {
    protected readonly DataContext _context;
    protected RepositoryBase(DataContext context)
    {
        _context = context;
    }
  }
}