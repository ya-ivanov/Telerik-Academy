if (typeof String.prototype.startsWith != 'function') {
    String.prototype.startsWith = function (str){
    return this.indexOf(str) == 0;
  };
}

function getElements(){
    var url = document.getElementById('url').value; index = 0, doneStr="{";
    if (url.startsWith("http://") || url.startsWith("https://"))
    {
        doneStr+=("protocol = \"");
        for (; index < url.length; index++)
        {
            if (url[index] != ':')
                doneStr+=(url[index]);
            else
                break;
        }
        index += 3;
        doneStr+=("\"\nserver = \"");
        for (; index < url.length; index++)
        {
            if (url[index] != '/')
                doneStr+=(url[index]);
            else
                break;
        }
        doneStr+=("\"\nresourse = \"");
        if (index == url.length || index + 1 == url.length)
            doneStr+=("none");
        else
        {
            for (; index < url.length; index++)
            {
                doneStr+=(url[index]);
            }
            doneStr+="\"\n";
        }
        doneStr+="}";
    }
    else
    {
        doneStr+=("Please enter valid URL.");
    }
    document.getElementById('info').value = doneStr;
}
