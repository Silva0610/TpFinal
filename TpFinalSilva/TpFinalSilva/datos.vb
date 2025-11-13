Public Class datos
    Private _dni As String
    Private _nombre As String
    Private _apellido As String
    Private _password As String

    Public Property DNI As String
        Get
            Return _dni
        End Get
        Set(value As String)
            If Not IsNumeric(value) Then
                Throw New Exception("El DNI debe contener solo números.")
            End If

            If value.Length <> 8 Then
                Throw New Exception("El DNI debe tener exactamente 8 dígitos.")
            End If

            _dni = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If Not value.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
                Throw New Exception("El nombre solo puede contener letras.")
            End If

            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If Not value.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
                Throw New Exception("El apellido solo puede contener letras.")
            End If

            _apellido = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            If value.Length < 6 Then
                Throw New Exception("La contraseña debe tener al menos 6 caracteres.")
            End If

            _password = value
        End Set
    End Property

    Private _Cl As String
    Private _Id As Integer
    Private _Correo As String
    Private _tel As Integer

    Public Property Cliente As String
        Get
            Return _Cl
        End Get
        Set(value As String)
            If IsNumeric(value) Then
                Throw New Exception("ERROR DE VALIDACIÓN: Un nombre no puede contener números.")
            Else
                _Cl = value
            End If
        End Set
    End Property

    Public Property IdCl As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)

            If value <= 0 Or value > 200000 Then
                Throw New Exception("ERROR: ID de cliente inválido o fuera de rango.")
            Else
                _Id = value
            End If
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("ERROR: Ingrese un correo electrónico.")
            Else
                _Correo = value
            End If
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _tel
        End Get
        Set(value As Integer)

            If value <= 0 Then
                Throw New Exception("ERROR: Ingrese un teléfono válido.")
            Else
                _tel = value
            End If
        End Set
    End Property
End Class
