function calculate(){
    var a=prompt("Enter a below");
    var b=prompt("Enter b below");
    var c=prompt("Enter c below");
    var a2=2*a;
    var ac=4*a*c;
    var discriminant=b*b;
    var discriminant=discriminant-ac;
    if(discriminant<0){
        document.getElementById('Equation').innerHTML='No real roots exist since Discriminant < 0 !<br />D = ' + discriminant + ' <br />The Equation = ' + a + 'x&#178; + ' + b + 'x + ' + c + '<br />';
        document.getElementById('x1').innerHTML='&nbsp; ';
        document.getElementById('x2').innerHTML='&nbsp; ';
    }
    else{
        var discriminant_sqrt=Math.sqrt(discriminant);
        var x1=-b+discriminant_sqrt;
        var x1=x1/a2;
        var x2=-b-discriminant_sqrt;
        var x2=x2/a2;
        document.getElementById('Equation').innerHTML=" Equation = " + a + "x&#178; + " + b + "x + " + c + "<br />";
        document.getElementById('x1').innerHTML=' x1 = ' + x1;
        document.getElementById('x2').innerHTML=' x2 = ' + x2;
    }
}