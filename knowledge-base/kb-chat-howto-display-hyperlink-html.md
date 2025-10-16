---
title: How to add a hyperlink in a text message
description: This article demonstrates how to show HTML formatted text and hyperlinks in RadChat.
type: how-to
page_title: Sending a clickable hyperlink in RadChat
slug: kb-chat-howto-display-hyperlink-html
position: 0
tags: chat, link, hyperlink, html, conversational, ui
ticketid: 1465210
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

How to send a hyperlink in RadChat (Conversational UI).

## Solution

In order to display html/hyperlink, you can create a custom message and use a RadRichTextBox in order to show its contents. The first step is to inherit the __TextMessage__ class as shown in __Example 1__.

__Example 1: Defining a custom message__
```C#

	public class HtmlMessage : TextMessage
    {
        public HtmlMessage(Author author, string text, DateTime creationDate = default(DateTime)) : base(author, text, creationDate)
        {
        }
    }
```
```VB.NET

	Public Class HtmlMessage
	    Inherits TextMessage

		Public Sub New(ByVal author As Author, ByVal text As String, Optional ByVal creationDate As Date = Date.MinValue)
			MyBase.New(author, text, creationDate)
		End Sub
    End Class
```

After that we can inherit the __MessageTemplateSelector__ in order to choose a DataTemplate for the messages. 

__Example 2: Defining a custom MessageTemplateSelector__
```C#

	public class CustomMessageTemplateSelector : MessageTemplateSelector
    {
        public DataTemplate HtmlMessageTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var htmlTextMessage = item as HtmlMessage;

            if (htmlTextMessage != null)
            {
                return this.HtmlMessageTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
```
```VB.NET

	Public Class CustomMessageTemplateSelector
	    Inherits MessageTemplateSelector

		Public Property HtmlMessageTemplate() As DataTemplate

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim htmlTextMessage = TryCast(item, HtmlMessage)

			If htmlTextMessage IsNot Nothing Then
				Return Me.HtmlMessageTemplate
			End If
			Return MyBase.SelectTemplate(item, container)
		End Function
    End Class
```

[Extract the xaml]({%slug styling-apperance-editing-control-templates%}) of the default MessageTemplateSelector for the theme that you are using and define the look of the custom HtmlMessage. Then we can use the custom selector in the __ItemTemplate__ of the __MessageGroup__ element as shown in __Example 3__. 

__Example 3: CustomMessageTemplateSelector in xaml__
```XAML

	<Grid>
        <Grid.Resources>
            <!-- Those are the templates for the different types of messages-->
            <local:CustomMessageTemplateSelector x:Key="CustomMessageTemplateSelector" x:Shared="false">
                <local:CustomMessageTemplateSelector.CalendarMessageTemplate>
                    <DataTemplate>
                        <telerik:RadCalendar SelectedDate="{Binding SelectedDate, Mode=TwoWay}" DisplayDate="{Binding DisplayDate}"/>
                    </DataTemplate>
                </local:CustomMessageTemplateSelector.CalendarMessageTemplate>
                <local:CustomMessageTemplateSelector.ListMessageTemplate>
                    <DataTemplate>
                        <telerik:RadListBox
                            ItemsSource="{Binding Source}"
                            SelectionMode="{Binding SelectionMode}"
                            SelectedIndex="{Binding SelectedIndex, Mode=TwoWay}"
                            SelectedItem="{Binding SelectedItem, Mode=TwoWay}"
                            DisplayMemberPath="{Binding DisplayMemberPath}"
                            ItemTemplate="{Binding ItemTemplate}"
                            IsSynchronizedWithCurrentItem="False"
                            MinWidth="220">
                            <telerik:EventToCommandBehavior.EventBindings>
                                <telerik:EventBinding Command="{Binding SelectionChangedCommand}" EventName="SelectionChanged" PassEventArgsToCommand="True"/>
                            </telerik:EventToCommandBehavior.EventBindings>
                        </telerik:RadListBox>
                    </DataTemplate>
                </local:CustomMessageTemplateSelector.ListMessageTemplate>
                <!-- This is the look of the HtmlMessage message type-->
                <local:CustomMessageTemplateSelector.HtmlMessageTemplate>
                    <DataTemplate>
                        <StackPanel>
                            <telerik:HtmlDataProvider RichTextBox="{Binding ElementName=richTextBox}" 
												    Html="{Binding Path=Text, Mode=TwoWay}" />
                            <telerik:RadRichTextBox x:Name="richTextBox" IsReadOnly="True" IsSpellCheckingEnabled="False" HyperlinkNavigationMode="Click" />
                        </StackPanel>
                    </DataTemplate>
                </local:CustomMessageTemplateSelector.HtmlMessageTemplate>
                <local:CustomMessageTemplateSelector.TextMessageTemplate>
                    <DataTemplate>
                        <chat:TextMessageControl/>
                    </DataTemplate>
                    </local:CustomMessageTemplateSelector.TextMessageTemplate>
                    <local:CustomMessageTemplateSelector.CardTemplate>
                        <DataTemplate>
                            <chat:Card/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.CardTemplate>
                    <local:CustomMessageTemplateSelector.ImageCardTemplate>
                        <DataTemplate>
                            <chat:ImageCard/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.ImageCardTemplate>
                    <local:CustomMessageTemplateSelector.ProductCardTemplate>
                        <DataTemplate>
                            <chat:ProductCard/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.ProductCardTemplate>
                    <local:CustomMessageTemplateSelector.WeatherCardTemplate>
                        <DataTemplate>
                            <chat:WeatherCard/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.WeatherCardTemplate>
                    <local:CustomMessageTemplateSelector.FlightCardTemplate>
                        <DataTemplate>
                            <chat:FlightCard/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.FlightCardTemplate>
                    <local:CustomMessageTemplateSelector.CarouselTemplate>
                        <DataTemplate>
                            <chat:CarouselCard/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.CarouselTemplate>
                    <local:CustomMessageTemplateSelector.DataFormTemplate>
                        <DataTemplate>
                            <ItemsControl ItemsSource="{Binding Fields}" ItemTemplateSelector="{StaticResource DataFormTemplateSelector}" Margin="5" MinWidth="220"/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.DataFormTemplate>
                    <local:CustomMessageTemplateSelector.ImageTemplate>
                        <DataTemplate>
                            <Image Source="{Binding Source}" Width="{Binding Size.Width}" Height="{Binding Size.Height}" Stretch="{Binding Stretch}"/>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.ImageTemplate>
                    <local:CustomMessageTemplateSelector.GifTemplate>
                        <DataTemplate>
                            <MediaElement Width="{Binding Size.Width}" Height="{Binding Size.Height}" Stretch="{Binding Stretch}" Source="{Binding Source}" LoadedBehavior="Play" UnloadedBehavior="Play">
                                <telerik:EventToCommandBehavior.EventBindings>
                                    <telerik:EventBinding Command="{Binding MediaEndedCommand}" EventName="MediaEnded" PassEventArgsToCommand="True"/>
                                </telerik:EventToCommandBehavior.EventBindings>
                            </MediaElement>
                        </DataTemplate>
                    </local:CustomMessageTemplateSelector.GifTemplate>
            </local:CustomMessageTemplateSelector>

            <!-- If you are using the NoXaml dlls, you should base the style on the default one:-->
            <!-- <Style TargetType="{x:Type chat:MessageGroup}" BasedOn="{StaticResource MessageGroupStyle}">-->
            <Style TargetType="{x:Type chat:MessageGroup}">
                <Setter Property="ItemTemplate">
                    <Setter.Value>
                        <DataTemplate>
                            <!-- This is where we use the custom template selector defined above -->
                            <chat:InlineMessageControl ContentTemplateSelector="{StaticResource CustomMessageTemplateSelector}" Content="{Binding Message}"/>
                        </DataTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
        </Grid.Resources>
    
        <telerik:RadChat x:Name="chat"   />
    </Grid>
```

> The code shown in __Example 3__  is for the purposes of the demo and you should make sure to extract the xaml of the default MessageTemplateSelector for the theme that you are using. 

__Example 4__ demonstrates how to add a message containing a hyperlink to the RadChat. 

__Example 4: Adding a message__
```C#

	public MainWindow()
    {
        InitializeComponent();

        this.chat.CurrentAuthor = new Author("TestAuthor");
        this.chat.AddMessage(new HtmlMessage(this.chat.CurrentAuthor, "<html>Visit our <a href=\"https://www.progress.com/\" >homepage</a>.</html>", DateTime.Now));
    }
```
```VB.NET

	Public Sub New()
		InitializeComponent()

		Me.chat.CurrentAuthor = New Author("TestAuthor")
		Me.chat.AddMessage(New HtmlMessage(Me.chat.CurrentAuthor, "<html>Visit our <a href=""https://www.progress.com/"" >homepage</a>.</html>", Date.Now))
    End Sub
```

## See Also

* [RadChat Getting Started]({%slug chat-getting-started%})
* [Data Providers]({%slug radrichtextbox-features-data-providers%})