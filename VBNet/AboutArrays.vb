Imports Xunit

Public Class AboutArrays
    Inherits Koan
    <Koan(1)> _
    Public Sub CreatingArrays()
        'Arrays can be created with New by adding () to the type, and with the elements between { }
        Dim empty_array = New Object() {}
        'Note that the type of an Array is specified by its element type followed by ()
        Assert.Equal(GetType(FillMeIn), empty_array.GetType())
        'Note that you have to explicitly check for subclasses
        Assert.True(GetType(Array).IsAssignableFrom(empty_array.GetType()))
        Assert.Equal(FILL_ME_IN, empty_array.Length)
    End Sub

    <Koan(2)> _
    Public Sub ArrayLiterals()
        'You don't have to specify a type if the arguments can be inferred
        Dim array = {42,3,2,4}
        Assert.Equal(GetType(Integer()), Array.GetType())
        Assert.Equal(New Integer() {42}, Array)
        'Are arrays 0-based or 1-based?
        Assert.Equal(42, Array(CType(FILL_ME_IN, Integer)))
        'This is important because...
        Assert.True(Array.IsFixedSize)
        '...it means we can't do this: array(4) = 13;
        Assert.Throws(GetType(FillMeIn), Sub() array(4) = 13)
        'This is because the array is fixed at length 4.
    End Sub

    <Koan(3)> _
    Public Sub AccessingArrayElements()
        Dim array = New String() {"peanut", "butter", "and", "jelly"}
        Assert.Equal(FILL_ME_IN, Array(0))
        Assert.Equal(FILL_ME_IN, Array(3))
        'This doesn't work:
        'Assert.Equal(FILL_ME_IN, array(-1));
    End Sub

    <Koan(4)> _
    Public Sub SlicingArrays()
        Dim array = New String() {"peanut", "butter", "and", "jelly"}
        Assert.Equal(New String() {FILL_ME_IN, FILL_ME_IN}, array.Take(2).ToArray())
        Assert.Equal(New String() {FILL_ME_IN, FILL_ME_IN}, array.Skip(1).Take(2).ToArray())
    End Sub
End Class