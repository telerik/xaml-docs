---
title: How to set the Command property of the button part
description: Disable only the button part when the CanExecute of the command returns false.
type: how-to
page_title: Enable the dropdown part when the CanExecute of the Command is False
slug: kb-buttons-splitbutton-howto-bind-command-of-button-part
position: 0
tags: splitbutton, command, button, canexecute, disabled
ticketid: 1085596
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.618</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadButtons for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to bind the Command property of the RadButton element(the left part) inside the RadSplitButton.

## Solution

Handle the Loaded event of the RadSplitButton, use the [ChildrenOfType]({%slug common-visual-tree-helpers%}) extension method in order to locate its RadButton child and set its __Command__ property. 

__Example 1: Setting the Command of the RadButton inside the RadSplitButton__
```C#
	
    private void RadSplitButton_Loaded(object sender, RoutedEventArgs e)
    {
        var splitButton = (RadSplitButton)sender;
        var buttonPart = splitButton.ChildrenOfType<RadButton>().FirstOrDefault(x => x.Name == "ButtonPart");
        if (buttonPart != null)
        {
            buttonPart.Command = new DelegateCommand(OnExecute, OnCanExecute);
        }
    }

    private bool OnCanExecute(object obj)
    {
        // If this method returns false, only the button part of the RadSplitButton will be disabled
        return true;
    }

    private void OnExecute(object obj)
    {
        MessageBox.Show("Button clicked!");
    }
```
```VB.NET
	
    Private Sub RadSplitButton_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim splitButton = DirectCast(sender, RadSplitButton)
		Dim buttonPart = splitButton.ChildrenOfType(Of RadButton)().FirstOrDefault(Function(x) x.Name = "ButtonPart")
		If buttonPart IsNot Nothing Then
			buttonPart.Command = New DelegateCommand(AddressOf OnExecute, AddressOf OnCanExecute)
		End If
	End Sub

	Private Function OnCanExecute(ByVal obj As Object) As Boolean
        ' If this method returns False, only the button part of the RadSplitButton will be disabled
		Return True
	End Function

	Private Sub OnExecute(ByVal obj As Object)
		MessageBox.Show("Button clicked!")
	End Sub
```

## See Also

* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})