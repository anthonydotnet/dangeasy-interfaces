# DangEasy-Interfaces

An opinionated interface library in dotnet standard 2.0 to help with application development. 

The goal of these interfaces is to provide some intuitive/obvious patterns & concepts to help write good quality clean code. Simple patterns, simple concepts, SOLID principals, and hopefully no confusion. 

You won't see a method signature such as UpdateOrCreate(), let alone any craziness such as GetUpdateOrCreate(). Multi-purpose methods like this can cause a lot of bugs, and even result poor quality programming. Methods should be single purpose and obvious. 


#A note about Async
You will probably notice async methods without their synchronous counterparts. I'm in a stage of my development life where I want to squeeze out every tiny bit of performance. If you can do it asynchronously, then why wouldn't you?

I hope you find this helpful. Pull requests are welcome!
