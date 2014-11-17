---
title: Drag and Drop within RadGridView
page_title: Drag and Drop within RadGridView
description: Drag and Drop within RadGridView
slug: dragdropmanager-howto-draganddrop-within-radgridview
tags: drag,and,drop,within,radgridview
published: True
position: 4
---

# Drag and Drop within RadGridView

The purpose of this tutorial is to show you how to implement __drag and drop within__ a __RadGridView__, giving the user feedback where the dragged item will be dropped.      

The final result should look like the one on the snapshot below:

![dragdropmanager-howto-draganddrop-within-radgridview 02](images/dragdropmanager-howto-draganddrop-within-radgridview_02.png)

* Create a new business object named __MessageViewModel__. It will be used to populate the __RadGridView__ with sample data.          

#### __C#__

{{region dragdropmanager-howto-draganddrop-within-radgridview_1}}
	public class MessageViewModel
	{
		public static IList Generate()
		{
			IList data = new ObservableCollection<MessageViewModel>();
			data.Add(new MessageViewModel("tom@hanna-barbera.com", "Cats are cool", 100));
			data.Add(new MessageViewModel("jerry@hanna-barbera.com", "Mice are cool", 100));
			data.Add(new MessageViewModel("spike@hanna-barbera.com", "Dogs are cool", 100));
			data.Add(new MessageViewModel("jerry2@hanna-barbera.com", "2Mice are cool", 200));
			data.Add(new MessageViewModel("spike2@hanna-barbera.com", "2Dogs are cool", 200));
			data.Add(new MessageViewModel("jerry3@hanna-barbera.com", "3Mice are cool", 300));
			data.Add(new MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300));
			data.Add(new MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300));
			data.Add(new MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300));
			return data;
		}
		public MessageViewModel(string sender, string subject, int size)
		{
			this.Sender = sender;
			this.Subject = subject;
			this.Size = size;
		}
		public string Subject
		{
			get;
			set;
		}
		public string Sender
		{
			get;
			set;
		}
		public int Size
		{
			get;
			set;
		}
		 public override string ToString()
		{
			return this.Sender;
		}
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-howto-draganddrop-within-radgridview_2}}
	Public Class MessageViewModel
		Public Shared Function Generate() As IList
			Dim data As IList = New ObservableCollection(Of MessageViewModel)()
			data.Add(New MessageViewModel("tom@hanna-barbera.com", "Cats are cool", 100))
			data.Add(New MessageViewModel("jerry@hanna-barbera.com", "Mice are cool", 100))
			data.Add(New MessageViewModel("spike@hanna-barbera.com", "Dogs are cool", 100))
			data.Add(New MessageViewModel("jerry2@hanna-barbera.com", "2Mice are cool", 200))
			data.Add(New MessageViewModel("spike2@hanna-barbera.com", "2Dogs are cool", 200))
			data.Add(New MessageViewModel("jerry3@hanna-barbera.com", "3Mice are cool", 300))
			data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
			data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
			data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
			Return data
		End Function
		Public Sub New(ByVal sender As String, ByVal subject As String, ByVal size As Integer)
			Me.Sender = sender
			Me.Subject = subject
			Me.Size = size
		End Sub
		Private _Subject As String
		Public Property Subject() As String
			Get
				Return _Subject
			End Get
			Set(ByVal value As String)
				_Subject = value
			End Set
		End Property
		Private _Sender As String
		Public Property Sender() As String
			Get
				Return _Sender
			End Get
			Set(ByVal value As String)
				_Sender = value
			End Set
		End Property
		Private _Size As Integer
		Public Property Size() As Integer
			Get
				Return _Size
			End Get
			Set(ByVal value As Integer)
				_Size = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return Me.Sender
		End Function
	End Class
{{endregion}}

* The XAML should look like the code snippet below.

#### __XAML__

{{region dragdropmanager-howto-draganddrop-within-radgridview_0}}
	<telerik:RadGridView   AutoGenerateColumns="True"
	                        Margin="5"
	                        Name="radGridView"
	                        AllowDrop="True"
	                        GroupRenderMode="Flat">
		<telerik:RadGridView.Resources>
			<DataTemplate x:Key="DraggedItemTemplate">
				<StackPanel>
					<StackPanel Orientation="Horizontal">
						<TextBlock Text="Dragging:" />
						<TextBlock Text="{Binding CurrentDraggedItem}"
								   FontWeight="Bold" />
					</StackPanel>
					<StackPanel Orientation="Horizontal">
						<TextBlock Text="{Binding CurrentDropPosition}"
								   FontWeight="Bold"
								   MinWidth="45" />
						<TextBlock Text=", ("
								   Foreground="Gray" />
						<TextBlock Text="{Binding CurrentDraggedOverItem}" />
						<TextBlock Text=")"
								   Foreground="Gray" />
					</StackPanel>
				</StackPanel>
			</DataTemplate>
		</telerik:RadGridView.Resources>
		<telerik:RadGridView.RowStyle>
			<Style TargetType="telerik:GridViewRow">
				<Setter Property="telerik:DragDropManager.AllowDrag"
						Value="True" />
				<Setter Property="telerik:DragDropManager.TouchDragTrigger"
						Value="TapAndHold"/>
			</Style>
		</telerik:RadGridView.RowStyle>
	</telerik:RadGridView>
{{endregion}}

>If you are referencing NoXaml binaries, then your style should specify __BasedOn={StaticResource GridViewRowStyle}__.

* Don't forget to populate your __RadGridView__ with sample data.            

#### __C#__

{{region dragdropmanager-howto-draganddrop-within-radgridview_3}}
	this.radGridView.ItemsSource = MessageViewModel.Generate();
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-howto-draganddrop-within-radgridview_4}}
	Me.radGridView.ItemsSource = MessageViewModel.Generate()
{{endregion}}

* Create a new class named __DropIndicationDetails__.           

#### __C#__

{{region dragdropmanager-howto-draganddrop-within-radgridview_15}}
	public class DropIndicationDetails : ViewModelBase
	{
		private object currentDraggedItem;
		private DropPosition currentDropPosition;
		private object currentDraggedOverItem;
	
		public object CurrentDraggedOverItem
		{
			get
			{
				return currentDraggedOverItem;
			}
			set
			{
				if (this.currentDraggedOverItem != value)
				{
					currentDraggedOverItem = value;
					OnPropertyChanged("CurrentDraggedOverItem");
				}
			}
		}
	
		public int DropIndex { get; set; }
	
		public DropPosition CurrentDropPosition
		{
			get
			{
				return this.currentDropPosition;
			}
			set
			{
				if (this.currentDropPosition != value)
				{
					this.currentDropPosition = value;
					OnPropertyChanged("CurrentDropPosition");
				}
			}
		}
	
		public object CurrentDraggedItem
		{
			get
			{
				return this.currentDraggedItem;
			}
			set
			{
				if (this.currentDraggedItem != value)
				{
					this.currentDraggedItem = value;
					OnPropertyChanged("CurrentDraggedItem");
				}
			}
		}
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-howto-draganddrop-within-radgridview_16}}
	Public Class DropIndicationDetails
		Inherits ViewModelBase
		Private m_currentDraggedItem As Object
		Private m_currentDropPosition As DropPosition
		Private m_currentDraggedOverItem As Object

		Public Property CurrentDraggedOverItem() As Object
			Get
				Return m_currentDraggedOverItem
			End Get
			Set(value As Object)
				If Me.m_currentDraggedOverItem <> value Then
					m_currentDraggedOverItem = value
					OnPropertyChanged("CurrentDraggedOverItem")
				End If
			End Set
		End Property

		Public Property DropIndex() As Integer
			Get
				Return m_DropIndex
			End Get
			Set(value As Integer)
				m_DropIndex = Value
			End Set
		End Property
		Private m_DropIndex As Integer

		Public Property CurrentDropPosition() As DropPosition
			Get
				Return Me.m_currentDropPosition
			End Get
			Set(value As DropPosition)
				If Me.m_currentDropPosition <> value Then
					Me.m_currentDropPosition = value
					OnPropertyChanged("CurrentDropPosition")
				End If
			End Set
		End Property

		Public Property CurrentDraggedItem() As Object
			Get
				Return Me.m_currentDraggedItem
			End Get
			Set(value As Object)
				If Me.m_currentDraggedItem <> value Then
					Me.m_currentDraggedItem = value
					OnPropertyChanged("CurrentDraggedItem")
				End If
			End Set
		End Property
	End Class
{{endregion}}

* The row reorder capabilities will be encapsulated in a __Behavior__. Create a new class named __RowReorderBehavior__.            

* Finally, the complete code for the __RowReorderBehavior__ is shown on the code snippet below.            

#### __C#__

{{region dragdropmanager-howto-draganddrop-within-radgridview_17}}
	public class RowReorderBehavior
	{
		private const string DropPositionFeedbackElementName = "DragBetweenItemsFeedback";
		private ContentPresenter dropPositionFeedbackPresenter;
		private Grid dropPositionFeedbackPresenterHost;
	
		private RadGridView _associatedObject;
	
		/// <summary>
		/// AssociatedObject Property
		/// </summary>
		public RadGridView AssociatedObject
		{
			get
			{
				return _associatedObject;
			}
			set
			{
				_associatedObject = value;
			}
		}
	
		private static Dictionary<RadGridView, RowReorderBehavior> instances;
	
		static RowReorderBehavior()
		{
			instances = new Dictionary<RadGridView, RowReorderBehavior>();
		}
	
		public static bool GetIsEnabled(DependencyObject obj)
		{
			return (bool)obj.GetValue(IsEnabledProperty);
		}
	
		public static void SetIsEnabled(DependencyObject obj, bool value)
		{
			RowReorderBehavior behavior = GetAttachedBehavior(obj as RadGridView);
	
			behavior.AssociatedObject = obj as RadGridView;
	
			if (value)
			{
				behavior.Initialize();
			}
			else
			{
				behavior.CleanUp();
			}
			obj.SetValue(IsEnabledProperty, value);
		}
	
		// Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsEnabledProperty =
			DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(RowReorderBehavior),
				new PropertyMetadata(new PropertyChangedCallback(OnIsEnabledPropertyChanged)));
	
		public static void OnIsEnabledPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
		{
			SetIsEnabled(dependencyObject, (bool)e.NewValue);
		}
	
		private static RowReorderBehavior GetAttachedBehavior(RadGridView gridview)
		{
			if (!instances.ContainsKey(gridview))
			{
				instances[gridview] = new RowReorderBehavior();
				instances[gridview].AssociatedObject = gridview;
			}
	
			return instances[gridview];
		}
	
		public RowReorderBehavior()
		{
			this.dropPositionFeedbackPresenter = new ContentPresenter();
			this.dropPositionFeedbackPresenter.Name = DropPositionFeedbackElementName;
			this.dropPositionFeedbackPresenter.HorizontalAlignment = HorizontalAlignment.Left;
			this.dropPositionFeedbackPresenter.VerticalAlignment = VerticalAlignment.Top;
			this.dropPositionFeedbackPresenter.RenderTransformOrigin = new Point(0.5, 0.5);
		}
	
		protected virtual void Initialize()
		{
			this.AssociatedObject.RowLoaded -= this.AssociatedObject_RowLoaded;
			this.AssociatedObject.RowLoaded += this.AssociatedObject_RowLoaded;
			this.UnsubscribeFromDragDropEvents();
			this.SubscribeToDragDropEvents();
			this.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded;
			this.AssociatedObject.DataLoaded += AssociatedObject_DataLoaded;
				
		}
	
		void AssociatedObject_DataLoaded(object sender, EventArgs e)
		{
	
			this.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded;
			this.AttachDropPositionFeedback();
		}
	
		protected virtual void CleanUp()
		{
			this.AssociatedObject.RowLoaded -= this.AssociatedObject_RowLoaded;
			this.UnsubscribeFromDragDropEvents();
			this.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded;
	
	
			this.DetachDropPositionFeedback();
	
		}
	
		void AssociatedObject_RowLoaded(object sender, Telerik.Windows.Controls.GridView.RowLoadedEventArgs e)
		{
			if (e.Row is GridViewHeaderRow || e.Row is GridViewNewRow || e.Row is GridViewFooterRow)
				return;
	
			GridViewRow row = e.Row as GridViewRow;
			this.InitializeRowDragAndDrop(row);
		}
	
		private void InitializeRowDragAndDrop(GridViewRow row)
		{
			if (row == null)
				return;
	
			DragDropManager.RemoveDragOverHandler(row, OnRowDragOver);
			DragDropManager.AddDragOverHandler(row, OnRowDragOver);
		}
	
		private void SubscribeToDragDropEvents()
		{
			DragDropManager.AddDragInitializeHandler(this.AssociatedObject, OnDragInitialize);
			DragDropManager.AddGiveFeedbackHandler(this.AssociatedObject, OnGiveFeedback);
			DragDropManager.AddDropHandler(this.AssociatedObject, OnDrop);
			DragDropManager.AddDragDropCompletedHandler(this.AssociatedObject, OnDragDropCompleted);
		}
	
			
	
		private void UnsubscribeFromDragDropEvents()
		{
			DragDropManager.RemoveDragInitializeHandler(this.AssociatedObject, OnDragInitialize);
			DragDropManager.RemoveGiveFeedbackHandler(this.AssociatedObject, OnGiveFeedback);
			DragDropManager.RemoveDropHandler(this.AssociatedObject, OnDrop);
			DragDropManager.RemoveDragDropCompletedHandler(this.AssociatedObject, OnDragDropCompleted);
	
		}
	
		private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
		{
			this.HideDropPositionFeedbackPresenter();
		}
	
		private void OnDragInitialize(object sender, DragInitializeEventArgs e)
		{
			var sourceRow = e.OriginalSource as GridViewRow ?? (e.OriginalSource as FrameworkElement).ParentOfType<GridViewRow>();
			if (sourceRow != null && sourceRow.Name != "PART_RowResizer")
			{
				DropIndicationDetails details = new DropIndicationDetails();
				var item = sourceRow.Item;
				details.CurrentDraggedItem = item;
	
				IDragPayload dragPayload = DragDropPayloadManager.GeneratePayload(null);
	
				dragPayload.SetData("DraggedItem", item);
				dragPayload.SetData("DropDetails", details);
	
				e.Data = dragPayload;
	
				e.DragVisual = new DragVisual()
				{
					Content = details,
					ContentTemplate = this.AssociatedObject.Resources["DraggedItemTemplate"] as DataTemplate
				};
				e.DragVisualOffset = e.RelativeStartPoint;
				e.AllowedEffects = DragDropEffects.All;
			}
		}
	
		private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs e)
		{
			e.SetCursor(Cursors.Arrow);
			e.Handled = true;
		}
	
		private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
		{
			var draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem");
			var details = DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails") as DropIndicationDetails;
	
			if (details == null || draggedItem == null)
			{
				return;
			}
	
			if (e.Effects == DragDropEffects.Move || e.Effects == DragDropEffects.All)
			{
				((sender as RadGridView).ItemsSource as IList).Remove(draggedItem);
			}
	
			if (e.Effects != DragDropEffects.None)
			{
				var collection = (sender as RadGridView).ItemsSource as IList;
				int index = details.DropIndex < 0 ? 0 : details.DropIndex;
				index = details.DropIndex > collection.Count - 1 ? collection.Count : index;
	
				collection.Insert(index, draggedItem);
			}
	
			HideDropPositionFeedbackPresenter();
		}
	
		private void OnRowDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
		{
			var row = sender as GridViewRow;
			var details = DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails") as DropIndicationDetails;
	
			if (details == null || row == null)
			{
				return;
			}
	
			details.CurrentDraggedOverItem = row.DataContext;
	
			if (details.CurrentDraggedItem == details.CurrentDraggedOverItem)
			{
				e.Effects = DragDropEffects.None;
				e.Handled = true;
				return;
			}
	
			details.CurrentDropPosition = GetDropPositionFromPoint(e.GetPosition(row), row);
			int dropIndex = (this.AssociatedObject.Items as IList).IndexOf(row.DataContext);
			int draggedItemIdex = (this.AssociatedObject.Items as IList).IndexOf(DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem"));
	           
			if (dropIndex >= row.GridViewDataControl.Items.Count - 1 && details.CurrentDropPosition == DropPosition.After)
			{
				details.DropIndex = dropIndex;
	            this.ShowDropPositionFeedbackPresenter(this.AssociatedObject, row, details.CurrentDropPosition);
				return;
			}
	
			dropIndex = draggedItemIdex > dropIndex ? dropIndex : dropIndex - 1;
			details.DropIndex = details.CurrentDropPosition == DropPosition.Before ? dropIndex : dropIndex + 1;
	
			this.ShowDropPositionFeedbackPresenter(this.AssociatedObject, row, details.CurrentDropPosition);
		}
	
		public virtual DropPosition GetDropPositionFromPoint(Point absoluteMousePosition, GridViewRow row)
		{
			if (row != null)
			{
				return absoluteMousePosition.Y < row.ActualHeight / 2 ? DropPosition.Before : DropPosition.After;
			}
	
			return DropPosition.Inside;
		}
	
		private bool IsDropPositionFeedbackAvailable()
		{
			return
					this.dropPositionFeedbackPresenterHost != null &&
					this.dropPositionFeedbackPresenter != null;
		}
	
		private void ShowDropPositionFeedbackPresenter(GridViewDataControl gridView, GridViewRow row, DropPosition lastRowDropPosition)
		{
			if (!this.IsDropPositionFeedbackAvailable())
				return;
			var yOffset = this.GetDropPositionFeedbackOffset(row, lastRowDropPosition);
			this.dropPositionFeedbackPresenter.Visibility = Visibility.Visible;
			this.dropPositionFeedbackPresenter.Width = row.ActualWidth;
			this.dropPositionFeedbackPresenter.RenderTransform = new TranslateTransform()
			{
				Y = yOffset
			};
		}
	
		private void HideDropPositionFeedbackPresenter()
		{
			this.dropPositionFeedbackPresenter.RenderTransform = new TranslateTransform()
			{
				X = 0,
				Y = -234324
			};
	        this.dropPositionFeedbackPresenter.Visibility = Visibility.Collapsed;
		}
	
		private double GetDropPositionFeedbackOffset(GridViewRow row, DropPosition dropPosition)
		{
			var yOffset = row.TransformToVisual(this.dropPositionFeedbackPresenterHost).Transform(new Point(0, 0)).Y;
			if (dropPosition == DropPosition.After)
				yOffset += row.ActualHeight;
			yOffset -= (this.dropPositionFeedbackPresenter.ActualHeight / 2.0);
			return yOffset;
		}
	
		private void DetachDropPositionFeedback()
		{
			if (this.IsDropPositionFeedbackAvailable())
				this.dropPositionFeedbackPresenterHost.Children.Remove(this.dropPositionFeedbackPresenter);
		}
	
		private void AttachDropPositionFeedback()
		{
			this.dropPositionFeedbackPresenterHost = this.AssociatedObject.ParentOfType<Grid>();
	
	        if (this.dropPositionFeedbackPresenterHost != null)
	        {
	            this.dropPositionFeedbackPresenter.Content = CreateDefaultDropPositionFeedback();
	            if (dropPositionFeedbackPresenterHost != null && dropPositionFeedbackPresenterHost.FindName(this.dropPositionFeedbackPresenter.Name) == null)
	            {
	                this.dropPositionFeedbackPresenterHost.Children.Insert(0, this.dropPositionFeedbackPresenter);
	            }
	        }
	        this.HideDropPositionFeedbackPresenter();
		}
	
		private static UIElement CreateDefaultDropPositionFeedback()
		{
			Grid grid = new Grid()
			{
				Height = 8,
				HorizontalAlignment = HorizontalAlignment.Stretch,
				IsHitTestVisible = false,
				VerticalAlignment = VerticalAlignment.Stretch
			};
			grid.ColumnDefinitions.Add(new ColumnDefinition()
			{
				Width = new GridLength(8)
			});
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			Ellipse ellipse = new Ellipse()
			{
				Stroke = new SolidColorBrush(Colors.Orange),
				StrokeThickness = 2,
				Fill = new SolidColorBrush(Colors.Orange),
				HorizontalAlignment = HorizontalAlignment.Stretch,
				VerticalAlignment = VerticalAlignment.Stretch,
				Width = 8,
				Height = 8
			};
			Rectangle rectangle = new Rectangle()
			{
				Fill = new SolidColorBrush(Colors.Orange),
				RadiusX = 2,
				RadiusY = 2,
				VerticalAlignment = VerticalAlignment.Stretch,
				HorizontalAlignment = HorizontalAlignment.Stretch,
				Height = 2
			};
			Grid.SetColumn(ellipse, 0);
			Grid.SetColumn(rectangle, 1);
			grid.Children.Add(ellipse);
			grid.Children.Add(rectangle);
			return grid;
		}
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-howto-draganddrop-within-radgridview_18}}
	Public Class RowReorderBehavior
		Private Const DropPositionFeedbackElementName As String = "DragBetweenItemsFeedback"
		Private dropPositionFeedbackPresenter As ContentPresenter
		Private dropPositionFeedbackPresenterHost As Grid

		Private _associatedObject As RadGridView

		''' <summary>
		''' AssociatedObject Property
		''' </summary>
		Public Property AssociatedObject() As RadGridView
			Get
				Return _associatedObject
			End Get
			Set(value As RadGridView)
				_associatedObject = value
			End Set
		End Property

		Private Shared instances As Dictionary(Of RadGridView, RowReorderBehavior)

		Shared Sub New()
			instances = New Dictionary(Of RadGridView, RowReorderBehavior)()
		End Sub

		Public Shared Function GetIsEnabled(obj As DependencyObject) As Boolean
			Return CBool(obj.GetValue(IsEnabledProperty))
		End Function

		Public Shared Sub SetIsEnabled(obj As DependencyObject, value As Boolean)
			Dim behavior As RowReorderBehavior = GetAttachedBehavior(TryCast(obj, RadGridView))

			behavior.AssociatedObject = TryCast(obj, RadGridView)

			If value Then
				behavior.Initialize()
			Else
				behavior.CleanUp()
			End If
			obj.SetValue(IsEnabledProperty, value)
		End Sub

		' Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
		Public Shared ReadOnly IsEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnabled", GetType(Boolean), GetType(RowReorderBehavior), New PropertyMetadata(New PropertyChangedCallback(OnIsEnabledPropertyChanged)))

		Public Shared Sub OnIsEnabledPropertyChanged(dependencyObject As DependencyObject, e As DependencyPropertyChangedEventArgs)
			SetIsEnabled(dependencyObject, CBool(e.NewValue))
		End Sub

		Private Shared Function GetAttachedBehavior(gridview As RadGridView) As RowReorderBehavior
			If Not instances.ContainsKey(gridview) Then
				instances(gridview) = New RowReorderBehavior()
				instances(gridview).AssociatedObject = gridview
			End If

			Return instances(gridview)
		End Function

		Public Sub New()
			Me.dropPositionFeedbackPresenter = New ContentPresenter()
			Me.dropPositionFeedbackPresenter.Name = DropPositionFeedbackElementName
			Me.dropPositionFeedbackPresenter.HorizontalAlignment = HorizontalAlignment.Left
			Me.dropPositionFeedbackPresenter.VerticalAlignment = VerticalAlignment.Top
			Me.dropPositionFeedbackPresenter.RenderTransformOrigin = New Point(0.5, 0.5)
		End Sub

		Protected Overridable Sub Initialize()
			Me.AssociatedObject.RowLoaded -= Me.AssociatedObject_RowLoaded
			Me.AssociatedObject.RowLoaded += Me.AssociatedObject_RowLoaded
			Me.UnsubscribeFromDragDropEvents()
			Me.SubscribeToDragDropEvents()
			Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded
			Me.AssociatedObject.DataLoaded += AssociatedObject_DataLoaded

		End Sub

		Private Sub AssociatedObject_DataLoaded(sender As Object, e As EventArgs)

			Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded
			Me.AttachDropPositionFeedback()
		End Sub

		Protected Overridable Sub CleanUp()
			Me.AssociatedObject.RowLoaded -= Me.AssociatedObject_RowLoaded
			Me.UnsubscribeFromDragDropEvents()
			Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded


			Me.DetachDropPositionFeedback()

		End Sub

		Private Sub AssociatedObject_RowLoaded(sender As Object, e As Telerik.Windows.Controls.GridView.RowLoadedEventArgs)
			If TypeOf e.Row Is GridViewHeaderRow OrElse TypeOf e.Row Is GridViewNewRow OrElse TypeOf e.Row Is GridViewFooterRow Then
				Return
			End If

			Dim row As GridViewRow = TryCast(e.Row, GridViewRow)
			Me.InitializeRowDragAndDrop(row)
		End Sub

		Private Sub InitializeRowDragAndDrop(row As GridViewRow)
			If row Is Nothing Then
				Return
			End If

			DragDropManager.RemoveDragOverHandler(row, OnRowDragOver)
			DragDropManager.AddDragOverHandler(row, OnRowDragOver)
		End Sub

		Private Sub SubscribeToDragDropEvents()
			DragDropManager.AddDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
			DragDropManager.AddGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
			DragDropManager.AddDropHandler(Me.AssociatedObject, OnDrop)
			DragDropManager.AddDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)
		End Sub



		Private Sub UnsubscribeFromDragDropEvents()
			DragDropManager.RemoveDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
			DragDropManager.RemoveGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
			DragDropManager.RemoveDropHandler(Me.AssociatedObject, OnDrop)
			DragDropManager.RemoveDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)

		End Sub

		Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
			Me.HideDropPositionFeedbackPresenter()
		End Sub

		Private Sub OnDragInitialize(sender As Object, e As DragInitializeEventArgs)
			Dim sourceRow = If(TryCast(e.OriginalSource, GridViewRow), TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of GridViewRow)())
			If sourceRow IsNot Nothing AndAlso sourceRow.Name <> "PART_RowResizer" Then
				Dim details As New DropIndicationDetails()
				Dim item = sourceRow.Item
				details.CurrentDraggedItem = item

				Dim dragPayload As IDragPayload = DragDropPayloadManager.GeneratePayload(Nothing)

				dragPayload.SetData("DraggedItem", item)
				dragPayload.SetData("DropDetails", details)

				e.Data = dragPayload

				e.DragVisual = New DragVisual() With { _
				 .Content = details, _
				 .ContentTemplate = TryCast(Me.AssociatedObject.Resources("DraggedItemTemplate"), DataTemplate) _
				}
				e.DragVisualOffset = e.RelativeStartPoint
				e.AllowedEffects = DragDropEffects.All
			End If
		End Sub

		Private Sub OnGiveFeedback(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
			e.SetCursor(Cursors.Arrow)
			e.Handled = True
		End Sub

		Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
			Dim draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem")
			Dim details = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

			If details Is Nothing OrElse draggedItem Is Nothing Then
				Return
			End If

			If e.Effects = DragDropEffects.Move OrElse e.Effects = DragDropEffects.All Then
				TryCast(TryCast(sender, RadGridView).ItemsSource, IList).Remove(draggedItem)
			End If

			If e.Effects <> DragDropEffects.None Then
				Dim collection = TryCast(TryCast(sender, RadGridView).ItemsSource, IList)
				Dim index As Integer = If(details.DropIndex < 0, 0, details.DropIndex)
				index = If(details.DropIndex > collection.Count - 1, collection.Count, index)

				collection.Insert(index, draggedItem)
			End If

			HideDropPositionFeedbackPresenter()
		End Sub

		Private Sub OnRowDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
			Dim row = TryCast(sender, GridViewRow)
			Dim details = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

			If details Is Nothing OrElse row Is Nothing Then
				Return
			End If

			details.CurrentDraggedOverItem = row.DataContext

			If details.CurrentDraggedItem = details.CurrentDraggedOverItem Then
				e.Effects = DragDropEffects.None
				e.Handled = True
				Return
			End If

			details.CurrentDropPosition = GetDropPositionFromPoint(e.GetPosition(row), row)
			Dim dropIndex As Integer = TryCast(Me.AssociatedObject.Items, IList).IndexOf(row.DataContext)
			Dim draggedItemIdex As Integer = TryCast(Me.AssociatedObject.Items, IList).IndexOf(DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem"))

			If dropIndex >= row.GridViewDataControl.Items.Count - 1 AndAlso details.CurrentDropPosition = DropPosition.After Then
				details.DropIndex = dropIndex
				Me.ShowDropPositionFeedbackPresenter(Me.AssociatedObject, row, details.CurrentDropPosition)
				Return
			End If

			dropIndex = If(draggedItemIdex > dropIndex, dropIndex, dropIndex - 1)
			details.DropIndex = If(details.CurrentDropPosition = DropPosition.Before, dropIndex, dropIndex + 1)

			Me.ShowDropPositionFeedbackPresenter(Me.AssociatedObject, row, details.CurrentDropPosition)
		End Sub

		Public Overridable Function GetDropPositionFromPoint(absoluteMousePosition As Point, row As GridViewRow) As DropPosition
			If row IsNot Nothing Then
				Return If(absoluteMousePosition.Y < row.ActualHeight / 2, DropPosition.Before, DropPosition.After)
			End If

			Return DropPosition.Inside
		End Function

		Private Function IsDropPositionFeedbackAvailable() As Boolean
			Return Me.dropPositionFeedbackPresenterHost IsNot Nothing AndAlso Me.dropPositionFeedbackPresenter IsNot Nothing
		End Function

		Private Sub ShowDropPositionFeedbackPresenter(gridView As GridViewDataControl, row As GridViewRow, lastRowDropPosition As DropPosition)
			If Not Me.IsDropPositionFeedbackAvailable() Then
				Return
			End If
			Dim yOffset = Me.GetDropPositionFeedbackOffset(row, lastRowDropPosition)
			Me.dropPositionFeedbackPresenter.Visibility = Visibility.Visible
			Me.dropPositionFeedbackPresenter.Width = row.ActualWidth
			Me.dropPositionFeedbackPresenter.RenderTransform = New TranslateTransform() With { _
			 .Y = yOffset _
			}
		End Sub

		Private Sub HideDropPositionFeedbackPresenter()
			Me.dropPositionFeedbackPresenter.RenderTransform = New TranslateTransform() With { _
			 .X = 0, _
			 .Y = -234324 _
			}
		End Sub

		Private Function GetDropPositionFeedbackOffset(row As GridViewRow, dropPosition__1 As DropPosition) As Double
			Dim yOffset = row.TransformToVisual(Me.dropPositionFeedbackPresenterHost).Transform(New Point(0, 0)).Y
			If dropPosition__1 = DropPosition.After Then
				yOffset += row.ActualHeight
			End If
			yOffset -= (Me.dropPositionFeedbackPresenter.ActualHeight / 2.0)
			Return yOffset
		End Function

		Private Sub DetachDropPositionFeedback()
			If Me.IsDropPositionFeedbackAvailable() Then
				Me.dropPositionFeedbackPresenterHost.Children.Remove(Me.dropPositionFeedbackPresenter)
			End If
		End Sub

		Private Sub AttachDropPositionFeedback()
			Me.dropPositionFeedbackPresenterHost = Me.AssociatedObject.ParentOfType(Of Grid)()
			If Me.dropPositionFeedbackPresenterHost IsNot Nothing Then
				Me.dropPositionFeedbackPresenter.Content = CreateDefaultDropPositionFeedback()
				Me.dropPositionFeedbackPresenterHost.Children.Add(Me.dropPositionFeedbackPresenter)
			End If
			Me.HideDropPositionFeedbackPresenter()
		End Sub

		Private Shared Function CreateDefaultDropPositionFeedback() As UIElement
			Dim grid__1 As New Grid() With { _
			 .Height = 8, _
			 .HorizontalAlignment = HorizontalAlignment.Stretch, _
			 .IsHitTestVisible = False, _
			 .VerticalAlignment = VerticalAlignment.Stretch _
			}
			grid__1.ColumnDefinitions.Add(New ColumnDefinition() With { _
			 .Width = New GridLength(8) _
			})
			grid__1.ColumnDefinitions.Add(New ColumnDefinition())
			Dim ellipse As New Ellipse() With { _
			 .Stroke = New SolidColorBrush(Colors.Orange), _
			 .StrokeThickness = 2, _
			 .Fill = New SolidColorBrush(Colors.Orange), _
			 .HorizontalAlignment = HorizontalAlignment.Stretch, _
			 .VerticalAlignment = VerticalAlignment.Stretch, _
			 .Width = 8, _
			 .Height = 8 _
			}
			Dim rectangle As New Rectangle() With { _
			 .Fill = New SolidColorBrush(Colors.Orange), _
			 .RadiusX = 2, _
			 .RadiusY = 2, _
			 .VerticalAlignment = VerticalAlignment.Stretch, _
			 .HorizontalAlignment = HorizontalAlignment.Stretch, _
			 .Height = 2 _
			}
			Grid.SetColumn(ellipse, 0)
			Grid.SetColumn(rectangle, 1)
			grid__1.Children.Add(ellipse)
			grid__1.Children.Add(rectangle)
			Return grid__1
		End Function
	End Class
{{endregion}}

Finally, you should attach the attached behavior:

#### __C#__

{{region dragdropmanager-howto-draganddrop-within-radgridview_19}}
	void radGridView_DataLoaded(object sender, EventArgs e)
	{
		RowReorderBehavior.SetIsEnabled(this.radGridView, true);
	}
{{endregion}}