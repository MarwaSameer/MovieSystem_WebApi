namespace MoviesSystem.Domain.PayementStripeModels
{
    public record StripeCustomer(
         string Name,
         string Email,
         string CustomerId);
}
