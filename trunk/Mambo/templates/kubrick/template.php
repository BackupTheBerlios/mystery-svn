<?php
// $Id: template.php,v 1.0 2004/02/05 00:00:00 jjanssens Exp $
/**
* Editor handler
* @package Mambo Open Source
* @Copyright (C) 2000 - 2003 Miro International Pty Ltd
* @ All rights reserved
* @ Mambo Open Source is Free Software
* @ Released under GNU/GPL License : http://www.gnu.org/copyleft/gpl.html
* @version $Revision: 1.4 $
**/

defined( '_VALID_MOS' ) or die( 'Direct Access to this location is not allowed.' );

function getMenuName()
{
global $Itemid;
$name = getMenu($Itemid);

$name = ereg_replace('[/ ]', "", strtolower($name));
return $name;
}

function getMenu($itemid)
{
global $database; 

$sql = "SELECT name FROM #__menu WHERE id='$itemid'";
$database->setQuery( $sql );

return $database->loadResult();
}
?>