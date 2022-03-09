// <copyright file="Program.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using RoccoGraphQL.GraphQL;
using RoccoGraphQL.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = builder.Configuration;
builder.Services.AddPersistenceServices(configuration);

// add company schema
builder.Services.AddScoped<CompanyQuery>();
builder.Services.AddScoped<ISchema, CompanySchema>(services => new CompanySchema(new SelfActivatingServiceProvider(services)));
 

// register graphQL 
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;

})
.AddDataLoader() // To improve performance using cache in data
.AddSystemTextJson()
.AddErrorInfoProvider(opt =>
                opt.ExposeExceptionStackTrace = true // Set to false to ommit "extension" in the reponse
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("*")
                   .AllowAnyHeader();
        });
});

// default setup
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "GraphQLNetExample", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GraphQLNetExample v1"));

    // add playground UI to development only   
    app.UseGraphQLPlayground();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

// make sure all our schemas registered to route
app.UseGraphQL<ISchema>();

app.Run();
