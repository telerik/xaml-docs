Public Class Default_Vb


	' #region persistence-framework-custom-property-provider-1
	Public Class SampleCustomPropertyProvider
		Implements ICustomPropertyProvider

		Public Function GetCustomProperties() As CustomPropertyInfo()
			' Create an array of CustomPropertyInfo objects to describe which properties should be persisted 				
			Return New CustomPropertyInfo() {}
		End Function

		Public Sub InitializeObject(context As Object)
			'Set the persisted component in a state such that it is ready to take the persisted settings
		End Sub

		Public Function InitializeValue(customPropertyInfo As CustomPropertyInfo, context As Object) As Object
			'Return a default value for the properties which the PersistenceFramework failed to restore
		End Function

		Public Function ProvideValue(customPropertyInfo As CustomPropertyInfo, context As Object) As Object
			'Implement logic that returns an object describing a persisted property. 
			'Note that this event is fired once for each property from the array returned by the GetCustomProperties() method. 
			'Therefore you need to implement a logic that returns a separate object for each property.
		End Function

		Public Sub RestoreValue(customPropertyInfo As CustomPropertyInfo, context As Object, value As Object)
			'Use the value argument to get the persisted settings.
			'Apply these settings on the context object as it represents the persisted component
		End Sub

	End Class
	' #endregion
	' #region persistence-framework-custom-property-provider-2
	ServiceProvider.RegisterPersistenceProvider(Of ICustomPropertyProvider)(GetType(SampleControl), New SampleCustomPropertyProvider())
	' #endregion
	' #region persistence-framework-custom-property-provider-3

	' #endregion

End Class