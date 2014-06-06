function getText(){
    var writeOpen = true, index, done = "";
    var text = document.getElementById('txt').value;
    for (index=0; index<text.length; index++)
    {
        if (text[index] == "<")
            writeOpen=false;
        if (text[index] == ">")
            writeOpen=true;
        if (writeOpen==true)
            if (text[index] != "<" && text[index] != ">")
                done+=text[index];
    }
    document.getElementById('txt').value = done;
}
