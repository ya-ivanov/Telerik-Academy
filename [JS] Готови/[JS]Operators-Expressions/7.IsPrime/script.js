function isPrime(){ 	
	var num = document.getElementById("num").value; 
	var times = 0;
    for (var index = 1; index <= 100; index++)
    {
    	if (num % index == 0)
        	times++;
    }
    if (times > 2)
     	alert("The given Number is NOT prime.");
    else 
    	alert("The number IS prime.");
}