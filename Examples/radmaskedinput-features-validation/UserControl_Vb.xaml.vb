Public Class Default_Vb


' #region radmaskedinput-features-validation_1
Public Class DataValidationViewModel
        Inherits ViewModelBase
        Private m_doubleValue As Double
        Private m_stringValue As String
        Private m_decimalValue As Decimal
        Private m_dateTimeValue As DateTime
        Public Property DoubleValue() As Double
                Get
                        Return m_doubleValue
                End Get
                Set				
                        If value < -100 OrElse value > 100 Then
                                Throw New ValidationException([String].Format("Value is {0} than {1}.", (If(value > 100, "greater", "less")), value))
                        End If
                        m_doubleValue = value
                        Me.OnPropertyChanged("DoubleValue")
                End Set
        End Property
        Public Property DecimalValue() As Decimal
                Get
                        Return m_decimalValue
                End Get
                Set
                        If value < -100 OrElse value > 100 Then
                                Throw New ValidationException([String].Format("Value is {0} than {1}.", (If(value > 100, "greater", "less")), value))
                        End If
                        m_decimalValue = value
                        Me.OnPropertyChanged("DecimalValue")
                End Set
        End Property
        Public Property DateTimeValue() As DateTime
                Get
                        Return m_dateTimeValue
                End Get
                Set
                        If value < DateTime.Parse("01.01.1900") OrElse value > DateTime.Parse("01.01.2099") Then
                                Throw New ValidationException([String].Format("Value is {0} than {1}.", (If(value > DateTime.Parse("01.01.2099"), "greater", "less")), value))
                        End If
                        m_dateTimeValue = value
                        Me.OnPropertyChanged("DateTimeValue")
                End Set
        End Property
        Public Property StringValue() As String
                Get
                        Return m_stringValue
                End Get
                Set
                        If value.Length > 6 Then
                                Throw New ValidationException([String].Format("Value's length is greater than {0}.", value.Length))
                        End If
                        m_stringValue = value
                        Me.OnPropertyChanged("StringValue")
                End Set
        End Property
End Class
' #endregion

' #region radmaskedinput-features-validation_4
Me.DataContext = New DataValidationViewModel()
' #endregion

' #region radmaskedinput-features-validation_6
Public Class DataAnnotationAttributesValidationViewModel
        Inherits ViewModelBase
        Private m_doubleValue As Double
        Private m_stringValue As String
        Private m_decimalValue As Decimal
        Private m_dateTimeValue As DateTime
        <Range(-100.0, 100.0)> _
        Public Property DoubleValue() As Double
                Get
                        Return m_doubleValue
                End Get
                Set
						Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "DateTimeValue" })
                        m_doubleValue = value
                        Me.OnPropertyChanged("DoubleValue")
                End Set
        End Property
        <Range(GetType(Decimal), "-100", "100")> _
        Public Property DecimalValue() As Decimal
                Get
                        Return m_decimalValue
                End Get
                Set
						Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "DecimalValue"})
                        m_decimalValue = value
                        Me.OnPropertyChanged("DecimalValue")
                End Set
        End Property
        <Range(GetType(DateTime), "01.01.1900", "01.01.2099")> _
        Public Property DateTimeValue() As DateTime
                Get
                        Return m_dateTimeValue
                End Get
                Set
						Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "DateTimeValue"})
                        m_dateTimeValue = value
                        Me.OnPropertyChanged("DateTimeValue")
                End Set
        End Property
        <StringLength(6)> _
        <Required> _
        Public Property StringValue() As String
                Get
                        Return m_stringValue
                End Get
                Set
						Validator.ValidateProperty(value, New ValidationContext(Me, Nothing, Nothing) With { .MemberName = "StringValue"})
                        m_stringValue = value
                        Me.OnPropertyChanged("StringValue")
                End Set
        End Property
End Class
' #endregion

' #region radmaskedinput-features-validation_9
Me.DataContext = New DataAnnotationAttributesValidationViewModel()
' #endregion
End Class
