---
title: XML Serialization String
page_title: XML Serialization String
description: This article describes the XML-based format used by the PersistenceFramework to store settings.
slug: persistence-framework-serialization-xml
tags: getting,started
published: True
position: 6
---

# XML Serialization String

This article shows the XML-based format used by the PersistenceFramework to store settings.

The following list describes the tags used by the persistence manager.

* __&lt;Data&gt;__: This tag holds the main export object. It contains all the persistence information.

	* __&lt;T&gt;__ (Types): This is a collection of TypeInfo objects.
	
		* __&lt;TI&gt;__ (TypeInfo): This tag holds the information about the corresponding serialized type. The TI tag has two attributes - __K__ (key) and __N__ (type). The key is used to associate the corresponding property value with this concrete type.
		
	* __&lt;P&gt;__ (PrimitiveValues): This is a collection of PrimitiveValue objects.
	
		* __&lt;PV&gt;__ (PrimitiveValue): This tag holds information about a serialized  primitive value. The PV tag has two attributes - __Key__ and __TypeKey__.
		
			* __&lt;Value&gt;__: This tag holds the value of the primitive.
			
	* __&lt;R&gt;__ (ReferenceValues): This is a collection of ReferenceValue objects.
	
		* __&lt;RV&gt;__ (ReferenceValue): This tag holds information about a serialized reference value. The RV tag has three attributes - __Key__, __IsRoot__ and __TypeKey__.
		
			* __&lt;D&gt;__ (Datas): This is a collection of PropertyData objects.
			
				* __&lt;PD&gt;__ (PropertyData): This tag holds information about an element’s property. The PD tag has few attributes - __PN__ (property name), __VK__ (value key), __RK__ (reference key), __TK__ (type key) and __TCK__ (type converter key).
				
			* __&lt;AttachedDatas&gt;__: This is a collection of AttachedPropertyData objects.
			
				* __&lt;APD&gt; (AttachedPropertyData)__:  This tag holds information about a serialized attached property. The APD tag has the same attributes as the PropertyData object.
				
__Example 1: XML serialization string produced from saving a RadButton__
```XML
	<?xml version="1.0"?>
	<RawData
		xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
		xmlns:xsd="http://www.w3.org/2001/XMLSchema">
		<SerializationString>
			<?xml version="1.0" encoding="utf-16"?>
			<Data
				xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
				xmlns:xsd="http://www.w3.org/2001/XMLSchema">
				<T>
					<TI K="-1280737422" N="Telerik.Windows.Controls.RadButton, Telerik.Windows.Controls, Version=2018.3.1016.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7" />
					<TI K="61477131" N="System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
					<TI K="1964071539" N="System.Windows.CornerRadius, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="-1987936643" N="System.Windows.CornerRadiusConverter, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="-1605745128" N="System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
					<TI K="-1711031575" N="System.Windows.Controls.ClickMode, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="-664072138" N="System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
					<TI K="2118094103" N="System.Windows.Media.Brush, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="2123160200" N="System.Windows.Thickness, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="1210177933" N="System.Windows.Media.FontFamily, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="917743010" N="System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
					<TI K="1372103125" N="System.Windows.FontStretch, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="957773259" N="System.Windows.FontStyle, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="438195037" N="System.Windows.FontWeight, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="1844036200" N="System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="81562524" N="System.Windows.VerticalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="883639814" N="System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
					<TI K="758643961" N="System.Windows.FlowDirection, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="-507393345" N="System.Windows.Size, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="1412931107" N="System.Windows.SizeConverter, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="613125302" N="System.Windows.Point, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
					<TI K="1051636111" N="System.Windows.Visibility, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
				</T>
				<P>
					<PV Key="-2" TypeKey="0" />
					<PV Key="1" TypeKey="-664072138">
						<Value xsi:type="xsd:string">0,0,0,0</Value>
					</PV>
					<PV Key="2" TypeKey="-664072138">
						<Value xsi:type="xsd:string">Click me.</Value>
					</PV>
					<PV Key="3" TypeKey="-664072138">
						<Value xsi:type="xsd:string">510.4,21.96</Value>
					</PV>
				</P>
				<R>
					<RV Key="61647805" IsRoot="true" TypeKey="-1280737422">
						<D>
							<PD PN="HoverDelay" VK="-2" RK="0" TK="61477131" TCK="0" />
							<PD PN="CornerRadius" VK="-2" RK="0" TK="1964071539" TCK="0" />
							<PD PN="InnerCornerRadius" VK="1" RK="0" TK="1964071539" TCK="-1987936643" />
							<PD PN="IsBackgroundVisible" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="IsDefault" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="IsCancel" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="ClickMode" VK="-2" RK="0" TK="-1711031575" TCK="0" />
							<PD PN="Content" VK="2" RK="0" TK="-664072138" TCK="0" />
							<PD PN="ContentStringFormat" VK="-2" RK="0" TK="-664072138" TCK="0" />
							<PD PN="BorderBrush" VK="-2" RK="0" TK="2118094103" TCK="0" />
							<PD PN="BorderThickness" VK="-2" RK="0" TK="2123160200" TCK="0" />
							<PD PN="Background" VK="-2" RK="0" TK="2118094103" TCK="0" />
							<PD PN="Foreground" VK="-2" RK="0" TK="2118094103" TCK="0" />
							<PD PN="FontFamily" VK="-2" RK="0" TK="1210177933" TCK="0" />
							<PD PN="FontSize" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="FontStretch" VK="-2" RK="0" TK="1372103125" TCK="0" />
							<PD PN="FontStyle" VK="-2" RK="0" TK="957773259" TCK="0" />
							<PD PN="FontWeight" VK="-2" RK="0" TK="438195037" TCK="0" />
							<PD PN="HorizontalContentAlignment" VK="-2" RK="0" TK="1844036200" TCK="0" />
							<PD PN="VerticalContentAlignment" VK="-2" RK="0" TK="81562524" TCK="0" />
							<PD PN="TabIndex" VK="-2" RK="0" TK="883639814" TCK="0" />
							<PD PN="IsTabStop" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="Padding" VK="-2" RK="0" TK="2123160200" TCK="0" />
							<PD PN="OverridesDefaultStyle" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="UseLayoutRounding" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="Width" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="MinWidth" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="MaxWidth" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="Height" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="MinHeight" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="MaxHeight" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="FlowDirection" VK="-2" RK="0" TK="758643961" TCK="0" />
							<PD PN="Margin" VK="-2" RK="0" TK="2123160200" TCK="0" />
							<PD PN="HorizontalAlignment" VK="-2" RK="0" TK="1844036200" TCK="0" />
							<PD PN="VerticalAlignment" VK="-2" RK="0" TK="81562524" TCK="0" />
							<PD PN="ForceCursor" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="AllowDrop" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="RenderSize" VK="3" RK="0" TK="-507393345" TCK="1412931107" />
							<PD PN="RenderTransformOrigin" VK="-2" RK="0" TK="613125302" TCK="0" />
							<PD PN="Opacity" VK="-2" RK="0" TK="917743010" TCK="0" />
							<PD PN="Uid" VK="-2" RK="0" TK="-664072138" TCK="0" />
							<PD PN="Visibility" VK="-2" RK="0" TK="1051636111" TCK="0" />
							<PD PN="ClipToBounds" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="SnapsToDevicePixels" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="IsEnabled" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="IsHitTestVisible" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="Focusable" VK="-2" RK="0" TK="-1605745128" TCK="0" />
							<PD PN="IsManipulationEnabled" VK="-2" RK="0" TK="-1605745128" TCK="0" />
						</D>
					</RV>
				</R>
			</Data>
		</SerializationString>
		<ValueTypes>
			<string>Telerik.Windows.Controls.RadButton, Telerik.Windows.Controls, Version=2018.3.1016.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7</string>
			<string>System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</string>
			<string>System.Windows.CornerRadius, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.CornerRadiusConverter, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</string>
			<string>System.Windows.Controls.ClickMode, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</string>
			<string>System.Windows.Media.Brush, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.Thickness, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.Media.FontFamily, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</string>
			<string>System.Windows.FontStretch, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.FontStyle, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.FontWeight, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.VerticalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</string>
			<string>System.Windows.FlowDirection, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.Size, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.SizeConverter, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.Point, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
			<string>System.Windows.Visibility, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</string>
		</ValueTypes>
	</RawData>
```

> All the brackets (lower-than and greater-than) in the XML are stored using the corresponding entity name - &amp;lt; and &amp;gt;

## See Also
* [Getting Started]({%slug persistence-framework-getting-started%})
* [Cross Version Support]({%slug persistence-framework-cross-version-support%})
