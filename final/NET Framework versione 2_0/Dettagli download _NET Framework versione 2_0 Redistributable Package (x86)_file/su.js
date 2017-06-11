var sNaId = 71;

window.onload = Init;

function Init()
{
    if(document && document.location && document.location.pathname)
    {
	    var url = document.location.pathname.toLowerCase();
	    if(url.indexOf("details.aspx") > -1)
	    {
		    // If on details page, modify links in overview.
		    var oOverview = document.getElementById("overview");
		    if(oOverview != null)
		    {
			    ModifyLink(oOverview, "44", false);
		    }
	    }

	    // If on thankyou page, modify links in wgaTalkback.
	    if(url.indexOf("thankyou.aspx") > -1)
	    {
		    var oWgaTalkBack = document.getElementById("wgaAdvantage");
		    if(oWgaTalkBack != null)
		    {
			    ModifyLink(oWgaTalkBack, "132", true);
		    }

		    var oWgaTalkBack = document.getElementById("wgaTalkBackLink");
		    if(oWgaTalkBack != null)
		    {
			    ModifyLink(oWgaTalkBack, "133", false);
		    }
	    }
	}

	// Bind onclick event to all relevant anchors.
	// Get container of our Menu
	var oMenuDiv = document.getElementById("mnpMenuTop");
	if(oMenuDiv != null)
	{
		// Get all links under it
		var oLinks = oMenuDiv.getElementsByTagName("a");

		if(oLinks != null)
		{
			// Bind onclick to links
			var iLinksCount = oLinks.length;
			for(var i=0; i<iLinksCount; i++)
			{
				// Don't bind to did you mean for URL's or hrefs that start with mailto and that already have tracking
				if (oLinks[i].na != sNaId && oLinks[i].href.indexOf("mailto") == -1 && oLinks[i].href.indexOf("info.aspx") == -1)
				{
					oLinks[i].onclick=ProcessLink;
				}
			}
		}

		if (oMenuDiv.nextSibling !=null)
		{
			var oAdDiv = oMenuDiv.nextSibling;
			//check if ad
			if (oAdDiv.attributes != null && oAdDiv.attributes["class"] != null && oAdDiv.attributes["class"].value == "mnpAds")
			{
				ModifyLink(oAdDiv, "77", false);
			}
		}

		// AdvancedSearch Node does not have an Id to identify it.
		// It is contained by the node previous to mnpMenuTop, so retrieve it using previousSibling property
		if (oMenuDiv.previousSibling != null)
		{
			var oAdvancedSearchNode = oMenuDiv.previousSibling;
			while (oAdvancedSearchNode.nodeType != 1 && oAdvancedSearchNode.previousSibling != null)
			{
				oAdvancedSearchNode = oAdvancedSearchNode.previousSibling;
			}
			ModifyLink(oAdvancedSearchNode, "27", false);
		}
	}
}

function ProcessLink(e)
{
	// Get clicked element
	var oElem;
	if(true == g_IsIE) oElem = event.srcElement;
	else oElem = e.target;

	// If not an anchor, iterate up till you find one - exit if hit the body tag.
	while (oElem.tagName != "A")
	{
		if (oElem.tagName == "BODY") return;
		if (g_IsIE) oElem = oElem.parentElement;
		else if (g_IsGecko) oElem = oElem.parentNode;
	}

	// Finish url
	var sTarget = oElem.href;

	// For intra-page links on the pages in the current domain, no need to report stats.
	if(sTarget.toLowerCase().indexOf("#") > -1)
	{
		if(sTarget.toLowerCase().indexOf(document.location.hostname + document.location.pathname) > -1) return;
	}


	// Page to be directed to
	var sInfoUrl = "info.aspx";
	var iP = GetPosition(oElem);

	// Try using encodeURIComponent - if not supported (like ie5.0), should fall to catch block and use escape instead.
	// Try/catch is not supported in some downlevel - but this script isn't served to them
	try{sInfoUrl += "?u=" + encodeURIComponent(sTarget) + "&na=" + sNaId + "&p=" + iP + "&SrcDisplayLang=" + sSrcDisplayLang + "&SrcCategoryId=" + sSrcCategoryId + "&SrcFamilyId=" + sSrcFamilyId;}
	catch(e){sInfoUrl += "?u=" + escape(sTarget) + "&na=" + sNaId + "&p=" + iP + "&SrcDisplayLang=" + escape(sSrcDisplayLang) + "&SrcCategoryId=" + sSrcCategoryId + "&SrcFamilyId=" + escape(sSrcFamilyId);}

	// Do redirect. Sometimes with slow browser reaction and rapid clicks this can get called more than once.
	// Ensure no repetition-check if existing href already modified
	if (oElem.href.toString().indexOf("info.aspx") == -1) oElem.href = sInfoUrl;
}

function GetPosition(oElem)
{
	var sHref = oElem.href;
	if (sHref == "") return 0;

	var oMenuDiv = document.getElementById("mnpMenuTop");
	var oDivs = oMenuDiv.getElementsByTagName("DIV");

	var iDivCount = oDivs.length;

	var iP = 0;

	for(var i=0; i<iDivCount; i++)
	{
		if (oDivs[i].className == "mnpMenuRow")
		{
			iP++;
			var oANodes = oDivs[i].getElementsByTagName("a");

			if (oANodes !== null && oANodes.length > 0)
			{
				if (sHref == oANodes[0].href && oANodes[0].innerHTML == oElem.innerHTML) return iP;
			}
		}
	}
}

function ModifyLink(oElem, iNa, incrementPosition)
{
	if(oElem != null)
	{			
		// Get all links under it
		var oLinks = oElem.getElementsByTagName("a");

		if(oLinks != null)
		{
			var iLinksCount = oLinks.length;
			var iP = 0;

			for(var i=0; i<iLinksCount; i++)
			{
				var sTarget = oLinks[i].href;

				// Don't modify hrefs that start with mailto and that already have tracking
				if (sTarget.indexOf("mailto") == -1 && sTarget.indexOf("info.aspx") == -1)
				{	
					if (incrementPosition)
					{
						iP = i + 1;
					}
					try{oLinks[i].href = "info.aspx?u=" + encodeURIComponent(sTarget) + "&na=" + iNa + "&p=" + iP + "&SrcDisplayLang=" + sSrcDisplayLang + "&SrcCategoryId=" + sSrcCategoryId + "&SrcFamilyId=" + sSrcFamilyId;}
					catch(e){oLinks[i].href = "info.aspx?u=" + escape(sTarget) + "&na=" + iNa + "&p=" + iP + "&SrcDisplayLang=" + escape(sSrcDisplayLang) + "&SrcCategoryId=" + sSrcCategoryId + "&SrcFamilyId=" + escape(sSrcFamilyId);}
				}
			}
		}
	}
}