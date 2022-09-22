using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using tournamaker.Areas.Identity.Data;
using tournamaker.Services;
using tournamaker.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("tournamakerContextConnection") ?? throw new InvalidOperationException("Connection string 'tournamakerContextConnection' not found.");

builder.Services.AddDbContext<tournamakerContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<tournamakerUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<tournamakerContext>();

// Add services to the container.

builder.Services.AddServerSideBlazor();

builder.Services.AddRazorPages();

builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapBlazorHub();
app.MapRazorPages();

app.Run();
