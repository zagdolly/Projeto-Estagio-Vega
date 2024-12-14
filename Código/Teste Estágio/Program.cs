using Teste_Est�gio.Context;
using Microsoft.EntityFrameworkCore;
using Teste_Est�gio.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Configura��o dos servi�os
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 2, 0)) // Substitua pela sua vers�o do MySQL
    ));

builder.Services.AddScoped<ISupplierRepositorio, SupplierRepositorio>();
builder.Services.AddScoped<IMaterialRepositorio, MaterialRepositorio>();



var app = builder.Build();

// Configura��o do middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();

