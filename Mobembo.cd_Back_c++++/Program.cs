using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Mobembo.cd_Back_c____;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Service;
using Mobembo.cd_Back_c____.Security;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHttpContextAccessor();
string cnstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mobembo.ce;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
builder.Services.
    AddEntityFrameworkSqlServer()
    .AddDbContext<Context>();

builder.Services.AddScoped<IConstente, Constente>();
builder.Services.AddScoped<ICrudService<PersonneCreateDTO, int>, PersonneService>();
builder.Services.AddScoped<ICrudService<BienDTO, int>, BienService>();
builder.Services.AddScoped<ICrudService<ProvinceDTO, int>, ProvinceService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })

    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constente.SecretToken))
        };
    });


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


