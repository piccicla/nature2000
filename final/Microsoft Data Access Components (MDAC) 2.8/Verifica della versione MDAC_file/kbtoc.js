var tocLinkCount=0;var kbTOC=document.getElementById("tocDiv");var kbHeadings=new Array();function passesTypeFilter(type){type=type.toLowerCase();eval("var p = ("+sectionFilter+");");return p;}function getInnerText(n){if(n.nodeType==3)return n.nodeValue;else{var txt="";for(var i=0;i<n.childNodes.length;i++)txt+=getInnerText(n.childNodes[i]);return txt;}}function tocScrollTo(e){e.scrollNode.scrollIntoView(true);return false;}function makeTOCNode(HNode,depth){var n=document.createElement("div");var t=getInnerText(HNode);n.innerHTML="<a href=\"#\" onclick=\"return tocScrollTo(this);\"><img src=\""+tocArrow+"\" alt=\"\" /><span class=\"tocTxt\">"+t+"</span></a><div class=\"tocLine\"></div>";n.childNodes[0].scrollNode=HNode;n.depth=depth;HNode.tocElement=n;return n;}function findParentTOCNode(){var h=kbHeadings;var d=h[h.length-1].tocElement.depth;for(var j=h.length-2;j>-1;j--){var jd=h[j].tocElement.depth;if(jd<d)return h[j];}}function enforceHeadingMaximums(p){if(p.tocElement.depth+1>2){eval("var max = depth"+(p.tocElement.depth+1)+"Limit");var l=p.tocElement.childNodes[1].childNodes.length;if(l>max){p.tocElement.childNodes[1].style.display="none";tocLinkCount -=l;}}}function loadTOCNode(depth,type){var e=getLatestElement();if(passesTypeFilter(type)&&depth<=depthLimit){kbHeadings.push(e);var c=makeTOCNode(e,depth);var p=findParentTOCNode();if(p){if(p.tocElement.childNodes[1].style.display!='none'){p.tocElement.childNodes[1].appendChild(c);enforceHeadingMaximums(p);tocLinkCount++;}}else{kbTOC.appendChild(c);tocLinkCount++;}if(tocLinkCount>tocEntryMinimum)kbTOC.style.display="block";else kbTOC.style.display="none";}}function getLatestElement(){var e=document.body;while(e.lastChild)e=e.lastChild;while(!e.tagName)e=e.parentNode;return e.previousSibling;}