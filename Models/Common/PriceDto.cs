namespace BackendSan.Models.Common;

public class PriceDto
{
    public decimal? OldAmount { get; set; }
    public decimal? Percent { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}