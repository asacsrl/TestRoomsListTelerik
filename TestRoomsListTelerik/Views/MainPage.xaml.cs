﻿using TestRoomsListTelerik.ViewModels;

namespace TestRoomsListTelerik.Views;

public partial class MainPage : ContentPage
{

  public MainPage()
  {
    InitializeComponent();
    BindingContext = new MainViewModel();
  }

}
