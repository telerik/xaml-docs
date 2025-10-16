---
title: Prevent Double-Click Maximization on RadWindow
page_title: Prevent double-click maximization on RadWindow
description: When the title bar of the RadWindow control is double-clicked, it gets maximized.
type: how-to
slug: kb-window-prevent-double-click-maximization
position: 0
tags: window, maximization, double-click
ticketid: 1539451
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2021.3.914</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadWindow for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to prevent maximization on the __RadWindow__ control, when the title bar is double-clicked.

## Solution

To achieve this, you could subscribe to the __HostCreated__ event of the __Window__ control, and inside of it, set the __SourceInitialized__ event of the __HostWindow__ property provided by the __HostWindowCreatedEventArgs__ event arguments. Additionally, several fields and methods from the __Win32__ __API__ would be required, which are present in the below code snippet.



```C#
	public partial class MainWindow : RadWindow
	{
		public MainWindow()
		{
			InitializeComponent();
	
			this.HostCreated += MainWindow_HostCreated;
		}
		
		[DllImport("user32.dll")]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
		[DllImport("user32.dll")]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
	
		private const int GWL_STYLE = -16;
		private const int WS_MAXIMIZEBOX = 0x10000;
		
		private void MainWindow_HostCreated(object sender, HostWindowCreatedEventArgs e)
		{
			e.HostWindow.SourceInitialized += Window_SourceInitialized;
		}
	
		private void Window_SourceInitialized(object sender, EventArgs e)
		{
			IntPtr hwnd = new WindowInteropHelper((Window)sender).Handle;
			var value = GetWindowLong(hwnd, GWL_STYLE);
			SetWindowLong(hwnd, GWL_STYLE, (int)(value & ~WS_MAXIMIZEBOX));
		}
	}
```
```VB.NET
	Public Partial Class MainWindow
		Inherits RadWindow
	
		Public Sub New()
			InitializeComponent()
			Me.HostCreated += AddressOf MainWindow_HostCreated
		End Sub
	
		<DllImport("user32.dll")>
		Private Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
		<DllImport("user32.dll")>
		Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
		Private Const GWL_STYLE As Integer = -16
		Private Const WS_MAXIMIZEBOX As Integer = &H10000
	
		Private Sub MainWindow_HostCreated(ByVal sender As Object, ByVal e As HostWindowCreatedEventArgs)
			e.HostWindow.SourceInitialized += AddressOf Window_SourceInitialized
		End Sub
	
		Private Sub Window_SourceInitialized(ByVal sender As Object, ByVal e As EventArgs)
			Dim hwnd As IntPtr = New WindowInteropHelper(CType(sender, Window)).Handle
			Dim value = GetWindowLong(hwnd, GWL_STYLE)
			SetWindowLong(hwnd, GWL_STYLE, CInt((value And Not WS_MAXIMIZEBOX)))
		End Sub
	End Class
```