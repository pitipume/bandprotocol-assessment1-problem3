using TransactionBroadcastAPI.Models;

namespace TransactionBroadcastAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly HttpClient _httpClient;

        public TransactionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TransactionResponse> BroadcastTransactionAsync(TransactionRequest transactionRequest)
        {
            var transactionResponse = await _httpClient.PostAsJsonAsync("https://mock-node-wgqbnxruha-as.a.run.app/broadcast", transactionRequest);
            transactionResponse.EnsureSuccessStatusCode();
            return await transactionResponse.Content.ReadFromJsonAsync<TransactionResponse>();
        }

        public async Task<TransactionStatusReponse> CheckTransactionStatusAsync(string tx_hash)
        {
            var transactionResponse = await _httpClient.GetAsync($"https://mock-node-wgqbnxruha-as.a.run.app/check/{tx_hash}");
            transactionResponse.EnsureSuccessStatusCode();
            return await transactionResponse.Content.ReadFromJsonAsync<TransactionStatusReponse>();
        }
    }
}