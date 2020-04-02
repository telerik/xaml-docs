---
title: Data Binding to Collection
page_title: Data Binding to Collection
description: This article shows how to use Telerik RadChat for WPF in MVVM scenario and data bind its DataSource collection.
slug: chat-populating-with-data-binding-to-collection
tags: overview
published: True
position: 0
---

# Data Binding to Collection

This article shows how to use RadChat in MVVM scenario by data binding its items source to a collection of view models.

To data bind the messages list you can use the __DataSource__ and __MessageConverter__ properties of the RadChat control.

The __DataSource__ property expects a collection of business objects containing information about the messages. 

The __MessageConverter__ allows you to use an implementation of the [IMessageConverter](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.conversationalui.imessageconverter) interface. This is used to convert between the business object models and the RadChat [message models]({%slug chat-items-messages-overview%}). The __ConvertItem__ method should convert a business object to a message object and __ConvertMessage__ should convert a message object to a business object.

The following example shows how to define custom models and use the converter.

#### __[C#] Example 1: Defining the messages view model__
{{region chat-populating-with-data-binding-to-collection-0}}
	public class TextMessageModel
	{
		public string Text { get; set; }
		public Author Author { get; set; }
		public DateTime CreationDate { get; set; }
	}
{{endregion}}

#### __[C#] Example 2: Defining the main view model and populating the data source with data__
{{region chat-populating-with-data-binding-to-collection-1}}
	public class MainViewModel
    {
        public ObservableCollection<TextMessageModel> Messages { get; set; }
        public Author CurrentAuthor { get; private set; }

        public MainViewModel()
        {
            this.CurrentAuthor = new Author("Martin");
            this.Messages = new ObservableCollection<TextMessageModel>();
            
            var otherAuthor = new Author("Virtual Assistant");
            this.Messages.Add(new TextMessageModel() { Text = "Hello Martin,", Author = otherAuthor, CreationDate = DateTime.Now });
            this.Messages.Add(new TextMessageModel() { Text = "I am your Virtual Assistant", Author = otherAuthor, CreationDate = DateTime.Now });
            this.Messages.Add(new TextMessageModel() { Text = "How can I help you?", Author = otherAuthor, CreationDate = DateTime.Now });
            
            this.Messages.Add(new TextMessageModel() { Text = "Hi", Author = this.CurrentAuthor, CreationDate = DateTime.Now.AddMinutes(5) });
            this.Messages.Add(new TextMessageModel() { Text = "Show me the weather for this week", Author = this.CurrentAuthor, CreationDate = DateTime.Now.AddMinutes(5) });
        }
    }
{{endregion}}

#### __[C#] Example 3: Implementing message converter__
{{region chat-populating-with-data-binding-to-collection-2}}
	public class MessageConverter : IMessageConverter
    {
		public MessageBase ConvertItem(object item)
        {
            var messageModel = (TextMessageModel)item;
            return new TextMessage(messageModel.Author, messageModel.Text, messageModel.CreationDate);
        }

        public object ConvertMessage(MessageBase message)
        {
            var textMessage = (TextMessage)message;
            return new TextMessageModel()
            { 
                Author = textMessage.Author, 
                Text = textMessage.Text,
                CreationDate = textMessage.CreationDate 
            };
        }
    }
{{endregion}}

#### __[XAML] Example 4: Setting up the RadChat control__
{{region chat-populating-with-data-binding-to-collection-3}}
	  <telerik:RadChat CurrentAuthor="{Binding CurrentAuthor}" DataSource="{Binding Messages}">
            <telerik:RadChat.DataContext>
                <local:MainViewModel />
            </telerik:RadChat.DataContext>
            <telerik:RadChat.MessageConverter>
                <local:MessageConverter />
            </telerik:RadChat.MessageConverter>
        </telerik:RadChat>
{{endregion}}

![](images/chat-populating-with-data-binding-to-collection-0.png)

> The example demonstrates how to work with text messages, but the same approach is also applicable for the other message types. 

## See Also  
* [Getting Started]({%slug chat-getting-started%})
* [ToolBar Commands]({%slug chat-items-toolbar-commands%})
