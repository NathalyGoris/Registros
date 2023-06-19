using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
//using Registros.Data;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

 var ConStr = builder.Configuration.GetConnectionString("ConStr");

    builder.Services.AddDbContext<Context>(Options=> Options.UseSqlite(ConStr));

builder.Services.AddScoped<PrioridadesBLL>();
builder.Services.AddScoped<ClientesBLL>();
builder.Services.AddScoped<TicketsBLL>();
builder.Services.AddScoped<TicketsDetalleBLL>();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
