 private void RadDiagram_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(e.PreviousSize != e.NewSize)
            {
                double deltaX = (e.NewSize.Width / e.PreviousSize.Width);
                double deltaY = (e.NewSize.Height / e.PreviousSize.Height);
 
                this.radDiagram.Shapes.ToList().ForEach(x =>
                    {
                        x.Position = new Point(x.Position.X * deltaX, x.Position.Y * deltaY);
                        x.Width = x.Width * deltaX;
                        x.Height = x.Height * deltaY;
                    });
            }
        }  