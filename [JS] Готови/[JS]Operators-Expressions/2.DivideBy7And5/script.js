function dividable(){
	var num = document.getElementById("num").value;
	var canBeDivided = num % 5 == 0 && num % 7 == 0;
	if (canBeDivided)
		alert("The number can Be Divided by 5 and seven at the same time.");
	else
		alert("The number CAN'T Be Divided by 5 and seven at the same time.");
}