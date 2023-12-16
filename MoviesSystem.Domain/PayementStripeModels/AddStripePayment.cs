namespace MoviesSystem.Domain.PayementStripeModels

{
    public record AddStripePayment(
         string CustomerId,
         string ReceiptEmail,
         string Description,
         string Currency,
         long Amount);
}
