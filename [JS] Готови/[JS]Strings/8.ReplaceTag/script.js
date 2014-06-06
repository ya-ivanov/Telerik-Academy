function changeTag(){
    var htmlText = document.getElementById('html').value, index, times = 0;
    while (index != -1)
    {
        index = htmlText.indexOf("<a href", index+1);
        if (index != -1)
            times++;
    }
    for (index = 0; index < times; index++)
    {
        htmlText = htmlText.replace("<a href=\"", "[URL=");
        htmlText = htmlText.replace("\">", "]");
        htmlText = htmlText.replace("</a>", "[/URL]");
        document.getElementById('info').value = "Converted text: \n" + htmlText;
    }
}
