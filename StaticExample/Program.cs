using StaticExample;

var classOne = new Classroom();

classOne.RoomNumber = 1;

var classTwo = new Classroom();

classTwo.RoomNumber = 2;

Classroom.Subject = "Java";

Console.WriteLine($"Class 1 is in room {classOne.RoomNumber} and Class 2 is in room {classTwo.RoomNumber} and they teach {Classroom.Subject}");

