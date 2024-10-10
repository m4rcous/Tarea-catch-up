using catch_up_platform.sources.Domain.model.Aggregates;
using catch_up_platform.sources.Domain.Services;

namespace catch_up_platform.sources.Application.Internal
{
    public class FavoriteSourceCommandService : IFavoriteSourceCommandService
    {
        // Método para crear una nueva fuente favorita
        public Task Handle(CreateFavoriteSourceCommand command)
        {
            // acá se creará una fuente favorita.
            throw new NotImplementedException();
        }

        // Método para actualizar una fuente favorita existente
        public Task Handle(UpdateFavoriteSourceCommand command)
        {
            // acá se actualizará la fuente favorita
            throw new NotImplementedException();
        }

        // Método para eliminar una fuente favorita
        public Task Handle(DeleteFavoriteSourceCommand command)
        {
            // y acá se eliminará una fuente favorita
            throw new NotImplementedException();
        }
    }
}
