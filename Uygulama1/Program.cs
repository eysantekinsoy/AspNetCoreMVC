WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Statik dosyaların root klasörünün değiştirmek istersek aşağıdaki kod
//builder.Environment.ContentRootPath = "rootFolder";

//Controller ve View yapısını projeye dahil ediyoruz.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

//Https Yönlendirmesini ve CSS,JS ve benzeri Statik sayfaların çalışmasını sağlamak
app.UseHttpsRedirection();
app.UseStaticFiles(); // root folder => wwwroot

//app.UseRouting();
//app.MapControllers();

// Controller seviyesinde otomatik Rotalama işlemini devreye alýyorum
app.MapDefaultControllerRoute();

//Controller seviyesinde özelleştirilmiş Rotalama işlemi yapmak için
//app.MapControllerRoute(
//    name: "public",
//    pattern: "Public/{controller=Home}/{action=Index}/{Id?}"
//    );

//app.MapControllerRoute(
//    name: "admin",
//    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
//    );

app.Run();