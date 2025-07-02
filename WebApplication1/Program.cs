
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using OpenTelemetry.Exporter;
using OpenTelemetry.Logs;
using System.Text;
using System.Threading.RateLimiting;
using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Extensions;
using WebApplication1.Filters;
using WebApplication1.Models;
using WebApplication1.Repository;

using WebApplication1.UserManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddOpenTelemetry(x => x.AddConsoleExporter());
// Add services to the container.
builder.Configuration.AddJsonFile("secret.json", optional: true, reloadOnChange: true);
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.AddServerHeader = false; // This prevents Kestrel from adding the "Server" header
});
builder.Services.AddScoped<LoggerFilter>();
builder.Services.AddControllers(config =>
{
   
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters()
.AddApplicationPart(typeof(WebApplication1.Presentation.AssemblyReference).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();
builder.Services.AddFluentEmails();
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly, includeInternalTypes:true);

builder.Services.ConfigureRepositoryManager();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddSingleton<TokenProvider>();
builder.Services.ConfigureServiceManager();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddRateLimiter(options =>
{
    options.AddPolicy("fixed-by-ip", httpContext =>
        RateLimitPartition.GetFixedWindowLimiter(
            partitionKey: httpContext.Connection.RemoteIpAddress?.ToString(),
            factory: _ => new FixedWindowRateLimiterOptions
            {
                PermitLimit = 3,
                Window = TimeSpan.FromSeconds(10)
            }));
});
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<User, IdentityRole>(options =>
    {
        // Optional: Configure Identity options here, e.g., password requirements, lockout settings
        options.SignIn.RequireConfirmedAccount = false; // Set to true if you need email confirmation
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>() // Links Identity to your DbContext
    .AddDefaultTokenProviders();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme; // Optional, often set for consistency
    })
    .AddJwtBearer(options =>
    {  
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true, 
            ValidateAudience = true, // Validate the recipient of the token
            ValidateLifetime = true, // Validate the to ken's expiry
            ValidateIssuerSigningKey = true, // Validate the signature key
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            // The Secret key should be used for IssuerSigningKey
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtSettings:Secret").Value)),
            
            


        };
    });

var app = builder.Build();

app.ConfigureExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRateLimiter();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();




