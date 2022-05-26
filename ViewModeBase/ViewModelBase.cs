using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModeBase
{
    public abstract partial class ViewModelBase : ObservableObject
    {

        [ObservableProperty]
        private bool canSave;

        public abstract void Save();
    }
}