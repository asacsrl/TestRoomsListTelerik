using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRoomsListTelerik.Models;

public partial class Room
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public ObservableCollection<Table> Tables { get; set; }

  public Room()
  {
    Id = Guid.NewGuid();
    Name = "";
    Tables = new ObservableCollection<Table>();
  }

}
