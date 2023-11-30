using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

//dotnet restore
//dotnet build
//dotnet run
//Now listening on: http://127.0.0.1:5000
//docker build -t dipalidocker15/csharp:v1
//docker run -t --name csharp_container dipalidocker15/csharp:v1

