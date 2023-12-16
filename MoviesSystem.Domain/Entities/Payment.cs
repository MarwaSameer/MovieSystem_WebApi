namespace MoviesSystem.Domain.Entities
{
    public class Payment : BaseEntity
    {

        //public int PaymentId { get; set; }

        public float Amount { get; set; }
        public string Method { get; set; } = string.Empty;
    }
}

