---
title: Specifications
page_title: Specifications
description: Specifications
slug: radbarcode-barcode-specifications
tags: specifications
published: True
position: 0
---

# Specifications


This help topic describes the specific characteristics of the bar codes per type.

|Barcode type	|Character Set	|Length	|Check Digit|
|---------------|---------------|-------|-----------|
|Code 128	|ASCII (128 characters)	|variable	|Mod 103|
|Code 39	|[A-Z]; [0-9]; [ - . $ / + % ]	|variable (avg. up to 20 chars)	|optional (Mod. 43)|
|EAN - 13	|numeric [0..9]	|7 usable digits	|1 check digit|
|EAN - 8	|numeric [0..9]	|12 digits	|1 check digit|
|UPC - A	|numeric [0..9]	|12 digits	|1 check digit|
|UPC - E	|numeric [0..9]	|7 digits	|1 check digit|