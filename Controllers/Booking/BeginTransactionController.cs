using BackendSan.Models.Requests.Booking;
using BackendSan.Models.Responses.Booking;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSan.Controllers.Booking;

[ApiController]
[Route("api/")]
public class BeginTransactionController : BaseApiController
{
    public BeginTransactionController(RelayService relayService) : base(relayService)
    {
    }
    
    [HttpPost("begintransaction")]
    public async Task<IActionResult> BeginTransaction([FromBody] BeginTransactionRequest request)
    {
        var result = await Forward<BeginTransactionResponse>("bookingservice/begintransaction", request);
        return result;
    }
}