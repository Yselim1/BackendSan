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
}

public class SeasonDto
{
    public string Name { get; set; }
    public List<TextCategoryDto> TextCategories { get; set; }
    public List<MediaFileDto> MediaFiles { get; set; }
}

public class TextCategoryDto
{
    public string Name { get; set; }
    public List<PresentationDto> Presentations { get; set; }
}

public class PresentationDto
{
    public int TextType { get; set; }
    public string Text { get; set; }
}

public class MediaFileDto
{
    public int FileType { get; set; }
    public string Url { get; set; }
    public string UrlFull { get; set; }
}

public class AddressDto
{
    public BaseCityDto City { get; set; }
    public List<string> AddressLines { get; set; }
    public GeoLocationDto Geolocation { get; set; }
}







