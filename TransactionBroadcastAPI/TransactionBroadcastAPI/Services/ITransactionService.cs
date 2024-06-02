using TransactionBroadcastAPI.Models;

namespace TransactionBroadcastAPI.Services
{
    public interface ITransactionService
    {
        Task<TransactionResponse> BroadcastTransactionAsync(TransactionRequest transactionRequest);
        Task<TransactionStatusReponse> CheckTransactionStatusAsync(string tx_hash);
    }
}
