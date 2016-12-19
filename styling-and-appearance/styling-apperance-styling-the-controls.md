---
title: Styling the Controls 
page_title: What is a Theme
description: What is a Theme
slug: styling-apperance-implicit-styles-overview
tags: setting,a,theme,(using,,implicit,styles)
published: True
position: 1
---

# Styling the Controls 

In order to customize the appearance of a specific control, you need to apply a style that sets a certain property. The style can be either **implicit** or **explicit**. 

Applying a style **explicitly** means that you have set a **Key** for this style and has coerced a certain control to use it. As in the example below:
 
An implicit style does not have a key attribute. It is applied for all controls of a certain type within a given scope. For example, adding the following style in the **App.xaml** file of your application will set the **Background** property for all **RadGridView** control within your application which do not have an explicit style set:



## How To Apply Custom Style to Controls  

The following example shows how to apply a custom style to a control in an application that uses the **Windows8** Theme. The control used is **RadComboBox** but the approach is identical for all controls and themes.
        
* First, add references to the required assemblies from the **Binaries.NoXaml** folder.

* Next, create a **Themes** folder in your project and copy the corresponding .xaml files from __Themes.Implicit/../Windows8/../Themes/ folder__ as shown in **Figure 4**.
        
#### __Figure 4: Copy the needed .xaml in the project__
![implicit styles 1](images/implicit_styles_1.png)

* The next step is to merge these **ResourceDictionaries** in the App.xaml file as shown in __Example 4__.          
            
#### __[XAML] Example 4: Merging the Resource Dictionaries__

{{region styling-apperance-implicit-styles-overview_0}}

        <Application xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
                     x:Class="RadControlsSilverlightNoXaml.App"
                     >
            <Application.Resources>
                <ResourceDictionary>
                    <ResourceDictionary.MergedDictionaries>
                        <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
                        <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
                    </ResourceDictionary.MergedDictionaries>
                </ResourceDictionary>
            </Application.Resources>
        </Application>
{{endregion}}

* And here is the result:

#### **Figure 5: RadComboBox default appearance**
![implicit styles 2](images/implicit_styles_2.png)

In order to modify the appearance of **RadComboBox**, simply base your custom style on the default style for the control as shown in **Example 5**.

**Example 5** shows how to create two custom styles for **RadComboBox** based on the  default styles from the **Windows8** theme.  
        
#### __[XAML] Example 5: Add custom styles for RadComboBox__

{{region styling-apperance-implicit-styles-overview_1}}
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
        <Style x:Key="CustomStyle" TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
            <Setter Property="Foreground" Value="Green" />
        </Style>
        <Style TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
            <Setter Property="Foreground" Value="Red" />
        </Style>
    </Application.Resources>
{{endregion}}

If you have three __RadComboBoxes__ as shown in __Example 6__.          
        
#### __[XAML] Example 6: RadComboBoxes with custom styling__

{{region styling-apperance-implicit-styles-overview_2}}
    <StackPanel>
        <telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" Style="{StaticResource CustomStyle}" />
        <telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" />
        <telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" />
    </StackPanel>
{{endregion}}

The __RadComboBox__ instances will be displayed as shown in __Figure 6__.
        
#### **Figure 6: RadComboBox instances with custom styles.**
![implicit styles 3](images/implicit_styles_3.png)


## Styling Custom Controls

If you're using Implicit Styles for custom controls, note that they will not automatically receive the inherited control style. You will have to base your custom style on the default style of the control that is inherited.

#### __[XAML] Example 7: Adding Style for styling custom control__

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

#### __[C#] Example 8: Setting the DefaultStyleKey for styling custom control__

{{region styling_customstyles}}
    public class MyCustomGrid : RadGridView
    {
        public MyCustomGrid()
        {
            this.DefaultStyleKey = typeof(MyCustomGrid);
        }
    }
{{endregion}}

#### __[VB.NET] Example 8: Setting the DefaultStyleKey for styling custom control__

{{region styling_customstyles-2}}
    Public Class MyCustomGrid
        Inherits RadGridView
        Public Sub New()
            Me.DefaultStyleKey = GetType(MyCustomGrid)
        End Sub
    End Class
{{endregion}}

>You might also have a look at the [Setting a Theme on a Custom Control](http://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/styling-apperance-custom-control) article.

## Control Styles Dependencies

**Example 9** lists the XAML files corresponding to the Telerik assemblies and the dependencies between them.
        
#### __[XAML] Example 9: All XAML files corresponding to the Telerik assemblies__

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

