using CommunityToolkit.Mvvm.ComponentModel;

namespace TestRoomsListTelerik.ViewModels;

  public partial class BaseViewModel : ObservableObject
  {
      public BaseViewModel()
      {

      }

      [ObservableProperty]
      [NotifyPropertyChangedFor(nameof(IsNotBusy))]
      bool isBusy;

      public bool IsNotBusy => !IsBusy;
  }