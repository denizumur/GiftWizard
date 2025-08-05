// GiftWizard.Application/Features/GiftFinder/Dtos/GiftSuggestionDto.cs
namespace GiftWizard.Application.Features.GiftFinder.Dtos;

public class GiftSuggestionDto
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductImageUrl { get; set; }
    public decimal Price { get; set; }
    public string Reasoning { get; set; } // Gemini'nin "Neden bu ürün?" sorusuna cevabı
}