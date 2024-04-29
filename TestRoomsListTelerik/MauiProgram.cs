using Telerik.Maui.Controls.Compatibility;
using TestRoomsListTelerik.ViewModels;
using TestRoomsListTelerik.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace TestRoomsListTelerik
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
      var builder = MauiApp.CreateBuilder();
      builder
        .UseTelerik()
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

      builder.Services.AddSingleton<MainPage>();
      builder.Services.AddSingleton<MainPageOnlyTables>();
      builder.Services.AddSingleton<MainViewModel>();

      return builder.Build();
    }
  }
}
