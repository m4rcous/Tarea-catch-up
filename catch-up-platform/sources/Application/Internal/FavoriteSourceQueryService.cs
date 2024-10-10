using catch_up_platform.sources.Domain.model.Aggregates;
using catch_up_platform.sources.Domain.Model.Queries;
using catch_up_platform.sources.Domain.Services;

namespace catch_up_platform.sources.Application.Internal
{
    public class FavoriteSourceQueryService : IFavoriteSourceQueryService
    {
        // Método para obtener una fuente favorita por Id
        public Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            // acá se obtendrá una fuente favorita por su Id
            throw new NotImplementedException();
        }

        // Método para obtener una fuente favorita por NewsApiKey y SourceId
        public Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
            // acá se obtendrá una fuente favorita por ApiKey y SourceId
            throw new NotImplementedException();
        }
    }
}
