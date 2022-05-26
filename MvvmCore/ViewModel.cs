using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ViewModeBase;

namespace MvvmCore 
{
    public partial class ViewModel : ViewModelBase
    {

        [ICommand(CanExecute = nameof(CanSave))]
        public override void Save()
        {
        }
    }
}