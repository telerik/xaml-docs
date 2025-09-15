---
title: Implement custom zoom levels for MapZoomBar UI
page_title: Implement custom zoom levels for MapZoomBar UI
description: Check our &quot;Implement custom zoom levels for MapZoomBar UI&quot; documentation article for the RadMap control.
slug: radmap-howto-custom-zoom-levels
tags: implement,custom,zoom,levels,for,mapzoombar,ui
published: True
position: 2
---

# Implement custom zoom levels for MapZoomBar UI

It is now possible to customize the default preset zoom levels in the MapZoomBar UI for every map provider.

## Customization of the zoom levels in the MapZoomBar

You can add custom zoom level through the `MapZoomBar.RegisterSetZoomLevelCommand` method, which accepts the following parameters:

* zoomLevel - Specifies the zoom level to set.

* commandText - Specifies the command label in the UI (you need to bind it in the DataTemplate as demonstrated below).

* dataTemplate - Specifies the data template for command presentation in the UI.

* imageUri - Uniform resource identifier (URI) of the image that is used in the map source button data template (you need to bind it in the DataTemplate as demonstrated below).

Here is a sample code snippet that demonstrates zoom level customization:


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
	    <telerik:RadMap x:Name="RadMap1" 
	                    ZoomLevel="15"
	                    MinZoomLevel="15"
	                    GeoBounds="42.3683598045287, -71.0789727419614, 3.9167707221002743, 2.1883037274811104">
	    </telerik:RadMap>
	</Grid>
```


```C#
	public class MainWindow : Window
	{
		private const string ImagePathFormat = "/Map;component/Silverlight/CustomCommands/Images/{0}.png";
		private AzureMapProvider provider;

		public MainPage()
		{
		    this.provider = new AzureMapProvider(){ SubscriptionKey = "Your Subscription Key" };
		    this.RadMap1.Provider = provider;
		    this.RadMap1.InitializeCompleted += new EventHandler(RadMap1_InitializeCompleted);
		}

		private void RadMap1_InitializeCompleted(object sender, EventArgs e)
		{
		    // remove the default zoom levels
		    RadMap1.MapZoomBar.Commands.Clear();
		    this.AddCustomZoomAction(15, "Downtown");
		    this.AddCustomZoomAction(18, "Neighborhood");
		    this.AddCustomZoomAction(20, "Block");
		}
		private void AddCustomZoomAction(int zoomLevel, string label)
		{
		    string imagePath = string.Format(ImagePathFormat, label);
		    this.RadMap1.MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel,
		        label,
		        this.LayoutRoot.Resources["CustomCommandDataTemplate"] as DataTemplate,
		        new Uri(imagePath, UriKind.RelativeOrAbsolute));
		}
	}
```

#### __VB.NET__
```VB.NET
	Public Partial Class MainWindow
    Inherits Window

    	Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
    	Private provider As AzureMapProvider
	
    	Public Sub New()
    	    StyleManager.ApplicationTheme = New Windows11Theme()
    	    InitializeComponent()
    	    Me.provider = New AzureMapProvider() With {
    	        .SubscriptionKey = "Your Subscription Key"
    	    }
    	    Me.RadMap1.Provider = provider
    	    Me.RadMap1.InitializeCompleted += New EventHandler(AddressOf RadMap1_InitializeCompleted)
    	End Sub
	
    	Private Sub RadMap1_InitializeCompleted(ByVal sender As Object, ByVal e As EventArgs)
    	    RadMap1.MapZoomBar.Commands.Clear()
    	    Me.AddCustomZoomAction(15, "Downtown")
    	    Me.AddCustomZoomAction(18, "Neighborhood")
    	    Me.AddCustomZoomAction(20, "Block")
    	End Sub
	
    	Private Sub AddCustomZoomAction(ByVal zoomLevel As Integer, ByVal label As String)
    	    Dim imagePath As String = String.Format(ImagePathFormat, label)
    	    Me.RadMap1.MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel, label, TryCast(Me.LayoutRoot.Resources("CustomCommandDataTemplate"), DataTemplate), New Uri(imagePath, UriKind.	RelativeOrAbsolute))
    	End Sub
	End Class
```