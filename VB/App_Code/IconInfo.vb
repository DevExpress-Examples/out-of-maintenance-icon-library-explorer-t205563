Imports System

Public Class IconInfo
    Private _category As String
    Private _size As String
    Private _collection As String
    Private _name As String
    Private _fullIconID As String
    Private _enumName As String

    Public Sub New(ByVal category As String, ByVal size As String, ByVal collection As String, ByVal name As String, ByVal fullIconID As String, ByVal enumName As String)
        Me._category = category
        Me._size = size
        Me._collection = collection
        Me._name = name
        Me._fullIconID = fullIconID
        Me._enumName = enumName
    End Sub
    Public Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Public Property Size() As String
        Get
            Return _size
        End Get
        Set(ByVal value As String)
            _size = value
        End Set
    End Property
    Public Property Collection() As String
        Get
            Return _collection
        End Get
        Set(ByVal value As String)
            _collection = value
        End Set
    End Property
    Public Property IconName() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property FullIconID() As String
        Get
            Return _fullIconID
        End Get
        Set(ByVal value As String)
            _fullIconID = value
        End Set
    End Property
    Public Property EnumName() As String
        Get
            Return _enumName
        End Get
        Set(ByVal value As String)
            _enumName = value
        End Set
    End Property
End Class

