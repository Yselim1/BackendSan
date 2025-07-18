namespace BackendSan.Models.Responses;

public class GetOffersResponseDto
{
    public GetOffersResponseBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class GetOffersResponseBodyDto
{
    public List<OfferDto> Offers { get; set; }
}

public class OfferDto
{
    public int Night { get; set; }
    public bool IsAvailable { get; set; }
    public int Availability { get; set; }
    public bool AvailabilityChecked { get; set; }
    public List<RoomDto> Rooms { get; set; }
    public bool IsRefundable { get; set; }
    public List<CancellationPolicyDto> CancellationPolicies { get; set; }
    public List<PriceBreakdownGroupDto> PriceBreakdowns { get; set; }
    public bool ThirdPartyOwnOffer { get; set; }
    public List<object> Restrictions { get; set; }
    public List<object> Warnings { get; set; }
    public bool IsChannelManager { get; set; }
    public DateTime ExpiresOn { get; set; }
    public string OfferId { get; set; }
    public DateTime CheckIn { get; set; }
    public PriceDto Price { get; set; }
}

public class RoomDto
{
    public string RoomId { get; set; }
    public string RoomName { get; set; }
    public string BoardId { get; set; }
    public string BoardName { get; set; }
    public List<object> BoardGroups { get; set; }
    public int StopSaleGuaranteed { get; set; }
    public int StopSaleStandart { get; set; }
    public List<TravellerDto> Travellers { get; set; }
    public string RoomInfoId { get; set; }
    public ThirdPartyInformationDto ThirdPartyInformation { get; set; }
    public bool VisiblePL { get; set; }
}

public class TravellerDto
{
    public int Type { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
}

public class ThirdPartyInformationDto
{
    public List<object> Infos { get; set; }
}

public class CancellationPolicyDto
{
    public string RoomNumber { get; set; }
    public DateTime DueDate { get; set; }
    public PriceDto Price { get; set; }
    public int Provider { get; set; }
}

public class PriceDto
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
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

