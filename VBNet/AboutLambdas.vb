Imports System.Collections.Generic
Imports System.Linq
Imports Xunit

Public Class AboutLambdas
    Inherits Koan
    <Koan(1)> _
    Public Sub UsingAnonymousMethods()
        'The AboutDelegates Koans introduced you to delegates. In all of those koans, 
        'the delegate was assigned to a predefined method. 
        'Anonymous methods let you define the method in place.
        'This Koan produces the same result as AboutDelegates.ChangingTypesWithConverter, but it uses 
        'an anonymous method instead. As you can see there is no method name, but it is 
        'prefixed with "delegate"
        Dim numbers = New Integer() {1, 2, 3, 4}
        Dim result = Array.ConvertAll(numbers, Function(x As Integer) x.ToString())

        Assert.Equal(FILL_ME_IN, result)
    End Sub
    <Koan(2)> _
    Public Sub AnonymousMethodsCanAccessOuterVariables()
        'Anonymous methods can access variable defined in the scope of the method where they are defined.
        'In C# this is called accessing an Outer Variable. In other languages it is called closure. 
        Dim numbers = New Integer() {4, 5, 6, 7, 8, 9}
        Dim toFind As Integer = 7
        Assert.Equal(FILL_ME_IN, Array.FindIndex(numbers, Function(x As Integer) x = toFind))
    End Sub
    <Koan(3)> _
    Public Sub AccessEvenAfterVariableIsOutOfScope()
        Dim criteria As Predicate(Of Integer)
        If True Then
            'Anonymous methods even have access to the value after the value has gone out of scope
            Dim toFind As Integer = 7
            criteria = Function(x As Integer) x = toFind
        End If
        Dim numbers = New Integer() {4, 5, 6, 7, 8, 9}
        'toFind is not available here, yet criteria still works
        Assert.Equal(FILL_ME_IN, Array.FindIndex(numbers, criteria))
    End Sub
    <Koan(4)> _
    Public Sub LambdaExpressionsAreShorthand()
        Dim numbers = New Integer() {1, 2, 3, 4}
        Dim anonymous = Array.ConvertAll(numbers, Function(x As Integer) x.ToString())
        'Lambda expressions are really nothing more than a short hand way of writing anonymous methods
        'The following is the same work done using a Lambda expression. 
        'The delegate key word is replaced with => on the other side of the parameters
        '        |                               |
        '        |                               |-----|
        '        |----------------------------|        |
        '                                    \|/      \|/
        Dim lambda = Array.ConvertAll(numbers, Function(x As Integer)
                                                   Return x.ToString()

                                               End Function)
        Assert.Equal(FILL_ME_IN, anonymous)
        'The => pair is spoken as "going into". If you were talking about this 
        'code with a peer, you would say "x going into..."
    End Sub
    <Koan(5)> _
    Public Sub TypeCanBeInferred()
        'Fortunately the above form of a Lambda is the most verbose form. 
        'Most of the time you can take many of the pieces out. 
        'The next few Koans will step you through the optional pieces.
        Dim numbers = New Integer() {1, 2, 3, 4}
        Dim anonymous = Array.ConvertAll(numbers, Function(x As Integer) x.ToString())
        Dim lambda = Array.ConvertAll(numbers, Function(x)
                                                   ' type is removed from the parameter --^
                                                   Return x.ToString()

                                               End Function)
        Assert.Equal(FILL_ME_IN, anonymous)
    End Sub
    <Koan(6)> _
    Public Sub ParensNotNeededOnSingleParemeterLambdas()
        Dim numbers = New Integer() {1, 2, 3, 4}
        Dim anonymous = Array.ConvertAll(numbers, Function(x As Integer) x.ToString())
        Dim lambda = Array.ConvertAll(numbers, Function(x)
                                                   '                                     ^-----------------------|
                                                   'When you have only one parameter, no parenthesis are needed -|
                                                   Return x.ToString()

                                               End Function)
        Assert.Equal(FILL_ME_IN, anonymous)
    End Sub
    <Koan(7)> _
    Public Sub BlockNotNeededOnSingleStatementLambdas()
        Dim numbers = New Integer() {1, 2, 3, 4}
        Dim anonymous = Array.ConvertAll(numbers, Function(x As Integer) x.ToString())
        Dim lambda = Array.ConvertAll(numbers, Function(x) x.ToString())
        'When you have only one statement, the curly brackets are not needed. What other two things are also missing?
        Assert.Equal(FILL_ME_IN, anonymous)
    End Sub
End Class
