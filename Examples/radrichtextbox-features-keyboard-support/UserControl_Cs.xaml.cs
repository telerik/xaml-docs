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

#region radrichtextbox-features-keyboard-support_0
private void editor_PreviewEditorKeyDown(object sender, Documents.PreviewEditorKeyEventArgs e)
{
    if(Keyboard.Modifiers.HasFlag(ModifierKeys.Alt) && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
    {
        e.SuppressDefaultAction = true;
    }            
}
#endregion

#region radrichtextbox-features-keyboard-support_1
private void editor_PreviewEditorKeyDown(object sender, Telerik.Windows.Documents.PreviewEditorKeyEventArgs e)
{
    if ((Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
    {
        e.SuppressDefaultAction = true;
    }
}
#endregion
}
