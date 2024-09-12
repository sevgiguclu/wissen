var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


/*
 * Index.html
 * Index.htm
 * Default.html
 * Default.htm
 */

DefaultFilesOptions option = new DefaultFilesOptions();
option.DefaultFileNames.Clear();
option.DefaultFileNames.Add("Index5.html");
app.UseDefaultFiles(option);

app.UseStaticFiles();

app.Run();
