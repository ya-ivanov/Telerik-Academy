function countTimes(){
	var lookFor = document.getElementById("lookFor").value;
	var someStr = document.getElementById("someStr").value;
	var times = 0;
	var caseSen = document.getElementById("sensitive").checked;
	if (caseSen)
	{
		var index = someStr.indexOf(lookFor);
		while(index != -1)
		{
			someStr=someStr.slice(index*1+lookFor.length);
			times++;
	   		index=someStr.indexOf(lookFor);
		}
	}
	else
	{
		var index = someStr.toLowerCase().indexOf(lookFor.toLowerCase());
		while(index != -1)
		{
			someStr=someStr.toLowerCase().slice(index*1+lookFor.length);
			times++;
	   		index=someStr.toLowerCase().indexOf(lookFor.toLowerCase());
		}
	}
	alert("Your string occures in the text " +  times + " times.");
}
