---
title: Command Support
page_title: Command Support
description: Check our &quot;Command Support&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-features-command-support
tags: command,support
published: True
position: 5
site_name: WPF
---

# Command Support

The purpose of this article is to introduce you the command support of the __RadTreeViewItems__.
	  
## Overview

The __RadTreeViewItem__ exposes a __Command__ property of type __ICommand__. You can use this property to trigger custom logic defined in your business object. Furthermore, you can set the __CommandExecutionTrigger__ property. This property is an enumeration which controls whether the command should be executed after a __Click__ or a __DoubleClick__ on the corresponding __RadTreeViewItem__.
		

## Demonstration

In this section we will demonstrate how you can trigger custom logic implemented in your business object using the __Command Support__ of the __RadTreeViewItem__. Hence we will need to create a custom class implementing the __INotifyPropertyChanged__ interface and exposing the following properties:
		

* __Header__ of type __string__
* __Children__ of type __ObservableCollection<ItemModel>__
* __EditCommand__ of type __DelegateCommand__
* __IsInEditMode__ of type __bool__

>The __ViewModelBase__ class implements the __INotifyPropertyChanged__ interface.
		  

#### __C#__

```C#
	public class ItemModel : ViewModelBase
	{
		private bool inInEditMode;
		public bool IsInEditMode
		{
			get
			{
				return this.inInEditMode;
			}
			set
			{
				if (this.inInEditMode != value)
				{
					this.inInEditMode = value;
					this.OnPropertyChanged("IsInEditMode");
				}
			}
		}

		private string header;
		public string Header
		{
			get
			{
				return this.header;
			}
			set
			{
				if (this.header != value)
				{
					this.header = value;
					this.OnPropertyChanged("Header");
				}
			}
		}

		public DelegateCommand EditCommand { get; set; }

		public ObservableCollection<ItemModel> Children { get; set; }
	}
```

#### __VB.NET__

```VB.NET
	Public Class ItemModel
		Inherits ViewModelBase
		Private inInEditMode As Boolean
		Public Property IsInEditMode() As Boolean
			Get
				Return Me.inInEditMode
			End Get
			Set(value As Boolean)
				If Me.inInEditMode <> value Then
					Me.inInEditMode = value
					Me.OnPropertyChanged("IsInEditMode")
				End If
			End Set
		End Property

		Private m_header As String
		Public Property Header() As String
			Get
				Return Me.m_header
			End Get
			Set(value As String)
				If Me.m_header <> value Then
					Me.m_header = value
					Me.OnPropertyChanged("Header")
				End If
			End Set
		End Property

		Public Property EditCommand() As DelegateCommand
			Get
				Return m_EditCommand
			End Get
			Set(value As DelegateCommand)
				m_EditCommand = Value
			End Set
		End Property
		Private m_EditCommand As DelegateCommand

		Public Property Children() As ObservableCollection(Of ItemModel)
			Get
				Return m_Children
			End Get
			Set(value As ObservableCollection(Of ItemModel))
				m_Children = Value
			End Set
		End Property
		Private m_Children As ObservableCollection(Of ItemModel)
	End Class
```

Furthermore, we can create a __ViewModel__ class which will fill and expose an __Items__ collection of type __ObservableCollection<ItemModel>__. Also, this class will hold the custom logic which will be triggered by the command of the __RadTreeViewItem__

#### __C#__

```C#
	public class ViewModel
	{
		public ViewModel()
		{
			this.Items = new ObservableCollection<ItemModel>();
			this.GenerateItems();
		}

		public ObservableCollection<ItemModel> Items { get; set; }

		private void GenerateItems()
		{
			ObservableCollection<ItemModel> children;
			for (byte j = 1; j < 5; j++)
			{
				children = new ObservableCollection<ItemModel>();
				for (byte i = 1; i < 4; i++)
				{
					children.Add(new ItemModel()
					{
						Header = string.Format("Child {0} of root {1}", i, j),
						EditCommand = new DelegateCommand((x) => this.OnEditCommandExecute(x))
					});
				}
				this.Items.Add(new ItemModel()
				{
					Header = string.Format("Root Item {0}", j),
					Children = children,
					EditCommand = new DelegateCommand((x) => this.OnEditCommandExecute(x))
				});
			}
		}

		private void OnEditCommandExecute(object sender)
		{
			var item = sender as ItemModel;
			if (item != null)
			{
				item.IsInEditMode = true;
			}
		}
	}
```

#### __VB.NET__

```VB.NET
	Public Class ViewModel
		Public Sub New()
			Me.Items = New ObservableCollection(Of ItemModel)()
			Me.GenerateItems()
		End Sub

		Public Property Items() As ObservableCollection(Of ItemModel)
			Get
				Return m_Items
			End Get
			Set(value As ObservableCollection(Of ItemModel))
				m_Items = Value
			End Set
		End Property
		Private m_Items As ObservableCollection(Of ItemModel)

		Private Sub GenerateItems()
			Dim children As ObservableCollection(Of ItemModel)
			For j As Byte = 1 To 4
				children = New ObservableCollection(Of ItemModel)()
				For i As Byte = 1 To 3
					children.Add(New ItemModel() With {
						.Header = String.Format("Child {0} of root {1}", i, j),
						.EditCommand = New DelegateCommand(Function(x) Me.OnEditCommandExecute(x))
					})
				Next
				Me.Items.Add(New ItemModel() With {
					.Header = String.Format("Root Item {0}", j),
					.Children = children,
					.EditCommand = New DelegateCommand(Function(x) Me.OnEditCommandExecute(x))
				})
			Next
		End Sub

		Private Sub OnEditCommandExecute(sender As Object)
			Dim item = TryCast(sender, ItemModel)
			If item IsNot Nothing Then
				item.IsInEditMode = True
			End If
		End Sub
	End Class
```

In MVVM scenarios it is best to use a __Style__ to set the __Command__ and __CommandExecutionTrigger__ properties of the __RadTreeViewItems__. For this purpose we will also allow the editing of items and we will use the boolean __IsInEditMode__ property defined in the custom __ItemModel__ class to set the corresponding __RadTreeViewItem__ in edit mode. This will be done in the __OnEditCommandExecute()__ method implemented in the __ViewModel__ class. In order to differ the item that invokes the command we can pass each __RadTreeViewItem's DataContext__ as __CommandParameter__ to the method where custom logic will be implemented. In order to achieve this we can use the __RelativeSource__ binding.
		{% if site.site_name == 'WPF' %}

#### __XAML__

```XAML
	<Grid>
		<Grid.Resources>
			<HierarchicalDataTemplate x:Key="HDT" ItemsSource="{Binding Children}">
				<TextBlock Text="{Binding Header, Mode=TwoWay}" />
			</HierarchicalDataTemplate>
			<Style TargetType="telerik:RadTreeViewItem">
				<Setter Property="Command" Value="{Binding EditCommand}" />
				<Setter Property="CommandParameter" Value="{Binding}" />
				<Setter Property="CommandExecutionTrigger" Value="DoubleClick" />
				<Setter Property="IsInEditMode" Value="{Binding IsInEditMode, Mode=TwoWay}" />
			</Style>
		</Grid.Resources>
		<telerik:RadTreeView IsEditable="True"
						 IsExpandOnDblClickEnabled="False"
						 ItemTemplate="{StaticResource HDT}"
						 ItemsSource="{Binding Items}" />
	</Grid>
```

{% endif %}
{% if site.site_name == 'Silverlight' %}

#### __XAML__

```XAML
	<Grid>
		<Grid.Resources>
			<telerik:HierarchicalDataTemplate x:Key="HDT" ItemsSource="{Binding Children}">
				<TextBlock Text="{Binding Header, Mode=TwoWay}" />
			</telerik:HierarchicalDataTemplate>
			<Style TargetType="telerik:RadTreeViewItem">
				<Setter Property="Command" Value="{Binding EditCommand}" />
				<Setter Property="CommandParameter" Value="{Binding}" />
				<Setter Property="CommandExecutionTrigger" Value="DoubleClick" />
				<Setter Property="IsInEditMode" Value="{Binding IsInEditMode, Mode=TwoWay}" />
			</Style>
		</Grid.Resources>
		<telerik:RadTreeView IsEditable="True"
						 IsExpandOnDblClickEnabled="False"
						 ItemTemplate="{StaticResource HDT}"
						 ItemsSource="{Binding Items}" />
	</Grid>
```

{% endif %}
