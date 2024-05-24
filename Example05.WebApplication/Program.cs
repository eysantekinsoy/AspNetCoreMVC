var builder = WebApplication.CreateBuilder(args);

//Controllers ve viewa yapýsýný Service eklentisini dahil etme
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Https otomotik yönlendirmesi
app.UseHttpsRedirection();

//Css Js ve benzeri statik sayfalarý çaðýrabilmek için
app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
