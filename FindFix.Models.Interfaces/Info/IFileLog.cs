using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    /// <summary>
    /// ファイルに関する自動入力されるべき情報を表す
    /// </summary>
    public interface IFileLog
    {

        /// <summary>
        /// 作成者
        /// </summary>
        string CreatedUser { get; }
        /// <summary>
        /// 作成時刻
        /// </summary>
        DateTime CreatedAt { get; }

        /// <summary>
        /// 最終更新者
        /// </summary>
        string LastModifiedUser { get; }
        /// <summary>
        /// 最終更新日
        /// </summary>
        DateTime LastModifiedAt { get; }

    }
}
