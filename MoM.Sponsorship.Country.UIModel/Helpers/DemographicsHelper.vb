Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common
Imports System.Linq

''' <summary>
''' Used for the Country Demogrphics forms
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class DemographicsHelper

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    Private Const quotaTypeCountryEnum = 1


    ' Code Table IDs
    ' none

    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(CountryFields.LANGUAGEOTHER).ValueChanged, AddressOf LanguageOther_ValueChanged
        AddHandler model.Fields(CountryFields.RELIGIONOTHER).ValueChanged, AddressOf ReligionOther_ValueChanged
        AddHandler model.Fields(CountryFields.GOVERNMENTOTHER).ValueChanged, AddressOf GovernmentOther_ValueChanged
    End Sub

    ''' <summary>
    ''' 'Initialize Code Table IDs 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeCodeTableVars()
        'Using crmSQLConnection = model.GetRequestContext().OpenAppDBConnection()

        'End Using
    End Sub

    ''' <summary>
    ''' Initialize the UI objects based on the loaded form values
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeUIDisplay()
        Toggle_LanguageOther()
        Toggle_ReligionOther()
        Toggle_GovernmentOther()
    End Sub

    Private Sub LanguageOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_LanguageOther()
    End Sub

    Private Sub ReligionOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ReligionOther()
    End Sub


    Private Sub GovernmentOther_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_GovernmentOther()
    End Sub

    Private Sub Toggle_LanguageOther()
        If model.Fields(CountryFields.LANGUAGEOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(CountryFields.LANGUAGEOTHER).ValueObject) = False Then
            model.Fields(CountryFields.LANGUAGEOTHERDESC).Visible = False
            model.Fields(CountryFields.LANGUAGEOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.LANGUAGEOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.LANGUAGEOTHERDESC).Enabled = False
                    model.Fields(CountryFields.LANGUAGEOTHERDESC).Required = False
            End Select

        Else
            model.Fields(CountryFields.LANGUAGEOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.LANGUAGEOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.LANGUAGEOTHERDESC).Enabled = True
                    model.Fields(CountryFields.LANGUAGEOTHERDESC).Required = True
            End Select
        End If
    End Sub


    Private Sub Toggle_ReligionOther()
        If model.Fields(CountryFields.RELIGIONOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(CountryFields.RELIGIONOTHER).ValueObject) = False Then
            model.Fields(CountryFields.RELIGIONOTHERDESC).Visible = False
            model.Fields(CountryFields.RELIGIONOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.RELIGIONOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.RELIGIONOTHERDESC).Enabled = False
                    model.Fields(CountryFields.RELIGIONOTHERDESC).Required = False
            End Select

        Else
            model.Fields(CountryFields.RELIGIONOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.RELIGIONOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.RELIGIONOTHERDESC).Enabled = True
                    model.Fields(CountryFields.RELIGIONOTHERDESC).Required = True
            End Select
        End If
    End Sub


    Private Sub Toggle_GovernmentOther()
        If model.Fields(CountryFields.GOVERNMENTOTHER).ValueObject Is Nothing OrElse
            CBool(model.Fields(CountryFields.GOVERNMENTOTHER).ValueObject) = False Then
            model.Fields(CountryFields.GOVERNMENTOTHERDESC).Visible = False
            model.Fields(CountryFields.GOVERNMENTOTHERDESC).ValueObject = Nothing

            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.GOVERNMENTOTHERSEPARATOR).Visible = False
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.GOVERNMENTOTHERDESC).Enabled = False
                    model.Fields(CountryFields.GOVERNMENTOTHERDESC).Required = False
            End Select

        Else
            model.Fields(CountryFields.GOVERNMENTOTHERDESC).Visible = True
            Select Case helperMode
                Case CRMHelper.FormMode.View
                    model.Fields(CountryFields.GOVERNMENTOTHERSEPARATOR).Visible = True
                Case CRMHelper.FormMode.Edit
                    model.Fields(CountryFields.GOVERNMENTOTHERDESC).Enabled = True
                    model.Fields(CountryFields.GOVERNMENTOTHERDESC).Required = True
            End Select
        End If
    End Sub

End Class


