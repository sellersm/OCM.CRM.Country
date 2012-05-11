Imports Blackbaud.AppFx
Imports Blackbaud.AppFx.UIModeling.Core
Imports MoM.Common
Imports System.Linq

''' <summary>
''' Used for the Country Quota forms
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class QuotaHelper

    Private Property model As UIModeling.Core.RootUIModel = Nothing

    Property helperMode As CRMHelper.FormMode       'Used for specific behavior for view form vs edit form

    Private Const quotaTypeCountryEnum = 1


    ' Code Table IDs
    ' none

    Public Sub New(ByVal uiModel As UIModeling.Core.RootUIModel, ByVal mode As CRMHelper.FormMode)
        model = uiModel
        helperMode = mode

        'Add all the handlers
        AddHandler model.Fields(CountryFields.QUOTATYPECODE).ValueChanged, AddressOf QuotaType_ValueChanged
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
        Toggle_ApprovedQuotaFields()
    End Sub

    Private Sub QuotaType_ValueChanged(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs)
        Toggle_ApprovedQuotaFields()
    End Sub

    ''' <summary>
    ''' Toggle the quota fields based on the type of quota
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Toggle_ApprovedQuotaFields()
        Dim countryQuota As Boolean = False     ' Used to determine if we are hiding/disabling the fields

        ' This includes blank and project quota - basically not Country quota
        countryQuota = (model.Fields(CountryFields.QUOTATYPECODE).ValueObject IsNot Nothing AndAlso
                       CInt(model.Fields(CountryFields.QUOTATYPECODE).ValueObject) = quotaTypeCountryEnum)


        ' Hide or show all the APPROVEDQUOTA... fields
        Dim genericList As List(Of UIField) = _model.Fields.ToList()
        Dim fieldsList = (From f In genericList Where f.Name.Contains("APPROVEDQUOTA")
                          Select f)
        For Each field As UIField In fieldsList
            Select Case helperMode
                Case CRMHelper.FormMode.Edit, CRMHelper.FormMode.Add
                    field.Enabled = countryQuota
                    If Not countryQuota Then
                        field.ValueObject = Nothing
                    End If
                Case CRMHelper.FormMode.View
                    field.Visible = countryQuota
            End Select
        Next

        ' These computed columns are only on the view form and should be visible only if the quota type is project.
        If helperMode = CRMHelper.FormMode.View Then
            model.Fields(CountryFields.CURRENTQUOTA).Visible = countryQuota
            model.Fields(CountryFields.DECREASEDQUOTA).Visible = countryQuota
            model.Fields(CountryFields.GROWTHQUOTA).Visible = countryQuota
        End If

    End Sub



End Class

