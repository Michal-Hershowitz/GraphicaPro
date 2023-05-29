using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Dal.Models;
using Dal.Services;
using Bl.Interface;
using Bl.Profiles;
using Bl;
using Dal.Interface;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//

var builder = WebApplication.CreateBuilder(args);
//

var provider = builder.Services.BuildServiceProvider();

var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    var frontendURL = configuration.GetValue<string>("frontend_url");

    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
    });

    //options.AddPolicy(name: MyAllowSpecificOrigins,
    //                  policy =>
    //                  {
    //                      policy.AllowAnyOrigin()
    //                      .AllowAnyHeader()
    //                            .AllowAnyMethod(); 
    //                  });
});

// Add services to the container.

builder.Services.Configure<DataBaseSettings>(
    builder.Configuration.GetSection(nameof(DataBaseSettings)));

builder.Services.AddSingleton<IDataBaseSettings>(sp =>
    sp.GetRequiredService<IOptions<DataBaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("DataBaseSettings:ConnectionString")));

//builder.Services.AddScoped<ICrud<Employee>, ServicesEmployee>();

//
//builder.Services.AddScoped<ICrud<Customer>, ServicesCustomer>();
builder.Services.AddAutoMapper(typeof(CustomerProfile));
builder.Services.AddScoped<IServicesCustomer, ServicesCustomer>();

builder.Services.AddScoped<IFunctionCustomerBl, FunctionCustomerBL>();

//
builder.Services.AddControllers();
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
app.UseStaticFiles();
app.UseRouting();

//app.UseCors(MyAllowSpecificOrigins);
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();