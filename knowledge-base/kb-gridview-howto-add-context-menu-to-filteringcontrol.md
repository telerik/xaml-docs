---
title: How to Add Context Menu to RadGridView FilteringControl 
description: Implement a context menu for TextBox elements inside the FilteringControl. 
type: how-to
page_title: Showing a Context Menu for Elements Inside the FilteringControl 
slug: kb-gridview-howto-add-context-menu-to-filteringcontrol
tags: contextmenu, filteringcontrol
ticketid: 1122194
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to display a context menu for elements inside the FilteringControl of the RadGridView.

## Solution

Create a class that inherits from FilteringControl and handle the __PreviewMouseRightButtonDown__ event. Inside the event handler, add the logic for displaying the context menu. 

__Example 1: Creating a custom FilteringControl__
```C#

	public class ExtendedFilteringControl : FilteringControl
    {
        public RadContextMenu contextMenu;

        public ExtendedFilteringControl(Telerik.Windows.Controls.GridViewColumn column)
        : base(column)
        {
            DefaultStyleKey = typeof(ExtendedFilteringControl);
            this.Loaded += FilteringControlEx_Loaded;
        }

        private void FilteringControlEx_Loaded(object sender, RoutedEventArgs e)
        {
            contextMenu = new RadContextMenu();
            contextMenu.Items.Add(new RadMenuItem() { Header = "Copy", Command = ApplicationCommands.Copy });
            this.PreviewMouseRightButtonDown += ExtendedFilteringControl_PreviewMouseRightButtonDown;
        }

        private void ExtendedFilteringControl_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var placementTarget = e.OriginalSource as FrameworkElement;

            if (placementTarget.ParentOfType<TextBox>() != null)
            {
                contextMenu.PlacementTarget = placementTarget;
                contextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;
                contextMenu.IsOpen = true;
            }
        }
    }
```
```VB.NET

	Public Class ExtendedFilteringControl
	    Inherits FilteringControl

		Public contextMenu As RadContextMenu

		Public Sub New(ByVal column As Telerik.Windows.Controls.GridViewColumn)
			MyBase.New(column)
			DefaultStyleKey = GetType(ExtendedFilteringControl)
			AddHandler Me.Loaded, AddressOf FilteringControlEx_Loaded
		End Sub

		Private Sub FilteringControlEx_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			contextMenu = New RadContextMenu()
			contextMenu.Items.Add(New RadMenuItem() With {
				.Header = "Copy",
				.Command = ApplicationCommands.Copy
			})
			AddHandler Me.PreviewMouseRightButtonDown, AddressOf ExtendedFilteringControl_PreviewMouseRightButtonDown
		End Sub

		Private Sub ExtendedFilteringControl_PreviewMouseRightButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim placementTarget = TryCast(e.OriginalSource, FrameworkElement)

			If placementTarget.ParentOfType(Of TextBox)() IsNot Nothing Then
				contextMenu.PlacementTarget = placementTarget
				contextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint
				contextMenu.IsOpen = True
			End If
		End Sub
    End Class
```

Then you have to set the __FilteringControl__ property of the columns which will utilize the custom control. 

__Example 2: Setting the FilteringControl of the columns__
```C#

	public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.AddCustomFilteringControls();
        }

        private void AddCustomFilteringControls()
        {
            foreach (var column in this.gridView.Columns)
            {
                column.FilteringControl = new ExtendedFilteringControl(column);
            }
        }
    }
```
```VB.NET

	Partial Public Class MainWindow
	Inherits Window

		Public Sub New()
			InitializeComponent()

			Me.AddCustomFilteringControls()
		End Sub

		Private Sub AddCustomFilteringControls()
			For Each column In Me.gridView.Columns
				column.FilteringControl = New ExtendedFilteringControl(column)
			Next column
		End Sub
    End Class
```

> The examples use the RadGridView setup from its [Getting Started]({%slug gridview-getting-started2%}) article.

<!-- -->

> If you are using the [NoXaml]({%slug xaml-vs-noxaml%}#noxaml-assemblies) dlls, you should [base the style for the custom FilteringControl on the default one for the theme]({%slug implicit-styles-styling-the-controls%}#basing-a-custom-style-on-a-theme-default-style). 

## See Also
* [RadGridView Getting Started]({%slug gridview-getting-started2%})
