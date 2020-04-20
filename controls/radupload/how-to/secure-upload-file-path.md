---
title: Secure Upload File Paths
page_title: Secure Upload File Paths
description: Secure the uploading file location when using RadUpload control and RadUploadHandler.
slug: radupload-how-to-sanitize-upload-file-paths
tags: sanitize,upload,cloud,handler,relative,path,directory
published: True
position: 0
site_name: Silverlight
---

# Secure Upload File Paths

This article shows how to improve the security of the RadUploadHandler used with RadUpload for Silverlight. 

__RadUploadHandler__ expects a web request that provides the file location of the uploading file along with few other parameters. After version `2020.1.413` of Telerik UI for Silverlight, the default upload directory on the server is the __App_Data__ folder. The upload target folder provided with the web request is concatenated to the App_Data folder which forms the full path on the server. The target folder can be relative, but it needs to point to a location only inside of App_Data. Othwerwise the upload won't happen.

>tip To alter the default behavior, you can create a custom RadUploadHandler and override its [GetTargetFolder or GetFilePath methods]({%slug radupload-features-upload-handler%}).

In versions prior to `2020.1.413`, by default, the uploaded files go to the directory where the handler class is defined. In this case, a specially crafted web request could result in uploads to arbitary locations. To avoid this and allow only safe paths __[upgrade]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}) to version `2020.1.413` or later__ of Telerik UI for Silverlight.

>tip Version `2020.1.413` is a [LIB]({%slug installation-installing-lib%}) but it is considered stable which means that we approve it for production use.

If you don't plan to upgrade to version `2020.1.413` or later, we recommend to manually ensure that the file paths received by the upload handler are secured. The following example shows one way to do this through a [custom handler]({%slug radupload-features-upload-handler%}).

#### __[C#] Example 1: Custom RadUploadHandler__
{{region radupload-how-to-sanitize-upload-file-paths-0}}
	using System;
	using System.IO;
	using System.Text;
	using System.Web;
	using Telerik.Windows;
	using Telerik.Windows.Controls;

	public class SampleUploadHandler : RadUploadHandler
    {
        private const string AppDataFolderPath = "~/App_Data/";
        private const string DefaultUploadFolderPath = "~/App_Data/UploadedFiles";
        
        public override string GetFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            string targetFolder = this.GetTargetFolder();
            if (targetFolder == null)
            {
                return null;
            }

            string extension = Path.GetExtension(fileName);
            string securedFileName = Path.GetFileNameWithoutExtension(this.Decode(fileName));
            return string.Format("{0}{1}", Path.Combine(targetFolder, Path.GetFileName(securedFileName)), extension);
        }
                
        public override string GetTargetFolder()
        {
            string mappedTargetFoler = null;
            try
            {
                if (!string.IsNullOrEmpty(this.TargetFolder))
                {
                    string appDataPath = this.Context.Server.MapPath(AppDataFolderPath).TrimEnd(Path.DirectorySeparatorChar);
                    mappedTargetFoler = Path.Combine(appDataPath, this.TargetFolder);

                    if (!Path.GetFullPath(mappedTargetFoler).StartsWith(Path.GetFullPath(appDataPath)))
                    {
                        mappedTargetFoler = null;
                        throw new ArgumentException("Uploading to folders outside 'AppData' special folder is not supported due to security restrictions.");
                    }
                }
                else
                {
                    mappedTargetFoler = this.Context.Server.MapPath(DefaultUploadFolderPath);
                }

                if (!Directory.Exists(mappedTargetFoler))
                {
                    Directory.CreateDirectory(mappedTargetFoler);
                }
            }
            catch (HttpException e)
            {
                this.AddReturnFileParam(RadUploadConstants.ParamNameMessage, e.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                this.AddReturnFileParam(RadUploadConstants.ParamNameMessage, uae.Message);
            }          
            catch (ArgumentException ae)
            {
                this.AddReturnFileParam(RadUploadConstants.ParamNameMessage, ae.Message);
            } 
            catch (NotSupportedException nse)
            {
                this.AddReturnFileParam(RadUploadConstants.ParamNameMessage, nse.Message);
            }
            catch (IOException ioe)
            {
                this.AddReturnFileParam(RadUploadConstants.ParamNameMessage, ioe.Message);
            }

            return mappedTargetFoler;
        }

        private string Decode(string str)
        {
            var urlDecoded = HttpUtility.UrlDecode(str);
            var encoding = new UTF8Encoding();
            var utfDecoded = encoding.GetString(encoding.GetBytes(urlDecoded));

            return utfDecoded;
        }
    }
{{endregion}}

## See Also
 * [Getting Started]({%slug radupload-getting-started%})
 * [Upload Handler]({%slug radupload-features-upload-handler%})
