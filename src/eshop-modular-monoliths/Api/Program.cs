using Catalog;
using Basket;
using Ordering;
using Microsoft.AspNetCore.DataProtection.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOderingModule(builder.Configuration);
var app = builder.Build();
app
   .UseCatalogModule()
   .UseBasketModule()
   .UseOrderingModule();

app.Run();
