 Private Sub RadDiagram_SizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
    If e.PreviousSize <> e.NewSize Then
        Dim deltaX As Double = (e.NewSize.Width \ e.PreviousSize.Width)
        Dim deltaY As Double = (e.NewSize.Height \ e.PreviousSize.Height)

        Me.radDiagram.Shapes.ToList().ForEach(Sub(x)
                                                  x.Position = New Point(x.Position.X * deltaX, x.Position.Y * deltaY)
                                                  x.Width = x.Width * deltaX
                                                  x.Height = x.Height * deltaY
                                              End Sub)
    End If
 End Sub