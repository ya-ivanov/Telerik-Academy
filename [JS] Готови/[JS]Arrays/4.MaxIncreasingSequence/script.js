function find(){
	var index = 0;
    var someArrayElements = 0;
    var currentSeq = 1;
    var longestSeq = 1;
    var times = 0;
    someArrayElements = window.prompt("Number of elements in your array:");
    var someArray = Array();
    var specialNumbers = Array();
    someArray[index] = window.prompt("Element [0] = ");
    for (index = 1; index < someArrayElements; index++)
    {
        someArray[index] = window.prompt("Element [" + index + "] = ");
        if ((Number(someArray[index - 1])+ 1) == Number(someArray[index]))
        {
            currentSeq++;
            if (currentSeq + 1 >= longestSeq)
            {
                longestSeq = currentSeq;
                specialNumbers.push(someArray[index - 1]);
                times++;
            }
        }
        else
        {
            currentSeq = 1;
        }
    }
    console.log("The longest sequense is:\n");
    for (var i = 0; i < times; i++)
    {
        console.log(specialNumbers[i] + ", ");
    }
    console.log(Number(specialNumbers[specialNumbers.length - 1])+1);
}
