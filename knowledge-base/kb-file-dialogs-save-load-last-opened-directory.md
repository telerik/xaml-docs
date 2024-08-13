---
title: Save and Restore the Last Opened Directory in RadFileDialogs
description: How to implement save and restore last opened directory in RadOpenFileDialog.
type: how-to
page_title: Persist the Last Directory on the File System When Using RadFileDialog
slug: kb-file-dialogs-save-load-last-opened-directory
tags: radopenfiledialog, wpf, restoredirectory, mvvm, owner, dialog
res_type: kb
ticketid: 1632230
---

## Environment

| Product | Version |
| --- | --- |
| RadFileDialogs for WPF | 2023.1.315 |

## Description

How to implement custom behavior that saves and restores the last opened directory when you show a RadFileDialog.

## Solution

To ensure `RadOpenFileDialog` remembers the last opened directory even across different application sessions, implement a custom logic to store the last directory path. This approach involves saving the directory path to a persistent storage, such as application settings or a file, and then retrieving it the next time the dialog is opened.

#### __[C#]__
{{region kb-file-dialogs-save-load-last-opened-directory-0}}
    public partial class App : Application
    {
        private IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        private const string dirCacheIsoStoreFileName = "RadOpenFileDialogDirectoryCache.txt";
        private string fileDialogDirectoryCache = "C:\\Program Files (x86)";

        protected override void OnStartup(StartupEventArgs e)
        {
            LoadDirectoryCacheFromStorage();
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            SaveDirectoryCacheToStorage();
            base.OnExit(e);
        }

        internal string GetDileDialogDirectoryCache()
        {
            return this.fileDialogDirectoryCache;
        }

        internal void UpdateFileDialogDirectoryCache(string newDirectory)
        {
            this.fileDialogDirectoryCache = newDirectory;
        }

        private void LoadDirectoryCacheFromStorage()
        {
            if (isoStore.FileExists(dirCacheIsoStoreFileName))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(dirCacheIsoStoreFileName, FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        this.fileDialogDirectoryCache = reader.ReadToEnd();
                    }
                }
            }
        }

        private void SaveDirectoryCacheToStorage()
        {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(dirCacheIsoStoreFileName, FileMode.OpenOrCreate, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.Write(this.fileDialogDirectoryCache);
                }
            }
        }
    }
{{endregion}}

#### __[C#]__
{{region kb-file-dialogs-save-load-last-opened-directory-1}}
	private void OnShowDialogButton_Click(object sender, RoutedEventArgs e)
	{
		RadOpenFileDialog openFileDialog = new RadOpenFileDialog
		{
			InitialDirectory = ((App)App.Current).GetDileDialogDirectoryCache()
		};

		if (openFileDialog.ShowDialog() == true)
		{
			string fileName = openFileDialog.FileName;
			((App)App.Current).UpdateFileDialogDirectoryCache(System.IO.Path.GetDirectoryName(fileName));
		}
	}
{{endregion}}


