using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmCore
{
    public abstract partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private bool canSave;

        public abstract void Save();
    }
}