---
title: Show desktop alert with message in RadChat
description: Display alert for sent message in RadChat.
type: how-to
page_title: Create a popup for new message in ConversationalUI
slug: kb-chat-showing-message-desktop-alert
position: 0
tags: chat, desktopalert, show, message
ticketid: 1408996
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadChat for WPF</td>
	</tr>
</table>

## Description

How to display alert, when a message is sent.

## Solution

Handle the __SendMessage__ event of the RadChat control, create a [RadDesktopAlert]({%slug raddesktopalert-getting-started%}) and set its Content to a new __MessageGroupViewModel__. We are going to use the __MessageGroup__ control to display the new message in the alert, however it can be replaced by a custom DataTemplate as well.
 

```XAML
	<Grid xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         xmlns:chat="clr-namespace:Telerik.Windows.Controls.ConversationalUI;assembly=Telerik.Windows.Controls.ConversationalUI" 
         x:Name="grid">
        <Grid.Resources>
            <DataTemplate x:Key="ChatTemplate">
                <chat:MessageGroup />
            </DataTemplate>
        </Grid.Resources>
        <telerik:RadChat x:Name="chat" SendMessage="chat_SendMessage" />
    </Grid>
```


```C#
    private void chat_SendMessage(object sender, SendMessageEventArgs e)
    {
        RadDesktopAlertManager manager = new RadDesktopAlertManager(AlertScreenPosition.BottomRight, new Point(0, 0), 10);
        var chat = sender as RadChat;
        var viewmodel = new MessageGroupViewModel(e.Message.Author);
        viewmodel.Messages.Add((e.Message as IInlineMessage).InlineViewModel);
        
        var alert = new RadDesktopAlert
        {
            Header = chat.CurrentAuthor.Name,
            Content = viewmodel,
            ContentTemplate = this.grid.FindResource("ChatTemplate") as DataTemplate,
            ShowDuration = 5000,
        };

        manager.ShowAlert(alert);
    }
```

## See Also

* [RadChat]({%slug chat-getting-started%})
