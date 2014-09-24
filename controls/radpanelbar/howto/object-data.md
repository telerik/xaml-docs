---
title: Bind to object data
page_title: Bind to object data
description: Bind to object data
slug: radpanelbar-object-data
tags: bind,to,object,data
published: True
position: 1
---

# Bind to object data



## 

__RadPanelBar__ can be bound to a collection of objects and dynamically create its collection of items.
          The collection that is provided as items source can contain either __RadPanelBarItems__ 
          or any other type of objects. If the items source collection contains __RadPanelBarItems__, they are directly made 
          children of the __RadPanelBar__ control. 
          Otherwise, the objects in the items source collection are wrapped in __RadPanelBarItem__ objects and then 
          are pushed into the __Items__ collection of the __RadPanelBar__ control.

Naturally, if the collection you are binding to implements the __INotifyCollectionChanged__ interface, 
        whenever your source collection is changed, the change would be immediately reflected in the __Items__ collection 
        of the __RadPanelBar__.

Here is an example of binding a __RadPanelBar__ control to a collection of strings:

#### __C#__

{{region radpanelbar-object-data_0}}
				List<string> myListDataSource = new List<string>();
				myListDataSource.Add("Item 1");
				myListDataSource.Add("Item 2");
				myListDataSource.Add("Item 3");
				RadPanelBar myPanel = new RadPanelBar();
				myPanel.ItemsSource = myListDataSource;
	{{endregion}}



#### __VB.NET__

{{region radpanelbar-object-data_0}}
		Dim myListDataSource As New List(Of String)()
		myListDataSource.Add("Item 1")
		myListDataSource.Add("Item 2")
		myListDataSource.Add("Item 3")
		Dim myPanel As New RadPanelBar()
		myPanel.ItemsSource = myListDataSource
	#End Region
	
	End Class
	#Region "radpanelbar-object-data_1"
	Partial Public Class Example
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
	
			Dim sourceCollection As New List(Of SourceCollection)()
	
			sourceCollection.Add(New SourceCollection())
			sourceCollection.Add(New SourceCollection())
			sourceCollection.Add(New SourceCollection())
			Dim myPanel As New RadPanelBar()
			myPanel.ItemsSource = sourceCollection
	
			myPanel.DisplayMemberPath = "Text"
		End Sub
	End Class
	Public Class SourceCollection
		Private m_number As Random
		Public Sub New()
			m_number = New Random(CInt(DateTime.Now.Ticks))
		End Sub
		Public ReadOnly Property Time() As DateTime
			Get
				Return DateTime.Now
			End Get
		End Property
		Public ReadOnly Property Number() As Integer
			Get
				Return m_number.[Next](0, 1000)
			End Get
		End Property
		Public ReadOnly Property Text() As String
			Get
				' Return a string of 8 random characters from A to Z
				Dim randomText As New System.Text.StringBuilder(8)
				For i As Integer = 0 To 7
					randomText.Append(ChrW(65 + (m_number.NextDouble() * 25)))
				Next
				Return randomText.ToString()
			End Get
		End Property
	End Class
	#End Region
	



By default, the string values from the items source collection will be assigned to the __Header__ 
        property of each __RadPanelBarItem__ in the __RadPanleBar__ control you are populating.

In case you want to display (in the item headers) a specific property of an object in a source collection, you can use the 
        __DisplayMemberPath__ property of __RadPanelBar__. You should set 
        __DisplayMemberPath__ to the name of the property you want to be displayed in the item header, like so:

#### __C#__

{{region radpanelbar-object-data_1}}
		public partial class Example : UserControl
		{
			public Example()
			{
				InitializeComponent();
	
				List<SourceCollection> sourceCollection = new List<SourceCollection>();
	
				sourceCollection.Add(new SourceCollection());
				sourceCollection.Add(new SourceCollection());
				sourceCollection.Add(new SourceCollection());
				RadPanelBar myPanel = new RadPanelBar();
				myPanel.ItemsSource = sourceCollection;
				myPanel.DisplayMemberPath = "Text";
	
			}
		}
		public class SourceCollection
		{
			private Random number;
			public SourceCollection()
			{
				number = new Random((int)DateTime.Now.Ticks);
			}
			public DateTime Time
			{
				get { return DateTime.Now; }
			}
			public int Number
			{
				get
				{
					return number.Next(0, 1000);
				}
			}
			public string Text
			{
				get
				{
					// Return a string of 8 random characters from A to Z
					System.Text.StringBuilder randomText = new System.Text.StringBuilder(8);
					for (int i = 0; i < 8; i++)
					{
						randomText.Append((char)(65 + (number.NextDouble() * 25)));
					}
					return randomText.ToString();
				}
			}
		}
	{{endregion}}



#### __VB.NET__

{{region radpanelbar-object-data_1}}
	Partial Public Class Example
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
	
			Dim sourceCollection As New List(Of SourceCollection)()
	
			sourceCollection.Add(New SourceCollection())
			sourceCollection.Add(New SourceCollection())
			sourceCollection.Add(New SourceCollection())
			Dim myPanel As New RadPanelBar()
			myPanel.ItemsSource = sourceCollection
	
			myPanel.DisplayMemberPath = "Text"
		End Sub
	End Class
	Public Class SourceCollection
		Private m_number As Random
		Public Sub New()
			m_number = New Random(CInt(DateTime.Now.Ticks))
		End Sub
		Public ReadOnly Property Time() As DateTime
			Get
				Return DateTime.Now
			End Get
		End Property
		Public ReadOnly Property Number() As Integer
			Get
				Return m_number.[Next](0, 1000)
			End Get
		End Property
		Public ReadOnly Property Text() As String
			Get
				' Return a string of 8 random characters from A to Z
				Dim randomText As New System.Text.StringBuilder(8)
				For i As Integer = 0 To 7
					randomText.Append(ChrW(65 + (m_number.NextDouble() * 25)))
				Next
				Return randomText.ToString()
			End Get
		End Property
	End Class
	#End Region
	


