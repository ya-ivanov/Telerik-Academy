function calcSign(){
	var firstNum = Number(document.getElementById("firstNum").value);
	var secNum = Number(document.getElementById("secNum").value);
	var thirdNum = Number(document.getElementById("thirdNum").value);
	var negativeTimes = 0;
	var number = firstNum*secNum*thirdNum;
	if (firstNum < 0)
		negativeTimes++;
	if (secNum < 0)
		negativeTimes++;
	if (thirdNum < 0)
		negativeTimes++;
	
	if (negativeTimes % 2 == 0)
		alert("The sign is '+'. The number is " + number + " .");
	else
		alert("The sign is '-'. The number is " + number + " .");
	}