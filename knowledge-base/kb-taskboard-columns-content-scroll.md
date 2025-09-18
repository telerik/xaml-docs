---
title: Set Can Content Scroll of TaskBoard Columns
description: This article showcases how to set the ScrollViewer.CanContentScroll on the RadTaskBoard's columns.
page_title: TaskBoard Columns With Set Can Content Scroll
type: how-to
slug: taskboard-columns-content-scroll
position: 0
tags: taskboard, columns, cancontentscroll, scrollviewer
ticketid: 1698948
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.3.813</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadTaskBoard for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Set the `CanContentScroll` property of the `ScrollViewer` element on the `RadTaskBoard` control's columns.

## Solution

The columns of the control are represented by the `TaskBoardColumnContainer` element. It contains a `ScrollViewer` in its `ControlTemplate`, which has its `CanContentScroll` property set to __True__.

To customize this, you can create a new [attached property]({%slug common-mvvm-attached-behavior%}) for the TaskBoardColumnContainer element and retrieve its ScrollViewer on the `Loaded` event. To do so, you can use the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) extension method.

To set the attached property, create an implicit Style that targets the TaskBoardColumnContainer element.

#### __[C#] Defining the attached property for setting the CanContentScroll of the ScrollViewer__
{{region taskboard-columns-content-scroll-0}}
    public class TaskBoardColumnContainerExtensions
    {
        public static bool GetCanContentScroll(DependencyObject obj)
        {
            return (bool)obj.GetValue(CanContentScrollProperty);
        }

        public static void SetCanContentScroll(DependencyObject obj, bool value)
        {
            obj.SetValue(CanContentScrollProperty, value);
        }

        public static readonly DependencyProperty CanContentScrollProperty =
            DependencyProperty.RegisterAttached("CanContentScroll", typeof(bool), typeof(TaskBoardColumnContainerExtensions), new PropertyMetadata  (true, OnCanContentScrollChanged));

        private static void OnCanContentScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TaskBoardColumnContainer taskBoardColumnContainer = (TaskBoardColumnContainer)d;

            taskBoardColumnContainer.Dispatcher.BeginInvoke(() => 
            {
                ScrollViewer scrollViewer = taskBoardColumnContainer.ChildrenOfType<ScrollViewer>().FirstOrDefault();

                if (scrollViewer != null)
                {
                    scrollViewer.CanContentScroll = (bool)e.NewValue;
                }
            });
        }
    }
{{endregion}}

#### __[XAML] Applying the attached property to the TaskBoardColumnContainer element__
{{region taskboard-columns-content-scroll-1}}
    <!-- If NoXaml is used: BasedOn="{StaticResource TaskBoardColumnContainerStyle}" -->
    <Style TargetType="taskboard:TaskBoardColumnContainer">
        <Setter Property="local:TaskBoardColumnContainerExtensions.CanContentScroll" Value="False"/>
    </Style>
{{endregion}}