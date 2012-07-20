Public Class CountryDemographicsEditFormUIModel

    Private Sub CountryDemographicsEditFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded        
        Dim myDemographicsHelper As New DemographicsHelper(Me, MoM.Common.CRMHelper.FormMode.Edit)
        myDemographicsHelper.InitializeCodeTableVars()
        myDemographicsHelper.InitializeUIDisplay()
    End Sub

End Class