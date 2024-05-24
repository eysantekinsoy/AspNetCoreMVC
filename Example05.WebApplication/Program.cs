var builder = WebApplication.CreateBuilder(args);

//Controllers ve viewa yap�s�n� Service eklentisini dahil etme
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Https otomotik y�nlendirmesi
app.UseHttpsRedirection();

//Css Js ve benzeri statik sayfalar� �a��rabilmek i�in
app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
