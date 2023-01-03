using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu.Entities;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.Menu;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinnerIds = new();
    private readonly List<MenuReviewId> _reviewIds = new();

    public string Name { get; } = null!;
    public string Description { get; } = null!;
    public float AverageRating { get; }

    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
    public HostId HostId { get; } = null!;

    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> ReviewsIds => _reviewIds.AsReadOnly();

    public DateTime CreatedDateTime { get; } = DateTime.UtcNow;
    public DateTime UpdatedDateTime { get; } = DateTime.UtcNow;

    public Menu(
        List<MenuSection> sections,
        List<DinnerId> dinnerIds,
        List<MenuReviewId> reviewIds,
        string name,
        string description,
        float averageRating,
        HostId hostId,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(MenuId.CreateUnique())
    {
        _sections = sections;
        _dinnerIds = dinnerIds;
        _reviewIds = reviewIds;
        Name = name;
        Description = description;
        AverageRating = averageRating;
        HostId = hostId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }
}