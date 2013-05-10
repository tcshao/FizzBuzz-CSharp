FizzBuzz-CSharp
===============

FizzBuzz in C# - With a semi-functional programming style, optimized for readability

original problem is stated as such:

>Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

C# has changed quite a bit in it's last couple iterations.  The addition of LINQ and extension methods have allowed the language to become much more expressive.  This isn't the best or most efficient implementation of FizzBuzz, it's even a bit over-engineered. But the intent is to display my "style".  

I believe the first two, and most important, aspects of code quality are 

	1) It Works
	2) It can easily be read by the next developer 
		(see the aphorism: "Everyone else's code sucks, in 3 weeks your code becomes everyone elses")

Although ability to scale, security, and performance are also major parts of quality software, If you have the first two (and tests in place to support #1) refactoring to address any other shortcomings is much easier because you don't have to figure out first what the program was actually meant to do.


