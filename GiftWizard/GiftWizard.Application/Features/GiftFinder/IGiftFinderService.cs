// GiftWizard.Application/Features/GiftFinder/IGiftFinderService.cs
using GiftWizard.Application.Features.GiftFinder.Dtos;

namespace GiftWizard.Application.Features.GiftFinder;

public interface IGiftFinderService
{
    Task<List<GiftSuggestionDto>> GetSuggestionsAsync(GiftProfileDto profileDto);
}