Public Class Default_Vb
   
    '#Region "radpropertygrid-flagenumeditor_1"
    <Flags()> _
    Public Enum Permissions
        Read = 1
        Write = 2
        Execute = 4
    End Enum

    '#End Region

    '#Region "radpropertygrid-flagenumeditor_3"
Namespace RPG_WPF
        <Flags()> _
        Public Enum Permissions
            All = -1
            None = 0
            Read = 1
            Write = 2
            Execute = 4
        End Enum
    End Namespace
    '#End Region

End Class
