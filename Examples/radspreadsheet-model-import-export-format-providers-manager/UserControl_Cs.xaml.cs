using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Spreadsheet.Utilities;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

namespace ImportExportFormatProvidersManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void RegisterXlsxFormatProvider()
        {
            #region radspreadsheet-model-import-export-format-providers-manager_0
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
            #endregion
        }

        private void UnregisterTxtFormatProvider()
        {
            #region radspreadsheet-model-import-export-format-providers-manager_1
            IWorkbookFormatProvider provider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider");
            if (provider != null)
            {
                WorkbookFormatProvidersManager.UnregisterFormatProvider(provider);
            }
            #endregion
        }

        private void Import()
        {
            RadSpreadsheet radSpreadsheet = new RadSpreadsheet();
            var editor = radSpreadsheet.ActiveWorksheetEditor;

            #region radspreadsheet-model-import-export-format-providers-manager_2
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FileDialogsHelper.GetOpenFileDialogFilter();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string extension = Path.GetExtension(openFileDialog.SafeFileName);
                    using (Stream input = openFileDialog.OpenFile())
                    {
                        editor.Owner.Workbook = WorkbookFormatProvidersManager.Import(extension, input);
                    }
                }
                catch (IOException ex)
                {
                    throw new IOException("The file cannot be opened. It might be locked by another application.", ex);
                }
            }
            #endregion

#if silverlight
            #region radspreadsheet-model-import-export-format-providers-manager_4
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FileDialogsHelper.GetOpenFileDialogFilter();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string extension = Path.GetExtension(openFileDialog.File.Name);
                    using (Stream input = openFileDialog.File.OpenRead())
                    {
                        editor.Owner.Workbook = WorkbookFormatProvidersManager.Import(extension, input);
                    }
                }
                catch (IOException ex)
                {
                    throw new IOException("The file cannot be opened. It might be locked by another application.", ex);
                }
            }
            #endregion
#endif
        }

        private void ExportCsvCustomDelimiter()
        {
            RadSpreadsheet radSpreadsheet = new RadSpreadsheet();
            var editor = radSpreadsheet.ActiveWorksheetEditor;

            #region radspreadsheet-model-import-export-format-providers-manager_3
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FileDialogsHelper.GetSaveFileDialogFilter();

            if (saveFileDialog.ShowDialog() == true)
            {
                string extension = Path.GetExtension(saveFileDialog.SafeFileName);
                using (Stream output = saveFileDialog.OpenFile())
                {
                    WorkbookFormatProvidersManager.Export(editor.Owner.Workbook, extension, output);
                }
            }

            #endregion
        }
    }
}
