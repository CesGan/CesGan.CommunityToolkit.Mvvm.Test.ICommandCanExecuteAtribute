using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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