---
title: Features
page_title: Features
description: Check our &quot;Features&quot; documentation article for the RadBarcode {{ site.framework_name }} control.
slug: radbarcodeqr-features
tags: features
published: True
position: 2
---

# {{ site.framework_name }} RadBarcode Features

## Version

>important This is the documentation of the old version of the RadBarcode component, which is currently deprecated. Check out the new version [here]({%slug barcode-getting-started%}).

This is an integer value, in the range from __1__ to __40__, representing the version which one desires to use. Usually, higher-version QR codes are used do accommodate larger amounts of data. If this property is not set, the control internally calculates the lowest possible version and uses it instead. Since __Q1 2014__ you can take advantage of the __ActualVersion__ property to get the version that the control calculated. In the cases when the __Version__ is set, both properties will be equal.        

## ErrorCorrectionLevel

There are four possible values to choose from - __L__(Low), __M__(Medium), __Q__(Quartile), __H__(High). These values allow for 7%, 15%,  25% and 30% recovery of symbol code words. Additionally, choosing a higher version of error correction dedicates a larger portion of modules for error correction. Thus, given two QR codes with the same sizes, the one with a lower error correction level would be able to accommodate more data.        

## Text

This string property represents the data, which will be encoded by the QR control.        

## Mode

There are four values available for this property - Alphanumeric, Numeric, Byte and Kanji. Essentially, this determines the sets of acceptable symbols - numbers, characters, etc.        

## ECI

The Extended Channel Interpretation, in short (__ECI__) allows for encoding of characters of different character sets. For example, choosing an ECI equal to 8859-7 will allow for encoding characters from the Latin/Greek alphabet. Please note, that the __ECI__ setting is only honored when the __Mode__ property of the control is set to Byte.        

## FNC1

This mode is used for messages containing data formatted either in accordance with the UCC/EAN Application Identifiers standard or in accordance with a specific industry standard previously agreed with AIM International.        

## ApplicationIndicator

This property allows for additional data to be applied to the FNC1 data. Please, keep in mind, that this is only applicable with FNC1Mode.FNC1SecondPosition. Additionally, the acceptable data for this property is in the range {a-z}],{[A-Z} and {00-99}.        

Essentially, both the FNC1 property and the ApplicationIndicator data is applied to the raw data encoded in the control, allowing for special formatting.        

## See Also
[Overview]({%slug radbarcode-overview%})
[QRCode Visual Structure]({%slug radbarcodeqr-qrcode-visual-structure%})
[Getting Started]({%slug radbarcodeqr-getting-started%})