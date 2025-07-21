namespace BackendSan.Models.Common;

public class MessageDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public int MessageType { get; set; }
    public string Message { get; set; }
}