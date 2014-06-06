function getPerson(persons){
	var youngest= 900, currYoungest = 0; youngestPos=0;
	for(var index = 0; index < persons.length; index++)
	{
		currYoungest = persons[index].age;
		if (currYoungest < youngest)
		{
			youngest = currYoungest;
			youngestPos = index;
		}
	}
	return youngestPos;
}

function findYoungest(){
	var persons = [
  		{firstname : "Gosho", lastname: "Petrov", age: 6},
  		{firstname : "Misho", lastname: "Lozeto", age: 21},
  		{firstname : "Tisho", lastname: "Tishov", age: 29},
  		{firstname : "Petko", lastname: "Gerganov", age: 10},
  		{firstname : "Kiril", lastname: "Lazarov", age: 36},
  		{firstname : "Pesho", lastname: "Ivanov", age: 81}];
	var youngest = getPerson(persons);
	console.log("The youngest person is:");
	console.log(persons[youngest].firstname + " " + persons[youngest].lastname);
}
