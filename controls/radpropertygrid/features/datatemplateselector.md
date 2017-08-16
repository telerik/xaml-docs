---
title: DataTemplateSelector Support
page_title: DataTemplateSelector Support
description: DataTemplateSelector Support
slug: radpropertygrid-datatemplateselector
tags: datatemplateselector,support
published: True
position: 3
---

# DataTemplateSelector Support

The __DataTemplateSelector__ approach enables conditional selection of __DataTemplates__, based on information provided by the respective bound data item.

{% if site.site_name == 'Silverlight' %}[Here](http://www.telerik.com/help/silverlight/gridview-template-selectors-overview.html){% endif %}{% if site.site_name == 'WPF' %}[Here](http://www.telerik.com/help/wpf/gridview-template-selectors-overview.html){% endif %} is an article that provides some additional, more extensive information on __DataTemplateSelectors__.

## DataTemplateSelectors in RadPropertyGrid

RadPropertyGrid enables its users to implement conditional editor __DataTemplate__ selection for its __PropertyGridFields__ trough a __DataTemplateSelector__:

#### __[C#] Example 1: Creating custom DataTemplateSelector__

	{{region cs-radpropertygrid-datatemplateselector_1}}
	public class Customer
	{
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
	    public string PhoneNumber { get; set; }
	    public Department Department { get; set; }
	}
	 
	public class FieldTemplateSelector : DataTemplateSelector
	{
	    public override DataTemplate SelectTemplate(object item, DependencyObject container)
	    {
	        PropertyDefinition propDef = item as PropertyDefinition;
	        if (propDef.DisplayName == "PhoneNumber")
	        {
	            return this.PhoneNumberDataTemplate;
	        }
	        if (propDef.SourceProperty.PropertyType == typeof(string))
	        {
	            return this.StringDataTemplate;
	        }
	        return null;
	    }
	 
	    public DataTemplate PhoneNumberDataTemplate { get; set; }
	    public DataTemplate StringDataTemplate { get; set; }
	}
{{endregion}}

#### __[VB.NET] Example 1: Creating custom DataTemplateSelector__

	{{region vb-radpropertygrid-datatemplateselector_1}}
	Public Class Customer
	    Public Property FirstName() As String
	    Public Property LastName() As String
	    Public Property PhoneNumber() As String
	    Public Property Department() As Department
	End Class
	Public Class FieldTemplateSelector
	    Inherits DataTemplateSelector
	    Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
	        Dim propDef As PropertyDefinition = TryCast(item, PropertyDefinition)
	        If propDef.DisplayName = "PhoneNumber" Then
	            Return Me.PhoneNumberDataTemplate
	        End If
	        If propDef.SourceProperty.PropertyType = GetType(String) Then
	            Return Me.StringDataTemplate
	        End If
	        Return Nothing
	    End Function
	    Public Property PhoneNumberDataTemplate() As DataTemplate
	        Get
	            Return m_PhoneNumberDataTemplate
	        End Get
	        Set(value As DataTemplate)
	            m_PhoneNumberDataTemplate = value
	        End Set
	    End Property
	    Private m_PhoneNumberDataTemplate As DataTemplate
	    Public Property StringDataTemplate() As DataTemplate
	        Get
	            Return m_StringDataTemplate
	        End Get
	        Set(value As DataTemplate)
	            m_StringDataTemplate = value
	        End Set
	    End Property
	    Private m_StringDataTemplate As DataTemplate
	End Class
{{endregion}}

#### __[XAML] Example 2: Defining custom DataTemplateSelector__

	{{region xaml-radpropertygrid-datatemplateselector_0}}
			<Grid>
			    <Grid.Resources>
			        <local:FieldTemplateSelector x:Key="DataTemplateSelector">
			            <local:FieldTemplateSelector.StringDataTemplate>
			                <DataTemplate>
			                    <TextBox Foreground="Red"
			         TextAlignment="Right"
			         telerik:AutoBindBehavior.UpdateBindingOnElementLoaded="Text" />
			                </DataTemplate>
			            </local:FieldTemplateSelector.StringDataTemplate>
			            <local:FieldTemplateSelector.PhoneNumberDataTemplate>
			                <DataTemplate>
			                    <telerik:RadMaskedTextInput Mask="###-###-###" Value="{Binding PhoneNumber, Mode=TwoWay}" />
			                </DataTemplate>
			            </local:FieldTemplateSelector.PhoneNumberDataTemplate>
			        </local:FieldTemplateSelector>
			    </Grid.Resources>
			    <telerik:RadPropertyGrid x:Name="rpg" EditorTemplateSelector="{StaticResource DataTemplateSelector}" />
			</Grid>
	{{endregion}}

>You might wonder where these "telerik" and "local", in front of the tags RadPropertyGrid and __FieldTemplateSelector__, came from. Well, these are the names of the namespaces you give when you import the appropriate assembly or your custom __DataTemplateSelector__ class into the XAML file.

![Rad Property Grid Template Selectors](images/RadPropertyGrid_Template_Selectors.png)

>The AutoBind attached behavior is fully compatible with the __DataTemplateSelector__ approach.

## See Also

 * [AutoBind Behaviour]({%slug radpropertygrid-autobind%})
