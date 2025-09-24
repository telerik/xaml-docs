---
title: Creating a Custom Gesture
page_title: Creating a Custom Gesture
description: Custom Gesture.
slug: touchmanager-creating-custom-gesture
tags: creating,gestures,gesture,custom,touch,manager,touchmanager
published: True
position: 2
---

# Creating a custom gesture

This article demonstrates how to implement a custom gesture and register it in TouchManager. The following example will guide you through the creation of a __two fingers tap__ gesture.

* [Implementing the gesture recognizer](#implementing-the-gesture-recognizer)
* [Implementing the gesture recognizer factory](#implementing-the-gesture-recognizer-factory)
* [Using the gesture](#using-the-gesture)

## Implementing the gesture recognizer 

To begin creating the gesture recognizer, you must first define a class that derives from GestureRecognizerBase and override its abstract methods. 	
	
__Example 1: Defining the gesture recognizer__	
```C#
	public class TwoFingerTapGestureRecognizer : GestureRecognizerBase
	{
		public TwoFingerTapGestureRecognizer(UIElement element)
			: base(element)
		{
		}

		public override void OnTouchEnter(GestureRecognizerEventArgs args)
		{            
		}

		public override void OnTouchDown(GestureRecognizerEventArgs args)
		{  
			// code here
		}

		public override void OnTouchMove(GestureRecognizerEventArgs args)
		{
		}

		public override void OnTouchUp(GestureRecognizerEventArgs args)
		{
			// code here
		}

		public override void OnTouchLeave(GestureRecognizerEventArgs args)
		{
			// code here
		}
	}
```
```VB.NET
	Public Class TwoFingerTapGestureRecognizer
		Inherits GestureRecognizerBase
		Public Sub New(element As UIElement)
			MyBase.New(element)
		End Sub

		Public Overrides Sub OnTouchEnter(args As GestureRecognizerEventArgs)
		End Sub

		Public Overrides Sub OnTouchDown(args As GestureRecognizerEventArgs)
			' code here '
		End Sub

		Public Overrides Sub OnTouchMove(args As GestureRecognizerEventArgs)
		End Sub

		Public Overrides Sub OnTouchUp(args As GestureRecognizerEventArgs)
			' code here '
		End Sub 

		Public Overrides Sub OnTouchLeave(args As GestureRecognizerEventArgs)
			' code here '
		End Sub
	End Class
```
	
For this example, we will use only three of the gesture recognizer's methods: OnTouchDown, OnTouchUp and OnTouchLeave.

The example will use several helper fields:

* __AllowedInterval__: A readonly field of type TimeSpan that contains the allowed timeframe in which the gesture can be executed. If the time between the touch down and touch up is more than the allowed timespan, the gesture won't be executed.
* __MaxTouchCount__: A readonly field of type Int32 that defines the count of the required touches for executing the gesture.
* __originTouchTime__: A field of type DateTime that holds the time when the first finger was down.
* __isTwoFingerGesture__: A field of type Boolean that tells if two fingers are on the screen and if the gesture can be executed.		
* __touchIds__: A field of type List<int> that holds the touch ids. The list is used to store the ids of the touches on the screen.		
* __handlers__: A field of type List<WeakReference> that holds references to the event handlers attached to the recognizer.

You can find the code definitions of the helper fields in the following code snippet:

__Example 2: Defining the fields of the recognizer__  
```C#
	private static readonly TimeSpan AllowedInterval = TimeSpan.FromMilliseconds(300);
	private static readonly int MaxTouchCount = 2;
	private DateTime originTouchTime;
	private bool isTwoFingerGesture;
	private List<int> touchIds = new List<int>();
	private List<WeakReference> handlers = new List<WeakReference>(); 
```
```VB.NET
	Private Shared ReadOnly AllowedInterval As TimeSpan = TimeSpan.FromMilliseconds(2000)
	Private Shared ReadOnly MaxTouchCount As Integer = 2
	Private originTouchTime As DateTime
	Private isTwoFingerGesture As Boolean
	Private touchIds As New List(Of Integer)()
	Private handlers As New List(Of WeakReference)()
```

When we add the properties we can use them in the overrides of the gesture recognizer's methods. 

* __OnTouchDown__: When this method is called, we can store the touch id in the *touchIds* collection. If this is the first touch, we are setting the *originTouchTime* to the current time. If this is the second touch, we set the *isTwoFingerGesture* property to __true__.
	
	__Example 3: Implementing logic in the OnTouchDown method__
	```C#
		public override void OnTouchDown(GestureRecognizerEventArgs args)
		{                        
			this.touchIds.Add(args.TouchId);
			if (this.touchIds.Count == 1)
			{
				this.originTouchTime = DateTime.Now;
			}
			this.isTwoFingerGesture = this.touchIds.Count == MaxTouchCount;
		}
	```
	```VB.NET
		Public Overrides Sub OnTouchDown(args As GestureRecognizerEventArgs)
			Me.touchIds.Add(args.TouchId)
			If Me.touchIds.Count = 1 Then
				Me.originTouchTime = DateTime.Now
			End If
			Me.isTwoFingerGesture = Me.touchIds.Count = MaxTouchCount
		End Sub
	```

* __OnTouchLeave__: When this method is called, we can remove the touch id of the leaving touch from the *touchIds* collection.
	
	__Example 4: Implementing logic in the OnTouchLeave method__
	```C#
		public override void OnTouchLeave(GestureRecognizerEventArgs args)
        {
            this.touchIds.Remove(args.TouchId);
        }
	```
	```VB.NET
		Public Overrides Sub OnTouchLeave(args As GestureRecognizerEventArgs)
			Me.touchIds.Remove(args.TouchId)
		End Sub
	```
		
* __OnTouchUp__: When this method is called, we can remove the touch id of the leaving touch from the collection. Here we can also check if the gesture can be executed. 
	
	__Example 5: Implementing logic in the OnTouchUp method__
	```C#
		public override void OnTouchUp(GestureRecognizerEventArgs args)
		{
			this.touchIds.Remove(args.TouchId);
			if (this.touchIds.Count == 0 && this.isTwoFingerGesture)
			{
				var ellapsed = DateTime.Now - this.originTouchTime;
				if (ellapsed <= TwoFingerTapGestureRecognizer.AllowedInterval &&
					GestureManager.CanActivateGesture(this.Element, "TwoFingerTapGesture"))
				{
					var token = GestureManager.ActivateGesture(this.Element, "TwoFingerTapGesture", null);
					GestureExtensions.RaiseTwoFingerTap(this.Element);
					token.DeactivateGesture();
				}
			}
		}
	```
	```VB.NET
		Public Overrides Sub OnTouchUp(args As GestureRecognizerEventArgs)
			Me.touchIds.Remove(args.TouchId)
			If Me.touchIds.Count = 0 AndAlso Me.isTwoFingerGesture Then
				Dim ellapsed = DateTime.Now - Me.originTouchTime
				If ellapsed <= TwoFingerTapGestureRecognizer.AllowedInterval AndAlso GestureManager.CanActivateGesture(Me.Element, "TwoFingerTapGesture") Then
					Dim token = GestureManager.ActivateGesture(Me.Element, "TwoFingerTapGesture", Nothing)
					GestureExtensions.RaiseTwoFingerTap(Me.Element)
					token.DeactivateGesture()
				End If
			End If
		End Sub
	```

	Note that we are using the __CanActivateGesture()__ and __ActivateGesture()__ methods of the __GestureManager__ class. This way we ensure that the gesture will be activated only if there is no collision between this gesture and the one that is currently active (if any). 
	
	> The GestureExtensions is a class that holds a custom routed event and fires it when the gesture is executed. We will discuss its implementation in the [Using the gesture](#using-the-gesture) section of this article.		

Example 6 is the main logic of the recognizer. In this example you'll see how to implement logic for storing the event handlers for the gesture. We can do this through a couple of public methods that accept event handlers as arguments and add/remove them in the *handlers* collection defined earlier.

__Example 6: Implementing logic for associating event handlers with the recognizer__
```C#
	public void AddHandler(RoutedEventHandler handler)
	{
		this.handlers.Add(new WeakReference(handler));
		this.HasGestureHandlers = true;
	}

	public void RemoveHandler(RoutedEventHandler handler)
	{
		for (int i = this.handlers.Count - 1; i >= 0; i--)
		{
			var target = this.handlers[i].Target as RoutedEventHandler;
			if (handler == target || target == null)
			{
				this.handlers.RemoveAt(i);
			}
		}
		this.HasGestureHandlers = this.handlers.Count > 0;
	}
```
```VB.NET
	Public Sub AddHandler(handler As RoutedEventHandler)
		Me.handlers.Add(New WeakReference(handler))
		Me.HasGestureHandlers = True
	End Sub

	Public Sub [RemoveHandler](handler As RoutedEventHandler)
		For i As Integer = Me.handlers.Count - 1 To 0 Step -1
			Dim target = TryCast(Me.handlers(i).Target, RoutedEventHandler)
			If handler = target OrElse target Is Nothing Then
				Me.handlers.RemoveAt(i)
			End If
		Next
		Me.HasGestureHandlers = Me.handlers.Count > 0
	End Sub
```
	
## Implementing the gesture recognizer factory

To add the gesture to a specific UIElement we need to create a recognizer factory that creates our gesture. The factory is a class that implements the __IGestureRecognizerFactory__ interface.

__Example 7: Defining the gesture recognizer factory__
```C#
	public class TwoFingerTapGestureRecognizerFactory : IGestureRecognizerFactory
	{
		public GestureRecognizerBase CreateGestureRecognizer(System.Windows.UIElement element)
		{
			return new TwoFingerTapGestureRecognizer(element);
		}

		public int Priority
		{
			get { return 0; }
		}

		public void RegisterGestureTransitions()
		{            
		}
	}
```
```VB.NET
	Public Class TwoFingerTapGestureRecognizerFactory
		Implements IGestureRecognizerFactory
		Public Function CreateGestureRecognizer(element As System.Windows.UIElement) As GestureRecognizerBase
			Return New TwoFingerTapGestureRecognizer(element)
		End Function

		Public ReadOnly Property Priority() As Integer
			Get
				Return 0
			End Get
		End Property

		Public Sub RegisterGestureTransitions()
		End Sub
	End Class
```

## Using the gesture

Lets start with defining the UIElement on which the gesture will be performed.

__Example 8: Defining the UI of the example__
```XAML
	<UserControl x:Class="WpfApplication1.Example"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             mc:Ignorable="d" 
             d:DesignHeight="300" d:DesignWidth="300">
		<StackPanel>
			<TextBlock Text="Tap using two fingers to change the opacity of the rectangle" TextAlignment="Center"/>
			<Rectangle x:Name="element"  Width="200" Height="200" Fill="Orange" Margin="30"/>
		</StackPanel>
	</UserControl>
```

To use the gesture we will need to register the gesture recognizer factory and create a recogonizer for the UIElement that should listen for it. Then we can add an event handler for the UIElement.

__Example 9: Creating a new instance of the recognizer and associating it with a UIElement__
```C#
	GestureManager.RegisterGestureRecognizerFactory(new TwoFingerTapGestureRecognizerFactory());
	//-----------
	TwoFingerTapGestureRecognizer recognizer = GestureManager.GetOrCreateGestureRecognizer<TwoFingerTapGestureRecognizer>(uiElement);
	recognizer.AddHandler(handler);
	element.AddHandler(TwoFingerTapEvent, handler, false);  
```
```VB.NET
	GestureManager.RegisterGestureRecognizerFactory(New TwoFingerTapGestureRecognizerFactory())
	'-----------'
	Dim recognizer As TwoFingerTapGestureRecognizer = GestureManager.GetOrCreateGestureRecognizer(Of TwoFingerTapGestureRecognizer)(uiElement)
	recognizer.AddHandler(handler)
	element.AddHandler(TwoFingerTapEvent, handler, False)
```

In example 10 we will wrap the TwoFingerTapEvent and the logic for adding handlers in a helper class called GestureExtensions.

__Example 10: Creating a helper class that raises an event when the gesture is performed__
```C#
	public class GestureExtensions
    {
        private static readonly RoutedEvent TwoFingerTapEvent = EventManager.RegisterRoutedEvent(
            "TwoFingerTap",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(TouchManager));

        public static void AddTwoFingerTapEventHandler(UIElement element, RoutedEventHandler handler)
        {
            TwoFingerTapGestureRecognizer recognizer = GestureManager.GetOrCreateGestureRecognizer<TwoFingerTapGestureRecognizer>(element);
            recognizer.AddHandler(handler);
            element.AddHandler(TwoFingerTapEvent, handler, false);            
        }

        internal static void RaiseTwoFingerTap(UIElement element)
        {
            element.RaiseEvent(new RoutedEventArgs(TwoFingerTapEvent, element));
        }
    }
```
```VB.NET
	Public Class GestureExtensions
		Private Shared ReadOnly TwoFingerTapEvent As RoutedEvent = EventManager.RegisterRoutedEvent("TwoFingerTap", RoutingStrategy.Direct, GetType(RoutedEventHandler), GetType(TouchManager))

		Public Shared Sub AddTwoFingerTapEventHandler(element As UIElement, handler As RoutedEventHandler)
			Dim recognizer As TwoFingerTapGestureRecognizer = GestureManager.GetOrCreateGestureRecognizer(Of TwoFingerTapGestureRecognizer)(element)
			recognizer.AddHandler(handler)
			element.AddHandler(TwoFingerTapEvent, handler, False)
		End Sub

		Friend Shared Sub RaiseTwoFingerTap(element As UIElement)
			element.RaiseEvent(New RoutedEventArgs(TwoFingerTapEvent, element))
		End Sub
	End Class	
```
	
Here is an example for using the GestureExtensions class and adding logic that is executed when the two-finger tap gesture is activated:

__Example 11: Associating the gesture recognizer with a UIElement__
```C#
	public partial class Example : UserControl
	{
		static Example()
		{
			GestureManager.RegisterGestureRecognizerFactory(new TwoFingerTapGestureRecognizerFactory());
		}

		public Example()
		{
			InitializeComponent();
			GestureExtensions.AddTwoFingerTapEventHandler(this.element, this.OnElementTwoFingerTap);        
		}
		
		private void OnElementTwoFingerTap(object sender, RoutedEventArgs e)
		{
			this.element.Opacity = this.element.Opacity == 1 ? 0.5 : 1;
		}
	}
```
```VB.NET
	Public Partial Class Example
		Inherits UserControl
		Shared Sub New()
			GestureManager.RegisterGestureRecognizerFactory(New TwoFingerTapGestureRecognizerFactory())
		End Sub

		Public Sub New()
			InitializeComponent()
			GestureExtensions.AddTwoFingerTapEventHandler(Me.element, AddressOf Me.OnElementTwoFingerTap)
		End Sub

		Private Sub OnElementTwoFingerTap(sender As Object, e As RoutedEventArgs)
			Me.element.Opacity = If(Me.element.Opacity = 1, 0.5, 1)
		End Sub
	End Class	
```

The following picture demonstrates the end result - changing the opacity when a two-fingers tap is performed on the Rectangle element.

![Creating Custom Gestures 01](images/touchmanager_creating_custom_gesture_01.png)
	
## See Also
* [Overivew]({%slug touchmanager-overview%})
* [Getting Started]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Custom Gestures]({%slug touchmanager-custom-gestures-overview%})
