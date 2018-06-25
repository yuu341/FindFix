using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    public interface IContainer : IComponent
    {
        IEnumerable<IComponent> Children { get; }
    }
}
