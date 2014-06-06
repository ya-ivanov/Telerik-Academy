function find(){
	var text = document.getElementById('txt').value.toLowerCase();
    var index = 0, times = 0;
    var lookFor = document.getElementById('lookFor').value.toLowerCase();
    while (index != -1)
    {
        index = text.indexOf(lookFor, index+1);
        if (index != -1)
            times++;
    } 
    alert("The substring >" + lookFor + "< is in the given string " + times + " times.");
}
