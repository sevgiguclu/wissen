var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DefaultFilesOptions option = new DefaultFilesOptions();
option.DefaultFileNames.Clear();
option.DefaultFileNames.Add("Index6.html");
app.UseDefaultFiles(option);

app.UseStaticFiles();


//app.MapGet("/", () => "Hello World!");

app.Run();
