// GiftWizard.Domain/Entities/GiftProfile.cs
namespace GiftWizard.Domain.Entities;

// Cinsiyet için daha yapısal bir tanım
public enum Gender
{
    Unspecified, // Belirtilmemiş
    Female,      // Kadın
    Male         // Erkek
}

public class GiftProfile
{
    public Guid Id { get; set; }
    public string AgeRange { get; set; }
    public Gender Gender { get; set; } // Cinsiyet eklendi
    public List<string> Interests { get; set; }
    public string? Style { get; set; }
    public string Occasion { get; set; }
    public string Relationship { get; set; } // İlişki türü eklendi
    public string PriceRange { get; set; } // Fiyat aralığı eklendi
}