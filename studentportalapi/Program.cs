using Microsoft.EntityFrameworkCore;
using studentportalapi.DataModel;
using studentportalapi.Respository;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
builder.Services.AddDbContext<Studentadmincontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();
builder.Services.AddSwaggerGen();


   builder.Services.AddAutoMapper(typeof(Program).Assembly);
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

IApplicationBuilder applicationBuilder = app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
