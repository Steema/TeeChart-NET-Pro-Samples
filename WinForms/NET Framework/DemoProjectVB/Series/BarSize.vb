Imports System
Imports System.Drawing
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles

'Namespace Steema.TeeChart.Samples

    ''' <summary>
    ''' Summary description for BarSize.
    ''' </summary>
    Public Class BarSize
        Inherits Bar

        Private ISize As Integer
        Private ISizeValues As ValueList

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal c As Chart)
            MyBase.New(c)
            ISizeValues = New ValueList(Me, "xSize")
        End Sub

        Public Property SizeValues() As ValueList
            Get
                Return ISizeValues
            End Get
            Set(ByVal Value As ValueList)
                SetValueList(ISizeValues, Value)
            End Set
        End Property

        Private Sub InternalCalcBarSize(ByVal valueIndex As Integer)
            If (ISizeValues(valueIndex) = 0) Then
                IBarSize = ISize
            Else 
                IBarSize = GetHorizAxis.CalcSizeValue(ISizeValues(valueIndex))
            End If
        End Sub

        Protected Overrides Function InternalClicked(ByVal valueIndex As Integer, ByVal p As Point) As Boolean
            InternalCalcBarSize(valueIndex)
            Return MyBase.InternalClicked(valueIndex, p)
        End Function

        Public Overrides Sub DrawValue(ByVal valueIndex As Integer)
            If (valueIndex = firstVisible) Then
                ISize = IBarSize
            End If
            InternalCalcBarSize(valueIndex)
            ' Call default Bar drawing method.
            MyBase.DrawValue(valueIndex)
        End Sub
    End Class
    'End Namespace