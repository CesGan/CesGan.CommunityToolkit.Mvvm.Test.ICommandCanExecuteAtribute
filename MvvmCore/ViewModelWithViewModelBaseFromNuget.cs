using CommunityToolkit.Mvvm.Input;

namespace MvvmCore
{
    internal partial class ViewModelWithViewModelBaseFromNuget : ViewModelBaseInsideProject
    {
        [ICommand(CanExecute = nameof(CanSave))]
        public override void Save()
        {
        }
    }
}
