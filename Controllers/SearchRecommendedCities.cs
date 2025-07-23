using BackendSan.Models.Request;
using BackendSan.Models.Responses;
using BackendSan.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSan.Controllers
{
    [ApiController]
    [Route("api")]
    public class SearchRecommendedCitiesController : BaseApiController
    {
        public SearchRecommendedCitiesController(RelayService relayService) : base(relayService)
        {

        }

        [HttpPost("searchrecommendedcities")]
        public async Task<IActionResult> SearchRecommendedCities([FromQuery] string recommendedCity)
        {
            var autocompleteRequest = new GetArrivalAutocompleteRequestDto
            {
                ProductType = (int)SearchSuggestionType.Hotel,
                Query = recommendedCity,
                Culture = "tr-TR" 
            };
            
            var autocompleteresult = await Forward<GetArrivalAutocompleteResponseDto>("productservice/getarrivalautocomplete", autocompleteRequest);

            List<BackendSearchItem> filteredHotels = new();
            
            if (autocompleteresult is OkObjectResult okResult && okResult.Value is GetArrivalAutocompleteResponseDto dto)
            {
                if (dto.Body?.Items != null)
                {
                    filteredHotels = dto.Body.Items.Where(item => item.Type == (int)SearchSuggestionType.Hotel)
                        .ToList();
                    filteredHotels = filteredHotels.Where(item => item.City?.Name?.ToLower() == autocompleteRequest.Query.ToLower()
                        || item.Hotel?.Name?.ToLower() == autocompleteRequest.Query.ToLower())
                        .Take(10)
                        .ToList();
                }
                
                return Ok(filteredHotels);


            }
            return autocompleteresult;

        }

    }
}
