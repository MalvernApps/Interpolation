
This ia C# example of how to do Quadratic peak finding.

I keep having to rewrite this code and reprove if from first principles so this is an effort never to forget it again and to code it in C#. 

All you need is the function call in your code.

Adssume you have an array

| Tables        | X Coord           | Value  |
| ------------- |:-------------:| -----:|
| col 3 is      | -1 | 30 |
| col 2 is      | 0     |   40 |
| zebra stripes | 1     |    40 |

Given the above values the peak is actually at the x coordinate of 0.5 but a straight peak find will give you 0 or 1, but I want 0.5 for my FFT based searching.

so given the above table I firstly solve the quadratic equations for a, b, and c assuming the curve is of the form:

ax^2 + bx + c = value;

now I differentiate to 2ax + b = 0;

A minimum as we want a minimum or maximum of the curve.

so we now plut in our a, b, and c to solve for x and have the anser.Given out new X we can also calculate out new peak value.

License: do whart you want but if its wrong don't come crying to me.'