function check(){
	var openClosed = 0, index;
    var expression = document.getElementById('equation').value;
    for (index=0; index<expression.length; index++)
    {
        if (expression[index] == '(')
        	openClosed++;
        else if (expression[index] == ')')
        {

            if (openClosed == 0)
            {
                openClosed--;
                break;
            }
            else 
            	openClosed--;
        }
    }
    if (openClosed == 0)
    	alert("The expression is correct.");
    else 
    	alert("The expression is wrong.");
}
