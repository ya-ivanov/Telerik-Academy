String.prototype.reverseStr = function (str){
    var reversed = "", index;
    for (index = this.length-1; index >= 0; index--)
    {
        reversed+=this[index];
    }
    return reversed;
}

function getPalindrs(){
    var txt = document.getElementById('text').value, index,words=[], done=[];
    words = txt.split(" ");
    for (index = 0; index < words.length; index++)
    {
        if (words[index].reverseStr() == words[index] && words[index].length>2)
            done.push(words[index]);
    }
    if(done.length > 0)
        document.getElementById('info').value = done.join(", ");
    else
        document.getElementById('info').value = "No palindromes in this text.";
}
