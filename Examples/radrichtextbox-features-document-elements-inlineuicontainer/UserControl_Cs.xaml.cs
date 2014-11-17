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

#region radrichtextbox-features-document-elements-inlineuicontainer_1
Section section = new Section();
Paragraph paragraph = new Paragraph();
InlineUIContainer container = new InlineUIContainer();
container.UiElement = new Button();
container.Height = 25;
container.Width = 70;
paragraph.Inlines.Add(container);
section.Blocks.Add(paragraph);
this.radRichTextBox.Document.Sections.Add(section);
#endregion

#region radrichtextbox-features-document-elements-inlineuicontainer_3
private static Size defaultSize = new Size(900, 400);
private void InsertMedia(Size size)
{
    OpenFileDialog ofd = new OpenFileDialog();
    if (ofd.ShowDialog() == true)
    {
        Stream stream = ofd.File.OpenRead();
        MediaElement media = new MediaElement();
        media.SetSource(stream);
        media.AutoPlay = true;
        InlineUIContainer container = new InlineUIContainer()
        {
            UiElement = media
        };
        if (size != Size.Empty)
        {
            container.Height = size.Height;
            container.Width = size.Width;
        }
        this.radRichTextBox1.InsertInline(container);
    }
}
private void buttonInsertVideo_Click(object sender, RoutedEventArgs e)
{
    InsertMedia(defaultSize);
}
private void buttonInsertAudio_Click(object sender, RoutedEventArgs e)
{
    InsertMedia(Size.Empty);
}
#endregion
}
