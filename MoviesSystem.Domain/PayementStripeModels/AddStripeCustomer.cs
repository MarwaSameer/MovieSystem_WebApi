namespace MoviesSystem.Domain.PayementStripeModels
{
    public record AddStripeCustomer(
          string Email,
          string Name,
          AddStripeCard CreditCard);
}
