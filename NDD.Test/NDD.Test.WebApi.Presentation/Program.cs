using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NDD.Test.Application.AutoMapper;
using NDD.Test.Application.Handlers;
using NDD.Test.Core.Data;
using NDD.Test.Core.Repository;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Handlers;
using NDD.Test.Domain.Interfaces.Repository;
using NDD.Test.Domain.Validators;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                         sqlServerOptionsAction: sqlOptions =>
                         {
                             sqlOptions.EnableRetryOnFailure();
                         }
    ), ServiceLifetime.Singleton);

builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddTransient<IValidator<Client>, ClientValidation>();
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddAutoMapper(typeof(ConfigurationMapper));

builder.Services.AddMediatR(typeof(CreateClientHandler));
builder.Services.AddMediatR(typeof(DeleteClientHandler));
builder.Services.AddMediatR(typeof(UpdateClientHandler));
builder.Services.AddMediatR(typeof(FindClientByIdHandler));
builder.Services.AddMediatR(typeof(FindClientAllHandler));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
