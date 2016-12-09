Public Class Diamond
    Inherits Bullet

    Public Overrides Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 500
        Sym = "♦"c

    End Sub


End Class
