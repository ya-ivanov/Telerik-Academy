Array.prototype.remove=function(toRemove)
{
  	var arr = [];
  	for (i=0;i<this.length;i++)
    {
    	if(this[i] == toRemove)
    	{
    		this.splice(i, 1);
    	}
    }
}

function start(){
	var elements = window.prompt("Enter the length of your array:");
	var someArr = [];
	for (var i = 0 ; i < elements; i++) 
	{
		someArr[i] = window.prompt("Element [" + i + "]:");
	}
	someArr.remove(window.prompt("What do you want to remove:"));
	for (var i = 0 ; i < elements; i++) 
	{
		console.log(someArr[i]);
	}
	alert("Check you console :) .");
}