using TestRoomsListTelerik.ViewModels;

namespace TestRoomsListTelerik.Views;

public partial class MainPageOnlyTables : ContentPage
{

  public MainPageOnlyTables()
  {
    InitializeComponent();
    BindingContext = new MainViewModel();
  }

}
