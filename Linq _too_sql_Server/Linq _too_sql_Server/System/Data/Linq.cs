using Linq__too_sql_Server;

namespace System.Data
{
    public class Linq
    {
        public class DataContext
        {
            private IDbConnection connection;
            private Linq.Mapping.MappingSource mappingSource;

            public DataContext(IDbConnection connection, Linq.Mapping.MappingSource mappingSource)
            {
                this.connection = connection;
                this.mappingSource = mappingSource;
            }

            public DataContext(string connection1, Linq.Mapping.MappingSource mappingSource)
            {
                this.mappingSource = mappingSource;
            }
        }

        public class Mapping
        {
            internal class MappingSource
            {
                public static implicit operator MappingSource(AttributeMappingSource v)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}