namespace TwitterAPI.Core.Context
{
    public class TwitterDatabaseSettings : ITwitterDatabaseSettings
    {
        public string PostsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
