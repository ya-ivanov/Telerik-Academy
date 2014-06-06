function bitCheck(){ 	
	var num = document.getElementById("num").value; 	
	var mask = 1;     
	mask = mask << 3;     
	var numberAndMask = num & mask;     
	var check = false;     
	check = (numberAndMask >> 3 == 1);     
	if (check)
		alert("The third bit is 1");
	else
		alert("The third bit is 0");
}