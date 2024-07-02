using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.Database
{
    internal class DatabaseDiagramLoader : IDiagramLoader
    {
        private readonly string connectionString;

        public DatabaseDiagramLoader(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public Diagram? Load(string name)
        {
            throw new NotImplementedException();
        }
    }
}
