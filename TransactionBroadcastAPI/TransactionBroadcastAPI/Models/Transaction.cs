namespace TransactionBroadcastAPI.Models
{
    public class Transaction
    {
        public string? Symbol { get; set; }
        public uint Price { get; set; }
        public uint TimeStamp { get; set; }
    }
}
