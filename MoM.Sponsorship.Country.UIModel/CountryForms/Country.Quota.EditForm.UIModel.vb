Public Class CountryQuotaEditFormUIModel

    Private Sub CountryQuotaEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Dim myQuotaHelper As New QuotaHelper(Me, MoM.Common.CRMHelper.FormMode.Edit)
        myQuotaHelper.InitializeCodeTableVars()
        myQuotaHelper.InitializeUIDisplay()
    End Sub

End Class