'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Historia_Clinica
    Public Property Id As Integer
    Public Property id_paciente As Integer
    Public Property motivo_consulta As String
    Public Property diagnostico As String
    Public Property tratamiento As String
    Public Property fecha As Date
    Public Property id_profesional As Long

    Public Overridable Property Paciente As Paciente
    Public Overridable Property Personal As Personal

End Class
