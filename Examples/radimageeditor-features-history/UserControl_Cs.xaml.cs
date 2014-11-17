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

#region radimageeditor-features-history_0
this.imageEditor.Undo();
#endregion

#region radimageeditor-features-history_1
this.ImageEditorUI.ImageEditor.Undo();
#endregion

#region radimageeditor-features-history_2
this.ImageEditorUI.ImageEditor.History.CurrentImageChanged += History_CurrentImageChanged;
#endregion

#region radimageeditor-features-history_3
private bool hasImageBeenChanged;
void History_CurrentImageChanged(object sender, EventArgs e)
{
   ImageHistory history = (ImageHistory)sender;
   if (!history.CanRedo && !history.CanUndo)
   {
      hasImageBeenChanged = true;
   }
   else
   {
      hasImageBeenChanged = false;
   }
}
#endregion
}
