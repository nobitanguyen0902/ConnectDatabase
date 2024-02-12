using MongoDB.Driver;
using Repository.Business;
using Repository.Infrastructure;
using Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMongoDatabase>(u =>
{
    var connectionUri = builder.Configuration["ConnectionStrings:MongoUrl"];
    var databaseName = builder.Configuration["ConnectionStrings:DatabaseName"];
    var settings = MongoClientSettings.FromConnectionString(connectionUri);
    return new MongoClient(settings).GetDatabase(databaseName);
});

builder.Services.AddSingleton<IMongoDb>(u =>
{
    var connectionUri = builder.Configuration["ConnectionStrings:MongoUrl"];
    var databaseName = builder.Configuration["ConnectionStrings:DatabaseName_2"];
    var settings = MongoClientSettings.FromConnectionString(connectionUri);
    return new MongoDb(new MongoClient(settings).GetDatabase(databaseName));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();