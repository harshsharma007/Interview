using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Questions
{
    class WhyCompilerDecidesDoubleRatherThanDecimal
    {
        /*
            Why the compiler decide 2.3 is double and not decimal?
            
            decimal x;
            x = 2.3; // Compilation error - can not convert double to decimal
            x = (decimal)2.3; // OK
            
            Why the compiler doesn't think like this: He wants to get a decimal, he give me a value that can be decimal, So it's decimal!
            And why this doesn't get compilation error
            
            short x;
            x = 23; // OK
            Who said that 23 isn't an int?
        */
    }

    class Answer
    {
        /*
            There are a lot of questions here. Let's break them down into small questions.
            
            - Why is the literal 2.3 of type double rather than decimal?
            Historical reasons. C# is designed to be a member of the "C-like syntax" family of languages, so that its superficial appearance and basic idioms are familiar to programmers
            who use C-like languages. In almost all of those languages, floating point literals are treated as binary not decimal floats because that's how C did it originally.
            
            Were I designing a new language from scratch I would likely make ambigious literals illegal; every floating point literal would have to be unambigiously double, single or
            decimal and so on.
            
            - Why is it illegal in general to convert implicitly between double and decimal?
            Because doing so is probably a mistake in two ways.
            
            First, doubles and decimals have different ranges and different amounts of "representation error" - that is, how different is the quantity represented from the precise
            mathematical quantity you wish to represent. Converting a double to a decimal or vice versa is a dangerous thing to do and you should be sure that you are doing it correctly;
            making you spell out the cast calls attention to the fact that you are potentially losing precision or magnitude.
            
            Second, doubles and decimals have very different usages. Doubles are usually used for scientific calculations where a difference between 1.000000000001 and 0.99999999999
            is far smaller than experimental error. Accruing small representation errors is irrelevant. Decimals are usually used for exact financial calculations that need to be
            perfectly accurate to the penny. Mixing the two accidentally seems dangerous.
            
            There are times when you have to do so; for example, it is easier to work out "exponential" problems like mortage amortization or compounded interest accrual in doubles.
            In those cases again we make you spell out that you are converting from double to decimal in order to make it very clear that this is a point in the program where precision
            or magnitude losses might occur if you haven't gotten it right.
            
            - Why is it illegal to convert a double literal to a decimal literal? Why not just pretend that it was a decimal literal?
            C# is not a "hide your mistakes for you" kind of language. It is a "tell you about your mistakes so you can fix them" kind of language. If you meant to say "2.3m" and you
            forgot the "m" then the compiler should tell you about it.
            
            - Then why is it legal to convert an integer literal (or any integer constant) to short, byte and so on?
            Because an integer constant can be checked to see if it is in the correct range at compile time. And a conversion from an in-range integer to a smaller integral type is
            always exact; it never loses precision or magnitude, unlike double/decimal conversions. Also, integer constant arithmetic is always done in a "checked" context unless
            you override that with an unchecked block, so there is not even the danger of overflow.
            
            And it is less likely that integer/short arithmetic crosses a "domain" boundary like double/decimal arithmetic. Double arithmetic is likely to be scientific, decimal
            arithmetic is likely to be financial. But integer and short arithmetic are not each clearly tied to different business domains.
            
            And making it legal means that you don't have to write ugly unnecessary code that casts constants to the right types.
            
            There is therefore no good reason to make it illegal, and good reasons to make it legal.
        */
    }
}
