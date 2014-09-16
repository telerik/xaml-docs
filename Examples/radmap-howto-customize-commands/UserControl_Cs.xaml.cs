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

#region radmap-howto-customize-commands_1
private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
private string VEKey = "set-your-BingMaps-Key-here";
private BingMapProvider provider;
private void SetProvider()
{
    this.provider = new BingMapProvider(MapMode.Aerial, true, this.VEKey);
    this.provider.Commands.Clear();
    this.AddCustomCommandAction(this.provider, "Restaurants");
    this.AddCustomCommandAction(this.provider, "Bars");
    this.AddCustomCommandAction(this.provider, "Museums");
    this.RadMap1.Provider = provider;
}
private void AddCustomCommandAction(BingMapProvider provider, string poi)
{
    string commandText = string.Format("Find {0}", poi);
    string commandName = string.Format("Find{0}Command", poi);
    CommandDescription commandDescription = new CommandDescription();
    commandDescription.Command = new RoutedUICommand(commandText, commandName, typeof(BingMapProvider));
    commandDescription.CommandParameter = poi;
    commandDescription.DataTemplate = this.LayoutRoot.Resources["CustomCommandDataTemplate"] as DataTemplate;
    string imagePath = string.Format(ImagePathFormat, poi);
    commandDescription.ImageUri = new Uri(imagePath, UriKind.RelativeOrAbsolute);
    CommandBinding commandBinding = new CommandBinding(commandDescription.Command, ExecuteCustomCommand);
    provider.Commands.Add(commandDescription);
    provider.CommandBindingCollection.Add(commandBinding);
}
private void ExecuteCustomCommand(object sender, ExecutedRoutedEventArgs e)
{
    // execute custom action here...
}
#endregion

#region radmap-howto-customize-commands_3
public MainPage()
{
       InitializeComponent();
       // Call this method if you want to create a brand-new list of custom commands for the provider.
       // Otherwise the custom command will be appended to the default list.
       this.radMap.Provider.Commands.Clear();
       CommandDescription commandDescription = new CommandDescription()
       {
             Command = new DelegateCommand(this.ExecuteCommand),
             CommandParameter = "test",
             DataTemplate = this.Resources["CustomTemplate2"] as DataTemplate
       };
       this.radMap.Provider.Commands.Add(commandDescription);
}
private void ExecuteCommand(object parameter)
{
       MessageBox.Show(string.Format("My command: {0}", parameter));
}
#endregion
}
