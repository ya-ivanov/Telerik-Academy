function swap(items, firstIndex, secondIndex){
    var temp = items[firstIndex];
    items[firstIndex] = items[secondIndex];
    items[secondIndex] = temp;
}

function selectionSort(){

    var arr = Array();
    var arrLength = window.prompt("Number of elements in your array:");
    for (var i = 0; i < arrLength; i++) 
    {
        arr[i] = window.prompt("Element [" + i + "]:");
    }
    var len = arrLength, min;
    for (i=0; i < len; i++)
    {
        min = i;
        for (j=i+1; j < len; j++)
        {
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        if (i != min)
        {
            swap(arr, i, min);
        }
    }
    console.log("Your array is now sorted:")
    for (var i = 0; i < arrLength; i++) 
    {
        console.log(arr[i]);
    }
}

