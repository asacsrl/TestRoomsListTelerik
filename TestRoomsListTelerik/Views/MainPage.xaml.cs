using TestRoomsListTelerik.ViewModels;

namespace TestRoomsListTelerik.Views;

public partial class MainPage : ContentPage
{

  public MainPage()
  {
    BindingContext = new MainViewModel();

    InitializeComponent();
  }

}
