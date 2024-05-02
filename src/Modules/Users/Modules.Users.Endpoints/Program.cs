using Modules.Users.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapControllerRoute(
    name: "users",
    pattern: "{controller:slugify=Home}/{action:slugify=Index}/{id?}"
);

app.Run();