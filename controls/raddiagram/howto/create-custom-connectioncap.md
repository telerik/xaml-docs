---
title: Create Custom Connection Cap
page_title: Create Custom ConnectionCap
description: Create Custom ConnectionCap.
slug: raddiagram-howto-create-custom-connectioncap
tags: create,custom,connectioncap
published: True
position: 17
---

# Create Custom Connection Cap

This tutorial will guide you through the task of creating custom connection cap. The final result will look like this.

![Custom Cap](images/RadDiagram_Features_CustomCapsFinal.png)

>With the __2024 Q3 SP1__ release, the RadDiagram control requires registering the custom types of shapes, connections, and connectors, in order to deserialize them successfully. Read more about this change [here]({%slug raddiagrams-features-serialization%}#allowing-tafe-types-and-assemblies).

To implement the neccesary customization you need to create custom class deriving from our RadDiagramConnection and override a couple of methods. Our comopnent exposes the __CreateSourceCapGeometry()__ and __CreateTargetCapGeometry()__ methods which we will take advantage of. As their names imply the CreateSourceCapGeometry() generates the source cap and the CreateTargetCapGeometry() generates the target cap. These methods should return an object of type __PathFigure__ which is further used as the respective cap of the RadDiagramConnection. The customized implementation of those methods should create the desired PathFigures based on three points. Those points are received as parameters of the methods.

In the __CreateSourceCapGeometry()__ method the first parameter is called _startPoint_ and marks the position of the connection's connector. The second parameter is called _endPoint_ and marks the furthest point of the first section of the connection. For better understanding please refer to the next picture.

![Custom Cap](images/RadDiagram_Features_CustomCaps.png)

Based on these two points you can determine the angle of the first section of the connection. This allows you to adjust the cap to that angle so that it follows the direction of the connection's section. The third parameter is named _baseLineStart_. It marks the starting point of the actual line of the connction. 

>The third point should be set in your custom logic. In other words, you can control the starting point of the actual line.

![Custom Cap](images/RadDiagram_Features_CustomCaps2.png)

In the __CreateTargetCapGeometry()__ method the parameters serve for the very same purpose and should be used just like the prameter of the other method. For clarification please refer the following picture.

![Custom Cap](images/RadDiagram_Features_CustomCaps3.png)

# Example

The next code snippet will create custom connection caps as shown in the beggining of this article.

#### __C#__
{{region raddiagram-howto-create-custom-connectioncap-0}}
    public class CustomConnection : RadDiagramConnection
    {
        protected override System.Windows.Media.PathFigure CreateSourceCapGeometry(System.Windows.Point startPoint, System.Windows.Point endPoint, ref System.Windows.Point baseLineStart)
        {
            baseLineStart = startPoint;
            var result = CreateMyCap(startPoint);

            return result;
        }

        protected override PathFigure CreateTargetCapGeometry(Point startPoint, Point endPoint, ref Point baseLineEnd)
        {
            baseLineEnd = startPoint;
            var result = this.CreateMyCap(startPoint);

            return result;
        }

        private PathFigure CreateMyCap(Point startPoint)
        {
            var result = new PathFigure();
            result.StartPoint = startPoint;

            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X, startPoint.Y - 2) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X + 4, startPoint.Y - 5) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X + 6, startPoint.Y - 3) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X + 2, startPoint.Y) });

            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X + 6, startPoint.Y + 3) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X + 4, startPoint.Y + 5) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X, startPoint.Y + 2) });

            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X - 4, startPoint.Y + 5) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X - 6, startPoint.Y + 3) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X - 2, startPoint.Y) });

            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X - 6, startPoint.Y - 3) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X - 4, startPoint.Y - 5) });
            result.Segments.Add(new LineSegment() { Point = new Point(startPoint.X, startPoint.Y - 2) });
            return result;
        }
    }
{{endregion}}

#### __VB.NET__
{{region raddiagram-howto-create-custom-connectioncap-1}}
    Public Class CustomConnection
        Inherits RadDiagramConnection
        Protected Overrides Function CreateSourceCapGeometry(startPoint As System.Windows.Point, endPoint As System.Windows.Point, ByRef baseLineStart As System.Windows.Point) As System.Windows.Media.PathFigure
            baseLineStart = startPoint
            Dim result = CreateMyCap(startPoint)

            Return result
        End Function

        Protected Overrides Function CreateTargetCapGeometry(startPoint As Point, endPoint As Point, ByRef baseLineEnd As Point) As PathFigure
            baseLineEnd = startPoint
            Dim result = CreateMyCap(startPoint)

            Return result
        End Function

        Private Function CreateMyCap(startPoint As Point) As PathFigure
            Me.SourceCapSize = New Size(13, 13)

            Dim result = New PathFigure()
            result.StartPoint = startPoint

            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X, startPoint.Y - 2) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X + 4, startPoint.Y - 5) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X + 6, startPoint.Y - 3) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X + 2, startPoint.Y) _
            })

            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X + 6, startPoint.Y + 3) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X + 4, startPoint.Y + 5) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X, startPoint.Y + 2) _
            })

            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X - 4, startPoint.Y + 5) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X - 6, startPoint.Y + 3) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X - 2, startPoint.Y) _
            })

            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X - 6, startPoint.Y - 3) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X - 4, startPoint.Y - 5) _
            })
            result.Segments.Add(New LineSegment() With { _
                Key .Point = New Point(startPoint.X, startPoint.Y - 2) _
            })
            Return result
        End Function
    End Class
{{endregion}}  

After utilising this code you can go in XAML and use your custom connection like this:

#### __XAML__
{{region raddiagram-howto-create-custom-connectioncap-2}}
    <telerik:RadDiagram x:Name="diagram">
			<telerik:RadDiagramShape x:Name="shape1" Position="100 100" ZIndex="1"/>
			<telerik:RadDiagramShape x:Name="shape2" Position="300 100" ZIndex="1"/>
			<local:CustomConnection Source="{Binding ElementName=shape1}" Target="{Binding ElementName=shape2}" ZIndex="3"/>
		</telerik:RadDiagram>
{{endregion}}
		
>"__local__" points to the namespace where the CustomConnection class is defined. Note, that if you are using the NoXaml dlls, you should base the style for the CustomConnection on the [default one for the theme]({%slug implicit-styles-styling-the-controls%}#styling-custom-controls).

![Custom Cap](images/RadDiagram_Features_CustomCapsFinal2.png)

## See Also
* [How To Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%})
* [Connections]({%slug raddiagrams-features-connections%})
