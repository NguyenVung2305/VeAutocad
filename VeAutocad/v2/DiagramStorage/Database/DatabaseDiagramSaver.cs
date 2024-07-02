using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.Database
{
    internal class DatabaseDiagramSaver : IDiagramSaver
    {
        private readonly string connectionString;

        public DatabaseDiagramSaver(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public void Save(string name, Diagram diagram)
        {
            throw new NotImplementedException();
        }
    }
}
