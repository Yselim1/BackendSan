using BackendSan.Models.Common;

namespace BackendSan.Models.Responses;
//GOD _ GetOfferDetail
public class GetOfferDetailsResponseDto
{
    public OfferDetailResponseBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class OfferDetailResponseBodyDto
{
    public List<OfferDetailDto> OfferDetails { get; set; }
}

public class OfferDetailDto
{
    public string OfferId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public DateTime ExpiresOn { get; set; }
    public bool IsAvailable { get; set; }
    public int Availability { get; set; }
    public bool IsRefundable { get; set; }
    public bool IsSpecial { get; set; }
    public string? Notes { get; set; }
    public PriceDto Price { get; set; }
    public List<CancellationPolicyDto> CancellationPolicies { get; set; }
    public List<PriceBreakdownDto> PriceBreakdowns { get; set; }
    public ThirdPartyInformationDto ThirdPartyInformation { get; set; }
    public ReservableInfoDto ReservableInfo { get; set; }
    public List<GODHotelDto> Hotels { get; set; }
}

public class GODHotelDto : BaseHotelDto
{
    public BaseLocationDto Location { get; set; }
    public GODCountryDto Country { get; set; }
    public GODCityDto City { get; set; }
    public GiataInfoDto GiataInfo { get; set; }
    public List<SeasonDto> Seasons { get; set; }
    public List<RoomDetailDto> Rooms { get; set; }
    public List<OfferInHotelDto> Offers { get; set; }
    public GODAddressDto Address { get; set; }
    public string? FaxNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public string? HomePage { get; set; }
    public int StopSaleGuaranteed { get; set; }
    public int StopSaleStandart { get; set; }
    public List<object> Handicaps { get; set; } = new List<object>();
    public bool HasChannelManagerOffer { get; set; }
    public int Provider { get; set; } 
 }

public class GODCityDto : BaseCityDto
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Id  { get; set; }
}

public class ReservableInfoDto
{
    public bool Reservable { get; set; }
}

public class GODAddressDto
{
    public BaseCityDto City { get; set; }
    public List<string> AddressLines { get; set; }
    public GeoLocationDto Geolocation { get; set; }
    public string ZipCode { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
}

public class RoomDetailDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string RoomSize { get; set; }
    public string MaxAdult { get; set; } 
    public List<string> BedOptions { get; set; }
    public List<PresentationDto> Presentations { get; set; }
    public List<FacilityDto> Facilities { get; set; }
    public List<MediaFileDto> MediaFiles { get; set; }
}

public class GODCountryDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
}

public class OfferInHotelDto
{
    public bool IsAvailable { get; set; }
    public int Availability { get; set; }
    public bool IsRefundable { get; set; }
    public bool IsChannelManager { get; set; }
    public List<RoomInHotelOfferDto> Rooms { get; set; }
    public List<object> Restrictions { get; set; } // You can replace `object` with a proper DTO if known
}

public class RoomInHotelOfferDto
{
    public string RoomId { get; set; }
    public string RoomName { get; set; }
    public string BoardId { get; set; }
    public string BoardName { get; set; }
    public List<TravellerDto> Travellers { get; set; }
    public string RoomInfoId { get; set; }
    public ThirdPartyInformationDto ThirdPartyInformation { get; set; }
    public bool VisiblePL { get; set; }
}

