namespace BackendSan.Models.Common;

public class FacilityCategoryDto
{
    public string Name { get; set; }
    public List<FacilityDto> Facilities { get; set; }
}

public class FacilityDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool IsPriced { get; set; }
}