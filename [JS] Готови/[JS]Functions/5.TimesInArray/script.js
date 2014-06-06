function timesInArr(someArr, tolookFor){
	var times = 0;
	for (var index = 0; index < someArr.length; index++)
	{
		if (someArr[index] == tolookFor)
		{
			times++;
		}
	}
	alert("The number " + tolookFor + " occures in the array " + times + " time/s.");
	var myArr = document.getElementById("myArray");
	myArr.value = someArr.join(", ");
	myArr.style.display="inline-block";
	document.getElementById("myArrayTxt").style.display="inline";
}

function fillArr(){
	var arr = [];
	var arrLength = window.prompt("The length of your array:");
	var lookFor;
	for (var index = 0; index < arrLength; index++)
	{
		arr[index] = window.prompt("Element [" + index + "]:");
	}
	lookFor = window.prompt("What is the number that you want to look for?");
	timesInArr(arr, lookFor);
}

