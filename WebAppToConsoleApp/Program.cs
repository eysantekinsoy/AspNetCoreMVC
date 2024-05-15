WebApplicationBuilder builder = WebApplication.CreateBuilder();


//web server için gerekli duyulan eklentilerin yazılacağı yer 

WebApplication app=builder.Build();

#region Map routing 
//app.MapGet("/", () => "<b>Hello World</b>"); //Kalın şekilde yazmaz.  (text-plain)

//app.MapGet("/", async (context) => //Kalın şekilde yazar. (text-html)
//{
//    //Console.WriteLine("Hello Web Application");
//    await context.Response.WriteAsync("<b>Hello web application</b>");
//});

//app.Run(async context =>
//{
//    string host = context.Request.Host.Host;
//    string path = context.Request.Path;

//    await context.Response.WriteAsync($"Host:{host}  Path: {path}");
//});
#endregion

app.Run();
