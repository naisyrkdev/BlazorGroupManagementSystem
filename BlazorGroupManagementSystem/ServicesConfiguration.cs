
namespace BlazorGroupManagementSystem;
using MudBlazor.Services;

public static class ServicesConfiguration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddMudServices();

        return services;
    }
}
