using Microsoft.AspNetCore.Mvc;
using TransactionBroadcastAPI.Models;
using TransactionBroadcastAPI.Services;

namespace TransactionBroadcastAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("broadcast")]
        public async Task<IActionResult> BroadcastTransaction(TransactionRequest transactionRequest)
        {
            var response = await _transactionService.BroadcastTransactionAsync(transactionRequest);
            return Ok(response);
        }

        [HttpGet("check/{tx_hash}")]
        public async Task<IActionResult> CheckTransactionStatus(string tx_hash)
        {
            var response = await _transactionService.CheckTransactionStatusAsync(tx_hash);
            return Ok(response);
        }
    }
}