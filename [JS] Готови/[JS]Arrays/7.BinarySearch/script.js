function binarySearch(items, value){

    var startIndex = 0,
        stopIndex = items.length - 1,
        middle = Math.floor((stopIndex + startIndex)/2);

    while(items[middle] != value && startIndex < stopIndex){

        if (value < items[middle]){
            stopIndex = middle - 1;
        } else if (value > items[middle]){
            startIndex = middle + 1;
        }

        middle = Math.floor((stopIndex + startIndex)/2);
    }

    return (items[middle] != value) ? -1 : middle;
}

function fill(){
    var arr = Array();
    var arrLength = window.prompt("Number of elements in your array:");
    for (var index = 0; index < arrLength; index++)
    {
        arr[index] = window.prompt("Element [" + index + "]:");
    }
    var lookFor = window.prompt("What do you want to look for? :");
    var indexEl = binarySearch(arr, lookFor);
    if (Number(indexEl) != -1)
    {
        console.log("Index of given element: " + indexEl);
    }
    else
    {
        console.log("The element is not found.");
    }
    
}
