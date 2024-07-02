using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.File
{
    internal class FileDiagramSaver : IDiagramSaver
    {
        private readonly string folder;

        public FileDiagramSaver(string folder)
        {
            this.folder = folder ?? throw new ArgumentNullException(nameof(folder));
        }

        public void Save(string name, Diagram diagram)
        {
            throw new NotImplementedException();
        }
    }
}
