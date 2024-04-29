using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TestRoomsListTelerik.Models;

namespace TestRoomsListTelerik.ViewModels;

public partial class MainViewModel : BaseViewModel
{
  #region Variables

  [ObservableProperty] 
  private ObservableCollection<Room> rooms;
  [ObservableProperty]
  private ObservableCollection<Table> tables;

  #endregion

  #region Initialization

  public MainViewModel()
  {
    //initialize the Rooms collection
    Rooms = new ObservableCollection<Room>();
    GetRooms();
    Tables = new ObservableCollection<Table>();
    GetTables();
  }

  #endregion

  #region Create interface collections


  private void GetTables()
  {
    for (int i = 0; i < 200; i++)
    {
      Tables.Add(new Table { Name = $"Table {i + 1}" });
    }
  }

  //Create 7 Rooms with 50 Tables each
  private void GetRooms()
  {
    Rooms = new ObservableCollection<Room>
            {
                new Room {Name="Room A"},
                new Room {Name="Room B"},
                new Room {Name="Room C"},
                new Room {Name="Room D"},
                new Room {Name="Room E"},
                new Room {Name="Room F"},
                new Room {Name="Room E"}
            };

    foreach (Room room in Rooms)
    {
      for (int i = 0; i < 50; i++)
      {
        room.Tables.Add(new Table { Name = $"Table {i + 1}" });
      }
    }
  }

  #endregion

}
