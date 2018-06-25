using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    /// <summary>
    /// エディターに対するアクセスをする
    /// 
    /// </summary>
    public interface IEditor
    {
        /// <summary>
        /// エディターの名前
        /// </summary>
        string Name { get; }
    }
}
