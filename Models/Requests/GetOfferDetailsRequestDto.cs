namespace BackendSan.Models.Requests;

public class GetOfferDetailsRequestDto
{
    public List<string> OfferIds { get; set; }
    public string Currency { get; set; }
    public bool GetProductInfo { get; set; }
}