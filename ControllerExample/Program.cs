var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();// add all the controllers as services

var app = builder.Build();
app.UseRouting();
app.MapControllers();   
app.Run();
