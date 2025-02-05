var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
@*#if (EnableSwaggerSupport)
builder.Services.AddSwaggerGen();
#endif*@
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    @*#if (EnableSwaggerSupport)
    {
    app.UseSwagger();
    app.UseSwaggerUI();
    }
    #endif*@
}
app.UseHttpsRedirection();
await app.RunAsync();

