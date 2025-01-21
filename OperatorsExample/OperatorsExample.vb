'Alexis Villagran 
'Spring 2025
'RCET 2265
'OperatorExample
'https://github.com/alxsvxn/OperatorsExample.git

Option Compare Binary

Module OperatorsExample

    Sub Main()
        'Sum Operator
        Console.Write("5 + 3 = ") 'Prints a string of characters in between the quotations
        Console.WriteLine(5 + 3) 'Print the sum
        Console.WriteLine() 'Adds a blank line under the function

        'Subtraction Operator
        Console.Write("5 - 3 = ") 'Prints a string of characters in between the quotations
        Console.WriteLine(5 - 3) 'Print the difference
        Console.WriteLine()

        'Multiplication Operator
        Console.Write("5 * 3 = ") 'Prints a string of characters in between the quotations
        Console.WriteLine(5 * 3) 'Print the product
        Console.WriteLine()

        'Floating Point division Operator
        Console.Write("5 / 3 = ") 'Prints a string of characters in between the quotations
        Console.WriteLine(5 / 3) 'Print the floating point quotient
        Console.WriteLine()

        'Integer division Operator
        Console.Write("5 \ 3 = ") 'Prints a string of characters in between the quotations
        Console.WriteLine(5 \ 3) 'Print the quotient
        Console.WriteLine()

        'Modulus operator
        Console.Write("5 mod 3 = ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 Mod 3) 'print the remainder
        Console.WriteLine()

        'Exponent operator
        Console.Write("5 ^ 3 = ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 ^ 3) 'print the exponent
        Console.WriteLine()

        'Concatenation operator
        Console.Write("5" & " " & "+" & " 3" & " = " & "8") 'Prints a string of characters between the quotations
        Console.WriteLine()
        Console.WriteLine("Wake Up" & vbNewLine & "[Happy Emoji & Sad Emoji]") 'vbnewline is a variable that creates a new line and carriage return
        Console.WriteLine()
        'By clicking next in the grey bar next to the numbers we can insert a breakpoint for debugging

        'Comparison Operators
        Console.Write("5 > 3 = ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 > 3) 'Prints the comparison expression(T/F)
        Console.WriteLine()

        Console.Write("5 < 3 = ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 < 3) 'Prints the comparison expression(T/F)
        Console.WriteLine()

        Console.Write("Does 5 = 3 ? ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 = 3) 'Prints the comparison expression(T/F)
        Console.WriteLine()

        Console.Write("Is 5 not equal to 3 ? ") 'Prints a string of characters between the quotations
        Console.WriteLine(5 <> 3) 'Prints the comparison expression(T/F)
        Console.WriteLine()

        Console.Write("A > B = ") 'Prints a string of characters between the quotations
        Console.WriteLine("A" > "B") 'Prints the comparison expression(T/F)
        Console.WriteLine()

        Console.Write("Is A the same as a ? ") 'Prints a string of characters between the quotations
        Console.WriteLine("A" = "a") 'Prints the comparison expression(T/F)
        Console.WriteLine()
    End Sub

End Module
