using catch_up_platform.sources.Domain.model.Aggregates;

namespace catch_up_platform.sources.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task Handle(CreateFavoriteSourceCommand command);
        Task Handle(UpdateFavoriteSourceCommand command);
        Task Handle(DeleteFavoriteSourceCommand command);
    }

    public record CreateFavoriteSourceCommand(int Id, string NewsApiKey, string SourceId);
    public record UpdateFavoriteSourceCommand(int Id, string NewsApiKey, string SourceId);
    public record DeleteFavoriteSourceCommand(int Id);
}
