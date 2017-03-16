---
title: Attached Behavior
page_title: Attached Behavior/Properties
description: AttachedBehavior
slug: common-mvvm-attached-behavior
tags: attached,behavior
published: True
position: 3
---

# Attached Behavior/Properties

Every developer has found him or herself in the situation where a control is missing the one feature that would be perfect in a specific situation or they would love to have a slightly different behavior of an existing feature. This is where attached properties come in handy.

[Attached properties](https://msdn.microsoft.com/en-us/library/ms749011(v=vs.110).aspx) could be used to extend the functionality of a control with very little implementation on our side. A great benefit is that an additional behavior can be added without performing the logic in the code-behind of the window where the control is situated.

## Example

The following example uses the **RadGridView** control, however, the approach can be applied to any other control of the suite.

Let's assume you would like to ask your users for confirmation when changing the selected item of the RadGridView control. Usually, in such case, you can handle the **SelectionChanging** event and cancel it on a specific condition. In order to achieve this through an attached behavior, you can apply the following logic:

**1.** Create a class that will hold the attached property:

#### **[C#] Example 1: Create the attached property**
	class RadGridViewAttachedBehavior
    {
        public static bool GetActivateSelectionChangingBehavior(DependencyObject obj)
        {
            return (bool)obj.GetValue(SelectionChangingBehaviorProperty);
        }

        public static void SetActivateSelectionChangingBehavior(DependencyObject obj, bool value)
        {
            obj.SetValue(SelectionChangingBehaviorProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectionChangingBehavior.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectionChangingBehaviorProperty =
            DependencyProperty.RegisterAttached("ActivateSelectionChangingBehavior", typeof(bool), typeof(RadGridViewAttachedBehavior), new PropertyMetadata(onSelectionChangingBehaviorActivated));

**2.** In the callback method passed to the PropertyMetadata of the attached property subscribe to the **SelectionChanging** event by using the **DependencyObject** argument:

#### **[C#] Example 2: Handle the SelectionChangingEvent of RadGridView on activating the behavior**
  	private static void onSelectionChangingBehaviorActivated(DependencyObject d, DependencyPropertyChangedEventArgs  e)
        {
            RadGridView grid = d as RadGridView;
            if ((bool)e.NewValue == true)
            {
                grid.SelectionChanging += Grid_SelectionChanging;
            }
        }

	 private static void Grid_SelectionChanging(object sender, SelectionChangingEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to change the selection?", "Selection Changing Dialog", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

**3.** Activate the attached behavior for the RadGridView instance:

####  **[XAML] Example 3: Set the attached behavior to the specific RadGridView**
		<telerik:RadGridView Grid.Row="0" 
                             Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             my:RadGridViewAttachedBehavior.ActivateSelectionChangingBehavior="True"
                             AutoGenerateColumns="False"
                             Margin="5">

Applying these steps will result in a confirmation dialog through which you can cancel the selection changing in your application, as shown in **Figure 1**.

#### **Figure 1: Confirmation dialog on changing the selected item of the RadGridView**
![](images/mvvmhelpers_selectionchanging_dialog.png)

Another implementation can be found on the following blog post - [Extending the Functionalities of RadControls with Attached Properties.](http://www.telerik.com/blogs/extending-the-functionality-of-radcontrols-with-attached-properties)

There is a demo available in our **SDK repository located at GitHub** - [ListBox SelectedItems](https://github.com/telerik/xaml-sdk/tree/master/ListBox/SelectedItems). The example is also available in the [SDK Samples Browser](http://demos.telerik.com/xaml-sdkbrowser/) labeled **"Create Attached Property for SelectedItems"**.

## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [ViewModelBase Class]({%slug common-viewmodelbase-class%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})