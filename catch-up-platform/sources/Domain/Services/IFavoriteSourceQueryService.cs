using catch_up_platform.sources.Domain.model.Aggregates;
using catch_up_platform.sources.Domain.Model.Queries;

namespace catch_up_platform.sources.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
        Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    }
}
