function findElement(){
	var index = 0;
    var someArrayElements = 0;
    someArrayElements = window.prompt("How many elements do you want your array to have?");
    var someArray = [];
    someArray[index] =  window.prompt("Element [" + index + "]:");
    for (index = 1; index < someArrayElements; index++)
    {
        someArray[index] = window.prompt("Element [" + index + "]:");
    }
    var numToLookFor = 0;
    numToLookFor = window.prompt("On what position is the number which you want to check?");
	if (Number(numToLookFor) > someArrayElements - 1 || Number(numToLookFor) < 0)
    {
       alert("This position is outside the range of the array.");
    }
    else if (Number(numToLookFor) + 1 == someArrayElements || Number(numToLookFor) == 0)
    {
        alert("The number on this position have only one neighbor. ");
    }
    else if (someArray[numToLookFor] > someArray[Number(numToLookFor) + 1] && someArray[Number(numToLookFor)] > someArray[numToLookFor - 1])
    {
        alert("Number " +  someArray[Number(numToLookFor)] + " is bigger than its neighbors.");
    }
}
