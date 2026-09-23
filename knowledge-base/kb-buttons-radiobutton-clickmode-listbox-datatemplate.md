---
title: Using RadioButton ClickMode and Resolving Selection Flipping in RadListBox DataTemplate
description: Set RadioButton.ClickMode in code or XAML and prevent IsSelected from reverting when a RadioButton is hosted in a RadListBox DataTemplate.
components: ["buttons"]
type: troubleshooting
page_title: RadioButton ClickMode and Selection Flipping in RadListBox DataTemplate
slug: kb-buttons-radiobutton-clickmode-listbox-datatemplate
position: 0
tags: radiobutton, radradiobutton, clickmode, frameworkelementfactory, radlistbox, datatemplate, isselected, ischecked, selection
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812 | RadRadioButton |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

When creating a `DataTemplate` in code (using `FrameworkElementFactory` or `XamlReader`) that hosts a `RadioButton` (or `RadRadioButton`) inside an items control such as `RadListBox`, clicking the radio button causes the bound property (such as `IsSelected` or `IsChecked`) to be invoked twice: first receiving `true`, and then immediately reverting to `false`.

Developers often ask about `RadioButton.ClickModeProperty` to check whether changing the click timing (press vs. release) resolves the double-invocation or selection-reverting behavior.

## What is RadioButton.ClickModeProperty?

`ClickModeProperty` is a dependency property inherited by `RadioButton` and `RadRadioButton` from `System.Windows.Controls.Primitives.ButtonBase`:

* **`ClickMode.Release`** (Default): The `Click` / `Checked` event fires when the mouse button is pressed and then released over the button.
* **`ClickMode.Press`**: The event fires immediately as soon as the mouse button is pressed down.
* **`ClickMode.Hover`**: The event fires when the mouse pauses over the button.

In code (such as with `FrameworkElementFactory`), you can set it via:

```csharp
feRadio.SetValue(System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty, ClickMode.Press);
```

While changing `ClickMode` to `Press` changes the input event timing, **it does not prevent `IsSelected` from reverting to `false`** if the underlying bindings or group definitions conflict with `RadListBox` selection mechanics.

## Cause of the Selection Reverting to False

When a `RadioButton` is hosted inside a `RadListBox.ItemTemplate`, three common issues trigger the immediate `true -> false` flip:

1. **Incorrect `SelectedValuePath` Binding on `RadListBox`:**
   `SelectedValuePath` expects a literal **string property name** (for example, `"IsSelected"` or `"Id"`), NOT a `Binding` object. Writing:
   ```csharp
   // INCORRECT: assigns a Binding object to a property expecting a string
   feListBox.SetBinding(RadListBox.SelectedValuePathProperty, new Binding("IsSelected") { Mode = BindingMode.TwoWay });
   ```
   binds `SelectedValuePath` itself, corrupting the internal selection lookup and resetting the selected item to `null` or unselected when clicked.

2. **Shared `GroupName` Across Items:**
   Setting a hardcoded `GroupName="BindingGroup"` on the `RadioButton` inside the template causes all radio buttons in every row to share a single mutually exclusive group. When clicking an item, WPF attempts to deselect other items, conflicting with the list box's item container selection and triggering a deselection cascade.

3. **Unsynchronized `ItemContainerStyle`:**
   When clicking the radio button, the `RadioButton.IsChecked` updates, but the container (`RadListBoxItem.IsSelected`) does not update unless synchronized via `ItemContainerStyle` with `Mode=TwoWay`. If the container selection is not synchronized, subsequent mouse or focus events from the parent `RadListBoxItem` override the check state.

## Solution

To properly embed a `RadioButton` inside `RadListBox` without selection conflicts:

### 1. Synchronize Selection via `ItemContainerStyle`

Bind `RadListBoxItem.IsSelectedProperty` to your item's `IsSelected` property using `BindingMode.TwoWay`. Do not bind `SelectedValuePath` to a `Binding` object:

```csharp
// ItemContainerStyle to sync selection between model and RadListBoxItem
var itemStyle = new Style(typeof(Telerik.Windows.Controls.RadListBoxItem));
itemStyle.Setters.Add(new Setter(
    Telerik.Windows.Controls.RadListBoxItem.IsSelectedProperty,
    new Binding("IsSelected") { Mode = BindingMode.TwoWay }));

feListBox.SetValue(Telerik.Windows.Controls.RadListBox.ItemContainerStyleProperty, itemStyle);
```

### 2. Configure the RadioButton Template Without Conflicting Groups

In the `RadioButton` factory, bind `IsChecked` to `IsSelected` with `BindingMode.TwoWay`. If you only have one radio button per row representing that row's selection, omit `GroupName` or bind `GroupName` to a unique identifier per item (such as item ID):

```csharp
FrameworkElementFactory feRadio = new FrameworkElementFactory(typeof(RadioButton));
feRadio.SetBinding(RadioButton.ContentProperty, new Binding("Description1"));
feRadio.SetBinding(RadioButton.IsCheckedProperty, new Binding("IsSelected") 
{ 
    Mode = BindingMode.TwoWay, 
    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged 
});

// Optional: Set ClickMode if you want the radio button to respond on mouse press
feRadio.SetValue(System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty, ClickMode.Press);

DataTemplate itemTemplate = new DataTemplate();
itemTemplate.VisualTree = feRadio;
itemTemplate.Seal();

feListBox.SetValue(Telerik.Windows.Controls.RadListBox.ItemTemplateProperty, itemTemplate);
```

### 3. Remove `SelectedValuePath` Binding

If you do not need `SelectedValue`, omit both `SelectedValue` and `SelectedValuePath`. If you do use them, pass a string literal representing the property name:

```csharp
// Only if using SelectedValue:
feListBox.SetValue(Telerik.Windows.Controls.RadListBox.SelectedValuePathProperty, "IsSelected");
```

## See Also

* [Using DataTemplate in Code]({%slug using-datatemplate-in-code%})
* [Radio Button Features]({%slug radbutton-features-radio-button%})
* [RadButtons Overview]({%slug radbuttons-overview%})
