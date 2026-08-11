---
title: Message Status
page_title: Message Status
description: See how to add a message status under the RadChat messages, like sent, delivered, seen, etc.
slug: chat-message-status
tags: status,message,seen
published: True
position: 4
---

# Message Status

The RadChat [messages]({%slug chat-items-messages-overview%}) allows you to display a custom status message text under the message (eg. "Sent", "Delivered", "Seen", etc.).

The status message visual is enabled by setting the `StatusVisibility` property of the view model of the message object.

The status text is set via the `Status` property of the message's view model.

__Creating a new message and setting the message status__

<snippet id='radchat-message-status-creating_a_new_message_and_setting_the_message_status-cs' />

![Telerik UI for WPF RadChat message status displayed beneath a chat message](images/chat-message-status-0.png)

You can later access the message and update its status if necessary.

__Updating the message status__

<snippet id='radchat-message-status-updating_the_message_status-cs' />