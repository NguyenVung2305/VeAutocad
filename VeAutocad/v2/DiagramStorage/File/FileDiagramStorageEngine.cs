using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.File
{
    internal class FileDiagramStorageEngine: IDiagramStorageEngine
    {
        private readonly string folder;

        public FileDiagramStorageEngine(string folder)
        {
            this.folder = folder ?? throw new ArgumentNullException(nameof(folder));
        }

        public IDiagramLoader GetLoader()
        {
            return new FileDiagramLoader(folder);
        }

        public IDiagramSaver GetSaver()
        {
            return new FileDiagramSaver(folder);
        }
    }
}
