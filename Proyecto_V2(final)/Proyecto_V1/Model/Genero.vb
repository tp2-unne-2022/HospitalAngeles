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

Partial Public Class Genero
    Public Property Id As Integer
    Public Property nombre As String
    Public Property deBaja As Boolean

    Public Overridable Property Paciente As ICollection(Of Paciente) = New HashSet(Of Paciente)
    Public Overridable Property Personal As ICollection(Of Personal) = New HashSet(Of Personal)

End Class