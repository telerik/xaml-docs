---
name: style-brand-terms
description: "Use this skill to write or review Telerik UI for WPF brand names, interaction verbs, and technical vocabulary. Covers WPF controls, XAML, C#, MVVM, data binding, commands, themes, resources, document processing, and licensing."
---

# Telerik UI for WPF Brand Names and Vocabulary

Use this skill to review customer-facing WPF documentation and support guidance. Preserve exact API identifiers, package names, resource keys, UI labels, quoted diagnostics, and technical meaning. This terminology guide does not replace API verification, build testing, or security review.

## Brand Names

On the first mention in article body prose, use **Progress® Telerik® UI for WPF**. On later mentions, use **Telerik UI for WPF** or the specific control name. Do not add trademark symbols to headings, metadata, code, package names, or exact UI labels.

Never pluralize a trademark, use it as a verb, or form possessives with it. Use lowercase generic nouns after control names: `RadGridView` control, `RadTreeView` class.

Use the product name **Telerik UI for WPF** and the framework name **WPF**. Do not describe WPF as a mobile or cross-platform UI framework. Write exact NuGet package identifiers in monospace and verify them against the repository's installation documentation and target release.

## Control and Framework Terms

Distinguish a control's display name from its API type. For example, **GridView** is the control family name and `RadGridView` is the WPF API type. Verify each control's own namespace, members, and supported behavior.

Use these product boundaries when they apply:

| Area | Distinction |
|---|---|
| Data and binding | `ItemsSource` supplies a control's items. `DataContext` supplies a binding source. `ObservableCollection<T>` reports collection changes; item-property changes require `INotifyPropertyChanged` or an equivalent mechanism. |
| Templates | `DataTemplate` defines item presentation. `ControlTemplate` defines a control's visual structure. Verify the binding source and supported template property. |
| Themes | Distinguish Xaml and NoXaml assemblies. Verify the selected theme, resource dictionaries, package references, and style mechanism. Do not mix theme setup instructions between flavors. |
| Commands and events | `ICommand` represents an executable action; an event reports that something happened. Verify command parameters, `CanExecute`, event names, and event-argument types. |
| Charts | Chart and ChartView are distinct documentation families. Verify the selected family's API, namespaces, series, and axes. |
| Scheduling | `RadScheduleView` presents appointments. Do not describe it as an operating-system job scheduler or notification service. |
| Documents | `RadPdfViewer` displays PDF content. PdfProcessing creates and manipulates PDF documents. `RadRichTextBox` edits rich text. Verify supported formats separately. |
| Navigation | Distinguish Telerik navigation controls from application navigation and routing. Do not assume a control replaces application-level navigation. |
| Licensing and security | Follow release-specific license guidance. Never include license keys, feed credentials, tokens, or sensitive customer data. UI visibility is not an authorization boundary. |

## WPF Setup and XAML

When documenting a WPF example, verify the target framework, Telerik package or assembly references, license activation, and Xaml or NoXaml flavor. Use the documented WPF XML namespace, commonly `http://schemas.telerik.com/2008/xaml/presentation`, or a verified CLR namespace. Do not prescribe MAUI APIs such as `UseTelerik()` or `MauiProgram.cs`.

For NoXaml applications, verify the theme assembly or copied theme resources and the required merged dictionaries. For Xaml applications, verify the control assembly's included styles and the documented theme selection mechanism. Do not infer the correct setup from a different Telerik UI product.

## Interaction Verbs

Use the verb that matches the actual Windows desktop action:

| Action | Verb | Example |
|---|---|---|
| Activate a button or link | click | Click **Add** in the sample app. |
| Activate with two rapid clicks | double-click | Double-click `MainWindow.xaml` in Visual Studio. |
| Use the secondary mouse button | right-click | Right-click the project in **Solution Explorer**. |
| Use a keyboard key | press | Press `Ctrl`+`S` to save the file. |
| Choose a menu item or value | select | Select **File** > **Save**. |
| Enter text | enter or type | Enter a value in the text box. |
| Move an item or resize a control | drag | Drag the column boundary to resize it. |

Write **click**, not "click on." Use **select** when the action is independent of the input method. Document touch input only when the specific WPF control and scenario support it; do not carry over mobile gestures or platform assumptions.

## Writing and Technical Claims

Use consistent compound words such as **checkbox**, **dropdown**, **filename**, **namespace**, **tooltip**, and **workspace**. Use **earlier** and **later** for version order, and **starting with** for a version boundary. Preserve precise API and accessibility state names such as `IsEnabled`.

Verify technical claims against the article for the target Telerik release and the relevant API documentation. Identify the Windows version, .NET target framework, Telerik version, and Xaml or NoXaml flavor when they affect the result. Distinguish documented support from tested behavior. Do not claim accessibility compliance from code inspection or screenshots alone.

When reviewing, report the exact term or claim, the correction, and the reason. State what was verified and what still requires build, runtime, or assistive-technology testing.

## Quick Checklist

- [ ] First brand mention uses Progress® Telerik® UI for WPF; later mentions omit trademarks.
- [ ] Control names, C# types, XAML namespaces, package IDs, and WPF APIs are accurate.
- [ ] Xaml and NoXaml theme setup is not mixed.
- [ ] `ItemsSource`, `DataContext`, notifications, templates, commands, and events are distinct.
- [ ] Desktop interaction verbs match the documented action; touch behavior is verified.
- [ ] Windows, .NET, Telerik-version, and accessibility claims have an explicit evidence scope.
- [ ] License keys, credentials, tokens, and customer data are excluded.
