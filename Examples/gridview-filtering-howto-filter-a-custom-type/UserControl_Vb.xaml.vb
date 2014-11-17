Public Class Default_Vb

' #region gridview-filtering-howto-filter-a-custom-type_0
Public Class Person
	Private ReadOnly m_name As String
	Private m_age As Integer

	Public ReadOnly Property Name() As String
		Get
			Return Me.m_name
		End Get
	End Property

	Public Property Age() As Integer
		Get
			Return Me.m_age
		End Get
		Set(value As Integer)
			Me.m_age = value
		End Set
	End Property

	Public Sub New(name As String)
		Me.m_name = name
	End Sub
End Class
' #endregion

' #region gridview-filtering-howto-filter-a-custom-type_1
Public Class Person
	Implements IEquatable(Of Person)
	Private ReadOnly m_name As String
	Private m_age As Integer

	Public ReadOnly Property Name() As String
		Get
			Return Me.m_name
		End Get
	End Property

	Public Property Age() As Integer
		Get
			Return Me.m_age
		End Get
		Set(value As Integer)
			Me.m_age = value
		End Set
	End Property

	Public Sub New(name As String)
		Me.m_name = name
	End Sub

	Public Function GenericEquals(other As Person) As Boolean Implements IEquatable(Of Person).[Equals]
		If other Is Nothing Then
			Return False
		End If

		Return StringComparer.Ordinal.Equals(Me.Name, other.Name)
	End Function

	Public Overrides Function Equals(obj As Object) As Boolean
		Return DirectCast(Me, IEquatable(Of Person)).Equals(TryCast(obj, Person))
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return Me.Name.GetHashCode() Xor Me.Age.GetHashCode()
	End Function
End Class
' #endregion

' #region gridview-filtering-howto-filter-a-custom-type_2
Public Class PersonConverter
	Inherits System.ComponentModel.TypeConverter
	Public Overrides Function CanConvertFrom(context As System.ComponentModel.ITypeDescriptorContext, sourceType As Type) As Boolean
		If sourceType = GetType(String) Then
			Return True
		End If

		Return MyBase.CanConvertFrom(context, sourceType)
	End Function

	Public Overrides Function ConvertFrom(context As System.ComponentModel.ITypeDescriptorContext, culture As System.Globalization.CultureInfo, value As Object) As Object
		Dim stringValue = TryCast(value, String)
		If stringValue IsNot Nothing Then
			Return New Person(stringValue)
		End If

		Return MyBase.ConvertFrom(context, culture, value)
	End Function

	Public Overrides Function CanConvertTo(context As System.ComponentModel.ITypeDescriptorContext, destinationType As Type) As Boolean
		If destinationType = GetType(String) Then
			Return True
		End If

		Return MyBase.CanConvertTo(context, destinationType)
	End Function

	Public Overrides Function ConvertTo(context As System.ComponentModel.ITypeDescriptorContext, culture As System.Globalization.CultureInfo, value As Object, destinationType As Type) As Object
		If destinationType = GetType(String) Then
			Return DirectCast(value, Person).ToString()
		End If

		Return MyBase.ConvertTo(context, culture, value, destinationType)
	End Function
End Class
' #endregion

' #region gridview-filtering-howto-filter-a-custom-type_3
Public Shared Operator <(left As Person, right As Person) As Boolean
	Return left.Age < right.Age
End Operator

Public Shared Operator <=(left As Person, right As Person) As Boolean
	Return left.Age <= right.Age
End Operator

Public Shared Operator >(left As Person, right As Person) As Boolean
	Return left.Age > right.Age
End Operator

Public Shared Operator >=(left As Person, right As Person) As Boolean
	Return left.Age >= right.Age
End Operator
' #endregion

End Class
