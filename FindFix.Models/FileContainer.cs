using FindFix.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Windows
{
    public class FileContainer : FileComponent , IContainer
    {
        public IEnumerable<IComponent> Children { get; private set; }
    }
}
