using BackendSan.Models.Requests.Booking;
using BackendSan.Models.Responses.Booking;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSan.Controllers.Booking;

[ApiController]
[Route("api/")]
public class SetReservasitonInfoController : BaseApiController
{
    public SetReservasitonInfoController(RelayService relayService) : base(relayService)
    {
    }
    
    [HttpPost("setreservasitoninfo")]
    public async Task<IActionResult> SetReservationInfo([FromBody] SetReservationInfoRequest request)
    {
        var result = await Forward<SetReservationInfoResponse>("bookingservice/setreservationinfo", request);
        return result;
    }
    
}