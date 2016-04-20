module Reading
  class KendoGridGeneraotr < Jekyll::Generator
		def generate(site)	
			@site = site
			site.pages.each do |p|			
				createKendoGridSection(p, p.content)
			end
		end
	
		def createKendoGridSection(page, content)
			kendoGridKeyWPF = /``kendogrid/
			wpfIndex = content.index(kendoGridKeyWPF)
			
			htmlWPF = "<script type='text/x-kendo-template' id='template'>
					<div><div class='detailsDIV' style='float:left; width:30%'></div><div style='float:right; width:60%' class='readmeDiv'></div></div>
				</script><script type='text/x-kendo-template' id='toolBarTemplate'><div class='toolbar'><label class='category-label' for='category'>Search Examples by Key Words</label><input type='search' id='searchBox' oninput='onUserInput()'/></div></script><div><div class='kendoDiv' id='kendoDiv' style='float:left;'></div>
				<h4 id='heading'></h4>
				<div><pre><code id='codeBlock'>code</code></pre></div></div>"
			
			if (wpfIndex)
				content[wpfIndex..wpfIndex + 11] = htmlWPF
			end
			
			kendoGridKeySL = /``kendogridSL/
			slIndex = content.index(kendoGridKeySL)
			
			htmlSL = "<script type='text/x-kendo-template' id='template'>
					<div><div class='detailsDIV' style='float:left; width:30%'></div><div style='float:right; width:60%' class='readmeDiv'></div></div>
				</script><script type='text/x-kendo-template' id='toolBarTemplate'><div class='toolbar'><label class='category-label' for='category'>Search Examples by Key Words</label><input type='search' id='searchBox' oninput='onUserInputSL()'/></div></script><div><div class='kendoDivSL' id='kendoDivSL' style='float:left;'></div>
				<h4 id='heading'></h4>
				<div><pre><code id='codeBlock'>code</code></pre></div></div>"
			
			if (slIndex)
				content[slIndex..slIndex + 13] = htmlSL
			end
			
			
		end
		
		def encode_liquid(content)
		  content = content.gsub("{{", "{{ '{{' }}")
		end
	end
end