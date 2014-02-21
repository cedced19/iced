Public Class Calcul

    Private Sub BT_CALCUL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CALCUL.Click
        If Verification() Then
            Me.LBL_COUT.Text = "Le cout du voyage sera de " & Calcul(Me.TXT_CONSOMMATION.Text, Me.TXT_NBKM.Text, Me.TXT_PRIXESS.Text) & " € "
            LBL_ERR.Hide()
        Else
            LBL_ERR.Show()
        End If
    End Sub

    ''' <summary>
    ''' Vérifie les trois textbox de la page, regarde si elles sont remplies et si des nombres ont été entrés
    ''' </summary>
    ''' <returns>Vrai si pas d'erreur, faux si une erreur</returns>
    ''' <remarks></remarks>
    Function Verification() As Boolean
        Dim Bon As Boolean = True
        If Me.TXT_CONSOMMATION.Text Is Nothing Or Not IsNumeric(Me.TXT_CONSOMMATION.Text) Then
            Bon = False
        End If
        If Me.TXT_NBKM.Text Is Nothing Or Not IsNumeric(Me.TXT_NBKM.Text) Then
            Bon = False
        End If
        If Me.TXT_PRIXESS.Text Is Nothing Or Not IsNumeric(Me.TXT_PRIXESS.Text) Then
            Bon = False
        End If
        Return Bon
    End Function

    ''' <summary>
    ''' Calcule le prix d'un voyage en fonction de la consommation, du prix de l'essence, et du nombre de kilomètres
    ''' </summary>
    ''' <param name="Consommation">Consommation</param>
    ''' <param name="NbKm">Distance parcourue</param>
    ''' <param name="PrixEss">Prix du kérosène</param>
    ''' <returns>Le coût en double</returns>
    ''' <remarks></remarks>
    Function Calcul(ByVal Consommation As Double, ByVal NbKm As Double, ByVal PrixEss As Double) As Double
        Dim Cout As Double

        Cout = ((NbKm / 100) * Consommation) * PrixEss

        Return Cout
    End Function

    Private Sub Calcul_Load(sender As Object, e As EventArgs) Handles Me.Load
        LBL_ERR.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Close()
    End Sub
End Class
