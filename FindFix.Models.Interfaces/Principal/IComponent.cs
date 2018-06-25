using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    public interface IComponent
    {
        /// <summary>
        /// 内部に保持している情報
        /// </summary>
        IDatum Data { get; }
    }
}
