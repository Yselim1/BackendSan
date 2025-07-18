using BackendSan.Models.Requests;
using BackendSan.Models.Responses;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSan.Controllers;

[ApiController]
[Route("api")]
public class OffersController : BaseApiController
{
    public OffersController(RelayService relayService) : base(relayService) { }
    
    [HttpPost("getoffers")]
    public async Task<IActionResult> GetOffers([FromBody] GetOffersRequestDto request)
    {
        var result = await Forward<GetOffersResponseDto>("productservice/getoffers", request);
        return result;
    }
}