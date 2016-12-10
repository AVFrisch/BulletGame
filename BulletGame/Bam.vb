Public Class Bam
    Inherits Bullet
    'Special bullet with ♠ shape that expands on impact

    Public Overrides Property Damage As Integer


    Public Sub New()

        MyBase.New()
        Damage = 100
        Sym = "♠"c

    End Sub


End Class
