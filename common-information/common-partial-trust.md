---
title: Partial Trust Support
page_title: Partial Trust Support
description: This topic provides an overview of the Partial Trust support across all the Telerik WPF controls.
slug: common-partial-trust
tags: partial,trust
published: True
position: 9
---

# Partial Trust Support

This topic will give you an overview of the Partial Trust support across all the Telerik WPF controls.

All controls in the suite require the following permissions due to the license mechanism that is used:

* __System.Security.Permissions.FileIOPermission__

* __System.Security.Permissions.SecurityPermission__

* __System.Security.Permissions.ReflectionPermission__ 


Increasing the permissions of a partially trusted application could usually be achieved by changing the permission set in the application manifest. 


The below table lists all controls in __Telerik UI for WPF__ suite and the additional permissions they require. 


Control	|	Working in WPF Partial Trust	|	Comments
---	|	---	|	---
DragDropManager	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission
AutoCompleteBox	|	Yes	|	
Barcode	|	Yes	|	
Book	|	Yes	|	
Breadcrumb	|	Yes	|	
BulletGraph	|	Yes	|	
BusyIndicator	|	Yes	|	
Buttons	|	Yes	|	
Calculator	|	Yes	|	
Calendar	|	Yes	|	
Carousel	|	Yes	|	
ChartView	|	Yes	|	
CollectionNavigator	|	Yes	|	
ColorEditor	|	Yes	|	
ColorPicker	|	Yes	|	
ComboBox	|	Yes	|	
ContextMenu	|	Yes	|	
CloudUpload |  Partially | Requires additional permission by files upload for System.Security.Permissions.FileDialogPermission
DataBar	|	Yes	|	
DataFilter	|	Yes	|	
DataForm	|	Yes	|	
DataPager	|	Yes	|	
DataServiceDataSource	|	No	|	
DateTimePicker	|	Yes	|	
DesktopAlert	|	No	|	
Diagram	|	Yes	|	Versions from Q3 2014 and older require additional permission for System.Security.Permissions.EnvironmentPermission <br/><br/> `<IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" Flags="Assertion, UnmanagedCode, Execution, ControlThread, ControlEvidence, ControlPolicy, SerializationFormatter, ControlDomainPolicy, ControlPrincipal, ControlAppDomain, RemotingConfiguration, Infrastructure, BindingRedirects"/>`
Docking	|	Partially	|	No floating windows - require full trust permission
EntityFrameworkDataSource	|	Partially	|	Requires additional permission for System.Data.SqlClient.SqlClientPermission
Expander	|	Yes	|	
ExpressionEditor	|	Yes	|	
GanttView	|	No	|	
Gauge	|	Yes	|	
GridView	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission for any operation that includes dragging of an element ( grouping, columns reording, frozen columns, rows reordering, rows resizing, etc.) LinqToSql data - Requires additional permission for System.Security.Permissions.ReflectionPermission
HeatMap	|	Yes	|	
ImageEditor	|	Yes	|	
ImageEditorUI	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission
Legend	|	Yes	|	
ListBox	|	Yes	|	
Map	|	No	|	
MaskedInput	|	Yes	|	
Menu	|	Partially	|	Issue with animation when opening a Menu
NumericUpDown	|	Yes	|	
OutlookBar	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission
PanelBar	|	Yes	|	
PdfProcessing	|	Yes	|	
PdfViewer	|	Yes	|	
PersistenceFramework	|	Yes	|	
PivotGrid	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission. Opening dialog windows - requires full trust permissions.
ProgressBar	|	Yes	|	
PropertyGrid	|	Yes	|	
Rating	|	Yes	|	
RibbonView	|	Partially	|	RibbonWindow requires full trust
RichTextBox	|	No	|	Requires additional permission for System.Security.Permissions.IsolatedStorageFilePermission
ScheduleView	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission. Opening Appointment dialog requires full trust permissions.
Slider	|	Yes	|	
SparkLine	|	Yes	|	
SpellChecker	|	Yes	|	
SpreadProcessing	|	Yes	|	
Spreadsheet	|	No	|	Requires additional permission for System.Security.Permissions.IsolatedStorageFilePermission
TabControl	|	Partially	|	Requires the following additional permissions for System.Security.Permissions.UIPermission
TileList	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission for tiles reordering.
TileView	|	Yes	|	
TimeBar	|	Yes	|	
Timeline	|	Yes	|	
ToolBar	|	Yes	|	
TransitionControl	|	Yes	|	
TreeListView	|	Partially	|	Requires additional permission for System.Security.Permissions.MediaPermission for any operation that includes dragging of an element (columns reording, frozen columns, rows reordering, rows resizing, etc.)
TreeMap	|	No	|	
TreeView	|	Yes	|	
VirtualizingWrapPanel	|	Yes	|	
WatermarkTextBox	|	Yes	|	
Window	|	No	|	
WordsProcessing	|	Yes	|	
ZipLibrary |    Yes  |

<!-- We can no longer claim a dedicated support for XBAP applications. This is due to the fact that, since Internet Explorer 9, XBAP is disabled by default. We strongly recommend using ClickOnce deployment instead. With this in mind, please note that some of the information in this article may be outdated. Please [contact our support team](https://www.telerik.com/account/support-tickets?pid=601) if you have an inquiry regarding the support for a given control. -->
