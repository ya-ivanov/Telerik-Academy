function findElement(){
	var specialPosition = 0;
    var someArrayElements = window.prompt("How many elements do you want your array to have?");
    var someArray = [];
    for (index = 0; index < someArrayElements; index++)
    {
        someArray[index] = window.prompt("Element [" + index + "]:");
    }
    specialPosition = find(someArray);
    if (Number(specialPosition) == -1)
    {
        alert("There is no number that is bigger than it's neighbors.");
    }
    else
    {
        alert("The index of first the number that is bigger than its neighbors int the array is " + specialPosition);
    }
}

function find(someArray){
    var index = 1, position = 0, minPosition = 100;
    for (; index < someArray.length - 1; index++)
    {
        if (someArray[index - 1] < someArray[index] && someArray[index] > someArray[index + 1])
        {
            position = index;
            if (minPosition > position)
            {
                minPosition = position;
            }
        }
        else
        {
            position = 0;
        }
    }
    if (Number(minPosition) == 100)
    {
        minPosition = -1;
    }
    return Number(minPosition); 
}
