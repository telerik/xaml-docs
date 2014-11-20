using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Annotations;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Fonts;
using Telerik.Windows.Documents.Fixed.Model.Text;

namespace PdfProcessingDocumentationSourceCode.Examples.ConceptsFonts
{
    public class UserControl_Cs
    {
        private void RegisterFont(FontFamily fontFamily, FontStyle fontStyle, FontWeight fontWeight, byte[] data)
        {
            #region radpdfprocessing-concepts-fonts_0
            FontsRepository.RegisterFont(fontFamily, fontStyle, fontWeight, data);
            #endregion

            #region radpdfprocessing-concepts-fonts_1
            FontBase font;
            bool success = FontsRepository.TryCreateFont(fontFamily, fontStyle, fontWeight, out font);
            #endregion
        }
    }
}
