using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCore
{
    public abstract partial class ViewModelbaseInsideProject : ObservableObject
    {
        [ObservableProperty]
        private bool canSave;

        public abstract void Save();
    }
}
