---
title: Overview
page_title: WPF Barcode Documentation | QRCode Overview
description: Check our &quot;Overview&quot; documentation article for Telerik Barcode for WPF control.
position: 0
slug: barcode-qrcode-overview
---

# Overview

QR code (abbreviated from Quick Response Code) is the trademark for a type of matrix barcode first designed for the automotive industry in Japan. The QR Code system has become popular outside the automotive industry due to its fast readability and greater storage capacity compared to standard UPC barcodes.

A QR code consists of black modules (square dots) arranged in a square grid on a white background, which can be read by an imaging device (such as a camera) and processed using Reed–Solomon error correction until the image can be appropriately interpreted. The required data are then extracted from patterns present in both horizontal and vertical components of the image.

A QR code uses four standardized encoding modes (numeric, alphanumeric, byte/binary, and kanji) to efficiently store data.

## Visual Structure

There are a total of 40 versions available in the QR code, from 21 by 21 modules to 177 by 177 modules, increasing in steps of 4 modules per side. Naturally, higher versions are used to encode larger amounts of data:

![barcode-2d-barcodes-qrcode-overview 001](images/barcode-2d-barcodes-qrcode-overview001.png)

![barcode-2d-barcodes-qrcode-overview 002](images/barcode-2d-barcodes-qrcode-overview002.png)

Disregarding the data, which consists of the actual encoded data, along with the error correction bits, the structure of the code includes the module groups listed below:

![barcode-2d-barcodes-qrcode-overview 003](images/barcode-2d-barcodes-qrcode-overview003.png)

* **Finder Pattern**: The finder pattern is a concentric square of alternating colors, located in all corners of the symbol except the bottom right. They are used by decoders establish orientation. The center is a 3x3 black square and it is surrounded by a one-module-thick white box, which is surrounded by a one-module-thick black box, making the full pattern 7x7 modules.
* **Alignment Pattern**: The alignment pattern is only included in the rendered QR code in version 2 and above. Its purpose is to allow the decoder to scan a skewed image, and convert it to the virtual grid of black and white modules, representing the encoded data. The alignment pattern is made of concentric squares, much like the finder patterns, with the center being a single black module.
* **Timing Pattern**: The timing pattern is an alternating stripe of black and white modules, starting at the lower left corner of the upper right Finder Pattern, going horizontally to the upper left finder pattern and then going vertically to the lower left finder pattern.
* **Format Data**: The format data is information, pertaining to the Masking rule used in the QR Code, along with error correction level. When the data in the QR code is encoded, some of the modules are inverted, in accordance with a predefined rule, in order to improve readability, and ensure that there are no big clusters of same-colored modules. This process is called masking, and the masking information is included in the format data, to alert the decoder that certain modules have been inverted.

The format data is encoded in 15 bits. One full copy of the format data is located around the upper left finder pattern. A second copy, divided into 7 and 8 bits, is located next to the other two finder patterns.
* **Version Data**: The version data includes information on which version the QR code is. This data is encoded into 18 modules, in a 6 by 3 matrix. Two copies of the version data matrix are included in the QR code - one next to the upper right finder pattern, and the other next to the lower left one.
* **Blank Space**: Additionally, around each QR code, there is an obligatory 4-modules-wide white space area:

![barcode-2d-barcodes-qrcode-overview 004](images/barcode-2d-barcodes-qrcode-overview004.png)

* **Data**: The data occupies all available modules, not occupied by any of the formatting data segments mentioned above. If the data is smaller than the capacity of the remaining modules, it is padded, in order to ensure that all modules are used. Additionally, the data consists of the actual encoded data, entered by the user, and the error correction bits, calculated on that data.

## See Also

- [Key Features]({% slug barcode-key-features%})
- [Supported Barcodes]({% slug barcode-supported-types-overview%})