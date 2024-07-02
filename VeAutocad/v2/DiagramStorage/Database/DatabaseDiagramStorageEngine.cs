using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.Database
{
    internal class DatabaseDiagramStorageEngine : IDiagramStorageEngine
    {
        private readonly string connectionString;

        public DatabaseDiagramStorageEngine(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public IDiagramLoader GetLoader()
        {
            return new DatabaseDiagramLoader(connectionString);
        }

        public IDiagramSaver GetSaver()
        {
            return new DatabaseDiagramSaver(connectionString);
        }
    }
}
