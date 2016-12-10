Public Class Diamond
    Inherits Bullet
    'Special bullet with ♦ shape

    Public Overrides Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 500
        Sym = "♦"c

    End Sub


End Class
