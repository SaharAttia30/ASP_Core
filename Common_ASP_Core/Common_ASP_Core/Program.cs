var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(options => options.RootDirectory = "/Pages");

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();  
var app = builder.Build();
app.MapRazorPages();
app.UseSession();  


app.Run();