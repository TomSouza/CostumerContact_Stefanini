using Dapper;
using System.Collections.Generic;
using System.Configuration;

namespace CustomerContact.Service
{
    public class Classification
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class ClassificationRepository : BaseRepository
    {
        public ClassificationRepository()
            : base(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString) { }

        public IEnumerable<Classification> GetAll()
        {
            return this.connection.Query<Classification>("select Id, Name from Classification");
        }
    }
}
