function sortValues(){
	var firstNum = Number(document.getElementById("firstNum").value);
	switch (firstNum)
    {
        case 0:
            alert(firstNum + " in english is zero");
            break;
        case 1:
            alert(firstNum + " in english is one");
            break;
        case 2:
            alert(firstNum + " in english is two");
            break;
        case 3:
            alert(firstNum + " in english is three");
            break;
        case 4:
            alert(firstNum + " in english is four");
            break;
        case 5:
            alert(firstNum + " in english is five");
            break;
        case 6:
            alert(firstNum + " in english is six");
            break;
        case 7:
            alert(firstNum + " in english is seven");
            break;
        case 8:
            alert(firstNum + " in english is eight");
            break;
        case 9:
            alert(firstNum + " in english is nine");
            break;
        default:
            alert("Enter number between 0...9");
            break;
    }
}