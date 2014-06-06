function replace(someStr){
    var index, done="";
    for (index = 0; index < someStr.length; index++)
    {
        if (someStr[index] == " ")
        {
            done+="&nbsp;"
        }
        else
            done+=someStr[index];
    }
    return done;
}

function startFromHere(){
    var text = document.getElementById('txt').value; 
    document.getElementById('txt').value = replace(text);
    
}