using AnimalApp.Components.Data;
using AnimalApp.Components.Repositories;
using AnimalApp.Components.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics; // Required for Debug.WriteLine()
using MudBlazor.Services; 

namespace AnimalApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "AnimalApp.db");

            Debug.WriteLine($"Database Path: {dbPath}");


            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<AnimalAppContext>(options =>
            options.UseSqlite($"Filename={dbPath}"));
            


            using (var scope = builder.Services.BuildServiceProvider().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AnimalAppContext>();
                DataBaseInitializer.Initialize(context);
            }
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();

#endif
            builder.Services.AddScoped<WeatherForecastService>();
            builder.Services.AddScoped<AnimalService>();
            builder.Services.AddScoped<AnimalRepository>();
            return builder.Build();
        }
    }
}

//created CRUD and animal repository. have things connected so that the database is created if it doesn't exist on the machine,
//and displays simple data to the animals page. next need to add buttons and another page to display eveyrthing for a selected animal.
