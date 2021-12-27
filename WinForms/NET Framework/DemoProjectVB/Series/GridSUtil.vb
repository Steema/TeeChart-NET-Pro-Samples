
Imports System
Imports System.Drawing
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles

    Public Class Grid3DUtils


        Private Sub New()
        End Sub 'New

        Private Shared Function ClosestValue(ByVal src As TeeChart.Styles.Custom3D, ByVal x As Double, ByVal z As Double) As Double

            Dim maxdist As Double = 1.0E+300
            Dim closer As Integer = -1
            Dim tmpx As Double
            Dim tmpz As Double
            Dim dist As Double
            Dim i As Integer = 0
            Do While (i < src.Count)
                tmpx = (src.XValues(i) - x)
                tmpz = (src.ZValues(i) - z)
                dist = Math.Sqrt(((tmpx * tmpx) _
                                + (tmpz * tmpz)))
                If (dist < maxdist) Then
                    maxdist = dist
                    closer = i
                End If
                i = (i + 1)
            Loop
            If (closer = -1) Then
                Return 0
            Else
                Return src.YValues(closer)
            End If
        End Function 'ClosestValue

        Public Shared Sub CreateGrid(ByVal src As TeeChart.Styles.Custom3D, ByVal dst As TeeChart.Styles.Custom3DGrid, ByVal gridsize As Integer)
            Dim tmpminx As Double = src.XValues.Minimum
            Dim tmpminz As Double = src.ZValues.Minimum
            Dim tmpxfact As Double = src.XValues.Range / System.Convert.ToDouble(gridsize)
            Dim tmpzfact As Double = src.ZValues.Range / System.Convert.ToDouble(gridsize)
            Dim tmpx, tmpz, tmpy As Double
            Dim iindex As Integer

            dst.BeginUpdate()
            Try
                dst.Clear()
                dst.IrregularGrid = True
                dst.NumXValues = gridsize
                dst.NumZValues = gridsize

                ' loop all grid cells
                Dim x As Integer
                For x = 1 To dst.NumXValues
                    tmpx = tmpminx + (x - 1) * tmpxfact
                    Dim z As Integer
                    For z = 1 To dst.NumZValues
                        tmpz = tmpminz + (z - 1) * tmpzfact
                        tmpy = ClosestValue(src, tmpx, tmpz)
                        iindex = dst(x, z)
                        If iindex <> -1 Then
                            dst.YValues.Value(iindex) = tmpy
                            dst.XValues.Value(iindex) = tmpx
                            dst.ZValues.Value(iindex) = tmpz
                        Else
                            dst(x, z) = dst.Add(tmpx, tmpy, tmpz)
                        End If
                    Next z
                Next x
            Finally
                dst.EndUpdate()
            End Try
        End Sub 'CreateGrid

        Public Shared Sub SmoothGrid(ByVal series As TeeChart.Styles.Custom3DGrid)
            Dim tmpx, tmpz, tmpy As Double
            series.BeginUpdate()
            Try
                series.IrregularGrid = True
                Dim tmpnumx As Integer = series.NumXValues
                Dim tmpnumz As Integer = series.NumZValues
                Dim x As Integer = 1
                Dim z As Integer = 1
                Do While (x < tmpnumx)
                    z = 1
                    Do While (z < tmpnumz)
                        tmpx = (0.5 _
                                    * (series.XValues.Value(series(x, z)) + series.XValues.Value(series((x + 1), z))))
                        tmpz = (0.5 _
                                    * (series.ZValues.Value(series(x, z)) + series.ZValues.Value(series(x, (z + 1)))))
                        tmpy = (0.25 _
                                    * ((2 * series.YValues.Value(series(x, z))) _
                                    + (series.YValues.Value(series((x + 1), z)) + series.YValues.Value(series(x, (z + 1))))))
                        series.Add(tmpx, tmpy, tmpz)
                        series.Add(series.XValues.Value(series(x, z)), (0.5 _
                                        * (series.YValues.Value(series(x, z)) + series.YValues.Value(series(x, (z + 1))))), tmpz)
                        series.Add(tmpx, (0.5 _
                                        * (series.YValues.Value(series(x, z)) + series.YValues.Value(series((x + 1), z)))), series.ZValues.Value(series(x, z)))
                        z = (z + 1)
                    Loop
                    series.Add((0.5 _
                                    * (series.XValues.Value(series(x, tmpnumz)) + series.XValues.Value(series((x + 1), tmpnumz)))), (0.5 _
                                    * (series.YValues.Value(series(x, tmpnumz)) + series.YValues.Value(series((x + 1), tmpnumz)))), series.ZValues.Value(series(x, tmpnumz)))
                    x = (x + 1)
                Loop
                z = 1
                Do While (z < tmpnumz)
                    series.Add(series.XValues.Value(series(tmpnumx, z)), (0.5 _
                                    * (series.YValues.Value(series(tmpnumx, z)) + series.YValues.Value(series(tmpnumx, (z + 1))))), (0.5 _
                                    * (series.ZValues.Value(series(tmpnumx, z)) + series.ZValues.Value(series(tmpnumx, (z + 1))))))
                    z = (z + 1)
                Loop
            Finally
                series.EndUpdate()
                series.Repaint()
            End Try
        End Sub 'SmoothGrid
    End Class 'Grid3DUtils