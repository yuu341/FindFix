using FindFix.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Windows
{
    public class FileComponent : IComponent
    {
        public IDatum Data { get; set; }
    }
}
