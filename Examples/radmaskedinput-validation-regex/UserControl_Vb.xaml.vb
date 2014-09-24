Public Class Default_Vb


' #region radmaskedinput-validation-regex_1
Public Class MaskedInputViewModel
	Inherits ViewModelBase
	Private m_email As String = "username@email.com"
	''' <summary>
	'''     Gets or sets the email.
	''' </summary>
	<RegularExpression("\b[a-z0-9._%-]+@[a-z0-9.-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Email Address.")> _
	Public Property Email() As String
		Get
			Return Me.m_email
		End Get
		Set
			If Me.m_email <> value Then
			    Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "Email" })
				Me.m_email = value
				OnPropertyChanged("Email")
			End If
		End Set
	End Property
	Private m_webAddress As String = "http://www.sampleaddress.com"
	''' <summary>
	'''     Gets or sets the webAddress.
	''' </summary>
	<RegularExpression("http://www.+\b[a-z0-9._%-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Web Address.")> _
	Public Property WebAddress() As String
		Get
			Return Me.m_webAddress
		End Get
		Set
			If Me.m_webAddress <> value Then
			    Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "WebAddress" })
				Me.m_webAddress = value
				OnPropertyChanged("WebAddress")
			End If
		End Set
	End Property
End Class
' #endregion
End Class
