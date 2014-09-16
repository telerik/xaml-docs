#region radcoloreditor-getting-started-0
RadColorEditor colorEditor = new RadColorEditor();
colorEditor.SelectedColor = Colors.Red;
#endregion

#region radcoloreditor-getting-started-1
colorEditor.SelectedColorChanged += new EventHandler<ColorChangeEventArgs>(colorEditor_SelectedColorChanged);

private void colorEditor1_SelectedColorChanged(object sender, ColorChangeEventArgs e)
{
   Color selectedColor = e.Color;
}
#endregion