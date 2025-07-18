namespace BackendSan.Models.Requests;

public class GetOffersRequestDto
{
    public required string SearchId { get; set; }
    public required string OfferId { get; set; }
    public int ProductType { get; set; } = 2;
    public required string ProductId { get; set; }
    public string Currency { get; set; } = "EUR";
    public string Culture { get; set; } = "tr-TR"; 
    public bool GetRoomInfo { get; set; } = true;
}