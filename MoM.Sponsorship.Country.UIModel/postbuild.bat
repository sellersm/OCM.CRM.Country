echo copy uimodel assembly to local bin and release folders...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\bin\Release\MoM.Sponsorship.Country.UIModel.dll" "C:\Program Files\Blackbaud\bbappfx\vroot\bin\custom" /y /d

echo.
echo copy all htmlforms to the appropriate location on the webserver...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.Demographics.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.OtherInfo.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.Quota.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.Demographics.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.OtherInfo.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.Quota.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.ExtensionSummary.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\CountryForms\Country.UIModelVersion.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d

rem echo minify the html and js files to optimize their payload on the wire
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.html /pre
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.js

