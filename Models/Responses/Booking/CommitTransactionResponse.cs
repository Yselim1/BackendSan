using BackendSan.Models.Common;

namespace BackendSan.Models.Responses.Booking;

public class CommitTransactionResponse
{
    public CommitTransactionResponseBody Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class CommitTransactionResponseBody
{
    public string ReservationNumber { get; set; } 
    public string EncryptedReservationNumber { get; set; }
    public string TransactionId { get; set; }
}