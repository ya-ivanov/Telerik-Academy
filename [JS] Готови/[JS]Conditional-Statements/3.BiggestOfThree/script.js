function calcSign(){
	var firstNum = Number(document.getElementById("firstNum").value);
	var secNum = Number(document.getElementById("secNum").value);
	var thirdNum = Number(document.getElementById("thirdNum").value);
	if (firstNum > secNum)
    {
	    if (firstNum > thirdNum)
	    	alert("The biggest number is " + firstNum);
	    else if (thirdNum > firstNum)
	    	alert("The biggest number is " + thirdNum);
	}
	else if (secNum > firstNum)
	{
	    if (secNum > thirdNum)
	    	alert("The biggest number is " + secNum);
	    else if (thirdNum > secNum)
	    	alert("The biggest number is " + thirdNum);
	}
	else if (thirdNum > firstNum)
	{
	    if (thirdNum > secNum)
	    	alert("The biggest number is " + thirdNum);
	    else if (secNum > thirdNum)
	    	alert("The biggest number is " + secNum);
	}
    else
        alert("The Numbers are even.");

}