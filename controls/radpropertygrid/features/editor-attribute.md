---
title: Editor Attribute
page_title: Editor Attribute
description: Editor Attribute
slug: radpropertygrid-editor-attribute
tags: editor,attribute
published: True
position: 17
---

# Editor Attribute



__RadPropertyGrid now provides support for the new Telerik attribute EditorAttribute__ that enables the user to define an editor for each property directly in its definition.

## 

__EditorAttribute__ is placed in __Telerik.Windows.Controls.Data binary in Telerik.Windows.Controls.Data.PropertyGrid namespace__. You need to have a reference to the assembly and add a using for the namespace. You can check the [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%}) article for more basic information.
      

It has tree properties:
        

* __EditorType__ – specifies the type of the editor used for the property
            

* __TargetProperty__ – defines the property of the custom editor that will be used for the binding
            

* __EditorStyle__ – sets the style of the UI component used for hosting the custom editor. Its values can be:
            

	* __DropDown__ - a drop down button which content is the custom editor to be displayed
                

	* __Modal__ - a button that shows a modal dialog window with the custom editor inside
                

	* __None (default value)__ – the editor will be placed directly in PropertyGridField and no special UI element will be used
                

Consequently, __EditorAttribute has a couple of constructors__ that can be used depending on the necessities:
        

* __public  EditorAttribute(Type editorType)__

* __public EditorAttribute(Type editorType, EditorStyle editorStyle)__

* __public EditorAttribute(Type editorType, string targetProperty)__

* __public EditorAttribute(Type editorType, string targetProperty, EditorStyle editorStyle)__

For the purposes of this example, the definition of RadPropertyGrid is:

#### [XAML]Example 1: Defining RadPropertyGrid

	{{region radpropertygrid-editor-attribute_0}}
	<telerik:RadPropertyGrid x:Name="propertyGrid" Item="{Binding Captain}" />
	{{endregion}}



The property __Captain__ is defined in the ViewModel as follows:
        

#### [C#]Example 2: Defining property in the ViewModel

	{{region radpropertygrid-editor-attribute_1}}
	private Player captain;
	public Player Captain
	{
		get 
		{
			if (this.captain == null)
			{
	 			this.captain = new Player("Pepe Reina", 25, Position.GK, "Spain") { PhoneNumber = new PhoneNumber() { CountryCode = "359", RegionCode = "885", Number = "434343" } }
			}
			return this.captain; 
		}
	}
	{{endregion}}



The definitions of the Custom editor __PhoneEditorControl__, the __Player business object__ used and the full implementation on the __PhoneNumber class__ can be found in the [Definitions](33f1dce2-0b7d-43b4-af52-4312258b380a#definitions) section.


* __EditorAttribute(Type editorType)__ – only the type of the editor can be specified. 

For example:
        

#### [C#]Example 3: Specifying the type of the editor

	{{region radpropertygrid-editor-attribute_2}}
	
	[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl)]
	public PhoneNumber PhoneNumber
	{
		get
		{
			return this.phoneNumber;
		}
		set
		{
			if (this.phoneNumber != value)
			{
				this.phoneNumber = value;
				this.OnPropertyChanged("PhoneNumber");
			}
		}
	}
	
	{{endregion}}



It will look like:
        
__Figure 1__: EditorAtrribute with editorType specified

![Rad Property Grid Custom Editor](images/RadPropertyGrid_CustomEditor.png)

* __EditorAttribute(Type editorType, EditorStyle editorStyle)__ – the type of the editor and the style of the containing host:

#### [C#]Example 4: Specifying the type of the editor and the style of the containing host

	{{region radpropertygrid-editor-attribute_3}}
	
	[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl), Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.DropDown)]
	public PhoneNumber PhoneNumber
	{
		get
		{
			return this.phoneNumber;
		}
		set
		{
			if (this.phoneNumber != value)
			{
				this.phoneNumber = value;
				this.OnPropertyChanged("PhoneNumber");
			}
		}
	}
	
	{{endregion}}



In this case PhoneEditorControl will be defined in a DropDownEditor control and it will look like:

__Figure 2__: EditorAtrribute with editorType and editorStyle specified

![Rad Property Grid Custom Editor In Drop Down](images/RadPropertyGrid_CustomEditorInDropDown.png)

* __EditorAttribute(Type editorType, string targetProperty)__ – the type of the editor and its property that you want to bind to. For instance:

#### [C#]Example 5: Specifying the type of the editor and the target property

{{region radpropertygrid-editor-attribute_4}}
	[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(RadNumericUpDown), "Value")]
	public int Number
	{
		get { return this.number; }
		set
		{
			if (value != this.number)
			{
				this.number = value;
				this.OnPropertyChanged("Number");
			}
		}
	}
	
	
	{{endregion}}



In this case the property from your business object – Number – will be bound to the ValueProperty of RadNumericUpDown control.     
        

The result will be:
        
__Figure 3__: EditorAtrribute with editorType and targetProperty specified

![Rad Property Grid Target Property](images/RadPropertyGrid_TargetProperty.png)

* __EditorAttribute(Type editorType, string targetProperty, EditorStyle editorStyle)__ – with this constructor all properties are set – the type of the editor, its property that will be used for the binding and the type of the host it will be placed inside. For example:

#### [C#]Example 6: Specifying the type of the editor, the target property and style of the containing host

	{{region radpropertygrid-editor-attribute_5}}
	[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(TextBox), "Text", Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.Modal)]
	public string Name
	{
		get { return this.name; }
		set
		{
			if (value != this.name)
			{
				this.name = value;
				this.OnPropertyChanged("Name");
			}
		}
	}
	
	{{endregion}}

It will look like:
        
 Figure 4: EditorAtrribute with editorType, targetProperty and editorStyle specified

 ![Rad Property Grid Custom Editor In Modal](images/RadPropertyGrid_CustomEditorInModal.png)

## Definitions

The definition of the Custom editor __PhoneEditorControl__ is:

#### [XAML]Example 7: Defining the custom editor

	{{region radpropertygrid-editor-attribute_1}}
	<UserControl x:Class="RadPropertyGrid_EditorAttribute.PhoneEditorControl"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
	             mc:Ignorable="d" >
		<UserControl.Resources>
			<Style TargetType="TextBox">
				<Setter Property="BorderBrush" Value="Transparent" />
			</Style>
		</UserControl.Resources>
	   
		<StackPanel Orientation="Horizontal" Height="20">
			<TextBlock Text="+" />
			<TextBox Text="{Binding CountryCode, Mode=TwoWay}" />
			<TextBlock Text=" (" />
			<TextBox Text="{Binding RegionCode, Mode=TwoWay}" />
				<TextBlock Text=") " />
			<TextBox Text="{Binding Number, Mode=TwoWay}" />
		</StackPanel>
	
	</UserControl>
	
	{{endregion}}



The definition of the __PhoneNumber__ class is:

#### [C#]Example 8: Defining PhoneNumber object

	{{region radpropertygrid-editor-attribute_6}}
	public class PhoneNumber : INotifyPropertyChanged
	{
		private string countryCode;
		public string CountryCode
		{
			get
			{
				return this.countryCode;
			}
			set
			{
				if (this.countryCode != value)
				{
					this.countryCode = value;
					this.OnPropertyChanged("CountryCode");
				}
			}
		}
	
		private string number;
		public string Number
		{
			get
			{
				return this.number;
			}
			set
			{
				if (this.number != value)
				{
					this.number = value;
					this.OnPropertyChanged("Number");
				}
			}
		}
	
		private string regionCode;
		public string RegionCode
		{
			get
			{
				return this.regionCode;
			}
			set
			{
				if (this.regionCode != value)
				{
					this.regionCode = value;
					this.OnPropertyChanged("RegionCode");
				}
			}
		}
	
		public event PropertyChangedEventHandler PropertyChanged;
	
		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	{{endregion}}



The definition of the __Player business object__ used for the example is:

#### [C#]Example 9: Defining Player object
	
	{{region radpropertygrid-editor-attribute_7}}
	public class Player : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		
		private string name;
		private int number;
		private Position position;
		private string country;
		private PhoneNumber phoneNumber;
		
		[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(TextBox), "Text", Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.Modal)]
		public string Name
		{
			get { return this.name; }
			set
			{
				if (value != this.name)
				{
					this.name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
		
		[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(RadNumericUpDown), "Value")]
		public int Number
		{
			get { return this.number; }
			set
			{
				if (value != this.number)
				{
					this.number = value;
					this.OnPropertyChanged("Number");
				}
			}
		}
		
		public Position Position
		{
			get { return this.position; }
			set
			{
				if (value != this.position)
				{
					this.position = value;
					this.OnPropertyChanged("Position");
				}
			}
		}	
		[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl), Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.DropDown)]
		public PhoneNumber PhoneNumber
		{
			get
			{
				return this.phoneNumber;
			}
			set
			{
				if (this.phoneNumber != value)
				{
					this.phoneNumber = value;
					this.OnPropertyChanged("PhoneNumber");
				}
			}
		}
		
		public string Country
		{
			get { return this.country; }
			set
			{
				if (value != this.country)
				{
					this.country = value;
					this.OnPropertyChanged("Country");
				}
			}
		}
		
		public Player()
		{
		
		}
		
		public Player(string name, int number, Position position, string country)
		{
			this.name = name;
			this.number = number;
			this.position = position;
			this.country = country;
		}
		
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
		{
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if (handler != null)
			{
				handler(this, args);
			}
		}
		
		private void OnPropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
	
	}
	
	{{endregion}}



# See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})
