function inCircle(){ 	
	var x = document.getElementById("numX").value; 	
	var y = document.getElementById("numY").value;
	var r = 5;
	if(Math.sqrt(Math.pow(x,2)+Math.pow(y, 2)) < r)
		alert("The point is within the circle");
	else
		alert("The point is outside the circle");
}