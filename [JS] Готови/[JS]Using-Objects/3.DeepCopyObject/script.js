function cloneObject(obj) {
        var clone = {};
        for(var i in obj) {
            if(typeof(obj[i])=="object")
                clone[i] = cloneObject(obj[i]);
            else
                clone[i] = obj[i];
        }
        return clone;
    }

function start(){
	var movie = [{
	    title: "The Avengers",
	    director: "Joss Whedon",
	    year: 2012,
	    rateIMDB: 8.3,
	}]
	var newObj = cloneObject(movie);
	console.log(newObj);
}