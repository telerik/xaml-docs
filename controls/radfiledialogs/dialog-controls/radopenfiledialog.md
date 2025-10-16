---
title: RadOpenFileDialog
page_title: RadOpenFileDialog
description: This article describes the RadOpenFileDialog control which can be used to specify one or multiple filenames to open. 
slug: radfiledialogs-radopenfiledialog
tags: open,file,dialog,show
published: True
position: 1
---

# RadOpenFileDialog

__RadOpenFileDialog__ is a modal dialog box that allows you to specify one or multiple filenames to open.

#### __Figure 1: RadOpenFileDialog in single selection mode__ 

![RadOpenFileDialog in single selection mode](images/radopenfiledialog-01.png)

## Showing the Dialog

To show the dialog call its __ShowDialog__ method. If a valid file is opened when you press OK, the __DialogResult__ property will return True and the __FileName__, and __FileNames__ properties will be set. You can use FileName and FileNames to get the names of the selected items.

> Note that when the ShowDialog method is called the UI of the host application will freeze until the dialog closes.

__Example 1: Show a open file dialog__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ShowOpenFileDialog();
		}

		private void ShowOpenFileDialog()
		{
			RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
			openFileDialog.Owner = this;
			openFileDialog.ShowDialog();
			if (openFileDialog.DialogResult == true)
			{
				string fileName = openFileDialog.FileName;
			}
		}
	}
```

> The __Owner__ property holds a reference of the Window which owned the dialog. Before calling the __ShowDialog()__ method, the __Owner__ property should be set to ensure correct behavior. Ownership is established when this property is set.   

## Opening the Selected File

You can open a read-only file stream for the selected file using the __OpenFile__ method. Or alternatively you can use the FileName and FileNames properties and open the file manually.

__Example 2: Open a file stream__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ShowOpenFileDialog();
		}

		private void ShowOpenFileDialog()
		{
			RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
			openFileDialog.Owner = this;
			openFileDialog.ShowDialog();
			if (openFileDialog.DialogResult == true)
			{
				Stream fileStream = openFileDialog.OpenFile();
			}
		}
	}
```

## Enabling Multiple Selection

The dialog supports single and multiple selection modes. By default you can select only one file at a time. To alter this you can set the __Multiselect__ property of RadOpenFileDialog.

__Example 3: Enable multiple selection__
```C#
	private void ShowOpenFileDialog()
    {
        RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
        openFileDialog.Owner = this;
        openFileDialog.Multiselect = true;
        openFileDialog.ShowDialog();       
    }
```

#### __Figure 2: Multiple selection__ 

![RadOpenFileDialog with multiple selection](images/radopenfiledialog-02.png)

## Working with the Selected Files

You can get the paths of the selected files via the __FileName__ and __FileNames__ properties. Note that the properties are empty until the DialogResult is valid. When you open file(s) the properties will return the corresponding paths.

You can get only the name of the selected files, without the full path, via the __SafeFileNames__ collection property.

__Example 3: Get the selected file names__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ShowOpenFileDialog();
		}

		private void ShowOpenFileDialog()
		{
			RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
			openFileDialog.Owner = this;
			openFileDialog.Multiselect = true;
			openFileDialog.ShowDialog();
			if (openFileDialog.DialogResult == true)
			{
				string filePath = openFileDialog.FileName;
				IEnumerable<string> filePaths = openFileDialog.FileNames;
				IEnumerable<string> fileNames = openFileDialog.SafeFileNames;
			}
		}
	}
```

The __FileName__ property can be set manually. This will change the value displayed in the selected file autocomplete box area. Note that setting this won't change the selected item in the list with the files.

## Saving the Last Used Directory

You can save the last used directory by setting the __RestoreDirectory__ property of the RadOpenFileDialog. After setting this property to __True__ and opening a file the __InitialDirectory__ of this RadOpenFileDialog instance will be set to the parent folder of the opened file.

> The __RestoreDirectory__ property will save the last used directory only for the scope of its __RadOpenFileDialog__ class instance. Clicking __Cancel__ or __X__ instead of __Open__ in the RadOpenFileDialog, will not save the last used directory.

__Example 4: Set RestoreDirectory property__
```C#
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.RestoreDirectory = true;
```

## Enabling ReadOnly CheckBox

You can display a checkbox to control whether the file should be opened in readonly mode with the __ShowReadOnly__ property of the RadOpenFileDialog. You can control the state of that checkbox by using the __ReadOnlyChecked__ property of the RadOpenFileDialog.

__Example 4: Enabling the ReadOnly CheckBox__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ShowOpenFileDialog();
		}

		private void ShowOpenFileDialog()
		{
			RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
			openFileDialog.Owner = this;
			openFileDialog.ShowReadOnly = true;
			openFileDialog.ReadOnlyChecked = true;
			openFileDialog.ShowDialog();
		}
	}
```

#### __Figure 3: RadOpenFileDialog with Checked ReadOnly CheckBox__ 
![RadOpenFileDialog with ReadOnlyCheckBox](images/radopenfiledialog-readonlycheckbox.png)

## DereferenceLinks

As of **R1 2018**, the **RadOpenFileDialog** exposes a **DereferenceLinks** property indicating whether a file dialog returns the location of the file referenced by a shortcut or the location of the actual shortcut file (with the **.lnk** extension).

__Example 5: Using the DereferenceLinks property__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ShowOpenFileDialog();
		}

		private void ShowOpenFileDialog()
		{
			RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
			openFileDialog.Owner = this;
			openFileDialog.DereferenceLinks = true;
			openFileDialog.ShowDialog();
			if (openFileDialog.DialogResult == true)
			{
				string filePath = openFileDialog.FileName;
				// If the selected file was C:\Users\\<user>\Desktop\Shortcut.lnk, for example,
				// the FileName property will now contain the actual location of the file,
				// for example - C:\Program Files\Program\Shortcut.exe.
			}
		}
	}
```

> If in multiple or single selection the first selected item is a link to a **directory** and DereferenceLinks is set to **True**, clicking the **Open** button will actually navigate to this directory.

## See Also
* [Visual Structure]({%slug radfiledialogs-visual-structure%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
* [Events]({%slug radfiledialogs-events%})