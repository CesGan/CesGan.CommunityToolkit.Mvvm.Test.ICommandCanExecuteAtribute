using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ViewModeBase;

namespace MvvmCore 
{
    public partial class ViewModelWithOutsideViewModelBase : ViewModelBaseOutsideProject
    {
        [ICommand(CanExecute = nameof(CanSave))]
        public override void Save()
        {
        }
    }
}