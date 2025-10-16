---
title: Help Button
page_title: Help Button
description: The article documents the help button of RadRibbonView.
slug: radribbonview-help-button
tags: help, help button, ribbon
published: True
position: 10
---

# Help Button

The `RadRibbonView` control allows you to display a help button, which is positioned on the right side of the component. To do so, set the `HelpButtonVisibility` property to `Visible`.

__Displaying the help button__
```XAML
    <telerik:RadRibbonView HelpButtonVisibility="Visible"/>
```

__RadRibbonView with displayed help button__

![RadRibbonView with displayed help button](images/radribbonview-help-button-0.png)

## Change the Help Button Image

To set a different icon from the default one, you can use the `HelpButtonImageSource` property.

__Changing the help button image__
```XAML
    <telerik:RadRibbonView HelpButtonImageSource="myHelpButton.png"/> 
```

## Set a Custom Style for the Help Button

The RadRibbonView control exposes the `HelpButtonStyle` property that allows you to customize the help button. To do so, set a new Style that targets the `RadRibbonButton` element.

__Setting a custom Style for the help button__
```XAML
    <telerik:RadRibbonView.HelpButtonStyle>
        <!--If NoXaml is used: BasedOn="{StaticResource HelpButtonStyle}"-->
        <Style TargetType="telerik:RadRibbonButton">
            <Setter Property="Background" Value="Red"/>
            <Setter Property="BorderBrush" Value="Orange"/>
            <Setter Property="BorderThickness" Value="3"/>
        </Style>
    </telerik:RadRibbonView.HelpButtonStyle>
```

__RadRibbonView with custom style set to the help button__

![RadRibbonView with custom style set to the help button](images/radribbonview-help-button-1.png)

## Set a Command on the Help Button

The RadRibbonView control allows you to set a command for the help button via the `HelpCommand` property. It will accept every object that implements the [ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand?view=net-9.0&redirectedfrom=MSDN) interface.

The following example showcases how to use the HelpCommand property:

__Defining the RadRibbonView__
```XAML
    <telerik:RadRibbonView HelpButtonVisibility="Visible">
        <telerik:RadRibbonTab Header="Home"/>
    </telerik:RadRibbonView>
```

__Defining the DelegateCommand__
```C#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            OpenHelpPageCommand = new DelegateCommand(ExecuteCommandHandler, CanExecuteCommandHandler);
            this.DataContext = OpenHelpPageCommand;
        }

        public DelegateCommand OpenHelpPageCommand { get; set; }

        private bool CanExecuteCommandHandler(object obj)
        {
            // Implement logic that checks if the button command can be executed 
            return true;
        }

        private void ExecuteCommandHandler(object obj)
        {
            // Implement the logic that should be executed when the button is clicked 
            MessageBox.Show("Help Command Executed");
        }
    }
```

__Setting the HelpCommand property__
```XAML
    <telerik:RadRibbonView HelpButtonVisibility="Visible" HelpCommand="{Binding}">
        <telerik:RadRibbonTab Header="Home"/>
    </telerik:RadRibbonView>
```

>tip In addition you can use the `HelpCommandParameter` and the `HelpCommandTarget` properties of the RadRibbonView in order to pass additional data to the command.
>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/HelpFunctionality).