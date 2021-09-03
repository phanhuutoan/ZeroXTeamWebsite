using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZeroXTeam.Helpers
{
  public class AdminFilterAction : IAsyncActionFilter
  {
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
      dynamic ViewBag = (context.Controller as Controller).ViewBag;
      ViewBag.IsAdmin = true;

      await next();
    }
  }
}