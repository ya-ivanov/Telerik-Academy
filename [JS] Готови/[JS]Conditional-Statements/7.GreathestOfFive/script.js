function greatestOfFive(){
	var num1 = window.prompt("Enter your 1st number:");
    var num2 = window.prompt("Enter your 2ns number:");
    var num3 = window.prompt("Enter your 4rd number:");
    var num4 = window.prompt("Enter your 4th number:");
    var num5 = window.prompt("Enter your 5th number:");
    var firstTwo = (Math.max(num1, num2));
    var secondTwo = (Math.max(num3, num4));
    var thirdTwo = (Math.max(firstTwo, secondTwo));
    var biggest = (Math.max(thirdTwo, num5));
    alert("The Greatest number is " + biggest);
}