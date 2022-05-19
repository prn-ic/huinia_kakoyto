using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<AnswerContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<CommentariesContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<EvaluationContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<FriendsContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<NotificationContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<PreviewContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<RecentlyViewedContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<RequestFriendContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<StatusContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<SupportsContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<VideosContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<VideosStatusContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));

builder.Services.AddDbContext<ViewingDynamicContext>(options =>
    options.UseSqlite("Data Source=db/AniFull.db"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
