---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadBarcode {{ site.framework_name }} control.
slug: radbarcode-overview
tags: overview
published: True
position: 0
CTAControlName: RadBarcode
---

# {{ site.framework_name }} RadBarcode Overview

__RadBarcode__ is a set of components that can be used to create, show and read barcodes. You can generate and visualize barcodes in a machine-readable format via the RadBarcode controls by providing numeric or character data. Additionally, you can read barcodes using the RadBarcodeReader component.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

>important This is the documentation of the old version of the RadBarcode component, which is currently deprecated. Check out the new version [here]({%slug barcode-getting-started%}).

## RadBarcodeSymbology Specifications
|Barcode|Description|
|----|----|
|**Codabar**|(aka Ames Code/USD-4/NW-7/2 of 7 Code): Used in libraries and blood banks|
|**Code 11**|(USD-8): Used to identify telecommunications equipment|
|**Code 25 Standard**|Used in airline ticket marking, photofinishing|
|**Code 25 Interleaved**|Used in warehouse, industrial applications|
|**Code 39**|(aka USD-3, 3 of 9): U.S. Government and military use, required for DoD applications|
|**Code 39 Extended**|(aka USD-3, 3 of 9): U.S. Government and military use, required for DoD applications, supports full ASCII|
|**Code 93**|(aka USS-93): Compressed form of Code 39|
|**Code 93 Extended**|(aka USS-93): Compressed form of Code 39, supports full ASCII|
|**Code 128**|Very dense code, used extensively worldwide|
|**Code 128 A**|Subset of Code 128  \* [more info in 1D Barcodes]({% slug radbarcode-barcode-types-description%})|
|**Code 128 B**|Subset of Code 128  \* [more info in 1D Barcodes]({% slug radbarcode-barcode-types-description%})|
|**Code 128 C**|Subset of Code 128  \* [more info in 1D Barcodes]({% slug radbarcode-barcode-types-description%})|
|**MSI**|Variation of Plessey code, with similar applications|
|**EAN 8**|Short version of EAN-13, 8 characters|
|**EAN 13**|Used with consumer products internationally, 13 characters|
|**Intelligent Mail**|Used by U.S. Post Office as successor of POSTNET and PLANET barcodes.|
|**PLANET**|Printed by U.S. Post Office on envelopes. Predecessor of Intelligent Mail barcode.|
|**Postnet**|Printed by U.S. Post Office on envelopes|
|**UPC A**|Used with consumer products in U.S., 12 characters|
|**UPC E**|Short version of UPC symbol, 6 characters|
|**UPC Supplement 2**|Used to indicate magazines and newspaper issue numbers|
|**UPC Supplement 5**|Used to mark suggested retail price of books|

__Additional information on Code128__

1. Code128A, Code128B and Code128C represent the A, B and C subsets of the Code128 symbology. Code128 uses an intelligent algorithm that picks automatically the appropriate subset according to the input value, and might switch between these subsets in the middle of a BarCode in order to produce a shorter generated sequence. For example, if you have the input string “ABCD1234”, the “ABCD” part of the string will be encoded using the A subset, while the “1234” part will be encoded with the C subset, because Code128C uses a double-density code for numerical values, thus producing a shorter BarCode as a result. If you want to disable this behavior you can specify explicitly one of the subsets: Code128A, Code128B or Code128C to the Symbology property of the BarCode report item.

2. Code128 can represent both ASCII characters and non-ASCII control characters. Normally the BarCode report item inserts automatically the appropriate control characters in order to conform to the Code128 specification. However certain applications might require manual insertion of certain control characters, such as the functional characters: FNC1-FNC4. For this purpose the BarCode report item assigns special Unicode values to these control characters outside the normal 0-127 ASCII code range. The following table lists all Code128 control characters and their corresponding Unicode values:

__Code 128 Control Characters__

|Control Character|Hexadecimal|Decimal|
|-----------------|-----------|-------|
|Code|F4|244|
|Code B|F5|245|
|Code C|F6|246|
|FNC1|F7|247|
|FNC2|F8|248|
|FNC3|F9|249|
|FNC4|FA|250|
|Shift|FB|251|
|Start A|FC|252|
|Start B|FD|253|
|Start C|FE|254|
|Stop|FF|255|

__Additional information on EAN128__

EAN128 is a special case of Code128. The only difference between EAN128 and Code 128 is that EAN128 inserts the FNC1 control character at the beginning of the BarCode in order to conform to the EAN128 specification. If you have a multi-part EAN128 BarCode which requires the FNC1 control character as a delimiter between the different parts, you should insert it manually:

## RadBarcodeQR

The QRCode represents a square matrix, filled with black and white modules. There are four modes available in the control, namely:

* __Numeric data__ (digits __0 - 9__)
* __Alphanumeric data__ (digits __0 - 9__; upper case letters __A-Z__; nine other characters: __space, $ % * + - . / :__ )
* __8-bit byte data__ (JIS 8-bit character set (Latin and Kana) in accordance with JIS X 0201)
* __Kanji characters__ (Shift JIS character set in accordance with JIS X 0208 Annex 1 Shift Coded Representation)
