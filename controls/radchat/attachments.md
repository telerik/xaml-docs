---
title: Message Attachments
page_title: Message File Attachments
description: See how to add a message attachments in RadChat.
slug: chat-attachments
tags: attach,message,seen
published: True
position: 4
---

# Message Attachments

The attachments feature allows you to add files in the chat messages.

To enable the attachments, set the `IsMoreButtonVisible` property of `RadChat` to `true`.

```XAML
<telerik:RadChat x:Name="chat" IsMoreButtonVisible="True" />
```

![A picture showing the chat attachemnts](images/chat-attachments-0.png)

## Handling Attachment Actions

The action that happens when you download or share attachments can be handled via the `AttachmentActionRequested` event of `RadChat`. The event is invoked when the user click onto the __Download__ or __Share__ button in the attachment.

![The share and download buttons of a RadChat message](images/chat-attachments-1.png)

```C#
private void RadChat_AttachmentActionRequested(object sender, AttachmentActionEventArgs e)
{
    IReadOnlyList<PromptInputAttachedFile> attachments = e.AttachedFiles;
    if (e.Action == AttachmentAction.Download)
    {
        foreach (var attachment in attachments)
        {
            var fileName = attachment.FileName;
            Stream fileStream = attachment.GetFileStream.Invoke();

            // implement file download
        }
    }
    else if (e.Action == AttachmentAction.Share)
    {
        foreach (var attachment in attachments)
        {
            var fileName = attachment.FileName;
            Stream fileStream = attachment.GetFileStream.Invoke();

            // implement file share
        }
    }
}
```

## Maximum Visible Attachments

The number of attachments that will be displayed by default without showing an expand button can be adjusted via the `MaxVisibleAttachments` property of `RadChat`.

```XAML
<telerik:RadChat x:Name="chat" IsMoreButtonVisible="True" MaxVisibleAttachments="2" />
```

![A picture showing the maximum visible attachments behavior](images/chat-attachments-2.png)

## Managing Message Attachments Programmatically

The attachments of a message can be accessed via its `AttachedFiles` collection property.

__Setting message attachments programmatically__

```C#
var textMessage = new TextMessage(this.chat.CurrentAuthor, "Sure, attaching the photos.");
var attachedFiles = new List<PromptInputAttachedFile>();
attachedFiles.Add(new PromptInputAttachedFile(new FileInfo("file-path-here")));
textMessage.AttachedFiles = attachedFiles.AsReadOnly();
```

__Getting message attachments__

```C#
IReadOnlyList<PromptInputAttachedFile> attachments = textMessage.AttachedFiles;
```

The content of a attached file can be accessed via the `GetFileStream` function of the corresponding `PromptInputAttachedFile` object.

```C#
Stream fileStream = textMessage.AttachedFiles.ElementAt(0).GetFileStream.Invoke();
```

## Customizing Input Box Attachment Appearance

The visual elements showing the attachments in the input text box can be adjusted via the `AttachmentTemplate` property of the `RadPromptInput` element.

```XAML
 <!-- xmlns:chat="clr-namespace:Telerik.Windows.Controls.ConversationalUI;assembly=Telerik.Windows.Controls" -->

 <Window.Resources>
     <chat:FileExtensionToGlyphConverter x:Key="FileExtensionToGlyphConverter" />
     <chat:FileSizeConverter x:Key="FileSizeConverter" />
     <DataTemplate x:Key="CustomAttachmentTemplate">
         <Border Background="Bisque" CornerRadius="4" Padding="5">
             <Grid>
                 <Grid.ColumnDefinitions>
                     <ColumnDefinition Width="Auto" />
                     <ColumnDefinition Width="*" />
                     <ColumnDefinition Width="Auto" />
                 </Grid.ColumnDefinitions>

                 <telerik:RadGlyph Glyph="{Binding FileName, Converter={StaticResource FileExtensionToGlyphConverter}}"
                                   VerticalAlignment="Top"/>

                 <StackPanel Grid.Column="1" Margin="5 0 0 0">
                     <TextBlock Text="{Binding FileName}" TextTrimming="CharacterEllipsis" />
                     <TextBlock Text="{Binding FileSize, Converter={StaticResource FileSizeConverter}}"/>
                 </StackPanel>

                 <telerik:RadButton Grid.Column="2"
                                    Command="{Binding RelativeSource={RelativeSource AncestorType={x:Type telerik:RadPromptInput}}, Path=RemoveAttachedFileCommand}"
                                    CommandParameter="{Binding}">
                     <telerik:RadGlyph Glyph="Close" />
                 </telerik:RadButton>
             </Grid>
         </Border>
     </DataTemplate>
 </Window.Resources>
```

```C#
private void RadChat_Loaded(object sender, RoutedEventArgs e)
{
	var chat = (RadChat)sender;
	var promptInput = chat.FindChildByType<RadPromptInput>();
	promptInput.AttachmentTemplate = (DataTemplate)this.Resources["CustomAttachmentTemplate"];
}
```

The data context passed to the `AttachmentTemplate` is an object of type `PromptInputAttachedFile`.

![](images/chat-attachments-3.png)

For conditional appearance customization, use the `AttachmentTemplateSelector` ([DataTemplateSelector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=netframework-4.8.1)) property.