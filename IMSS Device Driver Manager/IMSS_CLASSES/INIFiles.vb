Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Text

Public Class INIFiles

    <DllImport("KERNEL32.DLL", EntryPoint:="GetPrivateProfileStringW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnString As String, ByVal nSize As Integer, ByVal lpFilename As String) As Integer
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="iniFile"></param>
    ''' <param name="category"></param>
    ''' <returns></returns>
    Public Function GetKeys(ByVal iniFile As String, ByVal category As String) As List(Of String)
        Dim returnString As New String(" "c, 32768)
        GetPrivateProfileString(category, Nothing, Nothing, returnString, 32768, iniFile)

        Dim result As New List(Of String)(returnString.Split(ControlChars.NullChar))
        result.RemoveRange(result.Count - 2, 2)
        Return result
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="iniFile"></param>
    ''' <param name="category"></param>
    ''' <param name="key"></param>
    ''' <param name="defaultValue"></param>
    ''' <returns></returns>
    Public Function GetIniFileString(ByVal iniFile As String, ByVal category As String, ByVal key As String, ByVal defaultValue As String) As String
        Dim returnString As New String(" "c, 1024)
        GetPrivateProfileString(category, key, defaultValue, returnString, 1024, iniFile)

        Return returnString.Split(ControlChars.NullChar)(0)
    End Function
End Class