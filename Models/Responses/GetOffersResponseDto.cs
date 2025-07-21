using BackendSan.Models.Common;

namespace BackendSan.Models.Responses;

//GO- GetOffers
public class GetOffersResponseDto
{
    public GetOffersResponseBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class GetOffersResponseBodyDto
{
    public List<GOOfferDto> Offers { get; set; }
}

public class GOOfferDto : BaseOfferDto
{
    public List<GORoomDto> Rooms { get; set; }
    public List<PriceBreakdownGroupDto>? PriceBreakdowns { get; set; }
    public List<object>? Restrictions { get; set; }
    public List<object>? Warnings { get; set; }
}

public class GORoomDto : BaseRoomDto
{
    public string RoomInfoId { get; set; }
}

public class ThirdPartyInformationDto
{
    public List<object> Infos { get; set; }
}



public class PriceBreakdownGroupDto
{
    public int ProductType { get; set; }
    public List<PriceBreakdownDto> PriceBreakdowns { get; set; }
}

public class PriceBreakdownDto
{
    public string RoomNumber { get; set; }
    public DateTime Date { get; set; }
    public PriceDto Price { get; set; }
}

