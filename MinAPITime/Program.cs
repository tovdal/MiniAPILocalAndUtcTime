using Scalar.AspNetCore;
using static MinAPITime.Data.LocalandUtcTime;

namespace MinAPITime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Dessa ska alltid finnas, även i Production:
            app.MapOpenApi();
            app.MapScalarApiReference();

            var LocalAndUtcTimes = new List<LocalAndUtcTime>
            {
                new LocalAndUtcTime(DateTime.UtcNow, DateTime.Now)
            };

            app.MapGet("/now", () => LocalAndUtcTimes);

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
