---
title: Autostart
page_title: Autostart
description: Autostart
slug: radcloudupload-features-autostart
tags: autostart
publish: True
position: 2
---

# Autostart





## 

The __RadCloudUpload__ control exposes the __AutoStart__ property. Its type is __bool__ and it can be used to customize the behavior of the control when new files are selected. It can be get or set to indicate if selected files will be automatically uploaded right after the selection. The default value of this property is __false__ and newly selected files will not be started automatically for upload, the user will need to click the __Upload__ button. When you set the value of the  property to __true__, all newly added files will automatically start uploading.

>If the property is set to __true__ and an upload fails, it will not be automatically retried. The user will have to click the __Upload__ button.

# See Also

 * [Providers]({%slug radcloudupload-features-providers%})
