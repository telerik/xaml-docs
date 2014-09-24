Public Class Default_Vb


' #region radbreadcrumb-getting-started_2
Dim breadcrumb As New RadBreadcrumb()
breadcrumb.Header = "Breadcrumb Header"
breadcrumb.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
breadcrumb.VerticalAlignment = System.Windows.VerticalAlignment.Top
' #endregion

' #region radbreadcrumb-getting-started_5
Dim item1 As New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 1", 
        Key .DropDownHeader = "DropDownItem 1" 
}
item1.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 1.1", 
        Key .DropDownHeader = "DropDownItem 1.1" 
})
item1.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 1.2", 
        Key .DropDownHeader = "DropDownItem 1.2" 
})
item1.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 1.3", 
        Key .DropDownHeader = "DropDownItem 1.3" 
})
breadcrumb.Items.Add(item1)
Dim item2 As New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 2", 
        Key .DropDownHeader = "DropDownItem 2" 
}
item2.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 2.1", 
        Key .DropDownHeader = "DropDownItem 2.1" 
})
item2.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 2.2", 
        Key .DropDownHeader = "DropDownItem 2.2" 
})
item2.Items.Add(New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 2.3", 
        Key .DropDownHeader = "DropDownItem 2.3" 
})
breadcrumb.Items.Add(item2)
Dim item3 As New RadBreadcrumbItem() With { 
        Key .Header = "BreadcrumbItem 3", 
        Key .DropDownHeader = "DropDownItem 3" 
}
breadcrumb.Items.Add(item3)
' #endregion

' #region radbreadcrumb-getting-started_7
breadcrumb.Items.Remove(item2)
' #endregion

' #region radbreadcrumb-getting-started_10
breadcrumb.IsLinearMode = True
' #endregion

' #region radbreadcrumb-getting-started_13
breadcrumb.HistorySize = 15
' #endregion

' #region radbreadcrumb-getting-started_16
StyleManager.SetTheme(breadcrumb, New VistaTheme())
' #endregion
End Class
