using BackendSan.Controllers;
using BackendSan.Models.Common;

namespace BackendSan.Models.Responses

//PS - PriceSearch
{
    public class PriceSearchResponseDto
    {
        public PriceSearchResponseBody? Body { get; set; }
        public HeaderDto? Header { get; set; } 
    }

    public class PriceSearchResponseBody
    {
        public string searchId { get; set; }
        public DateTime expiresOn { get; set; }
        public List<PSHotelDto> hotels { get; set; } 


    }

    public class PSHotelDto : BaseHotelDto
    {
        public List<FacilitiesDTO> Facilities { get; set; }
        public PSLocationDto Location { get; set; }
        public CountryDTO Country { get; set; }
        public PSCityDto City { get; set; }
        public GiataInfoDto GiataInfo { get; set; } // giata hotel id and destination id
        public List<PSOfferDto> Offers { get; set; } 
        public string Address { get; set; }
        public List<BoardDto> BoardGroups { get; set; }
        public List<BoardDto> Boards { get; set; } 
        public List<BadgeDTO> Badges { get; set; }
        public int OrderNumber { get; set; }
        public string OriginalName { get; set; }
        public bool HasThirdPartyOwnOffer { get; set; } // true if the hotel has an own offer from a third party channel manager
        public string Code { get; set; }
    }
    public class BadgeDTO
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    
    public class FacilitiesDTO
    {
        public bool isPriced { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }
   
    public class  PSLocationDto : BaseLocationDto
    {
        public string CountryId { get; set; }
    }

    public class CountryDTO
    {
        public string internationalCode { get; set; }
        public string name { get; set; }
        public int provider { get; set; }
        public bool isTopRegion { get; set; }
        public bool ownLocation { get; set; }
    }
    public class PSCityDto : BaseCityDto
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Id  { get; set; }
    }

    public class  PSOfferDto : BaseOfferDto
    {
        public List<PSRoomDto> Rooms { get; set; }
        public bool? OwnOffer { get; set; } 
        public int? Provider { get; set; } // 1 for backend, 2 for channel manager
    }
    
    public class  PSRoomDto : BaseRoomDto
    {
        public int PartNo { get; set; }
        public List<object>? RoomGroups { get; set; } // list of room groups
        public string AccomId { get; set; }
        public string AccomName { get; set; }
        public int Allotment { get; set; }
        public Spo Spo { get; set; }
        public PriceDto Price { get; set; }
    }

    public class  Spo  // indirim
    {
        public PriceDto price { get; set; }
        public List<Items> items { get; set; }
    }
    public class Items
    {
        public int productType { get; set; } // 1 for hotel, 2 for flight
        public PriceDto price { get; set; }
    }
    
   
}
