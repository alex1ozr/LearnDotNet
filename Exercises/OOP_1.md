# Simple OOP exercise

Create:
1. C# class library project
2. C# console project to test the logic in your code. 

## Classes
Implement the following classes:
* Person 
* Student 
* Professor

### Classes requirements
* The Person class must have public property Name. The Name cannot be changed.
* The Person class must have two public methods 
  * SayHello() that writes "Hello! My name is {name}." to the console.
  * SetAge(int age) that assigns the age of the person.
* The Student and Teacher classes should be inherited from the Person class.
  * The Professor class must override SayHello() method so that it writes "Hello! My name is professor {name}." to the console.
* The Student class must have a public Study() method that writes "I'm studying" to the console.
* The Teacher class must have a public Explain() method that writes "Listen to me now! I'm your teacher!" to the console.
* Also create a public method SayAge() in the Student class that writes "I'm {age} years old" to the console.

## Test project requirements
* You must create a console application project with the Main method to do the following:
  * Create a new Person and make him say hello 
  * Create a new Student, set an age, say hello, and display their age on the screen. 
  * Create a new Teacher, set an age, say hello, and start the explanation.
