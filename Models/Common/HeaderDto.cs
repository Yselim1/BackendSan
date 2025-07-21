namespace BackendSan.Models.Common;

public class HeaderDto
{
    public string RequestId { get; set; }
    public bool Success { get; set; }
    public DateTime ResponseTime { get; set; }
    public List<MessageDto> Messages { get; set; }
}