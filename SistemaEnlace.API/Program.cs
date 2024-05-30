using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.API.Helpers;
using SistemaEnlace.Shared.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Meter un builder services
builder.Services.AddIdentity<User, IdentityRole>(x =>
{
    x.User.RequireUniqueEmail = true;
    x.Password.RequireDigit = false;   //Esto es lo que requiere una contraseña, falso es para crearla normal
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireNonAlphanumeric = false;

}).AddEntityFrameworkStores<DataContext>()
.AddDefaultTokenProviders();


builder.Services.AddScoped<IUserHelper, UserHelper>();




//Fin de los builder metidos
builder.Services.AddSwaggerGen(); builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=DefaultConnection"));

builder.Services.AddTransient<SeedDb>();
var app = builder.Build();
SeedData(app);
void SeedData(WebApplication app)
{
    IServiceScopeFactory? scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (IServiceScope? scope = scopedFactory!.CreateScope())
    {
        SeedDb? service = scope.ServiceProvider.GetService<SeedDb>();
        service!.SeedAsync().Wait();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
//Antes de autorizacion meter este
app.UseAuthorization();

app.MapControllers();   


app.UseCors(x => x

.AllowAnyMethod()
.AllowAnyHeader()
.AllowCredentials()
.SetIsOriginAllowed(origin => true)

);









app.Run();
