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

#region radribbonview-buttons-overview_2
private void RadRibbonButton_Click(object sender, RoutedEventArgs e)
{
 //place your custom logic here.
}
#endregion

#region radribbonview-buttons-overview_4
public partial class RibbonButtonsSample : UserControl
{
   public static readonly RoutedUICommand EquationCommand = new RoutedUICommand(
       "Equation",
       "EquationCommand",
       typeof( RibbonButtonsSample ) );
   public RibbonButtonsSample()
   {
       InitializeComponent();
       CommandManager.AddExecutedHandler( this, this.OnExecuted );
       CommandManager.AddCanExecuteHandler( this, this.OnCanExecute );
   }
   private void OnExecuted( object sender, ExecutedRoutedEventArgs e )
   {
       this.LayoutRoot.Background = new SolidColorBrush( Colors.Blue );
   }
   private void OnCanExecute( object sender, CanExecuteRoutedEventArgs e )
   {
       e.CanExecute = true;
   }
}
#endregion
}
