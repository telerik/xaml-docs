---
title: Key Properties
page_title: Key Properties
description: This article lists and explains the events exposed by the RadBadge control.
slug: radbadge-key-properties
tags: radbadge, key, property, properties,badgetype,geometry,anchorposition
published: True
position: 3
---

# Key Properties

This article will list the key properties provided by the RadBadge control.

* __Position__: A property of type __Point__ that gets or sets the relative position of the badge to the element which is attached to it.

	>The RadBadge control uses its center point for positioning it relative to the attached element. 

* __AnchorPosition__: A property of type __Point__ that gets or sets the __anchor position__ of the badge, relative to the size of the badge control. Default value is (0.5, 0.5).

* __PlayChangeAnimation__: A property of type __ICommand__ that gets or sets the play change animation of the badge.

* __InheritDataContext__: A property of type __bool__ that gets or sets a value indicating whether the badge should take the data context from its target element.

* __BadgeType__: A property of type __BadgeType__ that gets or sets the badge type of the badge control. The __BadgeType__ is an enumeration and it allows the following values:

	* __Default__
	* __DotOnly__
	* __Available__
	* __DoNotDisturb__
	* __Rejected__
	* __Remove__
	* __Offline__
	* __Away__
	* __OutOfOffice__
	* __Add__
	* __ContentOnly__: 	
	
#### Figure 3: RadBadge Types
![Telerik Badge Types](images/radbadge-key-properties_1.PNG)

* __Geometry__: A property of type __Geometry__ that gets or sets gets or sets the geometry of the badge control. You can apply one of the following geometry which our geometry extension markup provides.

	* __Circle__
	* __Ellipse__
	* __Rectangle__
	* __RoundedRectangle__
	* __Square__
	* __Triangle__
	* __RightTriangle__
	* __Pentagon__
	* __Hexagon__
	* __Heptagon__
	* __Octagon__
	* __Star5__
	* __Cloud__
	* __Oval__
	
	>To set custom geometry of the RadBadge control, the BadgeType property needs to be set to __ContentOnly__.

	#### __[XAML] Example 1: Set Custom Geometry__
	{{region xaml-radbadge-key-properties-0}}
		<telerik:RadButton Width="85" Height="30" Content="Notifications"  VerticalAlignment="Center" HorizontalAlignment="Center">
			<telerik:RadBadge.Badge>
				<telerik:RadBadge Content="99" BadgeType="ContentOnly" Background="#FFFFC000" Geometry="{telerik:Geometry Type=Oval}" />
			</telerik:RadBadge.Badge>
		</telerik:RadButton>
	{{endregion}}

	To apply custom geometry in code-behind, you can use the GeometryFactory.SetGeometry() method.

	#### __[C#] Example 1: Set Custom Geometry In Code__
	{{region xaml-radbadge-key-properties-0}}
		public Example()
		{
			this.InitializeComponent();
			this.badge.Geometry = GeometryFactory.SetGeometry(GeometryType.Hexagon);
		}
	{{endregion}}
		
	#### Figure 3: Custom Geometries
	![Telerik Badge Geometries](images/radbadge-key-properties_2.png)

* __TextAlignment__: A property of type __TextAlignment__ that gets or sets the text alignment of the underlying __TextBlock__.

