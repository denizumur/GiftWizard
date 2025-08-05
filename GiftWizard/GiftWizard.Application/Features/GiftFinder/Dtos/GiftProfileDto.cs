// GiftWizard.Application/Features/GiftFinder/Dtos/GiftProfileDto.cs
namespace GiftWizard.Application.Features.GiftFinder.Dtos;

public class GiftProfileDto
{
    public string AgeRange { get; set; }
    public int Gender { get; set; } // Frontend'den 0, 1, 2 gibi bir sayı alacağız
    public List<string> Interests { get; set; }
    public string? Style { get; set; }
    public string Occasion { get; set; }
    public string Relationship { get; set; }
    public string PriceRange { get; set; }
}