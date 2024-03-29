using Stock_Trading_App.Services;
using Stock_Trading_App.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<ICurrencyServices,CurrencyService>();
builder.Services.AddHttpClient<IComodityService,CommodityService>();
builder.Services.AddSingleton<ICurrencyServices,CurrencyService>();
builder.Services.AddSingleton<IComodityService,CommodityService>();


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
