---
title: Events
page_title: Events
description: Events
slug: radtabbedwindow-events
tags: overview
published: True
position: 3
---

# Events

The RadTabbedWindow control exposes a number of events to let you easily customize its behavior.

Most of these events are inherited from the [RadWindow](%slug radwindow-events-overview%) control. As the RadTabbedWindow contains a **TabbedWindowTabControl** which inherits from **RadTabControl**, most of its [events](%slug radtabcontrol-features-pinandclose%#events) bubble to the window as well.

## AddingNewTab

Occurs when a RadTabItem is being added via the 'Add' button in the UI. Its **AddingNewTabEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether adding the new tab via add button should be cancelled.
* **Item**: This will be the **Header** (or **DataContext**, in a databinding scenario) of the RadTabItem which is being added.

#### [XAML] Example 1: Handle the AddingNewTab event

{{region xaml-radtabbedwindow-events_1}}
    private void MainWindow_AddingNewTab(object sender, TabControlAddingNewTabEventArgs e)
    {
        if (this.TotalTabCount > this.MaxTabCount) // replace with your cancel condition
        {
            e.Cancel = true;
        }
        else
        {
            e.Item = new Person("P " + this.Items.Count);
        }
    }
{{endregion}}

>important If the provided Item's **type** does not match the data type of the current **ItemsSource** an exception will be thrown.

## PreviewTabClosed

Occurs when a RadTabItem is about to be closed. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabClosed

Occurs when a RadTabItem is closed. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabPinned

Occurs when a RadTabItem is about to be pinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabPinned

Occurs when a RadTabItem is pinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabUnpinned

Occurs when a RadTabItem is about to be unpinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabUnpinned

Occurs when a RadTabItem is unpinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewSelectionChanged

Handling this event by setting the **RadSelectionChangedEventArgs**' **Handled** property to **True** rollbacks the selection.

## SelectionChanged

Occurs when a change has been made to the selection.

## See Also

* [Key Properties](%slug radtabbedwindow-key-properties%)
* [Styles and Templates](%slug radtabbedwindow-styles-and-templates%)