function findMinAndMax(){
	var nNum = document.getElementById("numbersCount").value;
	var someArr = new Array();
	var str = " ";
	for(;nNum > 0; nNum--)
	{
		var num = window.prompt("Enter your number:");
		someArr.push(num);
		str+=num + ", ";
	}
	someArr.sort();
	document.getElementsByTagName("body")[0].innerHTML +="<h5>Your numbers:</h5><input type='text' value='" + str + "' />";
	alert("The smallest number is " + someArr[0] + " and the biggest is " + someArr[someArr.length-1]);
	
	
}
