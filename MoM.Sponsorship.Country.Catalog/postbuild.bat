echo copy catalog assembly to local bin and release folders...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.Catalog\bin\Release\MoM.Sponsorship.Country.Catalog.dll" "C:\Program Files\Blackbaud\bbappfx\vroot\bin\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.Country\MoM.Sponsorship.Country.UIModel\bin\Release\MoM.Sponsorship.Country.UIModel.dll" "C:\MissionOfMercy\CRM\Releases\DEV\Catalog Assemblies" /y /d

echo.