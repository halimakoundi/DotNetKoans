Imports Xunit

Public Class AboutContainers
    Inherits Koan
    <Koan(1)> _
    Public Sub PushingAndPopping()
        Dim array = New Integer() {1, 2}
        Dim stack As Stack = New Stack(array)
        stack.Push("last")
        Assert.Equal(FILL_ME_IN, stack.ToArray())
        Dim poppedValue = stack.Pop()
        Assert.Equal(FILL_ME_IN, poppedValue)
        Assert.Equal(FILL_ME_IN, stack.ToArray())
    End Sub

    <Koan(2)> _
    Public Sub Shifting()
        'Shift == Remove First Element
        'Unshift == Insert Element at Beginning
        'C# doesn't provide this natively. You have a couple
        'of options, but we'll use the LinkedList<T> to implement
        Dim array = New String() {"Hello", "World"}
        Dim list = New LinkedList(Of String)(array)
        list.AddFirst("Say")
        Assert.Equal(FILL_ME_IN, list.ToArray())
        list.RemoveLast()
        Assert.Equal(FILL_ME_IN, list.ToArray())
        list.RemoveFirst()
        Assert.Equal(FILL_ME_IN, list.ToArray())
        list.AddAfter(list.Find("Hello"), "World")
        Assert.Equal(FILL_ME_IN, list.ToArray())
    End Sub
End Class
