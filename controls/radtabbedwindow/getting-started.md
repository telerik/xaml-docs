---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadTabbedWindow control.
slug: radtabbedwindow-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadTabbedWindow__ control. 

## Assembly References

In order to use the __RadTabbedWindow__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.Data__

## Adding RadTabbedWindow to the Project

Start by creating a new WPF window using Visual Studio's item template.

{% figure 1, "Add new WPF Window", "add-new-window.png" %}

After this, replace the generated Window declaration with the following XAML code:

#### __[XAML] Example 1: Defining a RadTabbedWindow in XAML__

{{region xaml-radtabbedwindow-getting-started_0}}
    <telerik:RadTabbedWindow x:Class="GettingStarted.TabbedWindow"
                xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    </telerik:RadTabbedWindow>
{{endregion}}

Also in the code-behind file you should inherit the __RadTabbedWindow__ instead of the standard MS __Window__.

#### __[C#] Example 2: Inherit from RadTabbedWindow__

{{region cs-radtabbedwindow-getting-started_1}}
    public partial class TabbedWindow : RadTabbedWindow
    {
        public TabbedWindow()
        {
            InitializeComponent();
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: Inherit from RadTabbedWindow__

{{region vb-radtabbedwindow-getting-started_2}}
	Partial Public Class TabbedWindow
		Inherits RadTabbedWindow

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
{{endregion}}

Finally, you can remove the **StartupUri** property from the **App.xaml** file and replace the code-behind with the following:

#### __[C#] Example 3: Open RadTabbedWindow on application startup__

{{region cs-radtabbedwindow-getting-started_3}}
    public partial class App : Application
    {
        public App()
        {
            var tabbedWindow = new TabbedWindow();
            tabbedWindow.Header = "My Tabbed Window";
            tabbedWindow.Height = 400;
            tabbedWindow.Width = 600;
            tabbedWindow.Show();
        }
    }
{{endregion}}

#### __[VB.NET] Example 3: Open RadTabbedWindow on application startup__

{{region vb-radtabbedwindow-getting-started_4}}
	Partial Public Class App
		Inherits Application

		Public Sub New()
			Dim tabbedWindow = New TabbedWindow()
			tabbedWindow.Header = "My Tabbed Window"
			tabbedWindow.Height = 400
			tabbedWindow.Width = 600
			tabbedWindow.Show()
		End Sub
	End Class
{{endregion}}

If you run the application, you will see the RadTabbedWindow control illustrated in __Figure 2__. 

{% figure 2, "Empty RadTabbedWindow", "tabbedwindow-getting-started-1.png" %}

>important If you're using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) theming mechanism with the [NoXaml binaries]({%slug xaml-vs-noxaml%}), note that the newly created window will not automatically receive the default style. You should add the following style after the merged dictionaries to fix this:

#### __[XAML] Example 4: Adding the style for the new TabbedWindow__

{{region xaml-radtabbedwindow-getting-started_5}}
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Themes/System.Windows.xaml" />
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
            </ResourceDictionary.MergedDictionaries>
            <Style TargetType="local:TabbedWindow" BasedOn="{StaticResource RadTabbedWindowStyle}" />
        </ResourceDictionary>
    </Application.Resources>
{{endregion}}

## Add Tabs

You can add tabs to the window by directly defining them as its content.

#### __[XAML] Example 5: Defining a RadTabbedWindow in XAML__

{{region xaml-radtabbedwindow-getting-started_6}}
    <telerik:RadTabbedWindow x:Class="GettingStarted.TabbedWindow"
                xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
        <telerik:RadTabItem Header="Microsoft">
            <TextBlock Text="Microsoft Content" />
        </telerik:RadTabItem>
        <telerik:RadTabItem Header="Google">
            <TextBlock Text="Google Content" />
        </telerik:RadTabItem>
        <telerik:RadTabItem Header="Progress">
            <TextBlock Text="Progress Content" />
        </telerik:RadTabItem>
    </telerik:RadTabbedWindow>
{{endregion}}

Alternatively, you can set the **ItemsSource** property of the control or bind it to a collection in your viewmodel. In this case you may want to specify the [DisplayMemberPath]({%slug radtabbedwindow-key-properties%}#displaymemberpath) property to point to the property of your business objects which you want to be displayed in the tabs.

#### __[C#] Example 6: Set the window's ItemsSource__

{{region cs-radtabbedwindow-getting-started_6}}
    public TabbedWindow()
    {
        InitializeComponent();
        this.DisplayMemberPath = "Header";
        this.ItemsSource = new ObservableCollection<Tab>()
        {
               new Tab() { Header = "Microsoft", Content = "Microsoft Content" },
               new Tab() { Header = "Google", Content = "Google Content" },
               new Tab() { Header = "Progress", Content = "Progress Content" },
        };
    }
{{endregion}}

#### __[VB.NET] Example 6: Set the window's ItemsSource__

{{region vb-radtabbedwindow-getting-started_7}}
	Public Sub New()
		InitializeComponent()
		Me.DisplayMemberPath = "Header"
		Me.ItemsSource = New ObservableCollection(Of Tab)() From {
			New Tab() With {
				.Header = "Microsoft",
				.Content = "Microsoft Content"
			},
			New Tab() With {
				.Header = "Google",
				.Content = "Google Content"
			},
			New Tab() With {
				.Header = "Progress",
				.Content = "Progress Content"
			}
		}
	End Sub
{{endregion}}

In addition to the DisplayMemberPath you can also specify the **ContentTemplate** property as shown in **Example 7**.

#### __[XAML] Example 7: Defining a RadTabbedWindow in XAML__

{{region xaml-radtabbedwindow-getting-started_8}}
    <telerik:RadTabbedWindow.ContentTemplate>
        <DataTemplate>
            <TextBlock Text="{Binding Content}" />
        </DataTemplate>
    </telerik:RadTabbedWindow.ContentTemplate>
{{endregion}}

Upon running the application, your RadTabbedWindow should now be populated with tabs as shown on __Figure 3__. 

{% figure 3, "RadTabbedWindow with tabs", "tabbedwindow-getting-started-2.png" %}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the resource dictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadTabbedWindow__, you will need to merge the following resource dictionaries:

	* __System.Windows.xaml__
	* __Telerik.Windows.Controls.xaml__
	* __Telerik.Windows.Controls.Navigation.xaml__

__Example 5__ demonstrates how to merge the resource dictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 8: Merge the ResourceDictionaries__  
{{region xaml-radtabbedwindow-getting-started_9}}
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
				</ResourceDictionary.MergedDictionaries>
			</ResourceDictionary>
		</Application.Resources>
{{endregion}}

__Figure 3__ shows __RadTabbedWindow__ with the **Windows8** theme applied.
	
{% figure 3, "RadTabbedWindow with the Windows8 theme", "tabbedwindow-getting-started-3.png" %}

## See Also

* [Key Properties](%slug radtabbedwindow-key-properties%)
* [Events](%slug radtabbedwindow-events%)
* [Styles and Templates](%slug radtabbedwindow-styles-and-templates%)