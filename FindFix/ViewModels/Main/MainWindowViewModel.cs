using FindFix.Models.Interfaces;
using FindFix.ViewModels.Main;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFix.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel(IEnumerable<TreeContent> contents)
        {
            Contents = new ObservableCollection<TreeContent>(contents);
        }
        
        public IEnumerable<IDatum> Data { get; set; }
        /// <summary>
        /// ツリーアイテムを表す
        /// </summary>
        public ObservableCollection<TreeContent> Contents { get; }
    }
}
