using CarWorld.Data;
using CarWorld.Models;
using CarWorld.Services.Car;
using CarWorld.Services.CarShows;
using CarWorld.Services.Categories;
using CarWorld.Services.Comment;
using CarWorld.Services.Home;
using CarWorld.Services.SearchCars;
using CarWorld.Services.Vote;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// -------------------------
// Configure Services
// -------------------------
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

// Register your application services
builder.Services.AddTransient<ICreateCarService, CreateCarService>();
builder.Services.AddTransient<ICarsService, CarsService>();
builder.Services.AddTransient<ILatestCarsService, LatestCarsService>();
builder.Services.AddTransient<ICountsService, CountsService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ICommentsService, CommentsService>();
builder.Services.AddTransient<ICarShowsService, CarShowsService>();
builder.Services.AddTransient<ISearchService, SearchService>();
builder.Services.AddTransient<IVotesService, VotesService>();
builder.Services.AddTransient<IUserMessagesService, UserMessagesService>();

// -------------------------
// Build App
// -------------------------
var app = builder.Build();

// -------------------------
// Seed database
// -------------------------
app.PrepareDatabase(); // Keep your existing extension method

// -------------------------
// Configure Middleware
// -------------------------
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// -------------------------
// Configure Endpoints
// -------------------------
app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "categories",
    pattern: "{controller=Categories}/{action=CarsByCategory}/{bodyTypeId?}/{pageId?}");

app.MapRazorPages();

app.Run();