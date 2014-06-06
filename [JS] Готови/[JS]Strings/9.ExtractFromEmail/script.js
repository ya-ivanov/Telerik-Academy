function getEmail(){
    var txt = document.getElementById('text').value, index, done=[];
    strArray = txt.split(' ');
    var exist = false;
    for (index = 0; index < strArray.length; index++)
    {
        if (strArray[index].indexOf("@") != -1 || strArray[index].indexOf(".") != -1)
        {
            if (strArray[index].indexOf("@") >= 3 && strArray[index].indexOf(".") > strArray[index].indexOf("@") + 3)
            {
                done.push(strArray[index]);
                exist = true;
            }
        }
    }
    if (exist == false)
        document.getElementById('info').value = "Cant find valid emails in the given text.";
    else
        document.getElementById('info').value = "Emails:\n" + done.join("\n");
}
