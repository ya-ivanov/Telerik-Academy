var myDivs = 3;
function countDivs(){
	var times = document.getElementsByTagName("div").length;
	alert("There are "+times + " divs on this page.");
}
function createDiv(){
	document.getElementsByTagName("body")[0].innerHTML+=("<div>Div number " + myDivs + ".");
	myDivs++;
}
