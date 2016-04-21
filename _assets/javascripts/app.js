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
