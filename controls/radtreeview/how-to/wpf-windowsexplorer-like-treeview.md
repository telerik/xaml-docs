---
title: Create Windows Explorer Like WPF TreeView
page_title: Create Windows Explorer Like WPF TreeView
description: Create Windows Explorer Like WPF TreeView
slug: radtreeview-how-to-wpf-windowsexplorer-like-treeview
tags: create,windows,explorer,like,wpf,treeview
published: True
position: 13
site_name: WPF
---

# Create Windows Explorer Like WPF TreeView

Most of the __RadTreeView__ samples you see on the web are somewhat simplistic: while they may provide heterogeneous data, usually all children of a given node are of the same type.	  

The purpose of this tutorial is to show you how to generate a __RadTreeView__ that has N level items of different types (for example Windows Explorer - in one directory you could have more directories and files).	  

The final result should look like the snapshot below:
![](images/RadTreeView_HowToWindowsExplorerTree_005_WPF.PNG)

This tutorial will combine in itself the following:

* Load on demand. For more information, read [here]({%slug radtreeview-features-load-on-demand%}).		  

* Data binding to a collection of objects. For more information, read [here]({%slug radtreeview-populating-with-data-data-binding-to-object%}).		  

* Hierarchical data templates. For more information, read [here]({%slug radtreeview-populating-with-data-hierarchical-data-templates%}).		  

* [ItemContainerStyle]({%slug radtreeview-styling-and-appearance-item-container-style%}) and [ItemContainerStyleSelector]({%slug radtreeview-populating-with-data-item-container-style-selector%}).		  

* Item images. For more information, read [here]({%slug radtreeview-feautres-treeviewitem-item-images%}).		  

## Creating Windows Explorer Like TreeView

1. Here is a simple __RadTreeView__ declaration:

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_0}}
		<telerik:RadTreeView x:Name="radTreeView" Margin="8">
			<telerik:RadTreeViewItem Header="MyComputer"
				DefaultImageSrc="/Images/MyComputer.png"/>
		</telerik:RadTreeView>
		{{endregion}}

	![](images/RadTreeView_HowToWindowsExplorerTree_010_WPF.PNG)

	The treeview has an initial item with Header "MyComputer". When the user expands the "MyComputer" node, then all available drives will be displayed. When the user expands any drive, then all sub folders and files will be displayed. The same should happen when the user expands any sub directory.

2. Create three business objects - __File__, __Directory__ and __Drive__. Here is their structure:		
	* __File__

		#### __C#__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_1}}
			public class File
			{
				public File( string fullPath, string name )
				{
					this.FullPath = fullPath;
					this.Name = name;
				}
				public string FullPath
				{
					get;
					set;
				}
				public string Name
				{
					get;
					set;
				}
			}
		{{endregion}}

		#### __VB.NET__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_2}}
			Public Class File
				Public Sub New(ByVal fullPath As String, ByVal name As String)
					Me.FullPath = fullPath
					Me.Name = name
				End Sub
			
			Private _FullPath As String
				Public Property FullPath() As String
					Get
						Return _FullPath
					End Get
					Set(ByVal value As String)
						_FullPath = value
					End Set
				End Property
			
			Private _Name As String
				Public Property Name() As String
					Get
						Return _Name
					End Get
					Set(ByVal value As String)
						_Name = value
					End Set
				End Property
			End Class
		{{endregion}}

	* __Directory__

		#### __C#__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_3}}
			public class Directory
			{
				public Directory( string fullPath, string name )
				{
					this.FullPath = fullPath;
					this.Name = name;
					this.Children = new ObservableCollection<object>();
				}
				public string FullPath
				{
					get;
					set;
				}
				public string Name
				{
					get;
					set;
				}
				public ObservableCollection<object> Children
				{
					get;
					private set;
				}
			}
		{{endregion}}

		#### __VB.NET__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_4}}
			Public Class Directory
				Public Sub New(ByVal fullPath As String, ByVal name As String)
					Me.FullPath = fullPath
					Me.Name = name
					Me.Childs = New ObservableCollection(Of Object)()
				End Sub
			
			Private _FullPath As String
				Public Property FullPath() As String
					Get
						Return _FullPath
					End Get
					Set(ByVal value As String)
						_FullPath = value
					End Set
				End Property
			
			Private _Name As String
				Public Property Name() As String
					Get
						Return _Name
					End Get
					Set(ByVal value As String)
						_Name = value
					End Set
				End Property
			
					Private _Children As ObservableCollection(Of Object)
					Public Property Children() As ObservableCollection(Of Object)
						Get
							Return _Children
						End Get
						Set(ByVal value As ObservableCollection(Of Object))
							_Children = value
						End Set
					End Property
			End Class
		{{endregion}}

	* __Drive__

		#### __C#__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_5}}
			public class Drive
			{
				public Drive( string name, bool isReady )
				{
					this.Name = name;
					this.IsReady = isReady;
					this.Children = new ObservableCollection<object>();
				}
				public string Name
				{
					get;
					set;
				}
				public bool IsReady
				{
					get;
					set;
				}
				public ObservableCollection<object> Children
				{
					get;
					private set;
				}
			}
		{{endregion}}
			
		#### __VB.NET__

		{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_6}}
			Public Class Drive
				Public Sub New(ByVal name As String, ByVal isReady As Boolean)
					Me.Name = name
					Me.IsReady = isReady
			
						Me.Children = New ObservableCollection(Of Object)()
				End Sub
			
			Private _Name As String
				Public Property Name() As String
					Get
						Return _Name
					End Get
					Set(ByVal value As String)
						_Name = value
					End Set
				End Property
			
			Private _IsReady As Boolean
				Public Property IsReady() As Boolean
					Get
						Return _IsReady
					End Get
					Set(ByVal value As Boolean)
						_IsReady = value
					End Set
				End Property
			
					Private _Children As ObservableCollection(Of Object)
					Public Property Children() As ObservableCollection(Of Object)
						Get
							Return _Children
						End Get
						Set(ByVal value As ObservableCollection(Of Object))
							_Children = value
						End Set
					End Property
			End Class
	{{endregion}}

	The __Drive__ business object has a reference to an __ObservableCollection__ of objects. These are the childs' elements. In fact this collection will store all directories and files for the drive.

	The next step is to create the model for the application.

3. Create a new class named __ServiceFacade__. Add a reference to an __ObservableCollection__ of __Drives__.
	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_7}}
		public sealed class ServiceFacade
		{
			private static ServiceFacade instance;
			public static ServiceFacade Instance
			{
				get
				{
					if ( instance == null )
					{
						instance = new ServiceFacade();
						instance.Initialize();
					}
					return instance;
				}
			}
			public ObservableCollection<Drive> Drives
			{
				get;
				private set;
			}
			private void Initialize()
			{
			}
		}
	{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_8}}
		Public NotInheritable Class ServiceFacade
			Private Shared m_instance As ServiceFacade
		
			Public Shared ReadOnly Property Instance() As ServiceFacade
				Get
					If m_instance Is Nothing Then
						m_instance = New ServiceFacade()
						m_instance.Initialize()
					End If
		
					Return m_instance
				End Get
			End Property
		
		Private _Drives As ObservableCollection(Of Drive)
			Public Property Drives() As ObservableCollection(Of Drive)
				Get
					Return _Drives
				End Get
				Set(ByVal value As ObservableCollection(Of Drive))
					_Drives = value
				End Set
			End Property
		
			Private Sub Initialize()
			End Sub
		End Class
	{{endregion}}

	For better convenience, the __ServiceFacade__ class is an implementation of the [Singleton](http://en.wikipedia.org/wiki/Singleton_pattern) pattern. When the only one instance of the class is created, the __Drives__ collection needs to be populated with all drives on your machine. This will happen in the __Initialize()__ method. Here is a sample code how this can be achieved:

	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_9}}
		private void Initialize()
		{
			this.Drives = new ObservableCollection<Drive>();
			foreach ( DriveInfo driveInfo in System.IO.DriveInfo.GetDrives() )
			{
				this.Drives.Add( new Drive( driveInfo.Name, driveInfo.IsReady ) );
			}
		}
	{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_10}}
		Private Sub Initialize()
			Me.Drives = New ObservableCollection(Of Drive)()
			For Each driveInfo As DriveInfo In System.IO.DriveInfo.GetDrives()
				Me.Drives.Add(New Drive(driveInfo.Name, driveInfo.IsReady))
			Next
		End Sub
	{{endregion}}

4. Go back to your treeview declaration and bind the root node ("MyComputer") to the just created model. Here it is shown how this can be done:

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_11}}
		<telerik:RadTreeView x:Name="radTreeView" Margin="8">
			<telerik:RadTreeViewItem Header="MyComputer"
				DefaultImageSrc="/Images/MyComputer.png"
				ItemsSource="{Binding Source={x:Static example:ServiceFacade.Instance}, Path=Drives}"/>
		</telerik:RadTreeView>
	{{endregion}}

	> The "example" alias references the namespace containing the __ServiceFacade__ class.

	So far if you run the demo, the treeview does not "know" how to represent the __Drive__ object. You need to create a __HierachicalDataTemplate__. It is quite simple and just displays the name of the drive.

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_12}}
		<HierarchicalDataTemplate DataType="{x:Type example:Drive}" ItemsSource="{Binding Path=Children}">
			<Grid>
				<TextBlock Text="{Binding Name}"/>
			</Grid>
		</HierarchicalDataTemplate>
	{{endregion}}

	Run your demo. The result so far should look like the snapshot below:
	![](images/RadTreeView_HowToWindowsExplorerTree_020_WPF.PNG)

	As you can see under the MyComputer node, all available drives are shown. However, not all of the drives are ready for use (for example, someone will not have a floppy - A:\ on his PC) and you would probably want to disable these items. Also that you need to enable the load on demand behavior for the drives. The best way to do all of this is to use __ItemContainerStyle__ and __ItemContainerStyleSelector__.

5. Create a new class named __ItemStyleSelector__, which inherits from __StyleSelector__.

	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_13}}
		public class ItemStyleSelector : StyleSelector
		{
			public override System.Windows.Style SelectStyle( object item, System.Windows.DependencyObject container )
			{
				if ( item is Drive )
					return this.DriveStyle;
				else if ( item is Directory )
					return this.DirectoryStyle;
				else if ( item is File )
					return this.FileStyle; 
				return base.SelectStyle( item, container );
			}
		
			public Style DirectoryStyle
			{
				get;
				set;
			}
			public Style FileStyle
			{
				get;
				set;
			}
			public Style DriveStyle
			{
				get;
				set;
			}
		}
	{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_14}}
		Public Class ItemStyleSelector
			Inherits StyleSelector
			Public Overloads Overrides Function SelectStyle(ByVal item As Object, ByVal container As System.Windows.DependencyObject) As System.Windows.Style
				If TypeOf item Is Drive Then
					Return Me.DriveStyle
				ElseIf TypeOf item Is Directory Then
					Return Me.DirectoryStyle
				ElseIf TypeOf item Is File Then
					Return Me.FileStyle
				End If
		
				Return MyBase.SelectStyle(item, container)
			End Function
		
		Private _DirectoryStyle As Style
			Public Property DirectoryStyle() As Style
				Get
					Return _DirectoryStyle
				End Get
				Set(ByVal value As Style)
					_DirectoryStyle = value
				End Set
			End Property
		
		Private _FileStyle As Style
			Public Property FileStyle() As Style
				Get
					Return _FileStyle
				End Get
				Set(ByVal value As Style)
					_FileStyle = value
				End Set
			End Property
		
		Private _DriveStyle As Style
			Public Property DriveStyle() As Style
				Get
					Return _DriveStyle
				End Get
				Set(ByVal value As Style)
					_DriveStyle = value
				End Set
			End Property
		End Class
	{{endregion}}

	Add a new style in your control resources. Here is how the __Style__ for all the drives would look like:

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_15}}
		<UserControl.Resources>
		
			<Style x:Key="DriveItemStyle" TargetType="{x:Type telerik:RadTreeViewItem}">
				<Setter Property="IsLoadOnDemandEnabled" Value="{Binding IsReady}"/>
				<Setter Property="IsEnabled" Value="{Binding IsReady}"/>
				<Setter Property="DefaultImageSrc" Value="/Images/Drive.png"/>
				<Style.Triggers>
					<Trigger Property="IsExpanded" Value="True">
						<Trigger.Setters>
							<Setter Property="Foreground" Value="Blue"/>
							<Setter Property="FontStyle" Value="Italic"/>
						</Trigger.Setters>
					</Trigger>
				</Style.Triggers>
			</Style>
		
			<example:ItemStyleSelector x:Key="ItemStyleSelector"
				DriveStyle="{StaticResource DriveItemStyle}"/>
		
			<HierarchicalDataTemplate DataType="{x:Type example:Drive}" ItemsSource="{Binding Path=Children}">
				<Grid>
					<TextBlock Text="{Binding Name}"/>
				</Grid>
			</HierarchicalDataTemplate>
		
		</UserControl.Resources>
		<telerik:RadTreeView x:Name="radTreeView"
							 Margin="8"
							 IsLoadOnDemandEnabled="True"
							 ItemPrepared="RadTreeView_ItemPrepared"
							 LoadOnDemand="RadTreeView_LoadOnDemand">
			<telerik:RadTreeViewItem Header="MyComputer"
									 ItemsSource="{Binding Source={x:Static example:ServiceFacade.Instance},
														   Path=Drives}" />
		</telerik:RadTreeView>
	{{endregion}}

	This style performs the following:

	* Uses a style binding to bind the __IsLoadOnDemandEnabled__ and __IsEnabled__ properties of the __RadTreeViewItem__ to the __IsReady__ property to the Drive business object.
	* Sets the default image for the __RadTreeViewItem__.
	* Uses a simple trigger to change the Foreground and the __FontStyle__ properties of the __RadTreeViewItem__ when the item is expanded.				

	Also a new instance of the __ItemStyleSelector__ class is declared and the "DriveStyle" is set. The other two styles - "DirectoryStyle" and "FileStyle" will be declared and set later. Furthermore we subscribe to the __LoadOnDemand__ and __ItemsPrepared__ events of the __RadTreeView__ control.

	Next you can go back to your root node ("MyComputer") declaration and set the __ItemContainerStyleSelector__ property.

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_18}}
				<telerik:RadTreeView x:Name="radTreeView" 
									 Margin="8" 
									 ItemPrepared="RadTreeView_ItemPrepared"
									 LoadOnDemand="RadTreeView_LoadOnDemand">
			<telerik:RadTreeViewItem Header="MyComputer"
				DefaultImageSrc="/Images/MyComputer.png"
				ItemsSource="{Binding Source={x:Static example:ServiceFacade.Instance}, Path=Drives}"
				ItemContainerStyleSelector="{StaticResource ItemStyleSelector}"/>
		</telerik:RadTreeView>
	{{endregion}}

	Now run your demo. After applying the __Style__ you can see the difference. The drives which are not ready are disabled. Try to expand any of the enabled items - the LoadOnDemand event is fired.
	![](images/RadTreeView_HowToWindowsExplorerTree_030_WPF.PNG)

	You are one step closer to the final result. Next, you need to handle with load on demand event.  

6. Switch the code-behind and add the following code for the load on demand handler:

	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_19}}
		private void RadTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
		{
			e.Handled = true;
			RadTreeViewItem expandedItem = e.OriginalSource as RadTreeViewItem;
			if ( expandedItem == null )
				return;
		
			Drive drive = expandedItem.Item as Drive;
			if ( drive != null )
			{
				ServiceFacade.Instance.LoadChildren( drive );
				return;
			}
		
			Directory directory = expandedItem.Item as Directory;
			if ( directory != null )
			{
				ServiceFacade.Instance.LoadChildren( directory );
			}
		}
	{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_20}}
			Private Sub RadTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			e.Handled = true;
		
				Dim expandedItem As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
				If expandedItem Is Nothing Then
					Exit Sub
				End If
		
				Dim drive As Drive = TryCast(expandedItem.Item, Drive)
				If drive IsNot Nothing Then
					ServiceFacade.Instance.LoadChildren(drive)
					Exit Sub
				End If
		
				Dim directory As Directory = TryCast(expandedItem.Item, Directory)
				If directory IsNot Nothing Then
					ServiceFacade.Instance.LoadChildren(directory)
				End If
			End Sub
	{{endregion}}

	The code just takes the expanded item and makes a call to the __ServiceFacade__ object to load the children.

	> Be sure that you set the __Handled__ property of the __RoutedEvent__ to __True__. Otherwise, when you expand a directory object, the event will be bubbled up the visual tree and will be handled twice (or more).

	After this you can add the following public methods to the __ServiceFacade__ class.

	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_21}}
		public void LoadChildren( Drive d )
		{
			foreach ( string directory in System.IO.Directory.GetDirectories( d.Name ) )
			{
				DirectoryInfo directoryInfo = new DirectoryInfo( directory );
				d.Children.Add( new Directory( directory, directoryInfo.Name ) );
			}
			foreach ( string file in System.IO.Directory.GetFiles( d.Name ) )
			{
				FileInfo fileInfo = new FileInfo( file );
				d.Children.Add( new File( file, fileInfo.Name ) );
			}
		}
		
		public void LoadChildren( Directory d )
		{
			foreach ( string directory in System.IO.Directory.GetDirectories( d.FullPath ) )
			{
				DirectoryInfo directoryInfo = new DirectoryInfo( directory );
				d.Children.Add( new Directory( directory, directoryInfo.Name ) );
			}
			foreach ( string file in System.IO.Directory.GetFiles( d.FullPath ) )
			{
				FileInfo fileInfo = new FileInfo( file );
				d.Children.Add( new File( file, fileInfo.Name ) );
			}
		}
		{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_22}}
		Public Sub LoadChildren(ByVal d As Drive)
			For Each directory As String In System.IO.Directory.GetDirectories(d.Name)
				Dim directoryInfo As New DirectoryInfo(directory)
				d.Children.Add(New Directory(directory, directoryInfo.Name))
			Next
			For Each file As String In System.IO.Directory.GetFiles(d.Name)
				Dim fileInfo As New FileInfo(file)
				d.Children.Add(New File(file, fileInfo.Name))
			Next
		End Sub
	
		Public Sub LoadChildren(ByVal d As Directory)
			For Each directory As String In System.IO.Directory.GetDirectories(d.FullPath)
				Dim directoryInfo As New DirectoryInfo(directory)
				d.Children.Add(New Directory(directory, directoryInfo.Name))
			Next
			For Each file As String In System.IO.Directory.GetFiles(d.FullPath)
				Dim fileInfo As New FileInfo(file)
				d.Children.Add(New File(file, fileInfo.Name))
			Next
		End Sub
	{{endregion}}

	Both of the overloads load the child items respectively for the __Drive__ object and for the __Directory__ object. However, we don't need to load children for the __Files__ objects and this is why we can set their __IsLoadOnDemandEnabled__ property to __False__. The best way to do this is to subscribe to the __ItemPrepared__ event of the __RadTreeView__ control and implement the following code:

	#### __C#__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_22}}
		private void RadTreeView_ItemPrepared(object sender, RadTreeViewItemPreparedEventArgs e)
		{
			if (e.PreparedItem.DataContext is File)
			{
				e.PreparedItem.IsLoadOnDemandEnabled = false;
			}
		}
	{{endregion}}

	#### __VB.NET__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_23}}
			Private Sub RadTreeView_ItemPrepared(sender As Object, e As RadTreeViewItemPreparedEventArgs)
				If TypeOf e.PreparedItem.DataContext Is File Then
					e.PreparedItem.IsLoadOnDemandEnabled = False
				End If
			End Sub
	{{endregion}}

	The final step is to add __HierarchicalDataTemplate__(DataTemplate) and __Styles__ for the __Directory__ object and the __File__ object.  		

7. Declare a new __HierarchicalDataTemplate__ for the __Directory__ object and a __DataTemplate__ for the __File__ object in your application resources:

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_23}}
		<DataTemplate DataType="{x:Type example:File}">
			<TextBlock Text="{Binding Name}"/>
		</DataTemplate>
		
		<HierarchicalDataTemplate DataType="{x:Type example:Directory}"
			ItemsSource="{Binding Children}">
			<TextBlock Text="{Binding Name}"/>
		</HierarchicalDataTemplate>
	{{endregion}}  

8. Add two additional styles - one for the __Directory__ object and one for the __File__ object. Update your __ItemStyleSelector__ declaration - set the __DirectoryStyle__ and __FileStyle__ properties:

	#### __XAML__

	{{region radtreeview-how-to-wpf-windowsexplorer-like-treeview_24}}
		<Style x:Key="DirectoryItemStyle" TargetType="{x:Type telerik:RadTreeViewItem}">
			<Setter Property="Foreground" Value="Black"/>
			<Setter Property="FontStyle" Value="Normal"/>
			<Setter Property="DefaultImageSrc" Value="/Images/Folder.png"/>
			<Style.Triggers>
				<Trigger Property="IsExpanded" Value="True">
					<Trigger.Setters>
						<Setter Property="Foreground" Value="Blue"/>
						<Setter Property="FontStyle" Value="Italic"/>
					</Trigger.Setters>
				</Trigger>
			</Style.Triggers>
		</Style>
		
		<Style x:Key="FileItemStyle" TargetType="{x:Type telerik:RadTreeViewItem}">
			<Setter Property="Foreground" Value="Black"/>
			<Setter Property="FontStyle" Value="Normal"/>
			<Setter Property="DefaultImageSrc" Value="/Images/File.png"/>
		</Style>
		
		<example:ItemStyleSelector x:Key="ItemStyleSelector"
			DriveStyle="{StaticResource DriveItemStyle}"
			DirectoryStyle="{StaticResource DirectoryItemStyle}"
			FileStyle="{StaticResource FileItemStyle}"/>
	{{endregion}}

	The directory style is similar to the drive style. However, the style for the file object is a little different. It sets a different image.		

With the last declarations the WPF Windows Explorer TreeView is ready. Run your demo.
![](images/RadTreeView_HowToWindowsExplorerTree_040_WPF.PNG)

>tip Of course, you could experiment with the application and add additional functionality. Only the sky can be the limit for you!

>The initial load of the drives is a slower operation and can cause your application freezing. Consider adding some loading animation.

# See Also
 * [Bind RadTreeView to Self-Referencing Data]({%slug radtreeview-how-to-bind-to-self-referencing-data%})
 * [Disable Default Animation in RadTreeView]({%slug radtreeview-how-to-disable-default-animation%})