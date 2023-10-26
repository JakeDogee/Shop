using shop.api.Extensions;
using shop.api.Repository;
using shop.api.Repository.Abstractions;
using shop.api.Services;
using shop.api.Services.Abstractions;
using shop.data;

var builder = WebApplication.CreateBuilder(args);
builder
    .SetUpConfigurations()
    .ConfigureKestrel();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

await app.Services.GetService<ShopContext>().MigrateAsync();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
