namespace BackendSan.Models.Requests.Booking;

public class BeginTransactionRequest
{
    public List<string> OfferIds { get; set; }
    public string Currency { get; set; }
    public string Culture { get; set; }
}