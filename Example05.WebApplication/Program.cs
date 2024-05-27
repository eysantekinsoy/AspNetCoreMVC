var builder = WebApplication.CreateBuilder(args);

//Controllers ve Views Yap�s�n� Service eklentisini dahil ediyoruz.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Https otomatik y�nlendirmesi 
app.UseHttpsRedirection();

//CSS, JS vb statik sayfalar �a�r�la bilsindiye
app.UseStaticFiles();

app.MapDefaultControllerRoute();

//app.MapControllerRoute(name: "yeniRota", pattern: "{action=Index}/{controller=Home}/{id?}");

// News/Breaking/5?cat=Sport&subCat=Bundesliga

// News/Breaking/Sport/Budesliga/5 => /Controller/Action/CatName/SubCatNem/id?

app.Run();