Public Class Heart
    Inherits Obstacle
    'Health pickup with appropriate ♥ shape

    Overrides Property Sym As Char = "♥"c

    Public Overrides Property Health As Integer

    Public Sub New()

        MyBase.New()
        Health = 9999

    End Sub


End Class
