namespace BackendSan.Models.Common;

public class CancellationPolicyDto
{
    public string RoomNumber { get; set; }
    public DateTime DueDate { get; set; }
    public PriceDto Price { get; set; }
    public int Provider { get; set; }
}