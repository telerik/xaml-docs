---
title: Modal Editor
page_title: Modal Editor
description: Check our &quot;Modal Editor&quot; documentation article for the RadPropertyGrid WPF control.
slug: radpropertygrid-features-modal-editor
tags: propertygrid, editor, modal editor
published: True
position: 21
---

# Modal Editor

The `ModalEditor` element allows you to edit the value of a `PropertyDefinition` in a modal dialog window.

## Showing the ModalEditor via the EditorTemplate of a PropertyDefinition

The PropertyDefinition exposes the `EditorTemplate` property that will allow you to define a new ModalEditor instance for it. Via the `SourceProperty` of the ModalEditor, you can set the property from your business object that will be used for the binding. To use your custom editor, you can utilize the `Editor` property, which expects a value of the type of `FrameworkElement`.

#### __[C#] Defining the business object__
{{region radpropertygrid-features-modal-editor-0}}
    public class CharacterInfo
    {
        public string ProtagonistName { get; set; }
    }
{{endregion}}

#### __[VB.NET] Defining the business object__
{{region radpropertygrid-features-modal-editor-1}}
    Public Class CharacterInfo
        Public Property ProtagonistName As String
    End Class
{{endregion}}

#### __[XAML] Setting the ModalEditor via the EditorTemplate property__
{{region radpropertygrid-features-modal-editor-2}}
    <telerik:RadPropertyGrid.PropertyDefinitions>
        <telerik:PropertyDefinition DisplayName="Protagonist Name" Binding="{Binding ProtagonistName}">
            <telerik:PropertyDefinition.EditorTemplate>
                <DataTemplate>
                    <telerik:ModalEditor SourceProperty="{Binding ProtagonistName}">
                        <telerik:ModalEditor.Editor>
                            <TextBox Text="{Binding ProtagonistName}" telerik:StyleManager.Theme="Windows11"/>
                        </telerik:ModalEditor.Editor>
                    </telerik:ModalEditor>
                </DataTemplate>
            </telerik:PropertyDefinition.EditorTemplate>
        </telerik:PropertyDefinition>
    </telerik:RadPropertyGrid.PropertyDefinitions>
{{endregion}}

__ModalEditor defined via the EditorTemplate property__

![ModalEditor defined via the EditorTemplate property](images/radpropertygrid-features-modal-editor-0.png)

## Showing the ModalEditor When Using the EditorAttribute

When using the [EditorAttribute]({%slug radpropertygrid-editor-attribute%}), if its `EditorStyle` property is set to `Modal`, a new ModalEditor element is created.

#### __[C#] Setting the EditorStyle property to Modal__
{{region radpropertygrid-features-modal-editor-3}}
    public class CharacterInfo
    {
        [Editor(typeof(TextBox), "Text", EditorStyle.Modal)]
        public string ProtagonistName { get; set; }
    }
{{endregion}}

#### __[VB.NET] Setting the EditorStyle property to Modal__
{{region radpropertygrid-features-modal-editor-4}}
    Public Class CharacterInfo
        <Editor(GetType(TextBox), "Text", EditorStyle.Modal)>
        Public Property ProtagonistName As String
    End Class
{{endregion}}

__ModalEditor defined via the EditorStyle property of the EditorAttribute__

![ModalEditor defined via the EditorStyle property of the EditorAttribute](images/radpropertygrid-features-modal-editor-0.png)

## Customizing the ModalEditor

To customize the ModalEditor element, you can either create a `Style` that targets it or use the [FieldLoaded]({%slug radpropertygrid-events%}) event. You can retrieve it through the `Content` property of the `Field` object that is provided by the event's arguments.

#### __[XAML] Customizing the ModalEditor via a Style__
{{region radpropertygrid-features-modal-editor-5}}
    <!--If you are using NoXaml assemblies: BasedOn="{StaticResource ModalEditorStyle}"-->
    <Style TargetType="telerik:ModalEditor">
        <Setter Property="Foreground" Value="White"/>
        <Setter Property="Background" Value="Orange"/>
    </Style>
{{endregion}}

#### __[C#] Customizing the ModalEditor via the FieldLoaded event__
{{region radpropertygrid-features-modal-editor-6}}
    private void RadPropertyGrid_FieldLoaded(object sender, FieldEventArgs e)
    {
        var modalEditor = e.Field.Content as ModalEditor;

        if (modalEditor != null)
        {
            modalEditor.Foreground = Brushes.White;
            modalEditor.Background = Brushes.Orange;
        }
    }
{{endregion}}

#### __[VB.NET] Customizing the ModalEditor via the FieldLoaded event__
{{region radpropertygrid-features-modal-editor-7}}
    Private Sub RadPropertyGrid_FieldLoaded(ByVal sender As Object, ByVal e As FieldEventArgs)
        Dim modalEditor = TryCast(e.Field.Content, ModalEditor)

        If modalEditor IsNot Nothing Then
            modalEditor.Foreground = Brushes.White
            modalEditor.Background = Brushes.Orange
        End If
    End Sub
{{endregion}}

__Customized ModalEditor__

![Customized ModalEditor](images/radpropertygrid-features-modal-editor-1.png)

## Positioning the ModalEditor

The ModalEditor element provides the functionality to position the modal dialog window. To do so, you can utilize the `WindowStartupLocation`, `WindowTop`, and `WindowLeft` properties.

>important In order for the `WindowTop` and `WindowLeft` properties to be taken into account, the `WindowStartupLocation` property has to be set to `Manual`.

#### __[XAML] Positioning the ModalEditor via Style__
{{region radpropertygrid-features-modal-editor-8}}
    <!--If you are using NoXaml assemblies: BasedOn="{StaticResource ModalEditorStyle}"-->
	<Style TargetType="telerik:ModalEditor">
		<Setter Property="WindowStartupLocation" Value="Manual"/>
		<Setter Property="WindowTop" Value="500"/>
		<Setter Property="WindowLeft" Value="250"/>
	</Style>
{{endregion}}

#### __[C#] Positioning the ModalEditor via the FieldLoaded event__
{{region radpropertygrid-features-modal-editor-9}}
	private void PropertyGrid_FieldLoaded(object sender, Telerik.Windows.Controls.Data.PropertyGrid.FieldEventArgs e)
	{
		var modalEditor = e.Field.Content as ModalEditor;

		if (modalEditor != null)
		{
			modalEditor.WindowStartupLocation = WindowStartupLocation.Manual;
			modalEditor.WindowTop = 500;
			modalEditor.WindowLeft = 250;
		}
	}
{{endregion}}

#### __[VB.NET] Positioning the ModalEditor via the FieldLoaded event__
{{region radpropertygrid-features-modal-editor-10}}
	Private Sub PropertyGrid_FieldLoaded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Data.PropertyGrid.FieldEventArgs)
		Dim modalEditor = TryCast(e.Field.Content, ModalEditor)

		If modalEditor IsNot Nothing Then
			modalEditor.WindowStartupLocation = WindowStartupLocation.Manual
			modalEditor.WindowTop = 500
			modalEditor.WindowLeft = 250
		End If
	End Sub
{{endregion}}

## See Also

* [Editor Attribute]({%slug radpropertygrid-editor-attribute%})