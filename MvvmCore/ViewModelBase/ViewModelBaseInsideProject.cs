using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmCore
{
    public abstract partial class ViewModelBaseInsideProject : ObservableObject
    {
        [ObservableProperty]
        private bool canSave;

        public abstract void Save();
    }
}
