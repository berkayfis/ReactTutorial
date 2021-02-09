using System;
using TwitterAPI.Core.UserManagement;

namespace TwitterAPI.Core.Posts
{
    public class PostDto
    {
        //public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        public UserDto User { get; set; }
    }
}
