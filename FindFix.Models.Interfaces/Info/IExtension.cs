using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    /// <summary>
    /// 拡張子を表す
    /// </summary>
    public interface IExtension
    {
        /// <summary>
        /// 拡張子の実態（.は省略）
        /// </summary>
        string Suffix { get; set; }
        
        IEditor Editor { get; set; }
    }
}
