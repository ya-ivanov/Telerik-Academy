function windowProps(){
	var arr = Array();
	for(var item in window)
	{
		arr.push(item);
	}	
	arr.sort();
	alert("The biggest lexicographically in window is " + arr[0] + "\n" + "The smallest lexicographically in window is " + arr[arr.length-1] + "\n");
}
function documentProps(){
	var arr = Array();
	for(var item in document)
	{
		arr.push(item);
	}	
	arr.sort();
	alert("The biggest lexicographically in document is " + arr[0] + "\n" + "The smallest lexicographically in document is " + arr[arr.length-1] + "\n");
}
function navigatorProps(){
	var arr = Array();
	for(var item in navigator)
	{
		arr.push(item);
	}	
	arr.sort();
	alert("The biggest lexicographically in navigator is " + arr[0] + "\n" + "The smallest lexicographically in navigator is " + arr[arr.length-1] + "\n");
}
