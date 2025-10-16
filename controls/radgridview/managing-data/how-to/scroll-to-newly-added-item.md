---
title: Scroll to Newly Added Item
page_title: Scroll to Newly Added Item
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to scroll to a newly added item by using the ScrollIntoViewAsync method and the CollectionChanged event.
slug: gridview-how-to-scroll-to-newly-added-item
tags: scroll,to,newly,added,item
published: True
position: 5
---

# Scroll to Newly Added Item

This article shows how to scroll RadGridView to the newly added item.

You can achieve this by using the [ScrollIntoViewAsync]({%slug gridview-scroll-item%}) method and the **CollectionChanged** event of the control's **Items** collection. For the purpose, you can create a [custom behavior](https://github.com/microsoft/XamlBehaviorsWpf) and attach it to your RadGridView control.

__Example 1: The custom behavior__

```C#
    public class ScrollToNewItemBehavior : Behavior<RadGridView>
    {
        private RadGridView GridView
        {
            get
            {
                return this.AssociatedObject as RadGridView;
            }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            this.GridView.Items.CollectionChanged += OnCollectionChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.GridView.Items.CollectionChanged -= OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            if (args.Action == NotifyCollectionChangedAction.Add)
            {
                this.GridView.ScrollIntoViewAsync(args.NewItems[0], this.GridView.Columns[0], null);
            }
        }
    }
```
```VB.NET
	Public Class ScrollToNewItemBehavior
		Inherits Behavior(Of RadGridView)

		Private ReadOnly Property GridView() As RadGridView
			Get
				Return TryCast(Me.AssociatedObject, RadGridView)
			End Get
		End Property

		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			AddHandler GridView.Items.CollectionChanged, AddressOf OnCollectionChanged
		End Sub

		Protected Overrides Sub OnDetaching()
			MyBase.OnDetaching()
			RemoveHandler GridView.Items.CollectionChanged, AddressOf OnCollectionChanged
		End Sub

		Private Sub OnCollectionChanged(ByVal sender As Object, ByVal args As NotifyCollectionChangedEventArgs)
			If args.Action = NotifyCollectionChangedAction.Add Then
				Me.GridView.ScrollIntoViewAsync(args.NewItems(0), Me.GridView.Columns(0), Nothing)
			End If
		End Sub
	End Class
```

**Example 2** and **Example 3** demonstrate how you can apply the new behavior to all RadGridView instances in your application by creating an attached property which you can then use in an implicit style.

__Example 2: Defining the attached property__

```C#
    public class GridViewAttachedProperties
    {
        public static bool GetScrollToNewItem(DependencyObject obj)
        {
            return (bool)obj.GetValue(ScrollToNewItemProperty);
        }

        public static void SetScrollToNewItem(DependencyObject obj, bool value)
        {
            obj.SetValue(ScrollToNewItemProperty, value);
        }

        public static readonly DependencyProperty ScrollToNewItemProperty =
            DependencyProperty.RegisterAttached("ScrollToNewItem", typeof(bool), typeof(GridViewAttachedProperties), new PropertyMetadata(false, OnScrollNewItemIntoViewChanged));

        private static void OnScrollNewItemIntoViewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var gridView = d as RadGridView;
            if (gridView != null)
            {
                var scrollToNewItem = GetScrollToNewItem(d);
                var behaviors = Interaction.GetBehaviors(d);
                var scrollToNewItemBehavior = behaviors.SingleOrDefault(x => x is ScrollToNewItemBehavior);

                if (scrollToNewItemBehavior != null && !scrollToNewItem)
                {
                    behaviors.Remove(scrollToNewItemBehavior);
                }
                else if (scrollToNewItemBehavior == null && scrollToNewItem)
                {
                    scrollToNewItemBehavior = new ScrollToNewItemBehavior();
                    behaviors.Add(scrollToNewItemBehavior);
                }
            }
        }
    }
```
```VB.NET
	Public Class GridViewAttachedProperties
		Public Shared Function GetScrollToNewItem(ByVal obj As DependencyObject) As Boolean
			Return CBool(obj.GetValue(ScrollToNewItemProperty))
		End Function

		Public Shared Sub SetScrollToNewItem(ByVal obj As DependencyObject, ByVal value As Boolean)
			obj.SetValue(ScrollToNewItemProperty, value)
		End Sub

		Public Shared ReadOnly ScrollToNewItemProperty As DependencyProperty = DependencyProperty.RegisterAttached("ScrollToNewItem", GetType(Boolean), GetType(GridViewAttachedProperties), New PropertyMetadata(False, AddressOf OnScrollNewItemIntoViewChanged))

		Private Shared Sub OnScrollNewItemIntoViewChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim gridView = TryCast(d, RadGridView)
			If gridView IsNot Nothing Then
				Dim scrollToNewItem = GetScrollToNewItem(d)
				Dim behaviors = Interaction.GetBehaviors(d)
				Dim scrollToNewItemBehavior = behaviors.SingleOrDefault(Function(x) TypeOf x Is ScrollToNewItemBehavior)

				If scrollToNewItemBehavior IsNot Nothing AndAlso Not scrollToNewItem Then
					behaviors.Remove(scrollToNewItemBehavior)
				ElseIf scrollToNewItemBehavior Is Nothing AndAlso scrollToNewItem Then
					scrollToNewItemBehavior = New ScrollToNewItemBehavior()
					behaviors.Add(scrollToNewItemBehavior)
				End If
			End If
		End Sub
	End Class
```

__Example 3: Set the attached property in an implicit style__

```XAML
    <Application.Resources>
        <Style TargetType="telerik:RadGridView">
            <Setter Property="local:GridViewAttachedProperties.ScrollToNewItem" Value="True" />
        </Style>
    </Application.Resources>
```

>If you're using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __RadGridViewStyle__ as explained in [this article]({%slug implicit-styles-styling-the-controls%}).

## See Also

* [Scroll to a Particular Row or Column]({%slug gridview-scroll-item%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})