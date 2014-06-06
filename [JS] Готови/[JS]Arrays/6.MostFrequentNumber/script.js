function findNum(){
	var curBest = 0;
    var bestNum = 0;
    var arrLength;
    var arr = Array();
    arrLength = window.prompt("The number of elements in your array:");
    
    for(var index = 0; index < arrLength; index++)
    {
        arr[index] = window.prompt("Element [" + index + "]:");
    }
    arr.sort();
    for(var index = 1; index < arrLength; index++)
    {
        if (arr[index-1] == arr[index])
        {
            curBest++;
            if(curBest>bestNum)
            {
                bestNum=curBest;
            }
        }
        else
        {
            curBest=0;
        }
    }
    console.log("The most frequent number int the array is " + bestNum);
}
