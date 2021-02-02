namespace TwitterAPI.Core.Context
{
    public interface ITwitterDatabaseSettings
    {        
        string PostsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
