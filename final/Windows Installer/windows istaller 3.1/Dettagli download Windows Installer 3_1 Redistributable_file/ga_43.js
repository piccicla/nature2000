//appends plugin into the DOM using a placeholder <div id="embedDiv"> 
function AddGAPluginToDOM(){
	var oEmbedDiv = ge('embedDiv'); //use elements collection to bind
	if (oEmbedDiv!=null)
	{
		var eNode = document.createElement('embed');
		eNode.setAttribute('type', g_PluginType);
		eNode.setAttribute('hidden','true');
		eNode.setAttribute('id','mozillaPlugin');
		oEmbedDiv.appendChild(eNode);
		return true;
	}
	else
	{
		return false;
	}
}

function DisplayPluginInstallButton(){
	var btnInstall = ge('genuineBtn');
	if (btnInstall!=null)
		btnInstall.style.display='block';
}

function GetInstalledGAPluginVersion()
{
	// if plugins array is there and not fake
	if (navigator.plugins && navigator.plugins.length > 0) 
	{
		var pluginsArrayLength = navigator.plugins.length;
		// for each plugin...
		for (var pluginsArrayCounter=0; pluginsArrayCounter < pluginsArrayLength; pluginsArrayCounter++ )
		{	
			if (navigator.plugins[pluginsArrayCounter].name.substring(0, g_Position) == g_Plugin)
			{
				return navigator.plugins[pluginsArrayCounter].description;
			}
		}
	}
	return null;
}

function InstallGAPlugin(){
	try {
		location.href=g_GAMozillaPluginPath;
		var btnInstall			= ge('genuineBtn');
		var btnValidation		= ge('pluginValidation');
		var frmElem	= ge('quickCheck')
		if(btnInstall!=null && frmElem!=null && btnValidation!=null){
			frmElem.setAttribute('onsubmit','return GAPlugInValidation()',0);
			btnInstall.style.display='';
			btnValidation.style.display='block';
		}
		return false; 
	}catch(e){
		//install failed try the exe
		g_Target = 'exeValidation.aspx' + g_BaseQueryS;
		NextPage(g_Target,201);
	}
}

//checked to see if the user has opted in
function IsOptIn()
{
	var formEle = document.forms['decision'];
	if (formEle == null) //no opt out form
		return true;

	var ele = formEle.elements['optout'];
	if (ele != null && ele.checked) //selected optout
		return false;
	else
		return true;
}

function IsLatestPluginInstalled(){
	var returnVal = false
	try {
		if (GetInstalledGAPluginVersion() >= g_GALatestPluginVersion){
			returnVal =  true;
		}
	}
	catch(e){
		return returnVal;
	}
	return returnVal;
}

function IsPluginSupportedBrowser(){
	var name = navigator.userAgent.toLowerCase();
	if(name.indexOf("msie") == -1 && name.match("netscape/(([8-9])|(1[0-9]))"))
		return true;
	if( name.match("firefox/(([2-9])|(1.[1-9])|(1.0.[5-9])|(1.0.1[0-9]))"))
		return true;
	return false;
}


function IsGAActivexInstalled()//try axtivex method
{
	var sresult;
	try
	{
		sresult = LegitCheck.GetBlob( g_DateCode );
		if(LegitCheck.codeBase.indexOf(g_GALatestAXVersion) >-1){
			PluginType = 1;
			sresult = true;
		}
		else{sresult = false;}
	}
	catch(e)
	{
		try
		{
			sresult = LegitCheck.LegitCheck();
			if(LegitCheck.codeBase.indexOf(g_GALatestAXVersion) >-1){
				PluginType = 2;
				sresult = true;
			}
			else{sresult = false;}
		}
		catch(e)
		{
			sresult = false;
		}
	}
	return sresult;
}


//helper function to navigate to the next page with SiteUsage smarts
function NextPage(sUrl, iNa)
{
	if(g_IsStats)
		PageInfo(sUrl, iNa);
	else
		location.replace(sUrl);
}

function NextPageUrl(sUrl, iNa)
{
	if(g_IsStats)
		return PageInfoUrl(sUrl, iNa);
	else
		return sUrl;
}

// Try using encodeURIComponent - if not supported (like ie5.0), should fall to catch block and use escape instead.
// Try/catch is not supported in some downlevel - but this script isn't served to them
function PageInfo(g_Target, iNa)
{
	try{location.href='info.aspx?u='+encodeURIComponent(g_Target)+'&na='+encodeURIComponent(iNa)+'&SrcDisplayLang='+encodeURIComponent(sSrcDisplayLang)+'&SrcFamilyId='+encodeURIComponent(sSrcFamilyId)+'&oRef='+encodeURIComponent(document.referrer);}
	catch(e){location.href='info.aspx?u='+escape(g_Target)+'&na='+escape(iNa)+'&SrcDisplayLang='+escape(sSrcDisplayLang)+'&SrcFamilyId='+escape(sSrcFamilyId)+'&oRef='+escape(document.referrer);}
}

function PageInfoUrl(g_Target, iNa)
{
	try{return 'info.aspx?u='+encodeURIComponent(g_Target)+'&na='+encodeURIComponent(iNa)+'&SrcDisplayLang='+encodeURIComponent(sSrcDisplayLang)+'&SrcFamilyId='+encodeURIComponent(sSrcFamilyId)+'&oRef='+encodeURIComponent(document.referrer);}
	catch(e){return 'info.aspx?u='+escape(g_Target)+'&na='+escape(iNa)+'&SrcDisplayLang='+escape(sSrcDisplayLang)+'&SrcFamilyId='+escape(sSrcFamilyId)+'&oRef='+escape(document.referrer);}
}

// this function will return false to the form if it meets the conditions below
function QuickCheck() {
	if (IsOptIn()){
		if (g_IsIE5Plus){
			if (IsGAActivexInstalled()){
				if(PluginType == 1)
				{
					var frm = ge('quickCheck');
					if(frm != null)
					{
						g_Target = NextPageUrl("handoff.aspx"+g_BaseQueryS,201) +"&f=f";
						frm.action = g_Target;
						frm.method = "post";
						ge('hash').value = RunGAActiveX();
						frm.submit();
					}
					else
					{
						g_Target = 'genuineValidation.aspx' + g_BaseQueryS;
						NextPage(g_Target,201);
						return false;
					}
				}
				else
				{
					g_Target = g_HandOffPage + RunGAActiveX(); 
					NextPage(g_Target,201);
				}
				return false;
			//activex is not installed send to install page
			}else {
				g_Target = 'genuineValidation.aspx' + g_BaseQueryS;
				NextPage(g_Target,201);
				return false;
			}
		}
		//check for Mozilla browser and that the plugin path exists
		else if (IsPluginSupportedBrowser() && g_GAMozillaPluginPath!=null && g_GAMozillaPluginPath.length>1){
			if(IsLatestPluginInstalled() && AddGAPluginToDOM()){
				setTimeout("RunGAPlugIn(false)",0);
				return false;
			}else{
				g_Target = 'MozillaValidation.aspx' + g_BaseQueryS;
				NextPage(g_Target,201);
				return false;
			}
		}
	}
}

function RunGAActiveX()
{
	var h = '99';
	try
	{
		LegitCheck.HashCode = g_DateCode;
		if(PluginType == 1){
			h=LegitCheck.GetBlob( g_DateCode );
		}
		else{
			h = LegitCheck.LegitCheck();
		}
	}
	catch(e){}
	return h;
}

function RunGAPlugIn(IsInstallPage){
	try
	{
		var embed = ge('mozillaPlugin');
		embed.HashCode(g_DateCode);
		try {
			var frm = ge('quickCheck');
			var hash = embed.GetBlob(g_DateCode);
			g_Target = NextPageUrl("handoff.aspx"+g_BaseQueryS,201) +"&f=f";
			frm.action = g_Target;
			frm.method = "post";
			ge('hash').value = hash;
			frm.submit();
		}
		catch(e) {
			var hash = embed.LegitCheck;
			g_Target = g_HandOffPage + hash;
			NextPage(g_Target,201);
			return false;
		}
	}
	catch(e)
	{
		if(IsInstallPage)
		{
			g_Target = 'exeValidation.aspx' + g_BaseQueryS;
		}
		else//it failed try the install page
		{
			g_Target = 'mozillaValidation.aspx' + g_BaseQueryS;
		}
		NextPage(g_Target,201);
		return false;
	}
}

function GAPlugInValidation(){
	if (IsPluginSupportedBrowser()){
		if (GAPlugInValidation.caller !=null){
			navigator.plugins.refresh(false);
		}
		if (IsLatestPluginInstalled()){
			if (AddGAPluginToDOM()){
				setTimeout("RunGAPlugIn(true)",0);
			}else{//not able to add plug-in try using exe
				sTarget = "exeValidation.aspx" + g_BaseQueryS;
				NextPage(sTarget, 201);
			}
		}else{
			DisplayPluginInstallButton();
		}
	//not firefox goto exe
	}else 
	{
		sTarget = "exeValidation.aspx" + g_BaseQueryS;
		NextPage(sTarget, 201);
	}
}

function ge(id){return document.getElementById(id);}

var PluginType = -1;
var IsGAJSLoaded = true;