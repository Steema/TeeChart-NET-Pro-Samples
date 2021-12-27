
Imports System
Imports Steema.TeeChart



Public Class TeeSmoothGrid3D
    
    Public Shared Sub SmoothGrid3D(Series As Steema.TeeChart.Styles.Custom3DGrid)
        Dim tmpX, tmpY, tmpZ As Double
        Dim tmpNumX As Integer = Series.NumXValues
        Dim tmpNumZ As Integer = Series.NumZValues
        
        Series.BeginUpdate()
        Series.IrregularGrid = True
        
        Dim x As Integer
        Dim z As Integer
        For x = 1 To tmpNumX - 1
            For z = 1 To tmpNumZ - 1
                tmpX = (Series.XValues(Series(x, z)) + Series.XValues(Series(x + 1, z))) * 0.5
                tmpZ = (Series.ZValues(Series(x, z)) + Series.ZValues(Series(x, z + 1))) * 0.5
              
                
                tmpY = (Series.YValues(Series(x, z)) + Series.YValues(Series(x + 1, z)) + Series.YValues(Series(x, z)) + Series.YValues(Series(x, z + 1))) * 0.25
               
                
                Series.Add(tmpX, tmpY, tmpZ)
                
                Series.Add(Series.XValues(Series(x, z)), (Series.YValues(Series(x, z)) + Series.YValues(Series(x, z + 1))) * 0.5, tmpZ)
           
                
                Series.Add(tmpX, (Series.YValues(Series(x, z)) + Series.YValues(Series(x + 1, z))) * 0.5, Series.ZValues(Series(x, z)))
            Next z
            Series.Add((Series.XValues(Series(x, tmpNumZ)) + Series.XValues(Series(x + 1, tmpNumZ))) * 0.5, (Series.YValues(Series(x, tmpNumZ)) + Series.YValues(Series(x + 1, tmpNumZ))) * 0.5, Series.ZValues(Series(x, tmpNumZ)))
        Next x

        For z = 1 To tmpNumZ - 1
            Series.Add(Series.XValues(Series(tmpNumX, z)), (Series.YValues(Series(tmpNumX, z)) + Series.YValues(Series(tmpNumX, z + 1))) * 0.5, (Series.ZValues(Series(tmpNumX, z)) + Series.ZValues(Series(tmpNumX, z + 1))) * 0.5)
        Next z

        Series.EndUpdate()
        Series.Repaint()
    End Sub 'SmoothGrid3D
End Class 'TeeSmoothGrid3D