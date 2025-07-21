using BackendSan.Models.Common;

namespace BackendSan.Controllers;

public class BaseHotelDto
{
    public GeoLocationDto Geolocation { get; set; }
    public double Stars { get; set; }
    public double Rating { get; set; }
    public HotelCategoryDto HotelCategory { get; set; }
    public bool HasChannelManagerOffer { get; set; }
    public int Provider { get; set; }
    public string Thumbnail { get; set; }
    public string ThumbnailFull { get; set; }
    public DescriptionDto Description { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Themes> Themes { get; set; }
}