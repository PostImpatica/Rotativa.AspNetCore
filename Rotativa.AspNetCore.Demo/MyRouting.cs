using Microsoft.AspNetCore.Builder;

namespace Rotativa.AspNetCore.Demo
{
    public static class MyRouting
    {
        public static void RegisterRoutes(WebApplication? app)
        {
            app!.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");           

            app!.MapControllerRoute(
                "404-PageNotFound",
                "{*url}",
                new { controller = "Error", action = "PageNotFound" }
                );

        }
    }
}
