---
title: Improve Initial Load Performance of RadSpreadsheet
description: How to pre-load the RadSpreadsheet control in order to load its WPF/XAML resources beforehand.
type: how-to
page_title: Improve RadSpreadsheet Performance by Preloading the Associated XAML Resources
slug: kb-spreadsheet-preload-resources
tags: wpf, double-click, expand, collapse, spreadsheet,preload
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| RadSpreadsheet for WPF | 2025.1.211 |

## Description

The RadSpreadsheet is relatively complex control which comes with a big amount of XAML resources (styles, templates, brushes, etc.). All these resources will be loaded by WPF the first time the control is displayed, which takes some time. If you add also RadSpreadsheetRibbon, the loading time will increase even more. The next time you display RadSpreadsheet instances in the application the performance is going to be faster than the first one.

This problem may be noticeable by the users if the first RadSpreadsheet load happens on a button click or another user action. In this case, the usability of the application can be improved by moving the resources loading at another place, like on startup of the main window or the application. The following solution shows one way to do this.

## Solution

To preload the RadSpreadsheet XAML resources, you can add the control in a dummy UserControl and display it when the main window gets initialized. This will ensure that the needed resources are loaded before the user has the chance to interact with the application. You can further improve the application's usability by showing the dummy control in a window opened on a separate UI thread.

#### __[XAML] Defining the dummy UserControl__
{{region kb-spreadsheet-preload-resources-0}}
	<UserControl x:Class="WpfApp1.SpreadsheetUserControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"              
             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
             xmlns:spreadSheetControls="clr-namespace:Telerik.Windows.Controls.Spreadsheet.Controls;assembly=Telerik.Windows.Controls.Spreadsheet">
		<Grid>   
			<telerik:RadSpreadsheet x:Name="spreadsheet" />
			<telerik:RadSpreadsheetRibbon x:Name="spreadsheetRibbon" RadSpreadsheet="{Binding ElementName=spreadsheet, Mode=OneTime}"/>
			<spreadSheetControls:RadSpreadsheetFormulaBar x:Name="spreadsheetFormulaBar" RadSpreadsheet="{Binding ElementName=spreadsheet, Mode=OneTime}" />
			<spreadSheetControls:RadSpreadsheetStatusBar x:Name="spreadsheetStatusBar" RadSpreadsheet="{Binding ElementName=spreadsheet, Mode=OneTime}" />
		</Grid>
	</UserControl>
{{endregion}}

#### __[C#] Showing the window with the dummy UserControl__
{{region kb-spreadsheet-preload-resources-1}}
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindow_Loaded;
		}	

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			// pre-loading RadSpreadsheet on a new thread
			Thread thread = new Thread((ThreadStart)delegate
			{
				var dummyWindow = new Window() 
				{
					Content = new SpreadsheetUserControl(),
					ResizeMode = ResizeMode.NoResize, 
					Width = 0,
					Height = 0, 
					WindowStyle = WindowStyle.None
				};
				dummyWindow.Show();

				Dispatcher currentDispatcher = Dispatcher.CurrentDispatcher;
				currentDispatcher.BeginInvokeShutdown(DispatcherPriority.Background);
				Dispatcher.Run();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void OnShowTheActualRadSpreadsheetView()
		{        
			// show the view with your actual RadSpreadsheet definition - for example this can happen on button click, tab selection, menu item click, etc.
		}
	}
{{endregion}}