namespace catch_up_platform.sources.Domain.model.Aggregates
{
    /// <summary>
    /// Representa el agregado FavoriteSource, que permite a los usuarios guardar, actualizar y borrar fuentes favoritas.
    /// </summary>
    public class FavoriteSource
    {
        public int Id { get; private set; }
        public string NewsApiKey { get; private set; }
        public string SourceId { get; private set; }

        public FavoriteSource(int id, string newsApiKey, string sourceId)
        {
            Id = id;
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }

        public void UpdateSource(string newsApiKey, string sourceId)
        {
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }

        public void DeleteSource()
        {
            // lógica para eliminar una fuente favorita
        }
    }
}
