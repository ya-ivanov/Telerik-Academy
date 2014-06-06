function find(){
	var index = 0;
    var currentSeq = 1;
    var longestSeq = 1;
    var masterNumber = 0;
    var someArrayElements = window.prompt("How many elements do you want your array to have?");
    var someArray = Array();
   
    someArray[index] = window.prompt("Element [0] = ");
    for (index = 1 ; index < someArrayElements; index++)
    {
        someArray[index] = window.prompt("Element [" + index + "] = ");
        if (someArray[index - 1] == someArray[index])
        {
            currentSeq++;
            if (currentSeq > longestSeq)
            {
                longestSeq = currentSeq;
                masterNumber = someArray[index];
            }
        }
        else
        	currentSeq = 1;
    }
   	console.log("Longest Sequence: ");
    for (var counter = 0; counter < longestSeq; counter++)
    {
        console.log(masterNumber + ", ");
    }
}
