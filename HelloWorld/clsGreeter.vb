Option Strict On

Public Class clsGreeter

    Private mstrHiWord As String

    Public Sub New()
        mstrHiWord = "Hello"
    End Sub

    Public Function Greeting(vstrName As String) As String
        Return mstrHiWord & " " & vstrName & "!"
    End Function

End Class
