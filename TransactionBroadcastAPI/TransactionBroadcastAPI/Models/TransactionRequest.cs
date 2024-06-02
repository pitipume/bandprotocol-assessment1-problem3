namespace TransactionBroadcastAPI.Models
{
    public class TransactionRequest
    {
        public string? Symbol { get; set; }
        public uint Price { get; set; }
        public uint Timestamp { get; set; }
    }
}
