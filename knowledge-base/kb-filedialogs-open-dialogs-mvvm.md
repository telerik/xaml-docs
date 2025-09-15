---
title: Open File Dialogs from View Model
description: This article explains how to open the RadFileDialogs using an MVVM approach.
type: how-to
page_title: How to Open RadFileDialogs in a MVVM-Friendly Manner
slug: kb-filedialogs-open-dialogs-mvvm
position: 0
tags: filedialogs, open, radfiledialogs, mvvm, approach, viewmodel
ticketid: 1480760
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadFileDialogs for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to open the RadFileDialogs using an MVVM-friendly approach through the viewmodel.

## Solution

You can start by creating a service class similar to the one in **Example 1** which will be responsible for opening the window. If needed, you can also introduce an interface with a single **OpenFileDialog** method and have the OpenFileDialogService class implement this interface.

__Example 1: The OpenFileDialogService class__
```C#
	
    public class OpenFileDialogService
    {
        public string OpenFileDialog()
        {
            RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
            openFileDialog.Filter = "All Files (.)|.";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.DialogResult == true)
            {
                return openFileDialog.FileName;
            }

            return string.Empty;
        }
    }
```

You can now define a command in your view model which uses this service and its method.

__Example 2: Defining the viewmodel__
```C#
	
    public class MainViewModel : ViewModelBase
    {
		private OpenFileDialogService fileDialogService;

        public MainViewModel()
        {
            this.fileDialogService = new OpenFileDialogService();
            this.OpenFileDialogCommand = new DelegateCommand(OnOpenFileDialog);
        }

        public ICommand OpenFileDialogCommand { get; set; }

        private void OnOpenFileDialog(object obj)
        {
            var fileName = fileDialogService.OpenFileDialog();
        }
    }
```

Finally, you need to invoke this command from your view.

__Example 3: Binding the command in the view__
```XAML
	
    <Grid>
        <Grid.DataContext>
            <local:MainViewModel />
        </Grid.DataContext>
        <telerik:RadButton Command="{Binding OpenFileDialogCommand}" Content="Open Dialog" />
    </Grid>
```

## See Also
* [File Dialogs]({%slug radfiledialogs-getting-started%})