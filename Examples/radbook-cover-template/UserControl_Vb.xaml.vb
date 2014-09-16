Public Class Default_Vb
#Region "radbook-cover-template_1"
	''' <summary>
	''' DataTemplateSelector responsible for picking template for the back cover page and every consecutive left page.
	''' </summary>
	Public Class LeftPageTemplateSelector
		Inherits DataTemplateSelector
		''' <summary>
		''' Gets or sets the back cover template.
		''' </summary>
		''' <value>The back cover template.</value>
		Public Property BackCoverTemplate() As DataTemplate
			Get
				Return m_BackCoverTemplate
			End Get
			Set(ByVal value As DataTemplate)
				m_BackCoverTemplate = Value
			End Set
		End Property
		Private m_BackCoverTemplate As DataTemplate
		''' <summary>
		''' Gets or sets template for every left page in the book, except only in the case of a last page.
		''' </summary>
		''' <value>The left page template.</value>
		Public Property LeftPageTemplate() As DataTemplate
			Get
				Return m_LeftPageTemplate
			End Get
			Set(ByVal value As DataTemplate)
				m_LeftPageTemplate = Value
			End Set
		End Property
		Private m_LeftPageTemplate As DataTemplate
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim page As RadBookItem = TryCast(container, RadBookItem)
			' we need an instance of the book so that we can determine the whether the current page is the last page.
			Dim book As RadBook = TryCast(System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container), RadBook)
			' Using the index property, we can determine whether the page is last page or it is one of the inner left pages.
			If page.Index = book.Items.Count - 1 Then
				Return Me.BackCoverTemplate
			Else
				Return Me.LeftPageTemplate
			End If
		End Function
	End Class
	''' <summary>
	''' DataTemplateSelector responsible for picking template for the fron cover page and every consecutive right page.
	''' </summary>
	Public Class RightPageTemplateSelector
		Inherits DataTemplateSelector
		''' <summary>
		''' Gets or sets the front cover template.
		''' </summary>
		''' <value>The front cover template.</value>
		Public Property FrontCoverTemplate() As DataTemplate
			Get
				Return m_FrontCoverTemplate
			End Get
			Set(ByVal value As DataTemplate)
				m_FrontCoverTemplate = Value
			End Set
		End Property
		Private m_FrontCoverTemplate As DataTemplate
		''' <summary>
		''' Gets or sets template for every right page in the book, except only in the case of a first page.
		''' </summary>
		''' <value>The right page template.</value>
		Public Property RightPageTemplate() As DataTemplate
			Get
				Return m_RightPageTemplate
			End Get
			Set(ByVal value As DataTemplate)
				m_RightPageTemplate = Value
			End Set
		End Property
		Private m_RightPageTemplate As DataTemplate
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim page As RadBookItem = TryCast(container, RadBookItem)
			' Using the index property, we can determine whether the page is first page or it is one of the inner right pages.
			If page.Index = 0 Then
				Return Me.FrontCoverTemplate
			Else
				Return Me.RightPageTemplate
			End If
		End Function
	End Class
#End Region

#Region "radbook-cover-template_4"
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			book1.ItemsSource = Enumerable.Range(0, 10)
		End Sub
	End Class
#End Region

End Class
