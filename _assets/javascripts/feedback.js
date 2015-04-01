//Default FeedBack Values
var ratings = 3;
var title = document.title;
var URL = location.href.replace(location.hash, "");
var version = 2007;

/*************************************************************************
* Methods ********************************************************
*************************************************************************/

function DeliveryType()
{
    if (URL.indexOf("ms-help://") != -1) { return ("h"); }
    else if (URL.indexOf(".chm::/") != -1) { return ("c"); }
    else if (URL.indexOf("http://") != -1) { return ("w"); }
    else if (URL.indexOf("file:") != -1) { return ("f"); }
    else return ("0");
}

function DeliverableValue(deliverable)
{
    if (URL.indexOf("ms-help://") != -1)
    {
        delvalue = location.href.slice(0, location.href.lastIndexOf("/html/"));
        delvalue = delvalue.slice(delvalue.lastIndexOf("/") + 1);
        return delvalue;
    }
    else return (deliverable);
}

function URLValue()
{
    if (URL.indexOf(".chm::") != -1)
    {
        a = URL;
        while (a.indexOf("\\") < a.indexOf(".chm::") || a.indexOf("//") > a.indexOf(".chm::"))
        {
            if (a.indexOf("\\") == -1)
            {
                break;
            }
            a = a.substring(a.indexOf("\\") + 1, a.length);
        }
        return ("ms-its:" + a)
    }
    else if (URL.indexOf("file:///") != -1)
    {
        a = URL;

        b = a.substring(a.lastIndexOf("html") + 5, a.length);
        return ("file:///" + b);
    }
    else return (URL);
}

function GetLanguage()
{
    var langauge;
    if (navigator.userAgent.indexOf("Firefox") != -1)
    {
        var index = navigator.userAgent.indexOf('(');
        var string = navigator.userAgent.substring(navigator.userAgent.indexOf('('), navigator.userAgent.length);
        var splitString = string.split(';');
        language = splitString[3].substring(1, splitString[3].length);
    }
    else language = navigator.systemLanguage;
    return (language);
}


//---Gets topic rating.---
function GetRating()
{

    sRating = "0";
    for (var x = 0; x < 5; x++)
    {
        if (document.formRating)
        {
            if (document.formRating.fbRating[x].checked) { sRating = x + 1; } 
        }
        else return sRating;
    }
    return sRating;
}

function submitfeedback(alias, product, deliverable, productVersion, documentationVersion, defaultBody, defaultSubject)
{
    SubmitFeedback(alias, product, deliverable, productVersion, documentationVersion, defaultBody, defaultSubject);
}

function SubmitFeedback(alias, product, deliverable, productVersion, documentationVersion, defaultBody, defaultSubject)
{
    extractURL = URL
    extractURL = extractURL.substring(extractURL.indexOf("html/") + 5, extractURL.length);
    var subject = product + ". Article name: " + document.title;
    // + " ("
    // + "/1:"
    // + product 
    // + "/2:"
    // + productVersion
    // + "/3:"
    // + documentationVersion
    // + "/4:"
    // + DeliverableValue(deliverable)
    // + "/5:"
    //+ URLValue()
    // + "/6:"
    // + GetRating() 
    // + "/7:"
    // + DeliveryType()
    // + "/8:"
    // + GetLanguage()
    // + "/9:"
    // + version
    // + ")"; 

    var customBody = "***\r\nArticle: " + window.location + "\r\nPlease do not change the subject of this e-mail as it helps us handle the inquiry accordingly. \r\nYour feedback is used to improve the documentation and the product. Your e-mail address will not be used for any other purpose and is disposed of after the issue you report is resolved. While working to resolve the issue, you may be contacted via e-mail to get further details or clarification on the feedback you've sent. After the issue has been addressed, you may receive an e-mail to let you know of its status.\r\n***";

    location.href = "mailto:" + alias + "?subject=" + subject + "&body=" + encodeURIComponent(customBody);
}

function AltFeedback(src, title)
{
    src.title = title;
    return;
}