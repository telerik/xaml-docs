---
title: Template Structure
page_title: Template Structure
description: Template Structure
slug: radcoloreditor-template-structure
tags: template,structure
published: True
position: 4
---

# Template Structure



## 
<table><tr><td>![Template Structure](images/radcoloreditor-template-structure.png)</td><td>

* <b>LayoutRoot</b> - is of type <b>Grid</b> and represents the layout root for the template.
				  

* <b>SectionsGrid</b> - is of type <b>Grid</b> and contains all selection elements.
					  

* <b>SaturationValuePadGrid</b> - is of type <b>Grid</b> and contains the <b>ColorPalette</b>.
						  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and holds the main color.
							  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and holds the transparency of the main color.
							  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and holds the darkness of the main color.
							  

* <b>[Border]</b> - is of type <b>Border</b> and wraps the <b>Pad</b> which controls the chosen color.
							  

* <b>SaturationValuePad</b> - is of type <b>Pad</b> and represents the control that processes the chosen color.
								  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the selection thumb.
									  

* <b>[Ellipse]</b> - is of type <b>Ellipse</b> and represents the outer circle of the thumb.
										  

* <b>[Ellipse]</b> - is of type <b>Ellipse</b> and represents the inner circle of the thumb.
										  

* <b>HueSaturationPadGrid</b> - is of type <b>Grid</b> and hosts the SaturationValuePad section.
						  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and represents the multicolor rectangle.
							  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and represents the gray rectangle.
							  

* <b>SaturationValuePad</b> - is of type <b>Pad</b> and processes the selected color.
							  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the selection thumb.
								  

* <b>[Ellipse]</b> - is of type <b>Ellipse</b> and represents the outer circle of the thumb.
									  

* <b>[Ellipse]</b> - is of type <b>Ellipse</b> and represents the inner circle of the thumb.
									  

* <b>HuePadGrid</b> - is of type <b>Grid</b> and hosts the vertical multicolor rectangle.
						  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and represents the vertical multicolor rectangle.
							  

* <b>[Border]</b> - is of type <b>Border</b> and wraps the <b>Pad</b> control.
							  

* <b>HuePad</b> - is of type <b>Pad</b> and processes the selected color.
								  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the selection thumb.
									  

* <b>[Path]</b> - is of type <b>Path</b> and represents the left part of the selection thumb.
										  

* <b>[Path]</b> - is of type <b>Path</b> and represents the right part of the selection thumb.
										  

* <b>LuminancePadGrid</b> - is of type <b>Grid</b> and hosts the LuminancePad section.
						  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and represents the gray part of the scale.
							  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the white and black parts of the scale.
							  

* <b>[Rectangle]</b> - is of type <b>Rectangle</b> and represents the white part of the scale.
								  

* <b>[Rectangle]</b> - is of type <b>Grid</b> and represents the black part of the scale.
								  

* <b>[Border]</b> - is of type <b>Border</b> and wraps the Pad control.
							  

* <b>[LuminancePad]</b> - is of type <b>Pad</b> and processes the selected luminance.
								  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the selection thumb.
									  

* <b>[Path]</b> - is of type <b>Path</b> and represents the outer circle of the selection thumb.
										  

* <b>[Path]</b> - is of type <b>Path</b> and represents the inner circle of the selection thumb.
										  

* <b>InitAndCurrentColorGrid</b> - is of type <b>Grid</b> and hosts the <b>Borders</b> representing the initial, the selected and the previous colors.
						  

* <b>ChessBoardRect</b> - is of type <b>Border</b> and it is visualized when transparency is added to the initial and the selected colors.
							  

* <b>ChessboardEffect</b>  - is of type <b>ChessboardEffect</b> and it is visualized when transparency is added to the initial and the selected colors.
								  

* <b>PART_InitialColor</b> - is of type <b>Border</b> and represents the initial color.
							  

* <b>[Border]</b> - is of type <b>Border</b> and represents the selected color.
							  

* <b>[Border]</b> - is of type <b>Border</b> and represents the previous color.
							  

* <b>ColorModesGrid</b> - is of type <b>Grid</b> and hots
						  

* <b>[RadComboBox]</b> - is of type <b>RadComboBox</b> and it is used to switch between the edit modes.
							  

* <b>ClearSelectionButtonContent</b>

* <b>RgbTemplate</b> - is of type <b>Grid</b> and hosts all components needed in RGB edit mode.
							  

* <b>[TextBlock] "R"</b> - is of type <b>TextBlock</b> and displays the "R" symbol.
								  

* <b>[TextBlock] "G"</b> - is of type <b>TextBlock</b> and displays the "G" symbol.
								  

* <b>[TextBlock] "B"</b> - is of type <b>TextBlock</b> and displays the "B" symbol.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the R component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the G component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the B component of the color.
								  

* <b>RgbSliderRed</b> - is of type <b>RadSlider</b> and changes the R component of the color.
								  

* <b>RgbSliderGreen</b> - is of type <b>RadSlider</b> and changes the G component of the color.
								  

* <b>RgbSliderBlue</b> - is of type <b>RadSlider</b> and changes the B component of the color.
								  

* <b>HlsTemplate</b> - is of type <b>Grid</b> and hosts all components needed in HLS edit mode.
							  

* <b>[TextBlock] "H"</b> - is of type <b>TextBlock</b> and displays the "H" symbol.
								  

* <b>[TextBlock] "L"</b> - is of type <b>TextBlock</b> and displays the "L" symbol.
								  

* <b>[TextBlock] "S"</b> - is of type <b>TextBlock</b> and displays the "S" symbol.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the H component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the L component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the S component of the color.
								  

* <b>HlsSliderHue</b> - is of type <b>RadSlider</b> and changes the H component of the color.
								  

* <b>HlsSliderLuminance</b> - is of type <b>RadSlider</b> and changes the L component of the color.
								  

* <b>HlsSliderSaturation</b> - is of type <b>RadSlider</b> and changes the S component of the color.
								  

* <b>HsvTemplate</b> - is of type <b>Grid</b> and hosts all components needed in HSV edit mode.
							  

* <b>[TextBlock] "H"</b> - is of type <b>TextBlock</b> and displays the "H" symbol.
								  

* <b>[TextBlock] "S"</b> - is of type <b>TextBlock</b> and displays the "S" symbol.
								  

* <b>[TextBlock] "V"</b> - is of type <b>TextBlock</b> and displays the "V" symbol.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the H component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the S component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the V component of the color.
								  

* <b>HsvSliderHue</b> - is of type <b>RadSlider</b> and changes the H component of the color.
								  

* <b>HsvSliderSaturation</b> - is of type <b>RadSlider</b> and changes the S component of the color.
								  

* <b>HsvSliderValue</b> - is of type <b>RadSlider</b> and changes the V component of the color.
								  

* <b>CmykTemplate</b> - is of type <b>Grid</b> and hosts all components needed in CMYK edit mode.
							  

* <b>[TextBlock] "C"</b> - is of type <b>TextBlock</b> and displays the "C" symbol.
								  

* <b>[TextBlock] "M"</b> - is of type <b>TextBlock</b> and displays the "M" symbol.
								  

* <b>[TextBlock] "Y"</b> - is of type <b>TextBlock</b> and displays the "Y" symbol.
								  

* <b>[TextBlock] "K"</b> - is of type <b>TextBlock</b> and displays the "K" symbol.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the C component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the M component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the Y component of the color.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the K component of the color.
								  

* <b>CmykSliderCyan</b> - is of type <b>RadSlider</b> and changes the C component of the color.
								  

* <b>CmykSliderMagenta</b> - is of type <b>RadSlider</b> and changes the M component of the color.
								  

* <b>CmykSliderYellow</b> - is of type <b>RadSlider</b> and changes the Y component of the color.
								  

* <b>CmykSliderKey</b> - is of type <b>RadSlider</b> and changes the K component of the color.
								  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the components that control the transparency of the color.
							  

* <b>[TextBlock] "A"</b> - is of type <b>TextBlock</b> and displays the "A" symbol.
								  

* <b>[RadMaskedNumericInput]</b> - is of type <b>RadMaskedNumericInput</b> and displays/controls the A component of the color in all modes.
								  

* <b>SliderAlpha</b> - is of type <b>RadSlider</b> and changes the A component of the color in all modes.
								  

* <b>[Grid]</b> - is of type <b>Grid</b> and hosts the HEX representation of the color.
							  

* <b>[TextBlock] "#"</b> - is of type <b>TextBlock</b> and displays the "#" symbol.
								  

* <b>[TextBlock]</b> - is of type <b>TextBlock</b> and displays/controls the all components of the final color.
								  </td></tr></table>

# See Also

 * [Active Sections]({%slug radcoloreditor-activesections%})

 * [Structure]({%slug radcoloreditor-structure%})
