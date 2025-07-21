using BackendSan.Models.Common;

namespace BackendSan.Models.Responses;

public class CurrenciesResponseDto
{
    public CurrenciesBodyDto Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class CurrencyDto
{
    public string Code { get; set; }
    public string InternationalCode { get; set; }
    public string IconText { get; set; }
    public string Name { get; set; }
}

public class CurrenciesBodyDto
{
    public List<CurrencyDto> Currencies { get; set; }
}