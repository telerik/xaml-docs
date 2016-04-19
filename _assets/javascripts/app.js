function expandNavigation(url) {
    return function() {
        var segments = url.split("/");
        var page = segments[segments.length - 1];
        var treeview = this;

        var dataSource = this.dataSource;
        var node;

        for (var idx = 0; idx < segments.length; idx++) {
            node = dataSource.get(segments[idx]);
            node.set("expanded", true);
            dataSource = node.children;
        }

        node.set("selected", true);
        
        var navigationElement = $("#page-nav");		
		navigationElement.scrollTop(0);
		var selectedNodeTopOffset = this.findByUid(node.uid).offset().top;
		var scrollOffset = localStorage.getItem('ScrollOffset');		
		if(scrollOffset != null){			
			navigationElement.scrollTop(selectedNodeTopOffset- parseInt(scrollOffset));
		}
		else{
			navigationElement.scrollTop(selectedNodeTopOffset - navigationElement.height()/2);
		}

        this.unbind("dataBound", arguments.callee);
    }
}


function navigationTemplate(root) {
    return function(data) {
        var item = data.item;
        var text = item.text;

        if (item.hasChildren) {
            return text;
        }

        var url = item.path;

        if (location.pathname.indexOf(".html") < 0) {
            url = url.replace(".html", "");
        }

        while (item = item.parentNode()) {
            url = item.path + "/" + url;
        }

        return '<a href="' + root + url + '">' + text + "</a>";
    }
}

function preventParentSelection(e) {
    if (this.dataItem(e.node).hasChildren) {
        e.preventDefault();
        this.toggle(e.node);		
    }
    
    var offset = $(e.node).offset().top;
    localStorage.setItem('ScrollOffset',offset);
}

function onExpand(e) {
	var item = this.dataItem(e.node);
	
	if(!item.hasChildren)
	{
		var elementTop = $(e.node).offset().top;
		var treeScrollTop = $("#page-nav").scrollTop();

		var treeTop = $("#page-nav").offset().top;
		
		console.log("elementTop " + elementTop);
		console.log("treeScrollTop " + treeScrollTop);
		console.log("treeTop " + treeTop);
		
		$("#page-nav").animate({
			scrollTop: ((treeScrollTop + elementTop) - treeTop) / 2
		});
	}
}

$(function(){
    $("pre").addClass("prettyprint");

    prettyPrint();

    $("#markdown-toc")
        .on("click", "a", function() {
            $(".section > ul").hide();
        })
    .each(function() {
        var ul = $("<ul>");

        $("#page-article h2").each(function() {
            var h2 = $(this);

            if (!/fields|configuration|properties|events|methods/i.test(h2.text())) {
                return;
            }

            $("<li>")
                .addClass("section")
                .append(h2.children().clone())
                .appendTo(ul)
                .mouseenter(function() {
                    var children = $(this).children("ul");

                    if (!children.length) {
                        children = $("<ul>");

                        h2.nextUntil("h2").filter("h3").each(function(){
                            $("<li>").append($(this).children().clone()).appendTo(children);
                        });

                        if (children.children().length) {
                            children.appendTo(this);
                        }
                    }

                    children.show();
                })
                .mouseleave(function() {
                    $(this).children("ul").hide();
                });
        });

        ul.appendTo(this);
    });
});

$(function(){
    $(".toggle-nav").click(function() {
        $("#page-search").removeClass("search-visibility");
        $("#page-inner-content").removeClass("move-inner-content");
        $("#page-nav").toggleClass("nav-visibility");
    });
});

$(function(){
    $(".show-search").click(function() {
        $("#page-nav").removeClass("nav-visibility");
        $("#page-search").toggleClass("search-visibility");
        $("#page-inner-content").toggleClass("move-inner-content");
    });
});

$(function(){
    $('#toYear').text((new Date).getFullYear());
});

function httpGet(theUrl)
  {
    var xmlHttp = null;

    xmlHttp = new XMLHttpRequest();
    xmlHttp.open( "GET", theUrl, false );
    xmlHttp.send( null );
    return xmlHttp.responseText;
  }
  
  function escapeXamlCode(xamlCode)
  {
	var converted = xamlCode.replace(/</g, "&lt;");
	var converted2 = converted.replace(/>/g, "&gt;");
	return converted2;
  }
  
  function getFileExtension(fileName)
  {
	  var ext = fileName.split('.').pop();
	  if (ext =="xaml" || ext == "config" || ext == "csproj")
	  {
			ext = "xml"
	  }
	return ext;
  }
  
  function getCodeFromGitHub(url)
  {
		var html = httpGet(url);
		var fileExtenstion = getFileExtension(url);
		var langName = "";
		
		if (fileExtenstion =="xml")
		{			
			langName = "XML";
			if (url.endsWith('xaml'))
			{
				langName = "XAML";
			}
			html = escapeXamlCode(html);
		}	
		else if (fileExtenstion == "cs")
		{
			langName = "C#";
		}
		document.getElementById('heading').innerHTML = '<strong>' +langName+ '</strong>';
		
		 var prettyCode = prettyPrintOne(html, fileExtenstion);
		 return prettyCode;
  }
  
function populateCodeBlock(url)
{
   document.getElementById('codeBlock').innerHTML = getCodeFromGitHub(url);
}
  
 function setDescription(readmeDiv, description)
  {
	  var htmlStart ="<html><head></head><body><b><u>Description:</u></b><p>"
	  var htmnEnd = "</p></body></html>";
	  readmeDiv.html(htmlStart + description + htmnEnd);
  }
        
function getReadMeFileName(readmePath)
{    
	return readmePath.split('\\').pop();
}

function detailInit(e) {
                    var detailRow = e.detailRow;  

                     detailRow.find(".detailsDIV").kendoGrid({
                      
						dataSource: e.data.ExampleInfo.ExampleFileNames,   
                      
						columns: [{ title: "Files",	template: "#=data#"}],
							  
						selectable: "row",
							   
                        change: function() {							
                           var index = this.select().index();
                           var dataItem = this.dataSource.view()[index];
						   
						    populateCodeBlock(e.data.GitHubPath + dataItem);	
                        },                   
                    });   
					setDescription(e.detailRow.find(".readmeDiv"), e.data.Description);							
                }
				
function getGitHubFolderUrl(exampleInfo)
{
  var masterIndex = exampleInfo.GitHubPath.indexOf('master');
  var rootDir = exampleInfo.GitHubPath.substring(masterIndex + 7);  
  var dirName = exampleInfo.ExampleInfo.DirectoryName;
  
  var result ="<a href='https://github.com/telerik/xaml-sdk/tree/master/" + rootDir +"/'>" +dirName+ "</a>";
  return result;
}

$(function(){
  $("#kendoDiv").kendoGrid({  
			   toolbar: kendo.template($("#toolBarTemplate").html()),
               height: 450,
               columns: [{
                        field: "Name",
						width: 300,
                        template: function(dataItem) {
                          return getGitHubFolderUrl(dataItem)
                        },
                       },
					   { field: "Description"}], 
			   dataSource: {
				   transport: {
						read: {
							url: "sdk_wpf.json",
							dataType: "json"
						}
					}
				},
             detailTemplate: kendo.template($("#template").html()),
             detailInit: detailInit,
			 selectable: "row",
			 change: function (e) {
						var row = this.select();
						if (row != null) {
							if (row.next(".k-detail-row").is(":visible")) {
								e.sender.collapseRow(row);
							} else {
								e.sender.expandRow(row);
							}
						}
					},
        });
		
	var grid = $("#kendoDiv").data("kendoGrid");
	if (grid)
	{
		grid.one("dataBound", function(e) {
						e.sender.expandRow($('#kendoDiv tbody>tr:first'));
			  });
	}
});

$(function(){
  $("#kendoDivSL").kendoGrid({  
			   toolbar: kendo.template($("#toolBarTemplate").html()),
            	 height: 450,
            	 columns: [{
                        field: "Name",
						width: 300,
                        template: function(dataItem) {
                          return getGitHubFolderUrl(dataItem)
                        },
                       },
					   { field: "Description"}], 
			   dataSource: {
				   transport: {
						read: {
							url: "sdk_sl.json",
							dataType: "json"
						}
					}
				},
             detailTemplate: kendo.template($("#template").html()),
             detailInit: detailInit,
			 selectable: "row",
			 change: function (e) {
						var row = this.select();
						if (row != null) {
							if (row.next(".k-detail-row").is(":visible")) {
								e.sender.collapseRow(row);
							} else {
								e.sender.expandRow(row);
							}
						}
					},
        });
		
	var grid = $("#kendoDivSL").data("kendoGrid");
	if (grid)
	{
		grid.one("dataBound", function(e) {
						e.sender.expandRow($('#kendoDivSL tbody>tr:first'));
			  });
	}
});

 function onUserInput() {
      var input = document.getElementById("searchBox").value;
      var grid = $("#kendoDiv").data("kendoGrid");
       grid.dataSource.filter({ value: input,
                               field: "KeyWords",
                               operator: function(field, value){
                                 if (value == '')
                                 {
                                   return true;
                                 }
                                 
                                 if (field)
                                 {
                                   		var status = true;
                                   		var splittedSearchKeys = value.toLowerCase().split(/[ ,]+/);
                                   		for (var i = 0, length = splittedSearchKeys.length; i < length; i++) { 
                                           if (field.toLowerCase().indexOf(splittedSearchKeys[i]) < 0)
                                           {
                                             status = false;
                                             break;
                                           }
                                        }                                   
                                  		return status;
                                 }
                                 return false;
    							} 
                             });
  }
  
  function onUserInputSL() {
      var input = document.getElementById("searchBox").value;
      var grid = $("#kendoDivSL").data("kendoGrid");
        grid.dataSource.filter({ value: input,
                               field: "KeyWords",
                               operator: function(field, value){
                                 if (value == '')
                                 {
                                   return true;
                                 }
                                 
                                 if (field)
                                 {
                                   		var status = true;
                                   		var splittedSearchKeys = value.toLowerCase().split(/[ ,]+/);
                                   		for (var i = 0, length = splittedSearchKeys.length; i < length; i++) { 
                                           if (field.toLowerCase().indexOf(splittedSearchKeys[i]) < 0)
                                           {
                                             status = false;
                                             break;
                                           }
                                        }                                   
                                  		return status;
                                 }
                                 return false;
    							} 
                             });
  }

