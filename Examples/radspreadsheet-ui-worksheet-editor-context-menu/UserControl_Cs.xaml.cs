using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Telerik.Windows.Controls;

namespace UIWorksheetEditorContextMenu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        public void SetWorksheetEditorContextMenu()
        {
            #region radspreadsheet-ui-worksheet-editor-context-menu_0

            //Binding commandDescriptorsBinding = new Binding();
            //commandDescriptorsBinding.ElementName = "radSpreadsheet";
            //commandDescriptorsBinding.Path = new PropertyPath("CommandDescriptors");

            //this.radSpreadsheet.SetBinding(RadSpreadsheet.DataContextProperty, commandDescriptorsBinding);

            //RadContextMenu contextMenu = new RadContextMenu();

            //RadMenuItem cutMenuItem = new RadMenuItem();
            //cutMenuItem.Header = "Cut";

            //Binding cutCommandBinding = new Binding();
            //cutCommandBinding.Path = new PropertyPath("Cut.Command");

            //cutMenuItem.SetBinding(RadMenuItem.CommandProperty, cutCommandBinding);

            //Binding cutCommandVisibilityBinding = new Binding();
            //cutCommandVisibilityBinding.Path = new PropertyPath("Cut.IsEnabled");
            //cutCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //cutCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //cutMenuItem.SetBinding(RadMenuItem.VisibilityProperty, cutCommandVisibilityBinding);

            //var image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/cut.png");
            //image.Width = 16;
            //cutMenuItem.Icon = image;

            //contextMenu.Items.Add(cutMenuItem);


            //RadMenuItem copyMenuItem = new RadMenuItem();
            //copyMenuItem.Header = "Copy";

            //Binding copyCommandBinding = new Binding();
            //copyCommandBinding.Path = new PropertyPath("Copy.Command");

            //copyMenuItem.SetBinding(RadMenuItem.CommandProperty, copyCommandBinding);

            //Binding copyCommandVisibilityBinding = new Binding();
            //copyCommandVisibilityBinding.Path = new PropertyPath("Copy.IsEnabled");
            //copyCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //copyCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //copyMenuItem.SetBinding(RadMenuItem.VisibilityProperty, copyCommandVisibilityBinding);

            //image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/copy.png");
            //image.Width = 16;
            //copyMenuItem.Icon = image;

            //contextMenu.Items.Add(copyMenuItem);


            //RadMenuItem pasteMenuItem = new RadMenuItem();
            //pasteMenuItem.Header = "Paste";

            //Binding pasteCommandBinding = new Binding();
            //pasteCommandBinding.Path = new PropertyPath("Paste.Command");

            //pasteMenuItem.SetBinding(RadMenuItem.CommandProperty, pasteCommandBinding);

            //Binding pasteCommandVisibilityBinding = new Binding();
            //pasteCommandVisibilityBinding.Path = new PropertyPath("Paste.IsEnabled");
            //pasteCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //pasteCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //pasteMenuItem.SetBinding(RadMenuItem.VisibilityProperty, pasteCommandVisibilityBinding);

            //image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/pasteNormal.png");
            //image.Width = 16;
            //pasteMenuItem.Icon = image;

            //contextMenu.Items.Add(pasteMenuItem);


            //contextMenu.Items.Add(new RadMenuSeparatorItem());


            //RadMenuItem insertCellsMenuItem = new RadMenuItem();
            //insertCellsMenuItem.Header = "Insert...";

            //Binding insertCommandBinding = new Binding();
            //insertCommandBinding.Path = new PropertyPath("InsertCells.Command");

            //insertCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, insertCommandBinding);

            //Binding insertCommandVisibilityBinding = new Binding();
            //insertCommandVisibilityBinding.Path = new PropertyPath("InsertCells.IsEnabled");
            //insertCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //insertCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //insertCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, insertCommandVisibilityBinding);

            //contextMenu.Items.Add(insertCellsMenuItem);


            //RadMenuItem removeCellsMenuItem = new RadMenuItem();
            //removeCellsMenuItem.Header = "Delete...";

            //Binding removeCellsCommandBinding = new Binding();
            //removeCellsCommandBinding.Path = new PropertyPath("RemoveCells.Command");

            //removeCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, removeCellsCommandBinding);

            //Binding removeCellsCommandVisibilityBinding = new Binding();
            //removeCellsCommandVisibilityBinding.Path = new PropertyPath("RemoveCells.IsEnabled");
            //removeCellsCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //removeCellsCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //removeCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, removeCellsCommandVisibilityBinding);

            //contextMenu.Items.Add(removeCellsMenuItem);


            //RadMenuItem clearContentsMenuItem = new RadMenuItem();
            //clearContentsMenuItem.Header = "Clear Contents";

            //Binding clearContentsCommandBinding = new Binding();
            //clearContentsCommandBinding.Path = new PropertyPath("Clear.Command");

            //clearContentsMenuItem.SetBinding(RadMenuItem.CommandProperty, removeCellsCommandBinding);
            //clearContentsMenuItem.CommandParameter = "Contents";

            //Binding clearContentsCommandVisibilityBinding = new Binding();
            //clearContentsCommandVisibilityBinding.Path = new PropertyPath("Clear.IsEnabled");
            //clearContentsCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //clearContentsCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //clearContentsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, clearContentsCommandVisibilityBinding);

            //contextMenu.Items.Add(clearContentsMenuItem);


            //RadMenuSeparatorItem separator = new RadMenuSeparatorItem();

            //Binding separatorsVisibilityBinding = new Binding();
            //separatorsVisibilityBinding.Path = new PropertyPath("ShowFormatCellsDialog.IsEnabled");
            //separatorsVisibilityBinding.Mode = BindingMode.TwoWay;
            //separatorsVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //separator.SetBinding(RadMenuSeparatorItem.VisibilityProperty, separatorsVisibilityBinding);

            //contextMenu.Items.Add(separator);


            //RadMenuItem formatCellsMenuItem = new RadMenuItem();
            //formatCellsMenuItem.Header = "Format Cells...";

            //Binding formatCellsCommandBinding = new Binding();
            //formatCellsCommandBinding.Path = new PropertyPath("ShowFormatCellsDialog.Command");

            //formatCellsMenuItem.SetBinding(RadMenuItem.CommandProperty, formatCellsCommandBinding);

            //Binding formatCellsCommandVisibilityBinding = new Binding();
            //formatCellsCommandVisibilityBinding.Path = new PropertyPath("ShowFormatCellsDialog.IsEnabled");
            //formatCellsCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //formatCellsCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //formatCellsMenuItem.SetBinding(RadMenuItem.VisibilityProperty, formatCellsCommandVisibilityBinding);

            //image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/formatCells.png");
            //image.Width = 16;
            //formatCellsMenuItem.Icon = image;

            //contextMenu.Items.Add(formatCellsMenuItem);


            //RadMenuItem showHyperlinkMenuItem = new RadMenuItem();
            //showHyperlinkMenuItem.Header = "Hyperlink...";

            //Binding showHyperlinkCommandBinding = new Binding();
            //showHyperlinkCommandBinding.Path = new PropertyPath("ShowHyperlinkDialog.Command");

            //showHyperlinkMenuItem.SetBinding(RadMenuItem.CommandProperty, showHyperlinkCommandBinding);

            //Binding showHyperlinkCommandVisibilityBinding = new Binding();
            //showHyperlinkCommandVisibilityBinding.Path = new PropertyPath("ShowHyperlinkDialog.IsEnabled");
            //showHyperlinkCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //showHyperlinkCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //showHyperlinkMenuItem.SetBinding(RadMenuItem.VisibilityProperty, showHyperlinkCommandVisibilityBinding);

            //image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/insertHyperlink.png");
            //image.Width = 16;
            //showHyperlinkMenuItem.Icon = image;

            //contextMenu.Items.Add(showHyperlinkMenuItem);


            //RadMenuItem removeHyperlinkMenuItem = new RadMenuItem();
            //removeHyperlinkMenuItem.Header = "Remove Hyperlink";

            //Binding removeHyperlinkCommandBinding = new Binding();
            //removeHyperlinkCommandBinding.Path = new PropertyPath("RemoveHyperlink.Command");

            //removeHyperlinkMenuItem.SetBinding(RadMenuItem.CommandProperty, removeHyperlinkCommandBinding);

            //Binding removeHyperlinkCommandVisibilityBinding = new Binding();
            //removeHyperlinkCommandVisibilityBinding.Path = new PropertyPath("RemoveHyperlink.IsEnabled");
            //removeHyperlinkCommandVisibilityBinding.Mode = BindingMode.TwoWay;
            //removeHyperlinkCommandVisibilityBinding.Converter = new BooleanToVisibilityConverter();

            //removeHyperlinkMenuItem.SetBinding(RadMenuItem.VisibilityProperty, removeHyperlinkCommandVisibilityBinding);

            //image = new System.Windows.Controls.Image();
            //image.SetValue(IconManager.IconPropertyNameProperty, "Source");
            //image.SetValue(IconManager.IconSourceProperty, "/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/16/removeHyperlink.png");
            //image.Width = 16;
            //removeHyperlinkMenuItem.Icon = image;

            //contextMenu.Items.Add(removeHyperlinkMenuItem);

            //this.radSpreadsheet.WorksheetEditorContextMenu = contextMenu;

            #endregion
        }
    }
}