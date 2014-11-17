using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radrichtextbox-features-document-elements-inlineimage_1
Section section = new Section();
Paragraph paragraph = new Paragraph();
Stream stream = Application.GetResourceStream(new Uri(@"/Silverlight.Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream;
Size size = new Size(236, 50);
ImageInline image = new ImageInline(stream, size, "png");
paragraph.Inlines.Add(image);
section.Children.Add(paragraph);
this.radRichTextBox.Document.Sections.Add(section);
#endregion

#region radrichtextbox-features-document-elements-inlineimage_4
private void ImageButton_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog openDialog = new OpenFileDialog();
    openDialog.Filter = "Images|*.jpg;*.png";
    openDialog.Multiselect = false;
    bool? dialogResult = openDialog.ShowDialog();
    if (dialogResult == true)
    {
        Stream stream = openDialog.File.OpenRead();
        string extension = openDialog.File.Extension;
        this.radRichTextBox.InsertImage(stream, extension);
    }
}
#endregion
}
