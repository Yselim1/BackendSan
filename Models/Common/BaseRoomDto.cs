using BackendSan.Models.Responses;

namespace BackendSan.Models.Common;

public class BaseRoomDto
{
    public string RoomId { get; set; }
    public string RoomName { get; set; }
    public string BoardId { get; set; }
    public string BoardName { get; set; }
    public List<BoardDto> BoardGroups { get; set; }
    public int StopSaleGuaranteed { get; set; }
    public int StopSaleStandart { get; set; }
    public List<TravellerDto> Travellers { get; set; }
    public ThirdPartyInformationDto ThirdPartyInformation { get; set; }
    public bool VisiblePL { get; set; }
}