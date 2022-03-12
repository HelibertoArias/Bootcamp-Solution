// <copyright file="Program.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using RoccoGraphQL.GraphQL.Features.Companies;
using RoccoGraphQL.GraphQL.Features.Companies.Messaging;
using RoccoGraphQL.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = builder.Configuration;
builder.Services.AddPersistenceServices(configuration);

// add company schema
builder.Services.AddScoped<CompanyQuery>();
builder.Services.AddScoped<ISchema, CompanySchema>(services => new CompanySchema(new SelfActivatingServiceProvider(services)));
builder.Services.AddSingleton<CompanyMessageService>();

// register graphQL 
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;
    

})
    .AddGraphTypes(ServiceLifetime.Scoped)
 

.AddSystemTextJson()
.AddErrorInfoProvider(opt =>
                opt.ExposeExceptionStackTrace = true // Set to false to ommit "extension" in the reponse
).AddDataLoader() // To improve performance using cache in data
.AddWebSockets();

builder.Services.AddCors();
//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(
//        builder =>
//        {
//            builder.WithOrigins("*")
//                   .AllowAnyHeader()
//                   .AllowAnyMethod();
//        });
//});

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
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GraphQLNetExample v1"));

  
}

app.UseHttpsRedirection();

app.UseCors();

app.UseWebSockets();
app.UseGraphQLWebSockets<CompanySchema>(path: "/graphql");
app.UseGraphQL<ISchema>();
// add playground UI to development only   
app.UseGraphQLPlayground(new PlaygroundOptions() { GraphQLEndPoint = "/graphql" }, path: "/ui/playground");

app.UseAuthorization();


app.Run();
