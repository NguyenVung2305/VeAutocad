using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage.File
{
    internal class FileDiagramLoader: IDiagramLoader
    {
        private readonly string folder;

        public FileDiagramLoader(string folder)
        {
            this.folder = folder ?? throw new ArgumentNullException(nameof(folder));
        }

        public Diagram? Load(string name)
        {
            throw new NotImplementedException();
        }
    }
}
