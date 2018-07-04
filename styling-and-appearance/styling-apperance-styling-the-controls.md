---
title: Styling the Controls 
page_title: What is a Theme
description: What is a Theme
slug: implicit-styles-styling-the-controls
tags: setting,a,theme,(using,,implicit,styles)
published: True
position: 1
---

# Styling the Controls 

Customizing the look and feel of the **Telerik** controls is easy and intuitive due to the provided **theming** mechanism. An important step to remember is to always [base your custom styles](#basing-a-custom-style-on-a-theme-default-style) on the theme default one when using the **NoXAML** binary files. 

## Basing a Custom Style on a Theme Default Style

When you create a style that targets a specific control, you should base it on the default style that the theme provides. This way you will make sure that all properties, apart from the changed ones, are inherited from the default style.

We have followed a naming convention where the key for every control's default style consists of **the name of the control followed by a "Style" suffix**. This would mean that the default style applied for the **RadGridView** control is with **x:Key="RadGridViewStyle"**, the default one for the **RadComboBox** with **x:Key="RadComboBoxStyle"**, etc. **Example 1** shows how to create custom styles based on the default one for the **RadComboBox** control:

#### **[XAML] Example 1: Custom styles for RadComboBox**
{{region implicit-styles-styling-the-controls-0}}
	<Style x:Key="CustomStyle" TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
    	<Setter Property="Foreground" Value="Green" />
	</Style>

	<Style TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
    	<Setter Property="Foreground" Value="Red" />
	</Style>
{{endregion}}

> The Telerik themes come also with Styles for some of the [MS native controls]({%slug styling-apperance-themes-mscontrols%}#native-controls-supported-by-the-telerik-theming-mechanism) as TextBox, CheckBox, Button etc. If you want to customize the Style of those controls and keep the Telerik theming you can use the same principle as in __Example1__. For example, the x:Key of the TextBox style is __TextBoxStyle__.

## Styling Custom Controls

Note that custom controls will not automatically receive the inherited control's style. You will have to base your custom style on the default style of the control that is inherited.

#### __[XAML] Example 2: Adding Style for styling custom control__
{{region styling-apperance-implicit-styles-overview_7}}
    <Application.Resources>
      <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
          <ResourceDictionary Source="Themes/System.Windows.xaml" />
          <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
          <ResourceDictionary Source="Themes/Telerik.Windows.Controls.GridView.xaml" />
          <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
        </ResourceDictionary.MergedDictionaries>
        <Style TargetType="local:MyCustomGrid" BasedOn="{StaticResource RadGridViewStyle}" />
      </ResourceDictionary>
    </Application.Resources>
{{endregion}}

You will then need to set the control's **DefaultStyleKey**.

#### __[C#] Example 3: Setting the DefaultStyleKey for styling custom control__
{{region styling_customstyles}}
    public class MyCustomGrid : RadGridView
    {
        public MyCustomGrid()
        {
            this.DefaultStyleKey = typeof(MyCustomGrid);
        }
    }
{{endregion}}

#### __[VB.NET] Example 3: Setting the DefaultStyleKey for styling custom control__
{{region styling_customstyles-2}}
    Public Class MyCustomGrid
        Inherits RadGridView
        Public Sub New()
            Me.DefaultStyleKey = GetType(MyCustomGrid)
        End Sub
    End Class
{{endregion}}

>You might also have a look at the [Setting a Theme on a Custom Control](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/styling-apperance-custom-control) article.

## Control Styles Dependencies

**Example 4** lists the XAML files corresponding to the Telerik assemblies and the dependencies between them.
        
#### __[XAML] Example 4: All XAML files corresponding to the Telerik assemblies__

{{region styling-apperance-implicit-styles-overview_3}}
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
    
                <!-- Telerik.Windows.Controls is used by all assemblies -->            
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
    
                <ResourceDictionary Source="Themes/System.Windows.xaml" />    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
    
                <!-- Requires: System.Windows.xaml -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
    
                 <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Chart.xaml" />
    
                <!-- Requires: Telerik.Windows.Controls.Input -->    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Data.xaml" />
    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.DataVisualization.xaml" />
    
                <!-- Requires: Telerik.Windows.Controls.Navigation -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Docking.xaml" />
    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Expressions.xaml" />
    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.FixedDocumentViewers.xaml" />
    
                <!-- Requires: Telerik.Windows.Controls.Input -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.GridView.xaml" />
    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.ImageEditor.xaml" />
    
                <!-- Requires: Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.RibbonView.xaml" />
    
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.RichTextBoxUI.xaml" />
    
                <!-- Requires: System.Windows, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.ScheduleView.xaml" />
    
                <!-- Requires: Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
                <ResourceDictionary Source="Themes/Telerik.Windows.Documents.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
{{endregion}}


## See Also

* [Switching Custom Styles with Themes at Runtime]({%slug styling-apperance-custom-styles-themes-runtime%})

* [Switching Themes at Design-Time]({%slug styling-apperance-swiching-themes-design-time%})

* [Setting a Theme on MS Controls]({%slug styling-apperance-themes-mscontrols%})
