---
title: GridView Clear Input Before Commit in Deferred Search Mode
page_title: Clear the Input via the Clear Button Before Commit
description: This article shows how to clear the input in the search box using the clear button when IsSearchingDeferred is True of RadGridView.
type: how-to
slug: kb-gridview-deferred-search-clear-button-clear-text-before-commit
position: 0
tags: gridview, clear, deferred, search
ticketid: 1585166
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.912</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

When the `IsSearchingDeferred` property of `RadGridView` is set to __True__, the clear button will remove the search input only if it is committed.

This article will show you how to clear the search value every time the clear button is clicked.

## Solution

1. Subscribe to the `Loaded` event of RadGridView and retrieve the search-as-you-type TextBox element and cache it. Then, retrieve the RadButton control used for clearing the input. This can be done using the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) extension method.

    __Retrieve the search-as-you-type TextBox and clear RadButton elements__
    ```C#
		public partial class MainWindow : Window
		{
		    private TextBox searchTextBox;

		    public MainWindow()
		    {
		        InitializeComponent();

				this.radGridView.Loaded += OnRadGridViewLoaded;
		    }

		    private void OnRadGridViewLoaded(object sender, RoutedEventArgs e)
		    {
		        RadGridView radGridView = (RadGridView)sender;

		        TextBox searchAsYouTypeTextBox = radGridView.ChildrenOfType<TextBox>().FirstOrDefault(x => x.Name == "PART_SearchAsYouTypeTextBox");
		        RadButton clearButton = radGridView.ChildrenOfType<RadButton>().FirstOrDefault(x => x.Name == "ClearButton");

		        if (searchAsYouTypeTextBox != null && clearButton != null)
		        {
		            this.searchTextBox = searchAsYouTypeTextBox;
		        }
		    }
		}
    ```
```VB.NET
		Public Partial Class MainWindow
		    Inherits Window
		    Private searchTextBox As TextBox

		    Public Sub New()
		        InitializeComponent()

		        Me.radGridView.Loaded += AddressOf OnRadGridViewLoaded
		    End Sub

		    Private Sub OnRadGridViewLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
		        Dim radGridView As RadGridView = CType(sender, RadGridView)

		        Dim searchAsYouTypeTextBox As TextBox = radGridView.ChildrenOfType(Of TextBox)().FirstOrDefault(Function(x) x.Name Is "PART_SearchAsYouTypeTextBox")
		        Dim clearButton As RadButton = radGridView.ChildrenOfType(Of RadButton)().FirstOrDefault(Function(x) x.Name Is "ClearButton")

		        If searchAsYouTypeTextBox IsNot Nothing AndAlso clearButton IsNot Nothing Then
		            searchTextBox = searchAsYouTypeTextBox
		        End If
		    End Sub
		End Class
    ```

2.	Set the `Command` property of the RadButton element to __null__ and subscribe to its `Click` event. In the added event handler, clear the Text property of the cached `TextBox`, as well as the `SearchText` property of its `DataContext`. Its DataContext will be of the type `SearchViewModel`.

	__Subscribe to the Click event of the clear RadButton__
	```C#
		clearButton.Command = null;
        clearButton.Click += ClearButton_Click;

		private void ClearButton_Click(object sender, RoutedEventArgs e)
    	{
        	this.searchTextBox.Text = "";
        	((SearchViewModel)this.searchTextBox.DataContext).SearchText = "";
    	}
	```
```VB.NET
		clearButton.Command = Nothing
        clearButton.Click += AddressOf ClearButton_Click

		Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        	searchTextBox.Text = ""
        	CType(searchTextBox.DataContext, SearchViewModel).SearchText = ""
    	End Sub
	```

3. Subscribe to the `LostKeyboardFocus` event of the search-as-you-type `TextBox`. In the added event handler, if clear RadButton is the new element that receives the focus, raise its Click event. 

	__Subscribe to the LostKeyboardFocus event of the search-as-you-type TextBox__
	```C#
		this.searchTextBox.LostKeyboardFocus += SearchTextBox_LostKeyboardFocus;

		private void SearchTextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    	{
    	    if (e.NewFocus is RadButton radbutton)
    	    {
    	        if (radbutton.Name == "ClearButton")
    	        {
    	            radbutton.RaiseEvent(new RoutedEventArgs(RadButton.ClickEvent));
    	        }
    	    }
    	}
	```
```VB.NET
		Me.searchTextBox.LostKeyboardFocus += AddressOf SearchTextBox_LostKeyboardFocus

		Private Sub SearchTextBox_LostKeyboardFocus(ByVal sender As Object, ByVal e As KeyboardFocusChangedEventArgs)
        Dim radbutton As RadButton = Nothing

        	If CSharpImpl.__Assign(radbutton, TryCast(e.NewFocus, RadButton)) IsNot Nothing Then
        	    If radbutton.Name Is "ClearButton" Then
        	        radbutton.[RaiseEvent](New RoutedEventArgs(RadButton.ClickEvent))
        	    End If
        	End If
    	End Sub

		Private Class CSharpImpl
        	Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
        	    target = value
        	    Return value
        	End Function
    	End Class
	```

The full implementation of this solution is as follows:


```C#
	public partial class MainWindow : Window
	{
	    private TextBox searchTextBox;
	
	    public MainWindow()
	    {
	        InitializeComponent();
	    }

	    private void RadGridView_Loaded(object sender, RoutedEventArgs e)
	    {
	        RadGridView radGridView = (RadGridView)sender;

	        TextBox searchAsYouTypeTextBox = radGridView.ChildrenOfType<TextBox>().FirstOrDefault(x => x.Name == "PART_SearchAsYouTypeTextBox");
	        RadButton clearButton = radGridView.ChildrenOfType<RadButton>().FirstOrDefault(x => x.Name == "ClearButton");

	        if (searchAsYouTypeTextBox != null && clearButton != null)
	        {
	            this.searchTextBox = searchAsYouTypeTextBox;
	            this.searchTextBox.LostKeyboardFocus += SearchTextBox_LostKeyboardFocus;

	            clearButton.Command = null;
	            clearButton.Click += ClearButton_Click;
	        }
	    }

	    private void SearchTextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
	    {
	        if (e.NewFocus is RadButton radbutton)
	        {
	            if (radbutton.Name == "ClearButton")
	            {
	                radbutton.RaiseEvent(new RoutedEventArgs(RadButton.ClickEvent));
	            }
	        }
	    }

	    private void ClearButton_Click(object sender, RoutedEventArgs e)
	    {
	        this.searchTextBox.Text = "";
	        ((SearchViewModel)this.searchTextBox.DataContext).SearchText = "";
	    }
	}
```
```VB.NET
	Public Partial Class MainWindow
	    Inherits Window

	    Private searchTextBox As TextBox

	    Public Sub New()
	        InitializeComponent()
	    End Sub

	    Private Sub RadGridView_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
	        Dim radGridView As RadGridView = CType(sender, RadGridView)
	        Dim searchAsYouTypeTextBox As TextBox = radGridView.ChildrenOfType(Of TextBox)().FirstOrDefault(Function(x) x.Name = "PART_SearchAsYouTypeTextBox")
	        Dim clearButton As RadButton = radGridView.ChildrenOfType(Of RadButton)().FirstOrDefault(Function(x) x.Name = "ClearButton")

	        If searchAsYouTypeTextBox IsNot Nothing AndAlso clearButton IsNot Nothing Then
	            Me.searchTextBox = searchAsYouTypeTextBox
	            Me.searchTextBox.LostKeyboardFocus += AddressOf SearchTextBox_LostKeyboardFocus
	            clearButton.Command = Nothing
	            clearButton.Click += AddressOf ClearButton_Click
	        End If
	    End Sub

	    Private Sub SearchTextBox_LostKeyboardFocus(ByVal sender As Object, ByVal e As KeyboardFocusChangedEventArgs)
	        Dim radbutton As RadButton = Nothing

	        If CSharpImpl.__Assign(radbutton, TryCast(e.NewFocus, RadButton)) IsNot Nothing Then

	            If radbutton.Name = "ClearButton" Then
	                radbutton.[RaiseEvent](New RoutedEventArgs(RadButton.ClickEvent))
	            End If
	        End If
	    End Sub

	    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	        Me.searchTextBox.Text = ""
	        (CType(Me.searchTextBox.DataContext, SearchViewModel)).SearchText = ""
	    End Sub

	    Private Class CSharpImpl
	        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
	            target = value
	            Return value
	        End Function
	    End Class
	End Class
```