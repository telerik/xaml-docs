using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Shapes;

namespace ShapesAndImages
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        RadSpreadsheet radSpreadsheet = new RadSpreadsheet();

        private void FloatingImage()
        {
            #region radspreadsheet-model-features-shapes-and-images_0
            Worksheet worksheet = this.radSpreadsheet.ActiveWorksheet;
            FloatingImage image = new FloatingImage(worksheet, new CellIndex(7, 1), 35, 10);

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_01
            FileStream stream = File.Open(@"C:\Users\Velcheva\Desktop\spreadsheet_wpf_46_text.png", FileMode.Open);

            using (stream)
            {
                image.ImageSource = new Telerik.Windows.Documents.Media.ImageSource(stream, "jpg");
            }

            image.Width = 330;
            image.Height = 45;
            image.RotationAngle = 20;


            #endregion

            #region radspreadsheet-model-features-shapes-and-images_02
            worksheet.Shapes.Add(image);

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_03
            worksheet.Shapes.Add(image);

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_04
            image.CellIndex = new CellIndex(4, 5);
            image.OffsetX = 10;
            image.OffsetY = 10;

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_05
            image.Width -= 50;
            image.Height += 50;

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_06
            image.RotationAngle = 40;

            #endregion

            #region radspreadsheet-model-features-shapes-and-images_07
            image.IsHorizontallyFlipped = true;

            #endregion
        }

    }
}