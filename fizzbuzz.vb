Sub fizzbuzz()
　　Dim i As Long
　　Cells.Clear
　　For i = 1 To 100
　　　　If i Mod 15 = 0 Then
　　　　　　Cells(i, 4) = "FizzBuzz"
　　　　ElseIf i Mod 3 = 0 Then
　　　　　　Cells(i, 2) = "Fizz"
　　　　ElseIf i Mod 5 = 0 Then
　　　　　　Cells(i, 3) = "Buzz"
　　　　Else
　　　　　　Cells(i, 1) = i
　　　　End If
　　Next
End Sub
