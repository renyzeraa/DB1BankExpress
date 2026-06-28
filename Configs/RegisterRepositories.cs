using DB1BankExpress.Repositories;

namespace DB1BankExpress.Configs;

public static class RegisterRepositories
{
	public static void RegisterMyRepositories(this IServiceCollection service)
	{
		service.AddScoped<ICustomerRepository, CustomerRepository>();
	}
}
