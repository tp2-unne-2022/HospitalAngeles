﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class HospitalEntities4
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HospitalEntities4")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Genero() As DbSet(Of Genero)
    Public Overridable Property Obra_Social() As DbSet(Of Obra_Social)
    Public Overridable Property Paciente() As DbSet(Of Paciente)
    Public Overridable Property Personal() As DbSet(Of Personal)
    Public Overridable Property Tipo_Personal() As DbSet(Of Tipo_Personal)
    Public Overridable Property Tipo_Usuario() As DbSet(Of Tipo_Usuario)
    Public Overridable Property Usuario() As DbSet(Of Usuario)
    Public Overridable Property agenda() As DbSet(Of agenda)
    Public Overridable Property turnos() As DbSet(Of turnos)
    Public Overridable Property Historia_Clinica() As DbSet(Of Historia_Clinica)

    Public Overridable Function pa_All_Pacientes() As ObjectResult(Of pa_All_Pacientes_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of pa_All_Pacientes_Result)("pa_All_Pacientes")
    End Function

End Class