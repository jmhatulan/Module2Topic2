using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace TwitterClone.App_Code.Posts
{
    public class PostRepository
    {
        //public IEnumerable<Post> GetAllPosts()
        //{


        //        return new List<Post>()
        //    {
        //        new Post(){ Content = "Hello World", PostedBy = "joblipat"},
        //        new Post(){ Content = "Hello new World", PostedBy = "joelee" },
        //        new Post(){ Content = "Hello new new World" , PostedBy = "jimlim"},
        //        new Post(){ Content = "Hi World" , PostedBy = "joblipat"}
        //   };
        //}
        public IEnumerable<Post> GetAllPosts()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IT114L-B54-22\source\repos\TwitterClone\TwitterClone\App_Data\TwitterClone.mdf;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText =
                    "SELECT * " +
                    "FROM Posts " +
                    "ORDER BY postedOn DESC";
                return command
                    .ExecuteReader()
                    .Cast<IDataRecord>()
                    .Select(row => new Post()
                    {
                        Content = (string)row["content"],
                        PostedBy = (string)row["postedBy"]
                    })
                    .ToList();
            }
        }
    }
}