var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "searchbyid",
    pattern: "home/search/{id:int}",
    defaults: new { Controller = "home", Action = "searchbyid" }
    );

app.MapControllerRoute(
    name: "SearchByName",
    pattern: "home/search/{name}",
    defaults: new { Controller = "Home", Action = "SearchByName " }
    );

app.MapControllerRoute(
    name: "ShowUserInfo",
    pattern: "Home/ShowUserInfo/{id}/{username}",
    defaults: new { Controller = "Home", Action = "ShowUserInfo" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
