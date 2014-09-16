Public Class Default_Vb

    Public Sub SetWorksheetEditorContextMenu()
        '#Region "radspreadsheet-ui-worksheet-editor-context-menu_0"

        Dim commandDescriptorsBinding As New Binding()
        commandDescriptorsBinding.ElementName = "radSpreadsheet"
        commandDescriptorsBinding.Path = New PropertyPath("CommandDescriptors")

        Me.radSpreadsheet.SetBinding(RadSpreadsheet.DataContextProperty, commandDescriptorsBinding)

        Dim contextMenu As New RadContextMenu()

        Dim cutMenuItem As New RadMenuItem()
        cutMenuItem.Header = "Cut"

        Dim cutCommandBinding As New Binding()
        cutCommandBinding.Path = New PropertyPath("Cut.Command")

        cutMenuItem.SetBinding(RadMenuItem.CommandProperty, cutCommandBinding)

        Dim cutCommandVisibilityBinding As New Binding()
        cutCommandVisibilityBinding.Path = New PropertyPath("Cut.IsEnabled")
        cutCommandVisibilityBinding.Mode = BindingMode.TwoWay
        cutCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        cutMenuItem.SetBinding(RadMenuItem.VisibilityProperty, cutCommandVisibilityBinding)

        Dim image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/cut.png")
        image.Width = 16
        cutMenuItem.Icon = image

        contextMenu.Items.Add(cutMenuItem)


        Dim copyMenuItem As New RadMenuItem()
        copyMenuItem.Header = "Copy"

        Dim copyCommandBinding As New Binding()
        copyCommandBinding.Path = New PropertyPath("Copy.Command")

        copyMenuItem.SetBinding(RadMenuItem.CommandProperty, copyCommandBinding)

        Dim copyCommandVisibilityBinding As New Binding()
        copyCommandVisibilityBinding.Path = New PropertyPath("Copy.IsEnabled")
        copyCommandVisibilityBinding.Mode = BindingMode.TwoWay
        copyCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        copyMenuItem.SetBinding(RadMenuItem.VisibilityProperty, copyCommandVisibilityBinding)

        image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/copy.png")
        image.Width = 16
        copyMenuItem.Icon = image

        contextMenu.Items.Add(copyMenuItem)


        Dim pasteMenuItem As New RadMenuItem()
        pasteMenuItem.Header = "Paste"

        Dim pasteCommandBinding As New Binding()
        pasteCommandBinding.Path = New PropertyPath("Paste.Command")

        pasteMenuItem.SetBinding(RadMenuItem.CommandProperty, pasteCommandBinding)

        Dim pasteCommandVisibilityBinding As New Binding()
        pasteCommandVisibilityBinding.Path = New PropertyPath("Paste.IsEnabled")
        pasteCommandVisibilityBinding.Mode = BindingMode.TwoWay
        pasteCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        pasteMenuItem.SetBinding(RadMenuItem.VisibilityProperty, pasteCommandVisibilityBinding)

        image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/pasteNormal.png")
        image.Width = 16
        pasteMenuItem.Icon = image

        contextMenu.Items.Add(pasteMenuItem)


        contextMenu.Items.Add(New RadMenuSeparatorItem())


        Dim insertCellsMenuItem As New RadMenuItem()
        insertCellsMenuItem.Header = "Insert..."

        Dim insertCommandBinding As New Binding()
        insertCommandBinding.Path = New PropertyPath("InsertCells.Command")

        insertCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, insertCommandBinding)

        Dim insertCommandVisibilityBinding As New Binding()
        insertCommandVisibilityBinding.Path = New PropertyPath("InsertCells.IsEnabled")
        insertCommandVisibilityBinding.Mode = BindingMode.TwoWay
        insertCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        insertCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, insertCommandVisibilityBinding)

        contextMenu.Items.Add(insertCellsMenuItem)


        Dim removeCellsMenuItem As New RadMenuItem()
        removeCellsMenuItem.Header = "Delete..."

        Dim removeCellsCommandBinding As New Binding()
        removeCellsCommandBinding.Path = New PropertyPath("RemoveCells.Command")

        removeCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, removeCellsCommandBinding)

        Dim removeCellsCommandVisibilityBinding As New Binding()
        removeCellsCommandVisibilityBinding.Path = New PropertyPath("RemoveCells.IsEnabled")
        removeCellsCommandVisibilityBinding.Mode = BindingMode.TwoWay
        removeCellsCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        removeCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, removeCellsCommandVisibilityBinding)

        contextMenu.Items.Add(removeCellsMenuItem)


        Dim clearContentsMenuItem As New RadMenuItem()
        clearContentsMenuItem.Header = "Clear Contents"

        Dim clearContentsCommandBinding As New Binding()
        clearContentsCommandBinding.Path = New PropertyPath("Clear.Command")

        clearContentsMenuItem.SetBinding(RadMenuItem.CommandProperty, removeCellsCommandBinding)
        clearContentsMenuItem.CommandParameter = "Contents"

        Dim clearContentsCommandVisibilityBinding As New Binding()
        clearContentsCommandVisibilityBinding.Path = New PropertyPath("Clear.IsEnabled")
        clearContentsCommandVisibilityBinding.Mode = BindingMode.TwoWay
        clearContentsCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        clearContentsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, clearContentsCommandVisibilityBinding)

        contextMenu.Items.Add(clearContentsMenuItem)


        Dim separator As New RadMenuSeparatorItem()

        Dim separatorsVisibilityBinding As New Binding()
        separatorsVisibilityBinding.Path = New PropertyPath("ShowFormatCellsDialog.IsEnabled")
        separatorsVisibilityBinding.Mode = BindingMode.TwoWay
        separatorsVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        separator.SetBinding(RadMenuSeparatorItem.VisibilityProperty, separatorsVisibilityBinding)

        contextMenu.Items.Add(separator)


        Dim formatCellsMenuItem As New RadMenuItem()
        formatCellsMenuItem.Header = "Format Cells..."

        Dim formatCellsCommandBinding As New Binding()
        formatCellsCommandBinding.Path = New PropertyPath("ShowFormatCellsDialog.Command")

        formatCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, formatCellsCommandBinding)

        Dim formatCellsCommandVisibilityBinding As New Binding()
        formatCellsCommandVisibilityBinding.Path = New PropertyPath("ShowFormatCellsDialog.IsEnabled")
        formatCellsCommandVisibilityBinding.Mode = BindingMode.TwoWay
        formatCellsCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        formatCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, formatCellsCommandVisibilityBinding)

        image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/formatCells.png")
        image.Width = 16
        formatCellsMenuItem.Icon = image

        contextMenu.Items.Add(formatCellsMenuItem)


        Dim showHyperlinkMenuItem As New RadMenuItem()
        showHyperlinkMenuItem.Header = "Hyperlink..."

        Dim showHyperlinkCommandBinding As New Binding()
        showHyperlinkCommandBinding.Path = New PropertyPath("ShowHyperlinkDialog.Command")

        showHyperlinkMenuItem.SetBinding(RadMenuItem.CommandProperty, showHyperlinkCommandBinding)

        Dim showHyperlinkCommandVisibilityBinding As New Binding()
        showHyperlinkCommandVisibilityBinding.Path = New PropertyPath("ShowHyperlinkDialog.IsEnabled")
        showHyperlinkCommandVisibilityBinding.Mode = BindingMode.TwoWay
        showHyperlinkCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        showHyperlinkMenuItem.SetBinding(RadMenuItem.VisibilityProperty, showHyperlinkCommandVisibilityBinding)

        image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/insertHyperlink.png")
        image.Width = 16
        showHyperlinkMenuItem.Icon = image

        contextMenu.Items.Add(showHyperlinkMenuItem)


        Dim removeHyperlinkMenuItem As New RadMenuItem()
        removeHyperlinkMenuItem.Header = "Remove Hyperlink"

        Dim removeHyperlinkCommandBinding As New Binding()
        removeHyperlinkCommandBinding.Path = New PropertyPath("RemoveHyperlink.Command")

        removeHyperlinkMenuItem.SetBinding(RadMenuItem.CommandProperty, removeHyperlinkCommandBinding)

        Dim removeHyperlinkCommandVisibilityBinding As New Binding()
        removeHyperlinkCommandVisibilityBinding.Path = New PropertyPath("RemoveHyperlink.IsEnabled")
        removeHyperlinkCommandVisibilityBinding.Mode = BindingMode.TwoWay
        removeHyperlinkCommandVisibilityBinding.Converter = New BooleanToVisibilityConverter()

        removeHyperlinkMenuItem.SetBinding(RadMenuItem.VisibilityProperty, removeHyperlinkCommandVisibilityBinding)

        image = New System.Windows.Controls.Image()
        image.SetValue(IconManager.IconPropertyNameProperty, "Source")
        image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/removeHyperlink.png")
        image.Width = 16
        removeHyperlinkMenuItem.Icon = image

        contextMenu.Items.Add(removeHyperlinkMenuItem)

        Me.radSpreadsheet.WorksheetEditorContextMenu = contextMenu

        '#End Region
    End Sub


End Class