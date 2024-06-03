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
            try
            {
                if (transactionRequest == null)
                {
                    throw new Exception("Payload not found");
                }
                var transactionResponse = await _httpClient.PostAsJsonAsync("https://mock-node-wgqbnxruha-as.a.run.app/broadcast", transactionRequest);
                transactionResponse.EnsureSuccessStatusCode();
                return await transactionResponse.Content.ReadFromJsonAsync<TransactionResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error, please check your input Payload again: {ex}");
            }
        }

        public async Task<TransactionStatusReponse> CheckTransactionStatusAsync(string tx_hash)
        {
            try
            {
                if (tx_hash == null)
                {
                    throw new Exception("tx_hash not found");
                }
                var transactionResponse = await _httpClient.GetAsync($"https://mock-node-wgqbnxruha-as.a.run.app/check/{tx_hash}");
                transactionResponse.EnsureSuccessStatusCode();
                return await transactionResponse.Content.ReadFromJsonAsync<TransactionStatusReponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error, please check your input tx_hash again: {ex}");
            }
        }
    }
}