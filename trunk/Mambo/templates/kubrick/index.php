<?php defined( "_VALID_MOS" ) or die( "Direct Access to this location is not allowed." );
  include($mosConfig_absolute_path."/templates/$cur_template/mysplitcssmenu.php");
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<?php mosShowHead(); ?>
<meta http-equiv="Content-Type" content="text/html; <?php echo _ISO; ?>" />
<?php
	if ($my->id) {
		if($_REQUEST["task"] == "edit" || $_REQUEST["task"] == "new") {
       		include("editor/editor.php");
       		initEditor();
		}
	}
?>
<?php include_once ($mosConfig_absolute_path."/templates/$cur_template/template.php");?>
<?php echo "<link rel=\"stylesheet\" href=\"templates/$cur_template/css/template_css.css\" type=\"text/css\">" ; ?>
<link rel="shortcut icon" href="<?php echo $mosConfig_live_site;?>/images/favicon.ico" />
</head>
<body id="body-<?php echo getMenuName();?>">
<div id="page" <?php if(!$option || $option == 'com_content') { ?>class="wide"<?php }else{ ?>class="narrow"<?php } ?>>

<div id="header" onclick="location.href='<?php echo $mosConfig_live_site;?>';" style="cursor: pointer;">
	<div id="headerimg">
		<h1><a href="<?php echo $mosConfig_live_site;?>" title="<?php echo $mosConfig_sitename; ?>"><?php echo $mosConfig_sitename; ?></a></h1>
		<div class="description">Put Your Site Description Here</div>
		<div id="subheader"><?php require("mysplitcssmenu.php"); echo $mycssPSPLITmenu_content; ?></div>
	</div>
</div>
<hr />
<?php if(!$option || $option == 'com_content') { ?>
<div id="content" class="widecolumn">
<?php mosMainBody(); ?>
</div>
<?php }else{ ?>
<div id="content" class="narrowcolumn">
<?php if (mosCountModules('top')>0) { mosLoadModules ( 'top' ); } ?>
<?php mosMainBody(); ?>
<?php if (mosCountModules('top')>0) { mosLoadModules ( 'bottom' ); } ?>
</div>
<div id="sidebar">
<?php echo $mycssSSPLITmenu_content; ?>
<?php if (mosCountModules('inset')>0) { mosLoadModules ( 'inset' ); } ?>
<?php if (mosCountModules('left')>0) { mosLoadModules ( 'left' ); } ?>
	<!-- Creative Commons License -->
	<p align="center"><a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/2.0/"><img alt="Creative Commons License" border="0" src="http://creativecommons.org/images/public/somerights20.gif" /></a><br />
	This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/2.0/">Creative Commons License</a>.</p>
	<!-- /Creative Commons License -->
	<!--	
	<rdf:RDF xmlns="http://web.resource.org/cc/" xmlns:dc="http://purl.org/dc/elements/1.1/" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#">
	<Work rdf:about="">
	   <license rdf:resource="http://creativecommons.org/licenses/by-nc-sa/2.0/" />
	</Work>
	<License rdf:about="http://creativecommons.org/licenses/by-nc-sa/2.0/">
	   <permits rdf:resource="http://web.resource.org/cc/Reproduction" />
	   <permits rdf:resource="http://web.resource.org/cc/Distribution" />
	   <requires rdf:resource="http://web.resource.org/cc/Notice" />
	   <requires rdf:resource="http://web.resource.org/cc/Attribution" />
	   <prohibits rdf:resource="http://web.resource.org/cc/CommercialUse" />
	   <permits rdf:resource="http://web.resource.org/cc/DerivativeWorks" />
	   <requires rdf:resource="http://web.resource.org/cc/ShareAlike" />
	</License>
	</rdf:RDF>
	-->
</div>
<?php } ?>
<hr />
<div id="footer">
<p><?php echo $mosConfig_sitename; ?> is proudly hosted by <a href="http://developer.berlios.de" title="BerliOS Developer"> <img src="http://developer.berlios.de/bslogo.php?group_id=2892" width="121px" height="30px" border="0" alt="BerliOS Developer Logo"></a> and is valid <a href="http://validator.w3.org/check/referer" title="This page validates as XHTML 1.0 Transitional (most of the time)">XHTML</a> and <a href="http://jigsaw.w3.org/css-validator/check/referer" title="Valid CSS; hopefully...">CSS</a>.<br /><a href="http://binarybonsai.com/kubrick/">Design by Michael Heilemann</a>.<a href="http://www.psychiatric.com.ar/">Ported to Mambo by Alex Sancho</a>.</p>
</div>
</div>
</body>
</html>