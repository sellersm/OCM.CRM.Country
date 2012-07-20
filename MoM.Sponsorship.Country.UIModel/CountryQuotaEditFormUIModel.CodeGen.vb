﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.93.2034.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Country Quota Edit Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "acb9e3c3-e5f0-40e5-9349-4ce6321f90d1", "f29fddda-7ff0-4f95-96d9-59f0582f58cc", "Country Extension")> _
Partial Public Class [CountryQuotaEditFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Enums"

    ''' <summary>
    ''' Enumerated values for use with the QUOTATYPECODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Enum QUOTATYPECODES As Integer
        [ProjectQuota] = 0
        [CountryQuota] = 1
    End Enum

    ''' <summary>
    ''' Enumerated values for use with the NEWCHILDRENSTATUSCODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Enum NEWCHILDRENSTATUSCODES As Integer
        [No] = 0
        [Yes] = 1
    End Enum

    ''' <summary>
    ''' Enumerated values for use with the MARKETINGDEMANDSTATUSCODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Enum MARKETINGDEMANDSTATUSCODES As Integer
        [No] = 0
        [Yes] = 1
    End Enum

    ''' <summary>
    ''' Enumerated values for use with the OVERRIDETRIGGERSTATUSCODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Enum OVERRIDETRIGGERSTATUSCODES As Integer
        [No] = 0
        [Yes] = 1
    End Enum

#End Region

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _quotatypecode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of QUOTATYPECODES))
    Private WithEvents _approvedquotainitial As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota01oct As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota02nov As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota03dec As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota04jan As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota05feb As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota06mar As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota07apr As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota08may As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota09jun As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota10jul As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota11aug As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _approvedquota12sep As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
    Private WithEvents _newchildrenstatuscode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of NEWCHILDRENSTATUSCODES))
    Private WithEvents _performancecodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _marketingdemandstatuscode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of MARKETINGDEMANDSTATUSCODES))
    Private WithEvents _overridetriggerstatuscode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OVERRIDETRIGGERSTATUSCODES))
    Private WithEvents _childrennotentered As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public Sub New()
        MyBase.New()

        _quotatypecode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of QUOTATYPECODES))
        _approvedquotainitial = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota01oct = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota02nov = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota03dec = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota04jan = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota05feb = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota06mar = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota07apr = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota08may = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota09jun = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota10jul = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota11aug = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _approvedquota12sep = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        _newchildrenstatuscode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of NEWCHILDRENSTATUSCODES))
        _performancecodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _marketingdemandstatuscode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of MARKETINGDEMANDSTATUSCODES))
        _overridetriggerstatuscode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OVERRIDETRIGGERSTATUSCODES))
        _childrennotentered = New Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New Guid("acb9e3c3-e5f0-40e5-9349-4ce6321f90d1")
        MyBase.DataFormInstanceId = New Guid("f29fddda-7ff0-4f95-96d9-59f0582f58cc")
        MyBase.RecordType = "Country Extension"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/Country.Quota.EditForm.html"

        '
        '_quotatypecode
        '
        _quotatypecode.Name = "QUOTATYPECODE"
        _quotatypecode.Caption = "Quota type"
        _quotatypecode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of QUOTATYPECODES)) With {.Value = QUOTATYPECODES.[ProjectQuota], .Translation = "Project quota"})
        _quotatypecode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of QUOTATYPECODES)) With {.Value = QUOTATYPECODES.[CountryQuota], .Translation = "Country quota"})
        Me.Fields.Add(_quotatypecode)
        '
        '_approvedquotainitial
        '
        _approvedquotainitial.Name = "APPROVEDQUOTAINITIAL"
        _approvedquotainitial.Caption = "Initial quota"
        Me.Fields.Add(_approvedquotainitial)
        '
        '_approvedquota01oct
        '
        _approvedquota01oct.Name = "APPROVEDQUOTA01OCT"
        _approvedquota01oct.Caption = "01 - October"
        Me.Fields.Add(_approvedquota01oct)
        '
        '_approvedquota02nov
        '
        _approvedquota02nov.Name = "APPROVEDQUOTA02NOV"
        _approvedquota02nov.Caption = "02 - November"
        Me.Fields.Add(_approvedquota02nov)
        '
        '_approvedquota03dec
        '
        _approvedquota03dec.Name = "APPROVEDQUOTA03DEC"
        _approvedquota03dec.Caption = "03 - December"
        Me.Fields.Add(_approvedquota03dec)
        '
        '_approvedquota04jan
        '
        _approvedquota04jan.Name = "APPROVEDQUOTA04JAN"
        _approvedquota04jan.Caption = "04 - January"
        Me.Fields.Add(_approvedquota04jan)
        '
        '_approvedquota05feb
        '
        _approvedquota05feb.Name = "APPROVEDQUOTA05FEB"
        _approvedquota05feb.Caption = "05 - February"
        Me.Fields.Add(_approvedquota05feb)
        '
        '_approvedquota06mar
        '
        _approvedquota06mar.Name = "APPROVEDQUOTA06MAR"
        _approvedquota06mar.Caption = "06 - March"
        Me.Fields.Add(_approvedquota06mar)
        '
        '_approvedquota07apr
        '
        _approvedquota07apr.Name = "APPROVEDQUOTA07APR"
        _approvedquota07apr.Caption = "07 - April"
        Me.Fields.Add(_approvedquota07apr)
        '
        '_approvedquota08may
        '
        _approvedquota08may.Name = "APPROVEDQUOTA08MAY"
        _approvedquota08may.Caption = "08 - May"
        Me.Fields.Add(_approvedquota08may)
        '
        '_approvedquota09jun
        '
        _approvedquota09jun.Name = "APPROVEDQUOTA09JUN"
        _approvedquota09jun.Caption = "09 - June"
        Me.Fields.Add(_approvedquota09jun)
        '
        '_approvedquota10jul
        '
        _approvedquota10jul.Name = "APPROVEDQUOTA10JUL"
        _approvedquota10jul.Caption = "10 - July"
        Me.Fields.Add(_approvedquota10jul)
        '
        '_approvedquota11aug
        '
        _approvedquota11aug.Name = "APPROVEDQUOTA11AUG"
        _approvedquota11aug.Caption = "11 - August"
        Me.Fields.Add(_approvedquota11aug)
        '
        '_approvedquota12sep
        '
        _approvedquota12sep.Name = "APPROVEDQUOTA12SEP"
        _approvedquota12sep.Caption = "12 - September"
        Me.Fields.Add(_approvedquota12sep)
        '
        '_newchildrenstatuscode
        '
        _newchildrenstatuscode.Name = "NEWCHILDRENSTATUSCODE"
        _newchildrenstatuscode.Caption = "New children status"
        _newchildrenstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of NEWCHILDRENSTATUSCODES)) With {.Value = NEWCHILDRENSTATUSCODES.[No], .Translation = "No"})
        _newchildrenstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of NEWCHILDRENSTATUSCODES)) With {.Value = NEWCHILDRENSTATUSCODES.[Yes], .Translation = "Yes"})
        Me.Fields.Add(_newchildrenstatuscode)
        '
        '_performancecodeid
        '
        _performancecodeid.Name = "PERFORMANCECODEID"
        _performancecodeid.Caption = "Performance"
        _performancecodeid.CodeTableName = "USR_CHILDPROJECTCOUNTRYPERFORMANCECODE"
        Me.Fields.Add(_performancecodeid)
        '
        '_marketingdemandstatuscode
        '
        _marketingdemandstatuscode.Name = "MARKETINGDEMANDSTATUSCODE"
        _marketingdemandstatuscode.Caption = "Marketing demand status"
        _marketingdemandstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of MARKETINGDEMANDSTATUSCODES)) With {.Value = MARKETINGDEMANDSTATUSCODES.[No], .Translation = "No"})
        _marketingdemandstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of MARKETINGDEMANDSTATUSCODES)) With {.Value = MARKETINGDEMANDSTATUSCODES.[Yes], .Translation = "Yes"})
        Me.Fields.Add(_marketingdemandstatuscode)
        '
        '_overridetriggerstatuscode
        '
        _overridetriggerstatuscode.Name = "OVERRIDETRIGGERSTATUSCODE"
        _overridetriggerstatuscode.Caption = "Override trigger status"
        _overridetriggerstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of OVERRIDETRIGGERSTATUSCODES)) With {.Value = OVERRIDETRIGGERSTATUSCODES.[No], .Translation = "No"})
        _overridetriggerstatuscode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of OVERRIDETRIGGERSTATUSCODES)) With {.Value = OVERRIDETRIGGERSTATUSCODES.[Yes], .Translation = "Yes"})
        Me.Fields.Add(_overridetriggerstatuscode)
        '
        '_childrennotentered
        '
        _childrennotentered.Name = "CHILDRENNOTENTERED"
        _childrennotentered.Caption = "Children not entered"
        Me.Fields.Add(_childrennotentered)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Quota type
    ''' </summary>
    <System.ComponentModel.Description("Quota type")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [QUOTATYPECODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of QUOTATYPECODES))
        Get
            Return _quotatypecode
        End Get
    End Property
    
    ''' <summary>
    ''' Initial quota
    ''' </summary>
    <System.ComponentModel.Description("Initial quota")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTAINITIAL]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquotainitial
        End Get
    End Property
    
    ''' <summary>
    ''' 01 - October
    ''' </summary>
    <System.ComponentModel.Description("01 - October")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA01OCT]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota01oct
        End Get
    End Property
    
    ''' <summary>
    ''' 02 - November
    ''' </summary>
    <System.ComponentModel.Description("02 - November")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA02NOV]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota02nov
        End Get
    End Property
    
    ''' <summary>
    ''' 03 - December
    ''' </summary>
    <System.ComponentModel.Description("03 - December")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA03DEC]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota03dec
        End Get
    End Property
    
    ''' <summary>
    ''' 04 - January
    ''' </summary>
    <System.ComponentModel.Description("04 - January")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA04JAN]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota04jan
        End Get
    End Property
    
    ''' <summary>
    ''' 05 - February
    ''' </summary>
    <System.ComponentModel.Description("05 - February")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA05FEB]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota05feb
        End Get
    End Property
    
    ''' <summary>
    ''' 06 - March
    ''' </summary>
    <System.ComponentModel.Description("06 - March")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA06MAR]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota06mar
        End Get
    End Property
    
    ''' <summary>
    ''' 07 - April
    ''' </summary>
    <System.ComponentModel.Description("07 - April")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA07APR]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota07apr
        End Get
    End Property
    
    ''' <summary>
    ''' 08 - May
    ''' </summary>
    <System.ComponentModel.Description("08 - May")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA08MAY]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota08may
        End Get
    End Property
    
    ''' <summary>
    ''' 09 - June
    ''' </summary>
    <System.ComponentModel.Description("09 - June")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA09JUN]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota09jun
        End Get
    End Property
    
    ''' <summary>
    ''' 10 - July
    ''' </summary>
    <System.ComponentModel.Description("10 - July")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA10JUL]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota10jul
        End Get
    End Property
    
    ''' <summary>
    ''' 11 - August
    ''' </summary>
    <System.ComponentModel.Description("11 - August")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA11AUG]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota11aug
        End Get
    End Property
    
    ''' <summary>
    ''' 12 - September
    ''' </summary>
    <System.ComponentModel.Description("12 - September")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [APPROVEDQUOTA12SEP]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _approvedquota12sep
        End Get
    End Property
    
    ''' <summary>
    ''' New children status
    ''' </summary>
    <System.ComponentModel.Description("New children status")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [NEWCHILDRENSTATUSCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of NEWCHILDRENSTATUSCODES))
        Get
            Return _newchildrenstatuscode
        End Get
    End Property
    
    ''' <summary>
    ''' Performance
    ''' </summary>
    <System.ComponentModel.Description("Performance")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [PERFORMANCECODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _performancecodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Marketing demand status
    ''' </summary>
    <System.ComponentModel.Description("Marketing demand status")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [MARKETINGDEMANDSTATUSCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of MARKETINGDEMANDSTATUSCODES))
        Get
            Return _marketingdemandstatuscode
        End Get
    End Property
    
    ''' <summary>
    ''' Override trigger status
    ''' </summary>
    <System.ComponentModel.Description("Override trigger status")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [OVERRIDETRIGGERSTATUSCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OVERRIDETRIGGERSTATUSCODES))
        Get
            Return _overridetriggerstatuscode
        End Get
    End Property
    
    ''' <summary>
    ''' Children not entered
    ''' </summary>
    <System.ComponentModel.Description("Children not entered")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.2034.0")> _
    Public ReadOnly Property [CHILDRENNOTENTERED]() As Global.Blackbaud.AppFx.UIModeling.Core.SmallIntField
        Get
            Return _childrennotentered
        End Get
    End Property
    
End Class
