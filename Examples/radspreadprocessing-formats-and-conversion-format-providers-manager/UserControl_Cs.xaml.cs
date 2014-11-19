using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Spreadsheet.Utilities;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportFormatProvidersManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void RegisterXlsxFormatProvider()
        {
            #region radspreadprocessing-formats-and-conversion-format-providers-manager_0
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
            #endregion
        }

        private void UnregisterTxtFormatProvider()
        {
            #region radspreadprocessing-formats-and-conversion-format-providers-manager_1
            IWorkbookFormatProvider provider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider");
            if (provider != null)
            {
                WorkbookFormatProvidersManager.UnregisterFormatProvider(provider);
            }
            #endregion
        }

        private void Import()
        {
            #region radspreadprocessing-formats-and-conversion-format-providers-manager_2
            Workbook workbook;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string extension = Path.GetExtension(openFileDialog.SafeFileName);
                    using (Stream input = openFileDialog.OpenFile())
                    {
                        workbook = WorkbookFormatProvidersManager.Import(extension, input);
                    }
                }
                catch (IOException ex)
                {
                    throw new IOException("The file cannot be opened. It might be locked by another application.", ex);
                }
            }
            #endregion

#if silverlight
            #region radspreadprocessing-formats-and-conversion-format-providers-manager_4
            Workbook workbook;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string extension = Path.GetExtension(openFileDialog.File.Name);
                    using (Stream input = openFileDialog.File.OpenRead())
                    {
                        workbook = WorkbookFormatProvidersManager.Import(extension, input);
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
            Workbook workbook = new Workbook();
            #region radspreadprocessing-formats-and-conversion-format-providers-manager_3
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == true)
            {
                string extension = Path.GetExtension(saveFileDialog.SafeFileName);
                using (Stream output = saveFileDialog.OpenFile())
                {
                    WorkbookFormatProvidersManager.Export(workbook, extension, output);
                }
            }

            #endregion
        }
    }
}
