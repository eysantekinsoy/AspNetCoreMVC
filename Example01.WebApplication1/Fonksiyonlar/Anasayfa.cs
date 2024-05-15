using Microsoft.AspNetCore.Http;

namespace Example01.WebApplication1.Fonksiyonlar
{
    public class Anasayfa
    {
        private HttpContext _httpContext;
        public Anasayfa(HttpContext httpContext)
        {
            _httpContext = httpContext;
            
        }

        public async Task HelloWorld()
        {
            string page = _httpContext.Request.Query["page"];
            string size = _httpContext.Request.Query["size"];

            string response = $"Anasayfaya hos geldiniz. Sayfa:{page} Boyut: {size}";

            await _httpContext.Response.WriteAsync(response);
        }
    }
}
