using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    /// <summary>
    /// ファイル情報を表す
    /// </summary>
    public interface IFileInformation
    {
        /// <summary>
        /// 名前を表す
        /// </summary>
        string Name { get; }
   
        /// <summary>
        /// ファイルで自動入力されるような添付情報
        /// </summary>
        IFileLog Log { get; }

        /// <summary>
        /// 拡張子を表す
        /// </summary>
        IExtension Ext { get; }
    }
}
