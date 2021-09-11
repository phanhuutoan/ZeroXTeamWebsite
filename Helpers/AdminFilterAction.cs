using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ZeroXTeam.Helpers
{
  public class AdminFilterAction : IAsyncActionFilter
  {
    public string DataContent = "";
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
      dynamic ViewBag = (context.Controller as Controller).ViewBag;
      ViewBag.IsAdmin = true;

      await next();
    }
  }
}