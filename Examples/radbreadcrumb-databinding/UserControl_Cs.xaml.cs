using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radbreadcrumb-databinding_0
public class ExplorerItem
{
 public string Header { get; set; }
 public string PreviewHeader { get; set; }
 public string Path { get; set; }
 public ImageSource IconPath { get; set;} 
}
#endregion

#region radbreadcrumb-databinding_2
public class MainViewModel
{
 public ObservableCollection<ExplorerItem> Items { get; set; }
 public string Header { get; set; }
 public MainViewModel()
 {
  ImageSourceConverter isc = new ImageSourceConverter();
  this.Header = "MyComputer";
  this.Items = new ObservableCollection<ExplorerItem>();
  ExplorerItem personalInfo = new ExplorerItem()
  {
   Header = "Personal Folders",
   IconPath = (ImageSource)isc.ConvertFromString("Images/1PersonalFolders.png"),
   Path = "PersonalFolders"
  };
  this.Items.Add(personalInfo);
  ExplorerItem programFiles = new ExplorerItem()
  {
   Header = "Program Files",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Path = "ProgramFiles"
  };
  this.Items.Add(programFiles);
  ExplorerItem programFiles86 = new ExplorerItem()
  {
   Header = "Program Files(86)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Path = "ProgramFiles(86)"
  };
  this.Items.Add(programFiles86);
  ExplorerItem downloads = new ExplorerItem()
  {
   Header = "Downloads",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Path = "Downloads"
  };
  this.Items.Add(downloads);
  ExplorerItem localHard = new ExplorerItem()
  {
   Header = "Local Disk (C:)",
   Path = "LocalDisk(C:)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/HardDrive16.png")
  };
  this.Items.Add(localHard);
  ExplorerItem localHard2 = new ExplorerItem()
  {
   Header = "Local Disk (D:)",
   Path = "LocalDisk(D:)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/HardDrive16.png")
  };
  this.Items.Add(localHard2);
  ExplorerItem desktop = new ExplorerItem()
  {
   Header = "Desktop",
   Path = "Desktop",
   IconPath = (ImageSource)isc.ConvertFromString("Images/Desktop.png")
  };
  this.Items.Add(desktop);
 }
}
#endregion

#region radbreadcrumb-databinding_5
public class ExplorerItem
{
 public string Header { get; set; }
 public string PreviewHeader { get; set; }
 public string Path { get; set; }
 public ImageSource IconPath { get; set; }
 public ObservableCollection<ExplorerItem> Children { get; set; }
 public ExplorerItem()
 {
  this.Children = new ObservableCollection<ExplorerItem>();
 }
}
#endregion

#region radbreadcrumb-databinding_7
public class MainViewModel
{
 public ObservableCollection<ExplorerItem> Items { get; set; }
 public ExplorerItem Root { get; set; }
 public MainViewModel()
 {
  this.Items = new ObservableCollection<ExplorerItem>();
  this.LoadItems();
 }
 public void LoadItems()
 {
  ImageSourceConverter isc = new ImageSourceConverter();
  ExplorerItem personalInfo = new ExplorerItem()
  {
   Header = "Personal Folders",
   IconPath = (ImageSource)isc.ConvertFromString("Images/1PersonalFolders.png"),
   Children = new ObservableCollection<ExplorerItem>() 
   {
    new ExplorerItem() {Header = "Deleted Items(6)", IconPath =  (ImageSource)isc.ConvertFromString("Images/2DeletedItems.png"), Path = "DeletedItems"},
    new ExplorerItem() {Header = "Drafts", IconPath =  (ImageSource)isc.ConvertFromString("Images/3Drafts.png"), Path = "Drafts"},
    new ExplorerItem() {Header = "Inbox(14)", IconPath =  (ImageSource)isc.ConvertFromString("Images/4Inbox.png"), Path = "Inbox",
         Children = new ObservableCollection<ExplorerItem>()
         {
          new ExplorerItem() {Header = "Folders", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Folders"},
         }
        },
    new ExplorerItem() {Header = "Junk E-mails", IconPath = (ImageSource)isc.ConvertFromString("Images/junk.png"), Path = "JunkEmails"},
    new ExplorerItem() {Header = "Outbox", IconPath =  (ImageSource)isc.ConvertFromString("Images/outbox.png"), Path = "Outbox"},
    new ExplorerItem() {Header = "Sent Items", IconPath =  (ImageSource)isc.ConvertFromString("Images/sent.png"), Path = "SentItems"},
    new ExplorerItem() {Header = "Search Folder", IconPath =  (ImageSource)isc.ConvertFromString("Images/searchFolder.png"), Path = "SearchFolder",
         Children = new ObservableCollection<ExplorerItem>()
         {
          new ExplorerItem() {Header = "From Follow up", IconPath =  (ImageSource)isc.ConvertFromString("Images/search.png"), Path = "FromFollowup"},
          new ExplorerItem() {Header = "Large Mail", IconPath =  (ImageSource)isc.ConvertFromString("Images/search.png"), Path = "LargeMail"},
          new ExplorerItem() {Header = "Unread Mail", IconPath =  (ImageSource)isc.ConvertFromString("Images/search.png"), Path = "UnreadMail"},
         }
        }
   },
   Path = "PersonalFolders"
  };
  ExplorerItem programFiles = new ExplorerItem()
  {
   Header = "Program Files",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    new ExplorerItem() { Header = "Microsoft", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Microsoft" },
    new ExplorerItem() { Header = "Microsoft.NET", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Microsoft.NET" },
    new ExplorerItem()
    {
     Header = "Internet Explorer",
     IconPath =  (ImageSource)isc.ConvertFromString("Images/folder2.png"),
     Path = "InternetExplorer",
     Children = new ObservableCollection<ExplorerItem>(){
                   new ExplorerItem() {Header = "SIGNUP", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "SIGNUP"}
                  }
    }
   },
   Path = "ProgramFiles"
  };
  ExplorerItem programFiles86 = new ExplorerItem()
  {
   Header = "Program Files(86)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    new ExplorerItem() { Header = "Microsoft", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Microsoft" },
    new ExplorerItem() { Header = "Microsoft.NET", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Microsoft.NET" },
    new ExplorerItem()
    {
     Header = "Skype",
     IconPath =  (ImageSource)isc.ConvertFromString("Images/folder2.png"),
     Path = "Skype",
     Children = new ObservableCollection<ExplorerItem>(){
                   new ExplorerItem() {Header = "Phone", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Phone"},
                   new ExplorerItem() {Header = "Toolbars", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Toolbars"},
                   new ExplorerItem() {Header = "Plugin Manager", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "PluginManager"}
                  }
    },
    new ExplorerItem()
    {
     Header = "Notepad++",
     IconPath =  (ImageSource)isc.ConvertFromString("Images/folder2.png"),
     Path = "Notepad++",
     Children = new ObservableCollection<ExplorerItem>(){
                   new ExplorerItem() {Header = "localization", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "localization"},
                   new ExplorerItem() {Header = "plugins", IconPath = (ImageSource)isc.ConvertFromString("Images/junk.png"), Path = "plugins"}
                  }
    }
   },
   Path = "ProgramFiles(86)"
  };
  ExplorerItem downloads = new ExplorerItem()
  {
   Header = "Downloads",
   IconPath = (ImageSource)isc.ConvertFromString("Images/folder2.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    new ExplorerItem() { Header = "Music", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Music" },
    new ExplorerItem() { Header = "Movies", IconPath =  (ImageSource)isc.ConvertFromString("Images/folder.png"), Path = "Movies" }
   },
   Path = "Downloads"
  };
  ExplorerItem localHard = new ExplorerItem()
  {
   Header = "Local Disk (C:)",
   Path = "LocalDisk(C:)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/HardDrive16.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    personalInfo,
    programFiles,
    programFiles86,
    downloads
   }
  };
  ExplorerItem localHard2 = new ExplorerItem()
  {
   Header = "Local Disk (D:)",
   Path = "LocalDisk(D:)",
   IconPath = (ImageSource)isc.ConvertFromString("Images/HardDrive16.png")
  };
  ExplorerItem computer = new ExplorerItem()
  {
   Header = "Computer",
   Path = "Computer",
   IconPath = (ImageSource)isc.ConvertFromString("Images/Computer.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    localHard,
    localHard2
   }
  };
  ExplorerItem computer2 = new ExplorerItem()
  {
   Header = "Computer2",
   Path = "Computer2",
   Children = new ObservableCollection<ExplorerItem>()
   {
    localHard,
    localHard2
   }
  };
  this.Root = new ExplorerItem()
  {
   Header = "Desktop",
   Path = "Desktop",
   IconPath = (ImageSource)isc.ConvertFromString("Images/Desktop.png"),
   Children = new ObservableCollection<ExplorerItem>()
   {
    computer,
    computer2
   }
  };
  this.Items = new ObservableCollection<ExplorerItem>() { this.Root };
 }
}
#endregion
}
