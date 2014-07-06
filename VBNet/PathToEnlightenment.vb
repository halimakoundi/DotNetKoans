Public Class PathToEnlightenment
    Implements KoanHelpers.IAmThePathToEnlightenment
    Public ReadOnly Property ThePath() As String() Implements KoanHelpers.IAmThePathToEnlightenment.ThePath
        Get
            Return New String() {"DotNetKoans.VBNet.AboutAsserts",
                                 "DotNetKoans.VBNet.AboutNothing",
                                 "DotNetKoans.VBNet.AboutArrays",
                                 "DotNetKoans.VBNet.AboutHashes",
                                 "DotNetKoans.VBNet.AboutStrings",
                                 "DotNetKoans.VBNet.AboutInheritance",
                                 "DotNetKoans.VBNet.AboutMethods",
                                 "DotNetKoans.VBNet.AboutControlStatements",
                                 "DotNetKoans.VBNet.AboutUsing"
                                }
        End Get
    End Property
End Class
