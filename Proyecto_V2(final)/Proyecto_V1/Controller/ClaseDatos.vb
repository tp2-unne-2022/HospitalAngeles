Imports System.Net

Public Class ClaseDatos
#Region "PACIENTE"
    Shared Function listarPacientes(nombre As String, valorBaja As Integer)
        Dim ctx As New HospitalEntities4
        If valorBaja = 1 Then
            Dim datos = (From c In ctx.Paciente
                         Where c.apellido.Contains(nombre) And c.deBaja = True).ToList
            Return datos
        ElseIf valorBaja = 0 Then
            Dim datos = (From c In ctx.Paciente
                         Where c.apellido.Contains(nombre) And c.deBaja = False).ToList
            Return datos
        Else
            Dim datos = (From c In ctx.Paciente
                         Where c.apellido.Contains(nombre)).ToList
            Return datos
        End If
    End Function
    Shared Function getInfoPacientes(p_paciente_id As Integer) As Paciente
        Dim ctx As New HospitalEntities4
        Dim paciente As Paciente = (From c In ctx.Paciente
                                    Where c.Id = p_paciente_id
                                    Select c).SingleOrDefault
        Return paciente
    End Function
    Shared Sub actualizarPaciente(p_paciente_id As Integer, id_obra As Integer, id_genero As Integer, nombre As String, apellido As String, dni As Long, localidad As String, provincia As String, direccion As String, telefono As Long, fecha_alta As Date, fecha_nac As Date, email As String)
        Dim ctx As New HospitalEntities4
        Dim paciente As Paciente = (From c In ctx.Paciente
                                    Where c.Id = p_paciente_id
                                    Select c).SingleOrDefault
        With paciente
            .id_obra_soc = id_obra
            .id_genero = id_genero
            .nombre = nombre
            .apellido = apellido
            .dni = dni
            .localidad = localidad
            .provincia = provincia
            .direccion = direccion
            .telefono = telefono
            .fecha_alta = fecha_alta
            .id_obra_soc = id_obra
            .fecha_nac = fecha_nac
            .email = email
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarPaciente(paciente As Paciente)
        Dim ctx As New HospitalEntities4
        ctx.Paciente.Add(paciente)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarPaciente(p_paciente_id As String)
        Dim ctx As New HospitalEntities4
        Dim paciente As Paciente = (From c In ctx.Paciente
                                    Where c.Id = p_paciente_id
                                    Select c).SingleOrDefault
        ctx.Paciente.Remove(paciente)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "PERSONAL"
    Shared Function listarPersonal(nombre As String, valorBaja As Integer)
        Dim ctx As New HospitalEntities4
        If valorBaja = 1 Then
            Dim datos = (From c In ctx.Personal
                         Where c.apellido.Contains(nombre) And c.deBaja = True).ToList
            Return datos
        ElseIf valorBaja = 0 Then
            Dim datos = (From c In ctx.Personal
                         Where c.apellido.Contains(nombre) And c.deBaja = False).ToList
            Return datos
        Else
            Dim datos = (From c In ctx.Personal
                         Where c.apellido.Contains(nombre)).ToList
            Return datos
        End If
    End Function
    Shared Function getInfoPersonal(p_personal_id As Long) As Personal
        Dim ctx As New HospitalEntities4
        Dim personal As Personal = (From c In ctx.Personal
                                    Where c.dni = p_personal_id
                                    Select c).SingleOrDefault
        Return personal
    End Function
    Shared Sub actualizarPersonal(dni As Long, cod_tipo_personal As Integer, id_obra_soc As Integer, id_genero As Integer, nombre As String, apellido As String, fecha_nac As Date, fecha_ingreso As Date, localidad As String, provincia As String, domicilio As String, num_tel As Long, email As String)
        Dim ctx As New HospitalEntities4
        Dim personal As Personal = (From c In ctx.Personal
                                    Where c.dni = dni
                                    Select c).SingleOrDefault
        With personal
            .dni = dni
            .cod_tipo_personal = cod_tipo_personal
            .id_obra_soc = id_obra_soc
            .id_genero = id_genero
            .nombre = nombre
            .apellido = apellido
            .fecha_nac = fecha_nac
            .fecha_ingreso = fecha_ingreso
            .localidad = localidad
            .provincia = provincia
            .domicilio = domicilio
            .num_tel = num_tel
            .email = email
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarPersonal(personal As Personal)
        Dim ctx As New HospitalEntities4
        ctx.Personal.Add(personal)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarPersonal(p_personal_id As String)
        Dim ctx As New HospitalEntities4
        Dim personal As Personal = (From c In ctx.Personal
                                    Where c.dni = p_personal_id
                                    Select c).SingleOrDefault
        ctx.Personal.Remove(personal)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "OBRA SOCIAL"
    'Funcion compartida -> lista todos los registros de la tabla que contengan el dato pasado como parametro
    Shared Function listarObrasSociales(nombre As String, valorBaja As Integer)
        'Se inicializa una instancia de las entidades de la base de datos
        'Dim ctx As New HospitalEntities4
        'La variable datos va a ser = datos que cumplan la condicion de contener el parametro
        'Dim datos = (From c In ctx.Obra_Social
        '             Where c.nombre.Contains(nombre)).ToList

        'Devuelve esos registros de la tabla
        'Return datos
        Dim ctx As New HospitalEntities4
        If valorBaja = 1 Then
            Dim datos = (From c In ctx.Obra_Social
                         Where c.nombre.Contains(nombre) And c.deBaja = True).ToList
            Return datos
        ElseIf valorBaja = 0 Then
            Dim datos = (From c In ctx.Obra_Social
                         Where c.nombre.Contains(nombre) And c.deBaja = False).ToList
            Return datos
        Else
            Dim datos = (From c In ctx.Obra_Social
                         Where c.nombre.Contains(nombre)).ToList
            Return datos
        End If
    End Function
    'Funcion que devuelve los datos de un registro
    Shared Function getInfoObraSocial(id_obra As Integer) As Obra_Social
        Dim ctx As New HospitalEntities4
        Dim obraSoc As Obra_Social = (From c In ctx.Obra_Social
                                      Where c.Id = id_obra
                                      Select c).SingleOrDefault
        Return obraSoc
    End Function
    'Funcion que permite actualizar los datos de un registro
    Shared Sub actualizarObraSoc(id_obra As Integer, nombre As String, porc As Integer)
        Dim ctx As New HospitalEntities4
        Dim obraSoc As Obra_Social = (From c In ctx.Obra_Social
                                      Where c.Id = id_obra
                                      Select c).SingleOrDefault
        'Asigna los valores pasados como parametros a la instancia
        With obraSoc
            .nombre = nombre
            .porc_cobertura = porc
        End With
        ctx.SaveChanges()
    End Sub
    'Funcion que inserta a una obraSocial nueva a la tabla de la base de datos
    Shared Sub insertarObraSocial(obra_soc As Obra_Social)
        Dim ctx As New HospitalEntities4
        ctx.Obra_Social.Add(obra_soc)
        ctx.SaveChanges()
    End Sub
    'Funcion que elimina una obra social
    Shared Sub eliminarObraSocial(id_obraSoc As Integer)
        Dim ctx As New HospitalEntities4
        Dim obraSoc As Obra_Social = (From c In ctx.Obra_Social
                                      Where c.Id = id_obraSoc
                                      Select c).SingleOrDefault
        ctx.Obra_Social.Remove(obraSoc)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "GENERO"
    Shared Function listarGeneros(nombre As String)
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Genero
                     Where c.nombre.Contains(nombre)).ToList

        Return datos
    End Function
    Shared Function getInfoGeneros(id As Integer) As Genero
        Dim ctx As New HospitalEntities4
        Dim genero As Genero = (From c In ctx.Genero
                                Where c.Id = id
                                Select c).SingleOrDefault
        Return genero
    End Function
    Shared Sub actualizarGenero(id As Integer, nombre As String)
        Dim ctx As New HospitalEntities4
        Dim genero As Genero = (From c In ctx.Genero
                                Where c.Id = id
                                Select c).SingleOrDefault
        With genero
            .nombre = nombre
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarGenero(genero As Genero)
        Dim ctx As New HospitalEntities4
        ctx.Genero.Add(genero)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarGenero(id As Integer)
        Dim ctx As New HospitalEntities4
        Dim genero As Genero = (From c In ctx.Genero
                                Where c.Id = id
                                Select c).SingleOrDefault
        ctx.Genero.Remove(genero)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "TIPO PERSONAL"
    Shared Function listarTipoPersonal(nombre As String)
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Tipo_Personal
                     Where c.nombre.Contains(nombre)).ToList

        Return datos
    End Function
    Shared Function getInfoTipoPersonal(id As Integer) As Tipo_Personal
        Dim ctx As New HospitalEntities4
        Dim tipoPersonal As Tipo_Personal = (From c In ctx.Tipo_Personal
                                             Where c.Id = id
                                             Select c).SingleOrDefault
        Return tipoPersonal
    End Function
    Shared Sub actualizarTipoPersonal(id As Integer, nombre As String)
        Dim ctx As New HospitalEntities4
        Dim tipo_personal As Tipo_Personal = (From c In ctx.Tipo_Personal
                                              Where c.Id = id
                                              Select c).SingleOrDefault
        With tipo_personal
            .nombre = nombre
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarTipoPersonal(tipo_personal As Tipo_Personal)
        Dim ctx As New HospitalEntities4
        ctx.Tipo_Personal.Add(tipo_personal)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarTipoPersonal(id As Integer)
        Dim ctx As New HospitalEntities4
        Dim tipo_personal As Tipo_Personal = (From c In ctx.Tipo_Personal
                                              Where c.Id = id
                                              Select c).SingleOrDefault
        ctx.Tipo_Personal.Remove(tipo_personal)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "TIPO USUARIO"
    Shared Function listarTipoUsuario(nombre As String)
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Tipo_Usuario
                     Where c.nombre.Contains(nombre)).ToList

        Return datos
    End Function
    Shared Function getInfoTipoUsuario(id As Integer) As Tipo_Usuario
        Dim ctx As New HospitalEntities4
        Dim tipoUsuario As Tipo_Usuario = (From c In ctx.Tipo_Usuario
                                           Where c.Id = id
                                           Select c).SingleOrDefault
        Return tipoUsuario
    End Function
    Shared Sub actualizarTipoUsuario(id As Integer, nombre As String)
        Dim ctx As New HospitalEntities4
        Dim tipoUsuario As Tipo_Usuario = (From c In ctx.Tipo_Usuario
                                           Where c.Id = id
                                           Select c).SingleOrDefault
        With tipoUsuario
            .nombre = nombre
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarTipoUsuario(tipoUsuario As Tipo_Usuario)
        Dim ctx As New HospitalEntities4
        ctx.Tipo_Usuario.Add(tipoUsuario)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarTipoUsuario(id As Integer)
        Dim ctx As New HospitalEntities4
        Dim tipoUsuario As Tipo_Usuario = (From c In ctx.Tipo_Usuario
                                           Where c.Id = id
                                           Select c).SingleOrDefault
        ctx.Tipo_Usuario.Remove(tipoUsuario)
        ctx.SaveChanges()
    End Sub
#End Region
#Region "USUARIO"
    Shared Function listarUsuario(nombre As String, valorBaja As Integer)
        Dim ctx As New HospitalEntities4
        If valorBaja = 1 Then
            Dim datos = (From c In ctx.Usuario
                         Where c.username.Contains(nombre) And c.deBaja = True).ToList
            Return datos
        ElseIf valorBaja = 0 Then
            Dim datos = (From c In ctx.Usuario
                         Where c.username.Contains(nombre) And c.deBaja = False).ToList
            Return datos
        Else
            Dim datos = (From c In ctx.Usuario
                         Where c.username.Contains(nombre)).ToList
            Return datos
        End If
    End Function
    Shared Function getInfoUsuario(dni As Long, tipo_user As Integer) As Usuario
        Dim ctx As New HospitalEntities4
        Dim user As Usuario = (From c In ctx.Usuario
                               Where c.dni = dni And c.id_tipo_usuario = tipo_user
                               Select c).SingleOrDefault
        Return user
    End Function
    Shared Sub actualizarUsuario(dni As Long, tipo_user As Integer, nombre As String, contra As String)
        Dim ctx As New HospitalEntities4
        Dim user As Usuario = (From c In ctx.Usuario
                               Where c.dni = dni And c.id_tipo_usuario = tipo_user
                               Select c).SingleOrDefault
        With user
            .id_tipo_usuario = tipo_user
            .username = nombre
            .password = contra
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarUsuario(user As Usuario)
        Dim ctx As New HospitalEntities4
        ctx.Usuario.Add(user)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarUsuario(dni As Long, tipo_user As Integer)
        Dim ctx As New HospitalEntities4
        Dim user As Usuario = (From c In ctx.Usuario
                               Where c.dni = dni And c.id_tipo_usuario = tipo_user
                               Select c).SingleOrDefault
        ctx.Usuario.Remove(user)
        ctx.SaveChanges()
    End Sub
#End Region

#Region "TURNOS"
    Shared Sub insertarTurno(turnos As turnos)
        Dim ctx As New HospitalEntities4
        ctx.turnos.Add(turnos)
        ctx.SaveChanges()
    End Sub

    Shared Function listarTurnos(valorBaja As Integer)
        Dim ctx As New HospitalEntities4
        If valorBaja = 1 Then
            Dim datos = (From c In ctx.turnos
                         Where c.deBaja = True).ToList
            Return datos
        ElseIf valorBaja = 0 Then
            Dim datos = (From c In ctx.turnos
                         Where c.deBaja = False).ToList
            Return datos
        Else
            Dim datos = (From c In ctx.turnos).ToList
            Return datos
        End If

    End Function

    Shared Sub eliminarTurno(turno_id As String)
        Dim ctx As New HospitalEntities4
        Dim turno As turnos = (From c In ctx.turnos
                               Where c.nro_turno = turno_id
                               Select c).SingleOrDefault
        ctx.turnos.Remove(turno)
        ctx.SaveChanges()
    End Sub

    Shared Function getInfoTurnos(turno_id As Integer) As turnos
        Dim ctx As New HospitalEntities4
        Dim turno As turnos = (From c In ctx.turnos
                               Where c.nro_turno = turno_id
                               Select c).SingleOrDefault
        Return turno
    End Function

    Shared Function actualizarTurno(nro_turno As Integer, fecha As String, hora As DateTime, paciente As Integer, profesional As Long, monto As Decimal, montoFinal As Decimal)
        Dim ctx As New HospitalEntities4
        Dim turno As turnos = (From c In ctx.turnos
                               Where c.nro_turno = nro_turno
                               Select c).SingleOrDefault
        With turno
            .nro_turno = nro_turno
            .fecha = fecha
            .hora = hora
            .paciente = paciente
            .profesional = profesional
            .monto = monto
            .monto_final = montoFinal
        End With
        ctx.SaveChanges()
    End Function

#End Region

#Region "COMPROBANTES"
    'Shared Sub insertarComprobante(comprobante As Comprobante_Pago)
    '    Dim ctx As New HospitalEntities4
    '    ctx.Comprobante_Pago.Add(comprobante)
    '    ctx.SaveChanges()
    'End Sub

    'Shared Function listarComprobantes(nombre As String)
    '    Dim ctx As New HospitalEntities4
    '    Dim datos = (From c In ctx.Comprobante_Pago
    '                 Where c.concepto.Contains(nombre)).ToList

    '    Return datos
    'End Function

#End Region

#Region "AGENDA"
    Shared Sub insertarHorario(horario As agenda)
        Dim ctx As New HospitalEntities4
        ctx.agenda.Add(horario)
        ctx.SaveChanges()
    End Sub

    Shared Function listarAgenda()
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.agenda).ToList
        Return datos

    End Function

    Shared Function actualizarAgenda(id_agenda As Integer, horaEntrada As TimeSpan, horaSalida As TimeSpan, dia As String, dni As Long)
        Dim ctx As New HospitalEntities4
        Dim agenda As agenda = (From c In ctx.agenda
                                Where c.id_agenda = id_agenda
                                Select c).SingleOrDefault
        With agenda
            .id_agenda = id_agenda
            .hora_entrada = horaEntrada
            .hora_salida = horaSalida
            .dia = dia
            .profesional = dni
        End With
        ctx.SaveChanges()
    End Function

#End Region

#Region "HISTORIA CLINICA"
    Shared Function listarHistoriaClinica(id_pac As Integer, dniProf As Long)
        Dim ctx As New HospitalEntities4
        Dim datos = (From c In ctx.Historia_Clinica
                     Where c.id_paciente = id_pac And c.id_profesional = dniProf Order By c.id_paciente).ToList

        Return datos
    End Function
    Shared Function getInfoHistoriaClinica(id As Integer, id_paciente As Integer) As Historia_Clinica
        Dim ctx As New HospitalEntities4
        Dim histClin As Historia_Clinica = (From c In ctx.Historia_Clinica
                                            Where c.Id = id And c.id_paciente = id_paciente
                                            Select c).SingleOrDefault
        Return histClin
    End Function
    Shared Sub actualizarHistoriaClinica(id As Integer, id_paciente As Integer, motivo_consulta As String, diagnostico As String, tratamiento As String, id_prof As Long)
        Dim ctx As New HospitalEntities4
        Dim histClin As Historia_Clinica = (From c In ctx.Historia_Clinica
                                            Where c.Id = id And c.id_paciente = id_paciente
                                            Select c).SingleOrDefault
        With histClin
            .id_paciente = id_paciente
            .motivo_consulta = motivo_consulta
            .diagnostico = diagnostico
            .tratamiento = tratamiento
            .id_profesional = id_prof
        End With
        ctx.SaveChanges()
    End Sub
    Shared Sub insertarHIstoriaClinica(histClin As Historia_Clinica)
        Dim ctx As New HospitalEntities4
        ctx.Historia_Clinica.Add(histClin)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarHistoriaClinica(id As Integer)
        Dim ctx As New HospitalEntities4
        Dim histClin As Historia_Clinica = (From c In ctx.Historia_Clinica
                                            Where c.Id = id
                                            Select c).SingleOrDefault
        ctx.Historia_Clinica.Remove(histClin)
        ctx.SaveChanges()
    End Sub
#End Region
End Class