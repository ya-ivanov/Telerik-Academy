function digit(){
	var num = document.getElementById("num").value;
	var rightToLeft = num[num.length-3];
	if (rightToLeft == 7)
		alert("The 3rd digit from right to left is 7.")
	else
		alert("The 3rd digit from right to left is NOT 7. It is " + rightToLeft + " .");
}