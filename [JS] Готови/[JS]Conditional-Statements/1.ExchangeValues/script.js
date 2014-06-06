function replace(){
	var firstNum = Number(document.getElementById("firstNum").value);
	var secNum = Number(document.getElementById("secNum").value);
	var temp = 0;
	if (firstNum > secNum) 
	{
		temp = firstNum;
		firstNum = secNum;
		secNum = temp;
		alert("The 1st number is bigger than the 2nd one. Values are exchanged.");
	}
	else
		alert("The 1st number is smaller (or even) than the 2nd one. Values are not exchanged.");
}