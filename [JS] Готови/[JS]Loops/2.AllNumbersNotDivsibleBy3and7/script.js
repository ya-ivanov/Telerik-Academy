function print(){
	var nNum = Number(document.getElementById("numN").value);
	for(var index = 1; index< nNum+1; index++)
	{
		if (index % 3 != 0 | index % 7 != 0)
		{
		console.log(index );
		}
	}
	console.log("end");
}