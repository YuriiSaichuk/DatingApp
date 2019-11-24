using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string messege)
        {
            response.Headers.Add("Acces-Control-Allow-Origin", "*");
            response.Headers.Add("Acces-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Application-Error", messege);
        }
    }
}