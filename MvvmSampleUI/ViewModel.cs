using CommunityToolkit.Mvvm.Input;
using MvvmCore;

namespace MvvmSampleUI
{
    public partial class ViewModel : ViewModelBase
    {
        [ICommand(CanExecute = nameof(CanSave))]
        public override void Save()
        {
        }
    }
}