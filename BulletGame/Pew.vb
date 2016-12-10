Public Class Pew
    Inherits Bullet
    'Standard bullet dealing 50 damage

    Public Overrides Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 50

    End Sub


End Class
