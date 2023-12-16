
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.PayementService;
using Stripe;
namespace MovieSystem.Application
{
    public static class StripeInfrastructure
    {
        public static IServiceCollection AddStripeInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            StripeConfiguration.ApiKey = "sk_test_51NE0UACNZF449nyqfp6kuwdJoXi9cIfOhfnh9ppMIw7lY2uDqecMQOjJUUCHMyAbUA4UmDnidVKvgGEmQJ5JEOmr00tL2LrcHC"; //configuration.GetSection("StripeSettings:SecretKey").ToString();

            return services
                .AddScoped<CustomerService>()
                .AddScoped<ChargeService>()
                .AddScoped<TokenService>()
                .AddScoped<IStripeAppService, StripeAppService>();
        }
    }
}
/*
 * 
 * Data customer for test
 {
  "email": "yoourmail@gmail.com",
  "name": "Christian Schou",
  "creditCard": {
    "name": "Christian Schou",
    "cardNumber": "4242424242424242",
    "expirationYear": "2024",
    "expirationMonth": "12",
    "cvc": "999"
  }
}
 * 
 * Data for payement 
 * 
 {
  "customerId": "cus_OrQ9WFwKvswdFg",
  "receiptEmail": "gharby.mouez@gmail.com",
  "description": "string",
  "currency": "USD",
  "amount": 200
}
 * */