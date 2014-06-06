function reverseNum(){
	var num = document.getElementById("number").value;
	var reversed = [];
	for(var index = num.length-1; index >= 0; index--)
	{
		reversed.push(num[index]);
	}
	var result;
	result = reversed.join("");
	document.getElementById("result").value = result;
}