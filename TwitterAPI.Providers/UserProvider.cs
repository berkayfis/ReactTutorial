using MongoDB.Driver;
using MongoDB.Driver.Linq;
using TwitterAPI.Core.Context;
using TwitterAPI.Core.UserManagement;

namespace TwitterAPI.Providers
{
    public class UserProvider : IUserProvider
    {
        private IMongoCollection<User> Users;
        public UserProvider(ITwitterDatabaseSettings settings )
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Users = database.GetCollection<User>("users");
        }
        public User GetCurrentUser()
        {
            var randUser = Users.AsQueryable().Sample(1).FirstOrDefault();
            return randUser;
        }
    }
}
