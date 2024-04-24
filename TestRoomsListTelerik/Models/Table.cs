using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRoomsListTelerik.Models;

public partial class Table
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public double TotalAmount { get; set; }

  public Table()
  {
    Id = Guid.NewGuid();
    Name = "";
    TotalAmount = 0;
  }
}
