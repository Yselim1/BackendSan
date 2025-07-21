namespace BackendSan.Models.Common;

public class BaseOfferDto
{
    public int Night { get; set; }
    public bool IsAvailable { get; set; }
    public int Availability { get; set; }
    public bool AvailabilityChecked { get; set; }
    public bool IsRefundable { get; set; }
    public List<CancellationPolicyDto> CancellationPolicies { get; set; }
    public bool ThirdPartyOwnOffer { get; set; }
    public bool IsChannelManager { get; set; }
    public DateTime ExpiresOn { get; set; }
    public string OfferId { get; set; }
    public DateTime CheckIn { get; set; }
    public PriceDto Price { get; set; }
}