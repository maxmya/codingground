Module Module1
 
    Public Sub Main()
        Dim n As Integer = Console.ReadLine(), c As Char = Console.ReadLine(), m As Integer = System.Console.ReadLine(), answer As String, i As Integer
        Do Until n = 0 And m = 0
            answer = ""
            Select Case c
                Case "+"
                    answer = n + m
                Case "-"
                    answer = n - m
                Case "*"
                    answer = n * m
                Case "/"
                    If m Then answer = n / m Else answer = "Error dividing by 0\n"
                Case "^"
                    answer = 1
                    If m < 0 Then
                        answer = "-ve power is not supported yet\n"
                    Else
                        For i = 0 To m
                            answer *= n
                        Next
                    End If
                Case Else
                    answer = "This operation is invalid or not supported yet\n"
            End Select
            Console.WriteLine(answer)
            n = Console.ReadLine()
            c = Console.ReadLine()
            m = Console.ReadLine()
        Loop
    End Sub
 
End Module
