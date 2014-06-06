function sortValues(){
	var firstNum = Number(document.getElementById("firstNum").value);
	var secNum = Number(document.getElementById("secNum").value);
	var thirdNum = Number(document.getElementById("thirdNum").value);
	if (firstNum > secNum)
    {
        if (firstNum > thirdNum && firstNum > secNum )
        {
            console.log(firstNum);
            if (secNum > thirdNum)
            {
                console.log(secNum);
                console.log(thirdNum);
            }
            else
            {
                console.log(thirdNum);
                console.log(secNum);
            }
        }
    }
    if (secNum > firstNum && secNum > thirdNum)
    {
        console.log(secNum);
        if (firstNum > thirdNum)
        {
            console.log(firstNum);
            console.log(thirdNum);
        }
        else
        {
            console.log(thirdNum);
            console.log(firstNum);
        }
        
    }
    if (thirdNum > firstNum && thirdNum > secNum)
    {
        if (thirdNum > secNum)
        {
            console.log(thirdNum);
            if (firstNum > secNum)
            {
                console.log(firstNum);
                console.log(secNum);
            }
            else if (firstNum < secNum)
            {
                console.log(secNum);
                console.log(firstNum);
            }
        }
    }
}