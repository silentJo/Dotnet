using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/compute", (int price, String country) =>
{
    if (price <= 0) throw new ArgumentNullException(nameof(price));
    if (country is null) throw new ArgumentNullException(nameof(country));
    var taux = (country == "BE") ? 21 : 20;
    var pays = (country == "BE") ? "Belgique" : "France";
    var total = price * (100 + taux) / 100;
    return "price : "+price+", country : ´"+country+"´ => "+total+" (TVA "+pays+" "+taux+"%)";
}).WithName("Compute");

app.Run();
