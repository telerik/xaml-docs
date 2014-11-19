using System;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;
using Telerik.Windows.Documents.Fixed.Model.Extensions;
using Telerik.Windows.Documents.Fixed.Model.Resources;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelImageSource
{
    public class UserControl_Cs
    {
        private void CreateFromStream(string filename)
        {
            #region radpdfprocessing-model-imagesource_0
            using (FileStream source = File.Open(filename, FileMode.Open))
            {
                ImageSource imageSource = new ImageSource(source);
            }
            #endregion
        }

        private ImageSource CreateFromBitmap(string filename)
        {
            #region radpdfprocessing-model-imagesource_1
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filename, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();

            return bitmap.ToImageSource();
            #endregion
        }
    }
}
