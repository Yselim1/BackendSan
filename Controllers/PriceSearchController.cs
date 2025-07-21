using BackendSan.Models.Request;
using BackendSan.Models.Requests;
using BackendSan.Models.Responses;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace BackendSan.Controllers
{
    [ApiController]
    [Route("api")]
    public class PriceSearchController : BaseApiController
    {
        public PriceSearchController(RelayService relayService) : base(relayService)
        {

        }
        [HttpPost("hotelPriceSearch")]
        public async Task<IActionResult> HotelPriceSearch(PriceSearchRequestDto requestDto)
        {
            var result = await Forward<PriceSearchResponseDto>("productservice/pricesearch", requestDto);
            
            if (result is OkObjectResult okResult && okResult.Value is PriceSearchResponseDto dto)
            {
                if (dto.Body?.hotels != null)
                {
                    var hotelsToKeep = new List<PSHotelDto>();
                    foreach (var hotel in dto.Body?.hotels ?? new List<PSHotelDto>())
                    {
                        if (hotel.Provider != 0 && hotel.Provider != 1) 
                        {
                            if (hotel.Description != null && !string.IsNullOrEmpty(hotel.Description.Text))
                            {
                                // Remove HTML tags from the hotel description
                                hotel.Description.Text = RemoveHtmlTags(hotel.Description.Text);
                                hotel.Description.Text = hotel.Description.Text.Trim();
                            }
                            hotelsToKeep.Add(hotel); 
                        }
                    }
                    dto.Body.hotels = hotelsToKeep;
                }
                return Ok(dto);
            }
            return result;
        }

        [HttpPost("locationPriceSearch")]
        public async Task<IActionResult> PriceSearch(PriceSearchRequestDto requestDto)
        {
            var result = await Forward<PriceSearchResponseDto>("productservice/pricesearch", requestDto);

            if (result is OkObjectResult okResult && okResult.Value is PriceSearchResponseDto dto)
            {
                if (dto.Body?.hotels != null)
                {
                    var hotelsToKeep = new List<PSHotelDto>();

                    foreach (var hotel in dto.Body?.hotels ?? new List<PSHotelDto>())
                    {
                        if (hotel.Provider != 0 && hotel.Provider != 1) 
                        {
                            if (hotel.Description != null && !string.IsNullOrEmpty(hotel.Description.Text))
                            {
                                // Remove HTML tags from the hotel description
                                hotel.Description.Text = RemoveHtmlTags(hotel.Description.Text);
                                hotel.Description.Text = hotel.Description.Text.Trim();
                            }
                            hotelsToKeep.Add(hotel); 

                        }
                    }
                    dto.Body.hotels = hotelsToKeep;
                }
                return Ok(dto);
            }

            return result;
        }

        public static string RemoveHtmlTags(string htmlString)
        {
            if (string.IsNullOrEmpty(htmlString))
            {
                return htmlString;
            }
            // This regex replaces all occurrences of HTML tags with an empty string
            return Regex.Replace(htmlString, "<[^>]*>", string.Empty);
        }


    }
}
