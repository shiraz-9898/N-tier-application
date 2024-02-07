using BLL_Bussiness_Logic_Layer_.Interface;
using BLL_Bussiness_Logic_Layer_.Services;
using DAL_Data_Access_Layer_.DbContextClasses;
using DAL_Data_Access_Layer_.Interface;
using DAL_Data_Access_Layer_.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StudentDBC>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("conn")));

builder.Services.AddScoped<IStudentDAL, StudentDAL>();
builder.Services.AddScoped<IStudentBLL, StudentBLL>();


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
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}");

app.Run();
