namespace BackendSan.Models.Common;

public class BaseLocationDto
{
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}