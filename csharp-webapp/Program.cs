using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         CreateHostBuilder(args).Build().Run();
//     }

//     public static IHostBuilder CreateHostBuilder(string[] args) =>
//         Host.CreateDefaultBuilder(args)
//             .ConfigureWebHostDefaults(webBuilder =>
//             {
//                 webBuilder.UseStartup<Startup>();
//                 webBuilder.UseUrls("http://localhost:5000");
//             });
// }



public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseUrls("http://127.0.0.1:5000");

            });
}




// public class Program
// {
//     public static void Main(string[] args)
//     {
//         CreateHostBuilder(args).Build().Run();
//     }

//     public static IHostBuilder CreateHostBuilder(string[] args) =>
//         Host.CreateDefaultBuilder(args)
//             .ConfigureWebHostDefaults(webBuilder =>
//             {
//                 webBuilder.UseStartup<Startup>();
//                 webBuilder.UseUrls("http://0.0.0.0:5000"); // Listen on all network interfaces
//             });
// }
