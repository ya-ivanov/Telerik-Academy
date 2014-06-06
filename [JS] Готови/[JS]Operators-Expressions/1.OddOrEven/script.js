function oddOrEven(){
	var num = document.getElementById("num").value;
	if (num % 2 == 0)
		alert("The number " + num + " is even.");
	else
		alert("The number " + num + " is NOT even.");
}