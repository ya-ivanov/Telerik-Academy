function compare(){
	var firstArr = {};
	var secondArr = {};
	var timesBiggerFirst=0;
	var timesBiggerSecond=0;
	
	var arrLength = window.prompt("The length of the arrays:");
	for(var index = 0; index< arrLength; index++)
	{
		var num=window.prompt("First Array: Enter element " + index + " below:");
		firstArr[index]=num;
	}
	for(var index = 0; index< arrLength; index++)
	{
		secondArr[index]=window.prompt("Second Arr: Enter element " + index + " below:");
	}
	for(var index = 0; index< arrLength; index++)
	{
		if(firstArr[index].charCodeAt(0) > secondArr[index].charCodeAt(0))
		{
			timesBiggerFirst++;
		}
		else if(secondArr[index].charCodeAt(0) > firstArr[index].charCodeAt(0))
		{
			timesBiggerSecond++;
		}
	}
	if(timesBiggerFirst < timesBiggerSecond)
	{
		alert("The first array is bigger then the second one.");
	}
	else if(timesBiggerSecond < timesBiggerFirst)
	{
		alert("The second array is bigger then the first one.");
	}
	else
	{
		alert("The arrays are equal.");
	}

}
