Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace CustomDateTimeMeasureUnitsCalcuslatorSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = GenerateData(10000)
        End Sub

        Private Function GenerateData(ByVal count As Integer) As List(Of DataPoint)
            Dim points As New List(Of DataPoint)(count)
            Dim time As Date = Date.Now
            Dim generator As New Random()
            For i As Integer = 0 To count - 1
                time = time.AddHours(1)
                points.Add(New DataPoint With {.X = time, .Y = generator.NextDouble()})
            Next i
            Return points
        End Function
    End Class

    Public Class DataPoint
        Public Property X() As Date
        Public Property Y() As Double
    End Class
End Namespace
