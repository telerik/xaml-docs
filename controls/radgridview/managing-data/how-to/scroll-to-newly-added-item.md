---
title: Scroll to Newly Added Item
page_title: Scroll to Newly Added Item
description: Get started with Telerik's WPF DataGrid and learn how to scroll to a newly added item by using the ScrollIntoViewAsync method and the CollectionChanged event.
slug: gridview-how-to-scroll-to-newly-added-item
tags: scroll,to,newly,added,item
published: True
position: 5
---

# Scroll to Newly Added Item

This article shows how to scroll RadGridView to the newly added item.

You can achieve this by using the [ScrollIntoViewAsync]({%slug gridview-scroll-item%}) method and the **CollectionChanged** event of the control's **Items** collection. For the purpose, you can create an [attached behavior]({%slug common-mvvm-attached-behavior%}) and attach it to your RadGridView control.

#### __[C#] Example 1: The custom attached behavior__

{{region cs-gridview-how-to-scroll-to-newly-added-item_0}}
    public class ScrollToNewItemBehavior
    {
        public static bool GetIsEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnabledProperty);
        }

        public static void SetIsEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsEnabledProperty, value);
        }
        
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(ScrollToNewItemBehavior), new PropertyMetadata(false, OnIsEnabledChanged));

        private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var gridView = d as RadGridView;
            gridView.Items.CollectionChanged += (s, args) =>
            {
                if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    gridView.ScrollIntoViewAsync(args.NewItems[0], gridView.Columns[0], null);
                }
            };
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: The custom attached behavior__

{{region vb-gridview-how-to-scroll-to-newly-added-item_1}}
	Public Class ScrollToNewItemBehavior
		Public Shared Function GetIsEnabled(ByVal obj As DependencyObject) As Boolean
			Return CBool(obj.GetValue(IsEnabledProperty))
		End Function

		Public Shared Sub SetIsEnabled(ByVal obj As DependencyObject, ByVal value As Boolean)
			obj.SetValue(IsEnabledProperty, value)
		End Sub

		Public Shared ReadOnly IsEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnabled", GetType(Boolean), GetType(ScrollToNewItemBehavior), New PropertyMetadata(False, AddressOf OnIsEnabledChanged))

		Private Shared Sub OnIsEnabledChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim gridView = TryCast(d, RadGridView)
			AddHandler gridView.Items.CollectionChanged, Sub(s, args)
				If args.Action = System.Collections.Specialized.NotifyCollectionChangedAction.Add Then
					gridView.ScrollIntoViewAsync(args.NewItems(0), gridView.Columns(0), Nothing)
				End If
			End Sub
		End Sub
	End Class
{{endregion}}

**Example 2** demonstrates how you can apply the new behavior to all RadGridView instances in your application via an implicit style.

#### __[XAML] Example 2: Set the attached property in an implicit style__

{{region xaml-gridview-how-to-scroll-to-newly-added-item_2}}
    <Application.Resources>
        <Style TargetType="telerik:RadGridView">
            <Setter Property="local:ScrollToNewItemBehavior.IsEnabled" Value="True" />
        </Style>
    </Application.Resources>
{{endregion}}

>If you're using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __RadGridViewStyle__ as explained in [this article]({%slug implicit-styles-styling-the-controls%}).

## See Also

* [Scroll to a Particular Row or Column]({%slug gridview-scroll-item%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})