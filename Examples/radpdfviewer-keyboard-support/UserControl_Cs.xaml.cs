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

#region radpdfviewer-keyboard-support_0
this.pdfViewer.Clear();
this.pdfViewer.KeyBindings.Add(new KeyBinding(this.pdfViewer.Commands.PageUpCommand, new KeyGesture(Key.PageUp)));
this.pdfViewer.KeyBindings.RegisterCommand(this.pdfViewer.Commands.PageDownCommand, Key.PageDown);
#endregion

#region radpdfviewer-keyboard-support_1
public void Clear()                                                //Clears the collection
public void SetInputBindings(InputBindingCollection inputBindings) //Clears the current KeyBindings and sets the new ones.

public void Add(InputBinding inputBinding)                          
public void AddRange(IEnumerable<InputBinding> inputBindings)

public void RegisterCommand(ICommand command, Key key, ModifierKeys modifierKeys = ModifierKeys.None, object commandParameter = null)
#endregion
}
