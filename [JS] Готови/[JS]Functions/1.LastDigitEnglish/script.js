function getDigit(){
	var num = document.getElementById("num").value;
	var lastNum = Number(num[num.length - 1]);
	switch (lastNum)
	{
		case 0:
			alert("The last digit is 0. In English this is 'ZERO'.");
			break;
		case 1:
			alert("The last digit is 1. In English this is 'ONE'.");
			break;
		case 2:
			alert("The last digit is 2. In English this is 'TWO'.");
			break;
		case 3:
			alert("The last digit is 3. In English this is 'THREE'.");
			break;
		case 4:
			alert("The last digit is 4. In English this is 'FOUR'.");
			break;
		case 5:
			alert("The last digit is 5. In English this is 'FIVE'.");
			break;
		case 6:
			alert("The last digit is 6. In English this is 'SIX'.");
			break;
		case 7:
			alert("The last digit is 7. In English this is 'SEVEN'.");
			break;
		case 8:
			alert("The last digit is 8. In English this is 'EIGHT'.");
			break;
		case 9:
			alert("The last digit is 9. In English this is 'NINE'.");
			break;
		default:
			alert("Please enter a valud number!");
			break;
	}
}