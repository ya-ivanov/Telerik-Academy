function reverse(){
	var reversed = "", index;
	var str = document.getElementById('str').value;
	for (index = str.length-1; index >= 0; index--)
	{
		reversed+=str[index];
	}
	document.getElementById('str').value = reversed;
}