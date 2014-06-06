function hasProperty(object, property){
	if (property in object)
		return true;
	else
		return false;
}

function create(){
	var propName = document.getElementById("propName").value;
	var objName = document.getElementById("objName").value;
	var hasProp = hasProperty(Object(objName), propName);
	console.log("HasProperty: " +  hasProp);
}
