[Setup]
OutputDir=D:\Instaladores Gerente\Templos
OutputBaseFilename=Update_Templos_x86
AppCopyright=Methodus Tecnologia (Sistema Gratuito)
AppName=Methodus Templos
AppVerName=1.0.27
DefaultDirName=C:\Methodus\Templos\
DefaultGroupName=Methodus Tecnologia e Sistemas
VersionInfoVersion=1.0.19
VersionInfoCompany=Methodus Tecnologia e Sistemas
VersionInfoDescription=Sistema de gerenciamento de templos
VersionInfoCopyright=Sistema Gratuito
VersionInfoProductName=Methodus Templo
VersionInfoProductVersion=1.0.19
SetupIconFile=C:\Projetos\VBNET\ACCESS\Templos\Templos\SGT.ico
InfoAfterFile=C:\Projetos\VBNET\ACCESS\Templos\Leiame.rtf
WindowVisible=false
[Icons]
Name: {group}\Methodus Templos; Filename: {app}\Templos.exe; WorkingDir: {app}; IconIndex: 0
Name: {userdesktop}\Methodus Templos; Filename: {app}\Templos.exe; WorkingDir: {app}; IconIndex: 0
[Dirs]
Name: {app}\Relatorios\
[Languages]
Name: portugues; MessagesFile: C:\Program Files (x86)\Inno Setup 5\Languages\BrazilianPortuguese.isl
[Files]
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\Templos.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\Ionic.Utils.Zip.dll; DestDir: {app}; Flags: ignoreversion
Source: ..\..\CS\GERENTE\packages\Microsoft.ReportViewer.Windows.11.0.3452\lib\net40\Microsoft.ReportViewer.Common.dll; DestDir: {app}
Source: ..\..\CS\GERENTE\packages\Microsoft.ReportViewer.Windows.11.0.3452\lib\net40\Microsoft.ReportViewer.DataVisualization.DLL; DestDir: {app}
Source: ..\..\CS\GERENTE\packages\Microsoft.ReportViewer.Windows.11.0.3452\lib\net40\Microsoft.ReportViewer.ProcessingObjectModel.DLL; DestDir: {app}
Source: ..\..\CS\GERENTE\packages\Microsoft.ReportViewer.Windows.11.0.3452\lib\net40\Microsoft.ReportViewer.WinForms.DLL; DestDir: {app}
Source: ..\..\CS\GERENTE\packages\Microsoft.SqlServer.Types.11.0.2\lib\net20\Microsoft.SqlServer.Types.dll; DestDir: {app}
Source: ..\..\CS\GERENTE\GERENTE\bin\Debug\SqlServerTypes\x64\msvcr100.dll; DestDir: {app}\SqlServerTypes\x64\
Source: ..\..\CS\GERENTE\GERENTE\bin\Debug\SqlServerTypes\x64\SqlServerSpatial110.dll; DestDir: {app}\SqlServerTypes\x64\
Source: ..\..\CS\GERENTE\GERENTE\bin\Debug\SqlServerTypes\x86\msvcr100.dll; DestDir: {app}\SqlServerTypes\x86\
Source: ..\..\CS\GERENTE\GERENTE\bin\Debug\SqlServerTypes\x86\SqlServerSpatial110.dll; DestDir: {app}\SqlServerTypes\x86\
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_Chamadas.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_Chamada_Det1.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_Chamada_Det2.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_Chamada_Det3.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD_Det0.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD_Det1.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD_Det2.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD_Det3.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_EBD_Det4.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\CA\Relatorios\Rpt_Pessoas.rdlc; DestDir: {app}\CA\Relatorios\; Flags: ignoreversion
[Run]
Filename: {app}\Templos.exe; WorkingDir: {app}; Flags: postinstall runmaximized

