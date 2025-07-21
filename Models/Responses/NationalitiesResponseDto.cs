using BackendSan.Models.Common;

namespace BackendSan.Models.Responses;

public class NationalitiesResponseDto
{
    public NationalitiesBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}
public class NationalityDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string IsdCode { get; set; }
    public string ThreeLetterCode { get; set; }
}

public class NationalitiesBodyDto
{
    public List<NationalityDto> Nationalities { get; set; }
    public string Default { get; set; }
}

