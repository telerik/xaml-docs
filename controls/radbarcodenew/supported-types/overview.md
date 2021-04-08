---
title: Overview
page_title: WPF Barcode Documentation | Supported Types Overview
description: Check our &quot;Supported Types&quot; documentation article for Telerik Barcode for WPF control.
position: 0
slug: barcode-supported-types-overview
permalink: /controls/radbarcode/supported-types/overview
---

{% if site.has_cta_panels == true %}
{% include cta-panel-small.html %}
{% endif %}

# Supported Types

There are two types of barcodes according to their dimensions: Matrix (2D) and Linear (1D).

## Matrix (2D) Barcodes

The matrix code is a two-dimensional way for representing information. It can also be referred to as a 2D barcode or simply a 2D code. It is similar to the linear (one dimensional) barcode, but can represent more data per unit area.

Currently, **RadBarcode** supports *QR Code*, *PDF417*, and *Data Matrix* barcode types.

## Linear (1D) Barcodes

The linear (one dimensional) barcodes are made up of lines and spaces of various widths that create specific patterns. Currently, **RadBarcode** supports the following one dimensional barcode types:

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
|**Code 128 A**|Subset of Code 128  \*(more info in 1D Barcodes)|
|**Code 128 B**|Subset of Code 128  \*(more info in 1D Barcodes)|
|**Code 128 C**|Subset of Code 128  \*(more info in 1D Barcodes)|
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

## See Also

- [Key Features]({% slug barcode-key-features%})
