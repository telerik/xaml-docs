Public Class Default_Vb


' #region radslider-ticks-and-tick-frequency_2
Dim radSlider1 As New RadSlider()
radSlider1.Maximum = 10
Dim tickCollection As New DoubleCollection()
tickCollection.Add(3)
tickCollection.Add(5)
tickCollection.Add(7)
radSlider1.Ticks = tickCollection
radSlider1.TickPlacement = TickPlacement.TopLeft
LayoutRoot.Children.Add(radSlider1)
' #endregion
End Class
