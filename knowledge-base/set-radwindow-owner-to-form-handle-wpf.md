---
title: Setting Owner of RadWindow to Form Handle in UI for WPF
description: Learn how to set the Owner of a Telerik UI for WPF RadWindow to a WinForms form's handle (IntPtr) in a WinForms application.
type: how-to
page_title: Set RadWindow Owner to Form Handle in Telerik UI for WPF
meta_title: Set RadWindow Owner to Form Handle in Telerik UI for WPF
slug: set-radwindow-owner-to-form-handle-wpf
tags: radwindow, ui for wpf, radwindow, owner, winforms, handle, getwindowownerhandle, elementhost
res_type: kb
ticketid: 1711525
---

## Environment
<table>
  <tbody>
    <tr>
      <td>Product</td>
      <td>UI for WPF RadWindow</td>
    </tr>
    <tr>
      <td>Version</td>
      <td>2026.1.211</td>
    </tr>
  </tbody>
</table>

## Description

I want to use a Telerik [UI for WPF RadWindow](https://docs.telerik.com/devtools/wpf/controls/radwindow/overview) in a WinForms application and set its owner to the handle (IntPtr) of a WinForms form. 

This knowledge base article also answers the following questions:
- How to set the owner of RadWindow to a WinForms form's handle?
- How to override GetWindowOwnerHandle in RadWindow?
- How to enable modeless keyboard interop in RadWindow?

## Solution

To set the owner of a Telerik UI for WPF RadWindow to a WinForms form's handle, follow these steps:

1. Derive a class from RadWindow and override the `GetWindowOwnerHandle` method.
2. Create a property in the derived class to store the owner's handle (`IntPtr`).
3. In the WinForms form, assign the handle to the RadWindow's `OwnerHandle` property __prior to showing__ the window.

### Example Code

#### Custom RadWindow Class

```csharp
public partial class Window1 : RadWindow
{
    public Window1()
    {
        InitializeComponent();
    }

    protected override IntPtr GetWindowOwnerHandle()
    {
        return this.OwnerHandle;
    }

    public IntPtr OwnerHandle { get; set; }
}
```

#### WinForms Form Integration

```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var wpfwindow = new WpfCustomControlLibrary1.Window1();
        wpfwindow.HostCreated += (s, a) =>
        {
            ElementHost.EnableModelessKeyboardInterop(a.HostWindow);            
        };

        wpfwindow.OwnerHandle = this.Handle;
        wpfwindow.Show();
    }
}
```

### Key Points
- Override the `GetWindowOwnerHandle` method in the RadWindow-derived class to return the form's handle.
- Use `ElementHost.EnableModelessKeyboardInterop` to enable keyboard interop for the WPF window.

## See Also

- [RadWindow Overview](https://docs.telerik.com/devtools/wpf/controls/radwindow/overview)
- [Control.Handle Property in WinForms](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.handle?view=windowsdesktop-10.0&viewFallbackFrom=net-5.0)
- [ElementHost.EnableModelessKeyboardInterop](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.integration.elementhost.enablemodelesskeyboardinterop?view=windowsdesktop-10.0&viewFallbackFrom=net-5.0)
