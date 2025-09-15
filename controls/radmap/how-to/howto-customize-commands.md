---
title: Implement custom commands for MapCommandBar UI
page_title: Implement custom commands for MapCommandBar UI
description: Check our &quot;Implement custom commands for MapCommandBar UI&quot; documentation article for the RadMap control.
slug: radmap-howto-customize-commands
tags: implement,custom,commands,for,mapcommandbar,ui
published: True
position: 0
---

# Implement custom commands for MapCommandBar UI

The `MapCommandBar` element that by default displays the predefined view modes for every map provider, can be customized with additional commands.

## Customization of the commands in the MapCommandBar

Every custom command should be described by a `CommandDescription` instance that you need to add to the respective `Commands` collection of the used map provider (if your custom command is RoutedCommand / RoutedUICommand, you can add the associated `CommandBinding` to the `CommandBindingCollection` collection).

The CommandDescription class exposes the following properties:

* `Command`&mdash;Gets or sets the command that will be executed in response to UI action.
* `CommandParameter`&mdash;Gets or sets the command parameter associated with the respective command.
* `DataTemplate`&mdash;Gets or sets the data template that will be used to represent the command in CommandBar UI.
* `ImageUri`&mdash;Gets or sets the uniform resource identifier (URI) of the image that is used in the map source button data template.
* `IsAllowed`&mdash;Gets or sets a value indicating whether this command is allowed.
* `IsSelected`&mdash;Gets or sets a value indicating whether this command is selected initially.

Here is a sample code snippet that demonstrates custom `RoutedUICommand` usage:


```XAML
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
	    <telerik:RadMap x:Name="radMap" 
	                    ZoomLevel="15"
	                    MinZoomLevel="15"
	                    GeoBounds="42.3683598045287, -71.0789727419614, 3.9167707221002743, 2.1883037274811104">
	    </telerik:RadMap>
	</Grid>
```


```C#
	public partial class MainWindow : Window
	{
	    private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
	    private string APIKey = "set-your-OSM-API-key-here";
	    private OpenStreetMapProvider provider;

	    public MainWindow()
	    {
	        InitializeComponent();

	        this.SetProvider();
	    }
	
	    private void SetProvider()
	    {
	        this.provider = new OpenStreetMapProvider(this.APIKey) { StandardModeUserAgent = "My User Agent Text" };

	        this.provider.Commands.Clear();
	        this.AddCustomCommandAction(this.provider, "Restaurants");
	        this.AddCustomCommandAction(this.provider, "Bars");
	        this.AddCustomCommandAction(this.provider, "Museums");
	        this.radMap.Provider = provider;
	    }

	    private void AddCustomCommandAction(OpenStreetMapProvider provider, string poi)
	    {
	        string commandText = string.Format("Find {0}", poi);
	        string commandName = string.Format("Find{0}Command", poi);
	        CommandDescription commandDescription = new CommandDescription();
	        commandDescription.Command = new RoutedUICommand(commandText, commandName, typeof(OpenStreetMapProvider));
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
	}
```
```VB.NET
	Public Partial Class MainWindow
	    Inherits Window

	    Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
	    Private APIKey As String = "set-your-OSM-API-key-here"
	    Private provider As OpenStreetMapProvider

	    Public Sub New()
	        InitializeComponent()
	        Me.SetProvider()
	    End Sub

	    Private Sub SetProvider()
	        Me.provider = New OpenStreetMapProvider(Me.APIKey) With {
	            .StandardModeUserAgent = "My User Agent Text"
	        }
	        Me.provider.Commands.Clear()
	        Me.AddCustomCommandAction(Me.provider, "Restaurants")
	        Me.AddCustomCommandAction(Me.provider, "Bars")
	        Me.AddCustomCommandAction(Me.provider, "Museums")
	        Me.radMap.Provider = provider
	    End Sub

	    Private Sub AddCustomCommandAction(ByVal provider As OpenStreetMapProvider, ByVal poi As String)
	        Dim commandText As String = String.Format("Find {0}", poi)
	        Dim commandName As String = String.Format("Find{0}Command", poi)
	        Dim commandDescription As CommandDescription = New CommandDescription()
	        commandDescription.Command = New RoutedUICommand(commandText, commandName, GetType(OpenStreetMapProvider))
	        commandDescription.CommandParameter = poi
	        commandDescription.DataTemplate = TryCast(Me.LayoutRoot.Resources("CustomCommandDataTemplate"), DataTemplate)
	        Dim imagePath As String = String.Format(ImagePathFormat, poi)
	        commandDescription.ImageUri = New Uri(imagePath, UriKind.RelativeOrAbsolute)
	        Dim commandBinding As CommandBinding = New CommandBinding(commandDescription.Command, AddressOf ExecuteCustomCommand)
	        provider.Commands.Add(commandDescription)
	        provider.CommandBindingCollection.Add(commandBinding)
	    End Sub

	    Private Sub ExecuteCustomCommand(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
	    End Sub
	End Class
```

Here is a sample code snippet that demonstrates custom `DelegateCommand` usage:


```XAML
	<Grid x:Name="LayoutRoot">
	    <Grid.Resources>
	        <DataTemplate x:Key="MyDataTemplate">
	            <telerik:RadButton Command="{Binding Command}"
	                               Content="{Binding CommandParameter}"
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
	            </telerik:RadButton>
	        </DataTemplate>
	    </Grid.Resources>
	    <telerik:RadMap x:Name="radMap" 
	                    Margin="10"
	                    ZoomLevel="15"
	                    MinZoomLevel="15"
	                    GeoBounds="42.3683598045287, -71.0789727419614, 3.9167707221002743, 2.1883037274811104">
	    </telerik:RadMap>
	</Grid>
```


```C#
	public partial class MainWindow : Window
	{
	    private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
	    private string APIKey = "set-your-OSM-API-key-here";
	    private OpenStreetMapProvider provider;

	    public MainWindow()
	    {
	        StyleManager.ApplicationTheme = new Windows11Theme();

	        InitializeComponent();

	        this.SetProvider();
	    }
	
	    private void SetProvider()
	    {
	        this.provider = new OpenStreetMapProvider(this.APIKey) { StandardModeUserAgent = "My User Agent Text" };
	        this.radMap.Provider = this.provider;

	        this.radMap.Provider.Commands.Clear();
	        CommandDescription commandDescription = new CommandDescription()
	        {
	            Command = new DelegateCommand(this.ExecuteCommand),
	            CommandParameter = "test",
	            DataTemplate = this.LayoutRoot.Resources["MyDataTemplate"] as DataTemplate
	        };

	        this.radMap.Provider.Commands.Add(commandDescription);
	    }

	    private void ExecuteCommand(object parameter)
	    {
	        MessageBox.Show(string.Format("My command: {0}", parameter));
	    }
	}
```
```VB.NET
	Public Partial Class MainWindow
	    Inherits Window
	
	    Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
	    Private APIKey As String = "set-your-OSM-API-key-here"
	    Private provider As OpenStreetMapProvider
	
	    Public Sub New()
	        StyleManager.ApplicationTheme = New Windows11Theme()
	        InitializeComponent()
	        Me.SetProvider()
	    End Sub
	
	    Private Sub SetProvider()
	        Me.provider = New OpenStreetMapProvider(Me.APIKey) With {
	            .StandardModeUserAgent = "My User Agent Text"
	        }
	        Me.radMap.Provider = Me.provider
	        Me.radMap.Provider.Commands.Clear()
	        Dim commandDescription As CommandDescription = New CommandDescription() With {
	            .Command = New DelegateCommand(AddressOf Me.ExecuteCommand),
	            .CommandParameter = "test",
	            .DataTemplate = TryCast(Me.LayoutRoot.Resources("MyDataTemplate"), DataTemplate)
	        }
	        Me.radMap.Provider.Commands.Add(commandDescription)
	    End Sub
	
	    Private Sub ExecuteCommand(ByVal parameter As Object)
	        MessageBox.Show(String.Format("My command: {0}", parameter))
	    End Sub
	End Class
```