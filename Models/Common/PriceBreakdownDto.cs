namespace BackendSan.Models.Common;

public class PriceBreakdownDto
{
    public string RoomNumber { get; set; }
    public DateTime Date { get; set; }
    public PriceDto Price { get; set; }
}