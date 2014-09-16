Public Class Default_Vb

	' #region raddataform-datatemplate-selectors_0
Public Class EmployeesEditTemplateSelector
		Inherits Telerik.Windows.Controls.DataTemplateSelector

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim employee As Employee = TryCast(item, Employee)
			If employee Is Nothing Then
				Return Nothing
			ElseIf employee.Salary > 2500 Then
				Return Me.BigSalaryTemplate
			Else
				Return Me.SmallSalaryTemplate
			End If
		End Function

		Public Property BigSalaryTemplate() As DataTemplate
		Public Property SmallSalaryTemplate() As DataTemplate
	End Class
	' #endregion
	' #region raddataform-datatemplate-selectors_1

	Public Class EmployeesEditTemplateSelector
		Inherits System.Windows.Controls.DataTemplateSelector

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim employee As Employee = TryCast(item, Employee)
			If employee Is Nothing Then
				Return Nothing
			ElseIf employee.Salary > 2500 Then
				Return Me.BigSalaryTemplate
			Else
				Return Me.SmallSalaryTemplate
			End If
		End Function

		Public Property BigSalaryTemplate() As DataTemplate
		Public Property SmallSalaryTemplate() As DataTemplate
	End Class
	' #endregion
End Class
