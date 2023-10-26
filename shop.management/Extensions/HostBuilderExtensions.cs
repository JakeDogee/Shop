namespace shop.management.Extensions;

public static class HostBuilderExtensions
{
    public static WebApplicationBuilder SetUpConfigurations(this WebApplicationBuilder builder)
    {
        builder.Configuration.Sources.Clear();

        builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"secrets.json", optional: true)
            .AddEnvironmentVariables();

        return builder;
    }
    
    public static WebApplicationBuilder ConfigureKestrel(this WebApplicationBuilder builder)
    {
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.ListenAnyIP(
                int.TryParse(Environment.GetEnvironmentVariable("HTTP_PORT") ?? "5001", out var httpPort)
                    ? httpPort
                    : 5001);
        });

        return builder;
    }
}