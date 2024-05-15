using Example01.WebApplication1.Fonksiyonlar;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();



#region Map yapýsý
//app.MapGet("/", () => "Hello World!");

//app.MapGet("/anasayfa", async (httpContext) =>
//{
//    Anasayfa anasayfa = new Anasayfa(httpContext);
//    anasayfa.HelloWorld();

//});
#endregion

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseHsts();

//app.UseRouting();

app.MapDefaultControllerRoute(); //Default Rotalama

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Anasayfa}/{action=Merhaba}/{sayfaNo?}"
//    );


//app.UseEndpoints(endpoints =>
//{
//    app.MapGet("/hakkimizda", () => "hakkimizda sayfasi");
//});

//app.Run();
