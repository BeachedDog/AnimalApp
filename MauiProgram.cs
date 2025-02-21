using AnimalApp.Components.Data;
using AnimalApp.Components.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
            
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDbContext<AnimalAppContext>(options =>
            options.UseSqlite($"Filename={dbPath}"));

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            builder.Services.AddScoped<WeatherForecastService>();
            builder.Services.AddScoped<AnimalService>();
            return builder.Build();
        }
    }
}

//computer crashed. need to readd in Dbcontext and add it to scope, create Irepository,
//correctly seed databases for class and for animals. some data recovered below. 


//I have made a test database with 5 animals and got it to display to a component. #2 Next I would like to create a real database,
//have it interact with the repository, and send data to the front end. 
//#3 Add business logic and refactor front end,
//#4 expand off the basic to add fun functionality (animal look up, fact games, memory games, possibly a map of the zoo)