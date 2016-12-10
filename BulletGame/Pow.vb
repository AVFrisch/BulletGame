Public Class Pow
    Inherits Bullet
    'Powerful bullet dealing 100 damage

    Public Overrides Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 100

    End Sub


End Class
