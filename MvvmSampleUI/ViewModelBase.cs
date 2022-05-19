using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmSampleUI
{
    public abstract partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private bool canSave;

        public abstract void Save();
    }
}