namespace BackendSan.Models.Responses;

public class HeaderDto
{
    public string RequestId { get; set; }
    public bool Success { get; set; }
    public DateTime ResponseTime { get; set; }
    public List<MessageDto> Messages { get; set; }
}