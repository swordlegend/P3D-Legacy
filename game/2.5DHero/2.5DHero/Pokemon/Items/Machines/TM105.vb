Namespace Items.Machines

    <Item(405, "TM 105")>
    Public Class TM105

        Inherits TechMachine

        Public Sub New()
            MyBase.New(True, 2000, 290, 105)
            CanTeachAlways = True
        End Sub

    End Class

End Namespace
