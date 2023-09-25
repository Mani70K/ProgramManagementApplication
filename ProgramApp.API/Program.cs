using Microsoft.EntityFrameworkCore;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Entity.Implementation.InternalVisibleEntity;
using ProgramApp.Database.Entity.Interface;
using ProgramApp.Templates.Implementation.QuestionTemplate;
using ProgramApp.Templates.Implementation.StageTemplate;
using ProgramApp.Templates.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProgramAppDBContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection")));

builder.Services.AddScoped<IInternalVisibleEntity, DOBEntity>();
builder.Services.AddScoped<IInternalVisibleEntity, GenderEntity>();
builder.Services.AddScoped<IInternalVisibleEntity, IDEntity>();
builder.Services.AddScoped<IInternalVisibleEntity, NationalityEntity>();
builder.Services.AddScoped<IInternalVisibleEntity, PhoneNumberEntity>();
builder.Services.AddScoped<IInternalVisibleEntity, ResidenceEntity>();

builder.Services.AddScoped<IQuestionTemplate, DateQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, DropdownQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, FileUploadQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, MultipleChoiceQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, NumberQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, ParagraphQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, ShortAnswerQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, VideoQuestionQuestionTemplate>();
builder.Services.AddScoped<IQuestionTemplate, YesNoQuestionTemplate>();

builder.Services.AddScoped<IStageTemplate, PlacementStageTemplate>();
builder.Services.AddScoped<IStageTemplate, ShortlistingStageTemplate>();
builder.Services.AddScoped<IStageTemplate, VideoInterviewStageTemplate>();

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
