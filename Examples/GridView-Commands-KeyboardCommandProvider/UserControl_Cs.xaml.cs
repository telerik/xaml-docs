using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region GridView-Commands-KeyboardCommandProvider_0
class CustomKeyboardCommandProvider : DefaultKeyboardCommandProvider
 {
  private GridViewDataControl parentGrid;
  private DefaultKeyboardCommandProvider defaultKeyboardProvider;
  private CustomKeyboardCommandProvider customKeyboardProvider;
  public CustomKeyboardCommandProvider(GridViewDataControl grid)
   : base(grid)
  {
   this.parentGrid = grid;
  }
  public override IEnumerable<ICommand> ProvideCommandsForKey(Key key)
  {
   List<ICommand> commandsToExecute = base.ProvideCommandsForKey(key).ToList();
      if (key == Key.Enter)
       {
          commandsToExecute.Clear();
          commandsToExecute.Add(RadGridViewCommands.CommitEdit);
          commandsToExecute.Add(RadGridViewCommands.MoveNext);
          commandsToExecute.Add(RadGridViewCommands.BeginEdit);
       }
   return commandsToExecute;

  }
 }
#endregion

#region GridView-Commands-KeyboardCommandProvider_2
this.RadGridView1.KeyboardCommandProvider = new CustomKeyboardCommandProvider(this.RadGridView1);
#endregion
}
