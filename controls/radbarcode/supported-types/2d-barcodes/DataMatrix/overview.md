---
title: Overview
page_title: WPF Barcode Documentation | Data Matrix Overview
description: Check our &quot;Overview&quot; documentation article for Telerik Barcode for WPF control.
position: 0
published: True
slug: barcode-data-matrix-overview
---

# Overview

Data Matrix barcode is a two-dimensional type of code used widely in industry for marking small parts and items due to its high data density and reliability. Data Matrix code consists of dark and light square cells that form a matrix. The produced code can be square or rectangular and can have size up to 144x144 for square codes or 16x48 for rectangular codes. To provide better readability, the Data Matrix code includes error correction algorithm, allowing to reconstruct up to 30% of damaged code image.

#### __Figure 1: Data Matrix Barcode__
![datamatrix-barcode](images/barcode-datamatrix-structure.png)

## Data Matrix Barcode Structure

* **Finder pattern**: The L-shaped lines at the bottom and left of the code are called "finder pattern". It is used by the readers for orientation, adjustment and to correct distortion.

* **Module size**: the smallest cell in the code graphical representation. The module size is recommended to be at least 2x2 printed dots for better readability.

* **Timing pattern**: The lines at the top and right of the code are called "timing pattern". It provides information about the barcode size.

* **Data area**: The area surrounded by the finding pattern and timing pattern. Contains the modules that encode the barcode contents.

The size of the Data Matrix code depends on module size, length and type of its contents. The contents type determines if the encoded value contains only numerical characters or includes ASCII or Unicode characters. The following table shows the correlation between the content type, content length and matrix size:

| COUNT OF NUMERICAL CHARACTERS | COUNT OF ASCII CHARACTERS | MATRIX SIZE |
|---------|---------|---------|
6 |3 | 10x10
10 | 6 | 12x12
16 | 10 | 14x14
24 | 16 | 16x16
36 | 25 | 18x18
44 | 31 | 20x20
60 | 43 | 22x22
72 | 52 | 24x24
88 | 64 | 26x26
124 | 91 | 32x32

## See Also

- [Key Features]({% slug barcode-key-features%})
- [Supported Barcodes]({% slug barcode-supported-types-overview%})
