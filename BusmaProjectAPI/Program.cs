using BusmaProjectAPI.Data;
using BusmaProjectAPI.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*******************Add Mvc*********************/
builder.Services.AddMvc(
    Options => Options.EnableEndpointRouting = false
    ).AddXmlSerializerFormatters();
/*********************end Mvc*******************/

/*****************Start Add Identity *******************/
builder.Services.AddIdentity<Account, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
/*****************end Add Identity *******************/


/********start ConnectionStrings*********/
builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings"));
});

/********end ConnectionStrings*********/

#endregion

#region app

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
    app.UseSwagger();
    app.UseSwaggerUI();
    }
app.UseMvcWithDefaultRoute();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
