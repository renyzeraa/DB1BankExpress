using DB1BankExpress.Services;

namespace DB1BankExpress.Configs;

public static class RegisterServices
{
	public static void RegisterMyServices(this IServiceCollection service)
	{
		service.AddScoped<ICustomerService, CustomerService>();
	}
}
