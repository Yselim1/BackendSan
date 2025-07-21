namespace BackendSan.Models.Requests;

public class GetOfferDetailsRequestDyo
{
    public List<string> OfferIds { get; set; }
    public string Currency { get; set; }
    public bool GetProductInfo { get; set; }
}