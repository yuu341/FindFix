using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.Models.Interfaces
{
    /// <summary>
    /// コンポーネントに含まれる情報を表す
    /// </summary>
    public interface IDatum
    {
        /// <summary>
        /// データ自体における情報の管理をする
        /// </summary>
        IFileInformation Information { get; }
        /// <summary>
        /// 名前の設定または変更
        /// </summary>
        string Name { get; }
    }
}
