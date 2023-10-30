using shop.client.api.Extensions;
using shop.client.api.Repository;
using shop.client.api.Repository.Abstractions;
using shop.client.api.Services;
using shop.client.api.Services.Abstractions;
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
