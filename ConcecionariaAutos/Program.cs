using ConcecionariaAutos.data;
using ConcecionariaAutos.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(variable =>{

    variable.SwaggerDoc("V1", new OpenApiInfo
    {
        Title = "Concecionaria",
        Description = "Gestion de stock y vetas",
        Version = "V1",
        Contact = new OpenApiContact
        {
            Name = "Rizzo",
            Email = "rizzo@gmail.com",
            Url = new Uri("https://www.google.com.ar/"),
        },
        License=new OpenApiLicense
        {
            Name="",
            Url= new Uri("https://www.google.com.ar/"),

        }
    });
    

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    variable.IncludeXmlComments(xmlPath);



});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(variable2 => {
        variable2.SwaggerEndpoint("/swagger/V1/swagger.json", "Concecionaria");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
