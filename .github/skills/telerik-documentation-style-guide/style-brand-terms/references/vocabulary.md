# Telerik UI for WPF Vocabulary Reference

Use this reference with the [brand and terminology skill](../SKILL.md). Preserve exact API names, package identifiers, resource keys, UI labels, and quoted diagnostics. Verify feature availability for the Telerik release, target framework, Windows version, and Xaml or NoXaml flavor.

## Product and Framework Names

| Use | Meaning |
|---|---|
| Progress® Telerik® UI for WPF | Full brand name on first mention in article body prose. |
| Telerik UI for WPF | Product name for later mentions. |
| WPF | Microsoft Windows Presentation Foundation. Do not describe it as a mobile or cross-platform UI framework. |
| XAML | Markup language used to define WPF UI and resources. Preserve exact `XAML` spelling in prose. |
| Xaml / NoXaml | Telerik WPF assembly and theming flavors. Preserve the capitalization used by Telerik documentation. |

## Common Terms

| Standard form | Avoid |
|---|---|
| checkbox | check box, check-box |
| dataset | data set, except for the .NET `DataSet` type |
| dropdown | drop down, drop-down as a noun or adjective |
| dialog box | dialog, dialogue when referring to a UI window |
| filename | file name |
| namespace | name space |
| toolbar | tool bar |
| tooltip | tool tip |
| workspace | work space |
| login | log in as a noun; retain "log in" as a verb |
| setup | set up as a noun; retain "set up" as a verb |

Use the standard casing **API**, **URL**, **XML**, **JSON**, **HTML**, **PDF**, **.NET**, **C#**, **VB.NET**, **NuGet**, and **GitHub**. Use **C#** and **VB.NET** as prose labels. Follow repository rendering conventions and preserve valid existing language-fence aliases when editing unrelated examples.

## Control and API Terms

Control display names and API identifiers are not interchangeable. Use the exact control name and verify its type and members in the WPF documentation or API reference.

| Term | Distinction |
|---|---|
| GridView / `RadGridView` | GridView is the control family; `RadGridView` is the Telerik WPF API type for tabular data. |
| TreeView / `RadTreeView` | Hierarchical items control; distinguish it from framework types and similarly named controls. |
| `ItemsSource` | Supplies the collection displayed by a control. It does not retrieve or persist application data. |
| `DataContext` | Supplies a binding source. It is not the same as `ItemsSource`. |
| `ObservableCollection<T>` | Notifies listeners about collection changes. Item-property changes require `INotifyPropertyChanged` or an equivalent mechanism. |
| `DataTemplate` | Defines the presentation of data items. |
| `ControlTemplate` | Defines the visual structure of a control when supported. |
| `ICommand` | Represents an executable action. Verify command binding, parameters, and `CanExecute`. |
| Event | Reports a notification with a documented event-argument type. It is not automatically an MVVM command. |
| Xaml assemblies | Include control styles. Verify the supported theme-selection mechanism. |
| NoXaml assemblies | Use implicit styles from theme assemblies or copied theme XAML. Verify required theme resources and dictionaries. |
| Chart / ChartView | Separate Telerik WPF documentation families. Do not mix their APIs. |
| `RadScheduleView` | Presents appointments. It is not an operating-system job scheduler. |
| `RadPdfViewer` / PdfProcessing | `RadPdfViewer` displays PDF content; PdfProcessing creates and manipulates PDF documents. |
| `RadRichTextBox` | Edits rich-text documents. Verify supported formats and import/export behavior separately. |

## WPF Setup and Diagnostics

Verify target framework, Telerik package or assembly references, license activation, XAML XML namespace, and Xaml or NoXaml flavor. The common Telerik presentation namespace is `http://schemas.telerik.com/2008/xaml/presentation`; confirm it for the documented control and release.

When a type is unresolved, check references, namespace declarations, and the control's actual API type. When a binding fails, check `DataContext`, `ItemsSource`, binding paths, item context, notifications, and binding diagnostics. For styling issues, check theme resources, dictionary merge order, resource keys, `TargetType`, and whether the app uses Xaml or NoXaml assemblies.

Name the Windows version, .NET target framework, Telerik version, and build configuration when they affect a result. Distinguish documented support from tested behavior. Do not claim accessibility compliance from code inspection or screenshots alone; report actual keyboard, focus, and assistive-technology checks.

Keep credentials, license keys, access tokens, and sensitive customer information out of code, logs, screenshots, and expected output.
