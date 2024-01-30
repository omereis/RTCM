
function checkMenuItem (idActive) {
	var menu = document.getElementById ("divNavbar");
	if (menu != null)
		deactivateMenuItems (menu);
	var mi = document.getElementById (idActive);
	if (mi != null)
		mi.className = "active";
}
//-----------------------------------------------------------------------------
function deactivateMenuItems (menu) {
	for (var n=0 ; n < menu.children.length ; n++) {
		item = menu.children[n];
		if (item.children.length > 0)
			deactivateMenuItems (item);
		else
			item.className = '';
	}
}
