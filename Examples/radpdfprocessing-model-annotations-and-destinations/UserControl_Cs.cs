using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Actions;
using Telerik.Windows.Documents.Fixed.Model.Annotations;
using Telerik.Windows.Documents.Fixed.Model.Navigation;
using Action = Telerik.Windows.Documents.Fixed.Model.Actions.Action;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelAnnotationsAndDestinations
{
    public class UserControl_Cs
    {
        private void CreateLinkToDestination(Destination destination, RadFixedPage page)
        {
            #region radpdfprocessing-model-annotations-and-destinations_0
            Link linkWithDestination = new Link(destination);
            page.Annotations.Add(linkWithDestination);
            #endregion
        }

        private void CreateLinkToAction(Action action, RadFixedPage page)
        {
            #region radpdfprocessing-model-annotations-and-destinations_1
            Link linkWithAction = new Link(action);
            page.Annotations.Add(linkWithAction);
            #endregion
        }

        private void CreateLocation(RadFixedPage secondPage, RadFixedPage firstPage)
        {
            #region radpdfprocessing-model-annotations-and-destinations_2
            Location location = new Location();
            location.Left = 225;
            location.Top = 500;
            location.Zoom = 4;
            location.Page = secondPage;

            var link = firstPage.Annotations.AddLink(location);
            link.Rect = new Rect(10, 10, 50, 50);
            #endregion
        }

        private void CreateAction(RadFixedPage firstPage, Location location)
        {
            #region radpdfprocessing-model-annotations-and-destinations_3
            GoToAction goToAction = new GoToAction();
            goToAction.Destination = location;

            var goToLink = firstPage.Annotations.AddLink(goToAction);
            goToLink.Rect = new Rect(10, 10, 50, 50);

            UriAction uriAction = new UriAction();
            uriAction.Uri = new Uri(@"http://www.telerik.com");

            var uriLink = firstPage.Annotations.AddLink(uriAction);
            uriLink.Rect = new Rect(70, 10, 50, 50);
            #endregion
        }
    }
}
