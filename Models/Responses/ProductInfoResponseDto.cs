using BackendSan.Controllers;
using BackendSan.Models.Common;

namespace BackendSan.Models.Responses;

//PI - ProductInfo
public class ProductInfoResponseDto
{
    public ProductInfoBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class ProductInfoBodyDto
{
    public PIHotelDto Hotel { get; set; }
}


public class PIHotelDto : BaseHotelDto
{
    public List<SeasonDto> Seasons { get; set; }
    public AddressDto Address { get; set; }
    public string FaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string HomePage { get; set; }
    public int StopSaleGuaranteed { get; set; }
    public int StopSaleStandart { get; set; }
    public List<object> Handicaps { get; set; }
    public BaseLocationDto Location { get; set; }
    public BaseLocationDto Country { get; set; }
    public BaseLocationDto City { get; set; }
    public bool HasChannelManagerOffer { get; set; }
    public int Provider { get; set; }
}

public class AddressDto
{
    public BaseCityDto City { get; set; }
    public List<string> AddressLines { get; set; }
    public GeoLocationDto Geolocation { get; set; }
}







