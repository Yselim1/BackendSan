using BackendSan.Models.Requests.Booking;
using BackendSan.Models.Responses.Booking;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSan.Controllers.Booking;

[ApiController]
[Route("api/")]
public class CommitTransactionController : BaseApiController
{
    public CommitTransactionController(RelayService relayService) : base(relayService)
    {
    }
    
    [HttpPost("committransaction")]
    public async Task<IActionResult> CommitTransaction([FromBody] CommitTransactionRequest request)
    {
        var result = await Forward<CommitTransactionResponse>("bookingservice/committransaction", request);
        return result;
    }
}