// GiftWizard.Application/Abstractions/IAiService.cs
using GiftWizard.Domain.Entities; // GiftProfile'ı kullanmak için

namespace GiftWizard.Application.Abstractions;

public interface IAiService
{
    Task<string> GetGiftIdeasAsSingleTextAsync(GiftProfile profile);
}