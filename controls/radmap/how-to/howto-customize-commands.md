---
title: Implement custom commands for MapCommandBar UI
page_title: Implement custom commands for MapCommandBar UI
description: Implement custom commands for MapCommandBar UI
slug: radmap-howto-customize-commands
tags: implement,custom,commands,for,mapcommandbar,ui
published: True
position: 0
---

# Implement custom commands for MapCommandBar UI

It is now possible to customize the default set of commands in the MapCommandBar UI for every map provider.

## Customization of the commands in the MapCommandBar

Every custom command should be described by a __CommandDescription__ instance that you need to add to the respective __MapProvider.Commands__ collection (if your custom command is RoutedCommand / RoutedUICommand, you can add the associated __CommandBinding__ to the __MapProvider.CommandBindingCollection__).

The __CommandDescription__ class exposes the following properties:

* __Command__ - Gets or sets the command that will be executed in response to UI action.

* __CommandParameter__ - Gets or sets the command parameter associated with the respective command.

* __DataTemplate__ - Gets or sets the data template that will be used to represent the command in CommandBar UI.

* __ImageUri__ - Gets or sets the uniform resource identifier (URI) of the image that is used in the map source button data template.

* __IsAllowed__ - Gets or sets a value indicating whether this command is allowed.

* __IsSelected__ - Gets or sets a value indicating whether this command is selected initially.

Here is a sample code snippet that demonstrates custom __RoutedUICommand__ usage:

#### __XAML__
{{region radmap-howto-customize-commands_0}}
	<Grid x:Name="LayoutRoot">
	    <Grid.Resources>
	        <DataTemplate x:Key="CustomCommandDataTemplate">
	            <telerik:RadButton Command="{Binding Path=Command}"
	                                CommandParameter="{Binding CommandParameter}"
	                                HorizontalContentAlignment="Stretch"
	                                Height="26"
	                                Margin="0,3"
	                                CornerRadius="3"
	                                Opacity="0.8"
	                                BorderBrush="#FF848484">
	                <telerik:RadButton.Background>
	                    <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                        <GradientStop Color="White"/>
	                        <GradientStop Color="#FFD4D4D4" Offset="1"/>
	                        <GradientStop Color="Gainsboro" Offset="0.5"/>
	                        <GradientStop Color="#FFADADAD" Offset="0.51"/>
	                    </LinearGradientBrush>
	                </telerik:RadButton.Background>
	                <Grid HorizontalAlignment="Stretch">
	                    <Grid.ColumnDefinitions>
	                        <ColumnDefinition />
	                        <ColumnDefinition Width="32" />
	                    </Grid.ColumnDefinitions>
	                    <TextBlock Text="{Binding Path=Command.Text}"
	              TextAlignment="Center" 
	              HorizontalAlignment="Stretch" 
	              Padding="7,0"
	              FontSize="11" 
	              FontWeight="Bold" />
	                    <Image Grid.Column="1" Width="16" Height="16" HorizontalAlignment="Center" VerticalAlignment="Center">
	                        <Image.Source>
	                            <BitmapImage UriSource="{Binding ImageUri}" />
	                        </Image.Source>
	                    </Image>
	                </Grid>
	            </telerik:RadButton>
	        </DataTemplate>
	    </Grid.Resources>
	    <telerik:RadMap x:Name="RadMap1" 
	                    ZoomLevel="15"
	                    MinZoomLevel="15"
	                    GeoBounds="42.3683598045287, -71.0789727419614, 3.9167707221002743, 2.1883037274811104">
	    </telerik:RadMap>
	</Grid>
{{endregion}}

#### __C#__
{{region radmap-howto-customize-commands_1}}
	private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
	private string VEKey = "set-your-BingMaps-Key-here";
	private BingRestMapProvider provider;
	private void SetProvider()
	{
	    this.provider = new BingRestMapProvider(MapMode.Aerial, true, this.VEKey);
	
	    this.provider.Commands.Clear();
	    this.AddCustomCommandAction(this.provider, "Restaurants");
	    this.AddCustomCommandAction(this.provider, "Bars");
	    this.AddCustomCommandAction(this.provider, "Museums");
	    this.RadMap1.Provider = provider;
	}
	private void AddCustomCommandAction(BingRestMapProvider provider, string poi)
	{
	    string commandText = string.Format("Find {0}", poi);
	    string commandName = string.Format("Find{0}Command", poi);
	    CommandDescription commandDescription = new CommandDescription();
	    commandDescription.Command = new RoutedUICommand(commandText, commandName, typeof(BingRestMapProvider));
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
{{endregion}}

#### __VB.NET__
{{region radmap-howto-customize-commands_2}}
	Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
	Private VEKey As String = "set-your-BingMaps-Key-here"
	Private provider As BingRestMapProvider
	Private Sub SetProvider()
	 Me.provider = New BingRestMapProvider(MapMode.Aerial, True, Me.VEKey)
	 Me.provider.Commands.Clear()
	 Me.AddCustomCommandAction(Me.provider, "Restaurants")
	 Me.AddCustomCommandAction(Me.provider, "Bars")
	 Me.AddCustomCommandAction(Me.provider, "Museums")
	 Me.RadMap1.Provider = provider
	End Sub
	Private Sub AddCustomCommandAction(provider As BingRestMapProvider, poi As String)
	 Dim commandText As String = String.Format("Find {0}", poi)
	 Dim commandName As String = String.Format("Find{0}Command", poi)
	 Dim commandDescription As New CommandDescription()
	 commandDescription.Command = New RoutedUICommand(commandText, commandName, GetType(BingRestMapProvider))
	 commandDescription.CommandParameter = poi
	 commandDescription.DataTemplate = TryCast(Me.LayoutRoot.Resources("CustomCommandDataTemplate"), DataTemplate)
	 Dim imagePath As String = String.Format(ImagePathFormat, poi)
	 commandDescription.ImageUri = New Uri(imagePath, UriKind.RelativeOrAbsolute)
	 Dim commandBinding As New CommandBinding(commandDescription.Command, ExecuteCustomCommand)
	 provider.Commands.Add(commandDescription)
	 provider.CommandBindingCollection.Add(commandBinding)
	End Sub
	Private Sub ExecuteCustomCommand(sender As Object, e As ExecutedRoutedEventArgs)
	 ' execute custom action here...'
	End Sub
{{endregion}}

Here is a sample code snippet that demonstrates custom __DelegateCommand__ usage:

#### __C#__
{{region radmap-howto-customize-commands_3}}
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
{{endregion}}

#### __VB.NET__
{{region radmap-howto-customize-commands_4}}
	Public Sub New()
	 InitializeComponent()
	 ' Call this method if you want to create a brand-new list of custom commands for the provider. '
	 ' Otherwise the custom command will be appended to the default list.'
	 Me.radMap.Provider.Commands.Clear()
	 Dim commandDescription As New CommandDescription() With { _
	  .Command = New DelegateCommand(Me.ExecuteCommand), _
	  .CommandParameter = "test", _
	  .DataTemplate = TryCast(Me.Resources("CustomTemplate2"), DataTemplate) _
	 }
	 Me.radMap.Provider.Commands.Add(commandDescription)
	End Sub
	Private Sub ExecuteCommand(parameter As Object)
	 MessageBox.Show(String.Format("My command: {0}", parameter))
	End Sub
{{endregion}}