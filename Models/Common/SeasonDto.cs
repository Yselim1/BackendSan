namespace BackendSan.Models.Common;

public class SeasonDto
{
    public string Name { get; set; }
    public List<TextCategoryDto> TextCategories { get; set; }
    public List<MediaFileDto> MediaFiles { get; set; }
    public List<FacilityCategoryDto>? FacilityCategories { get; set; } 
}

public class TextCategoryDto
{
    public string Name { get; set; }
    public List<PresentationDto> Presentations { get; set; }
}

public class PresentationDto
{
    public int TextType { get; set; }
    public string Text { get; set; }
}

public class MediaFileDto
{
    public int FileType { get; set; }
    public string Url { get; set; }
    public string UrlFull { get; set; }
}

