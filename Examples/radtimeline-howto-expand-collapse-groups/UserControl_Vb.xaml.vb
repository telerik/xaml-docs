Public Class Default_Vb
'this region intentionally skipped:
' #region radtimeline_howto_expand_collapse_groups-0

' #endregion

' #region radtimeline_howto_expand_collapse_groups-1
Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
	If value IsNot Nothing AndAlso TypeOf value Is String Then
		Dim groupKey As String = DirectCast(value, String)
		Dim initiallyExpandedGroupKey As String = DirectCast(parameter, String)

		If groupKey = initiallyExpandedGroupKey Then
			Return True
		End If
	End If

	Return False
End Function
' #endregion

' #region radtimeline_howto_expand_collapse_groups-2
Public Shared ReadOnly ExpandedGroupKeyProperty As DependencyProperty = DependencyProperty.RegisterAttached("ExpandedGroupKey", GetType(String), GetType(TimelineItemGroupControlBehavior), New PropertyMetadata(OnExpandedGroupKeyChanged))

Public Shared Function GetExpandedGroupKey(obj As DependencyObject) As Object
	Return DirectCast(obj.GetValue(ExpandedGroupKeyProperty), String)
End Function

Public Shared Sub SetExpandedGroupKey(obj As DependencyObject, value As String)
	obj.SetValue(ExpandedGroupKeyProperty, value)
End Sub

Private Shared Sub OnExpandedGroupKeyChanged(sender As DependencyObject, e As DependencyPropertyChangedEventArgs)
	Dim timelineGroup As TimelineItemGroupControl = TryCast(sender, TimelineItemGroupControl)
	If timelineGroup Is Nothing OrElse e.NewValue Is Nothing Then
		Return
	End If

	timelineGroup.IsExpanded = String.Equals(timelineGroup.Header, DirectCast(e.NewValue, String))
End Sub
' #endregion

End Class
