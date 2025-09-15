---
title: Display RadBusyIndicator When UI is Blocked During Layout Operation
page_title: "Show RadBusyIndicator when the main UI thread is blocked."
description: Show BusyIndicator on New UI Thread When the UI is Frozen
type: how-to
slug: kb-busyindicator-blocked-rendering
position: 0
tags: rendering,blocked,ui,another,thread,window,ui,busyindicator,busy
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2023.3.1010</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadBusyIndicator for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to show RadBusyIndicator for WPF, when the main UI thread is blocked.

## Solution

The `RadBusyIndicator` is a WPF control which means that if something blocks the main UI thread, the indicator will be frozen too. Most commonly it is not displayed at all, or its animation freezes. The purpose of this control is to indicate long operations that happen on a background thread, but it cannot be used to show longer operations related to the WPF layout or rendering. However, there is trick to use `RadBusyIndicator` in these situations. 

To do that, you can display the `RadBusyIndicator` in a `Window` opened on a new UI thread. This can happen just before the time consuming layout operation. The closing of the window can be started just after its opening, using the main window's `Dispatcher` and the `DispatcherPriority.ContextIdle` setting. This should ensure that the window is closed after the main UI thread is available.

>tip Use this approach only if the main UI thread is blocked. In case you need to busy indicate background operations, use the control in its [original setup]({%slug radbusyindicator-getting-started%}).


```C#
	public partial class MainWindow : Window
	{
		private Window busyIndicatorWindow;

		public MainWindow()
		{          
			InitializeComponent();			
		}

		private void OnSetDataButtonClick(object sender, RoutedEventArgs e)
		{
			ShowBusyIndicator();
			
			// time consuming layout Operation
			// for example: 
			// this.radGridView.ItemSource = veryBigItemsSource;
		}

		private void ShowBusyIndicator()
		{
			var halfWidth = this.ActualWidth / 2;
			var halfHeigth = this.ActualHeight / 2;
			var top = this.Top + (halfHeigth / 2);
			var left = this.Left + (halfWidth / 2);

			var thread = CreateNewWindowThread(top, left, halfWidth, halfHeigth);
			
			Dispatcher.BeginInvoke(new Action(() =>
			{
				var dispatcher = Dispatcher.FromThread(thread);
				dispatcher.BeginInvoke(new Action(() => { busyIndicatorWindow.Close(); }));

			}), DispatcherPriority.ContextIdle, null);
		}		

		private Thread CreateNewWindowThread(double top, double left, double width, double height)
		{
			var thread = new Thread(() =>
			{
				busyIndicatorWindow = new Window();
				busyIndicatorWindow.Content = new RadBusyIndicator() { IsBusy = true };
				busyIndicatorWindow.AllowsTransparency = true;
				busyIndicatorWindow.ShowInTaskbar = true;
				busyIndicatorWindow.ResizeMode = ResizeMode.NoResize;
				busyIndicatorWindow.WindowStyle = WindowStyle.None;
				busyIndicatorWindow.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#5A5FBA7D"));
				busyIndicatorWindow.Width = width;
				busyIndicatorWindow.Height = height;
				busyIndicatorWindow.Top = top;
				busyIndicatorWindow.Left = left;
				busyIndicatorWindow.Closed += (s, e) =>
				{
					busyIndicatorWindow.Dispatcher.InvokeShutdown();
				};

				busyIndicatorWindow.Show();                
				Dispatcher.Run();
			});
						
			thread.SetApartmentState(ApartmentState.STA);
			thread.IsBackground = true;
			thread.Start();

			return thread;
		}      
	}
```
