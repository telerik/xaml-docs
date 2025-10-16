---
title: How to replace the default ContextMenu with RadContextMenu in RadDateTimePicker
description: Using RadContextMenu instead of ContextMenu in RadDateTimePicker.
type: how-to
page_title: Show RadContextMenu rather than ContextMenu in RadDateTimePicker
slug: kb-datetimepicker-replace-contextmenu-with-radcontextmenu
position: 
tags: contextmenu, radcontextmenu, raddatetimepicker, datetimepicker
ticketid: 1427861
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDateTimePicker for WPF</td>
	    </tr>
    </tbody>
</table>


## Description
How to replace the default ContextMenu with RadContextMenu in RadDateTimePicker.

## Solution
1. Add the RadContextMenu as a StaticResource in xaml.
2. Handle the Loaded event of the RadDateTimePicker.
3. In the Loaded event, use the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) method to find the RadWatermarkTextBox inside the RadDateTimePicker and set its ContextMenu property to null.
4. Set the RadContextMenu to the RadWatermarkTextBox using the RadContextMenu.SetContextMenu() method.


```XAML
	<Grid x:Name="grid">
        <Grid.Resources>
            <telerik:RadContextMenu x:Key="ContextMenu">
                <telerik:RadMenuItem Command="ApplicationCommands.Cut" />
                <telerik:RadMenuItem Command="ApplicationCommands.Copy"  />
                <telerik:RadMenuItem Command="ApplicationCommands.Paste" />
            </telerik:RadContextMenu>
        </Grid.Resources>
        <telerik:RadDateTimePicker  Width="200" Height="25" Foreground="Green" Loaded="RadDateTimePicker_Loaded" /> 
    </Grid>
```


```C#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadDateTimePicker_Loaded(object sender, RoutedEventArgs e)
        {
            var waterMarkTextBox = (sender as RadDateTimePicker).ChildrenOfType<RadWatermarkTextBox>().FirstOrDefault();

            waterMarkTextBox.ContextMenu = null;
            var contextMenu = this.grid.FindResource("ContextMenu") as RadContextMenu;
            RadContextMenu.SetContextMenu(waterMarkTextBox, contextMenu);
        }
    }
```

>As an alternative approach, you can also [Edit the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of the RadDateTimePicker.
