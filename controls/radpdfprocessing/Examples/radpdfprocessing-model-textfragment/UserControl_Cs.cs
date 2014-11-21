using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Annotations;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Text;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelTextFragment
{
    public class UserControl_Cs
    {
        private void CreateRadFixedPage(IContainerElement container)
        {
            #region radpdfprocessing-model-textfragment_0
            TextFragment fragment = new TextFragment();
            container.Content.Add(fragment);
            #endregion

            #region radpdfprocessing-model-textfragment_1
            TextFragment textFragment = container.Content.AddTextFragment();
            TextFragment textFragmentWithText = container.Content.AddTextFragment("Text");
            #endregion
        }
    }
}
