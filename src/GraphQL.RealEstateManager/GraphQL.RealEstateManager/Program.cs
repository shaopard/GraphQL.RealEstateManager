using GraphiQl;
using GraphQL.AspNet.Configuration;
using GraphQL.RealEstateManager.Extensions;
using GraphQL.Types;
using GraphQL;
using System.Reflection;
using GraphQL.RealEstateManager.Schema;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterDITypes();

// functioneaza cu Queryes si Types
builder.Services.AddGraphQL(options => options
    .AddSchema<RealEstateSchema>()
    .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = builder.Environment.IsDevelopment())
    .AddGraphTypes(Assembly.GetExecutingAssembly())
    .AddSystemTextJson());

// functioneaza cu controllere care edting GraphController
//builder.Services.AddGraphQL();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseGraphiQl();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// functioneaza cu Queryes si Types
app.UseGraphQL<ISchema>();

// functioneaza cu controllere care edting GraphController
//app.UseGraphQL();
app.Run();
