---
title: FlagEnumEditor
page_title: FlagEnumEditor
description: FlagEnumEditor
slug: radpropertygrid-radenumeditor
tags: flagenumeditor
published: True
position: 6
---

# FlagEnumEditor

RadPropertyGrid now supports editing bit flag enum by exposing a new editor – __FlagEnumEditor__. It enables the user to store any combination of the values that are defined in the enumerator list:

![Rad Property Grid Flag Enum Editor 5](images/RadPropertyGrid_FlagEnumEditor_5.png)

You can define flag enum by setting __FlagsAttribute__ as follows:

#### __[C#] Example 1: Defining flag enum__

	{{region cs-radpropertygrid-flagenumeditor_0}}
	[Flags]
	public enum Permissions
		{
			Read = 1,
			Write = 2,
			Execute = 4
		}
	
	{{endregion}}

#### __[VB.NET] Example 1: Defining flag enum__

	{{region vb-radpropertygrid-flagenumeditor_0}}
	    <Flags()> _
	    Public Enum Permissions
	        Read = 1
	        Write = 2
	        Execute = 4
	    End Enum
	{{endregion}}

Each element should contain name and a value (which should be degree of 2 – 1, 2, 4, 8, 16, etc.).

>You can find more information about enum and flag enum in [this article](http://msdn.microsoft.com/en-us/library/cc138362.aspx).

Once you define your flag enum, you can edit it in RadPropertyGrid as follows:    

![Rad Property Grid Flag Enum Editor 2](images/RadPropertyGrid_FlagEnumEditor_2.png)

Furthermore, if you define zero and -1 values in your flag enum (meaning no flags are set and all flags are set correspondingly), you can benefit from the built-in functionality for selecting and unselecting the elements of the enum:

#### __[C#] Example 2: Defining flag enum__

	{{region cs-radpropertygrid-flagenumeditor_1}}
	namespace RPG_WPF
	{
	    [Flags]
	    public enum Permissions
	    {
	        All = -1,
	        None = 0,
	        Read = 1,
	        Write = 2,
	        Execute = 4
	    }
	}
	{{endregion}}

#### __[VB.NET] Example 2: Defining flag enum__

	{{region vb-radpropertygrid-flagenumeditor_1}}
	Namespace RPG_WPF
	        <Flags()> _
	        Public Enum Permissions
	            All = -1
	            None = 0
	            Read = 1
	            Write = 2
	            Execute = 4
	        End Enum
	    End Namespace
	    '#End Region
	
	End Class
	{{endregion}}

>Do not define values with 0 and -1 values if you do not mean to use them as select no flag and select all flags.

You can manually define your __FlagEnumEditor__ in __XAML__, like so:

#### __[XAML] Example 4: Defining FlagEnumEditor__

	{{region xaml-radpropertygrid-flagenumeditor_2}}
	<telerik:PropertyDefinition Binding="{Binding Permission}"> 
	                        <telerik:PropertyDefinition.EditorTemplate> 
	                            <DataTemplate> 
	                                <telerik:FlagEnumEditor Value="{Binding Permission}" EnumType="my:Permissions"/> 
	                            </DataTemplate> 
	                        </telerik:PropertyDefinition.EditorTemplate> 
	                    </telerik:PropertyDefinition>
	{{endregion}}

Thus your __FlagEnumEditor__ will look like:

![Rad Property Grid Flag Enum Editor 3](images/RadPropertyGrid_FlagEnumEditor_3.png)

![Rad Property Grid Flag Enum Editor 4](images/RadPropertyGrid_FlagEnumEditor_4.png)
