[Setup]
OutputDir=E:\Instaladores Gerente\Templos
OutputBaseFilename=Setup_Templos_x86
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
Name: {app}\HC\
[Languages]
Name: portugues; MessagesFile: C:\Program Files (x86)\Inno Setup 5\Languages\BrazilianPortuguese.isl
[Files]
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\Templos.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Projetos\VBNET\ACCESS\Templos\Templos\bin\Debug\Ionic.Utils.Zip.dll; DestDir: {app}; Flags: ignoreversion
Source: Templos\bin\Debug\Microsoft.ReportViewer.Common.dll; DestDir: {app}
Source: Templos\bin\Debug\Microsoft.ReportViewer.WinForms.dll; DestDir: {app}
Source: Templos\bin\Debug\Microsoft.SqlServer.Types.dll; DestDir: {app}
Source: Templos\bin\Debug\SqlServerTypes\x64\msvcr100.dll; DestDir: {app}\SqlServerTypes\x64\
Source: Templos\bin\Debug\SqlServerTypes\x64\SqlServerSpatial110.dll; DestDir: {app}\SqlServerTypes\x64\
Source: Templos\bin\Debug\SqlServerTypes\x86\msvcr100.dll; DestDir: {app}\SqlServerTypes\x86\
Source: Templos\bin\Debug\SqlServerTypes\x86\SqlServerSpatial110.dll; DestDir: {app}\SqlServerTypes\x86\
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
Source: ..\..\..\..\Methodus\Templos\Dados\BaseSGT.accdb; DestDir: {app}\Dados\; Flags: uninsneveruninstall onlyifdoesntexist
Source: E:\Downloads\Programas\Trabalho\NetFx20SP2_x86.exe; DestDir: {app}\Tools\; Flags: onlyifdoesntexist ignoreversion; DestName: Fw20.exe
Source: E:\Downloads\Programas\Trabalho\dotnetfx35.exe; DestDir: {app}\Tools\; Flags: onlyifdoesntexist ignoreversion; DestName: Fw35.exe
;Source: E:\Downloads\Programas\Util\FoxitReader734_enu_Setup_clean.exe; DestDir: {app}\Tools\; Flags: onlyifdoesntexist ignoreversion; DestName: Lpdf.exe
Source: E:\Downloads\Programas\Trabalho\Bancos de dados\AccessDatabaseEngine.exe; DestDir: {app}\Tools\; DestName: AcDB_86.exe
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\001.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\002.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\003.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\004.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\005.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\006.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\007.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\008.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\009.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\010.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\011.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\012.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\013.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\014.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\015.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\016.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\017.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\018.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\019.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\020.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\021.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\022.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\023.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\024.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\025.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\026.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\027.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\028.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\029.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\030.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\031.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\032.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\033.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\034.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\035.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\036.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\037.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\038.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\039.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\040.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\041.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\042.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\043.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\044.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\045.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\046.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\047.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\048.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\049.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\050.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\051.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\052.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\053.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\054.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\055.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\056.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\057.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\058.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\059.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\060.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\061.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\062.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\063.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\064.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\065.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\066.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\067.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\068.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\069.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\070.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\071.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\072.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\073.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\074.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\075.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\076.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\077.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\078.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\079.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\080.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\081.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\082.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\083.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\084.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\085.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\086.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\087.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\088.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\089.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\090.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\091.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\092.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\093.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\094.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\095.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\096.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\097.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\098.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\099.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\100.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\101.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\102.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\103.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\104.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\105.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\106.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\107.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\108.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\109.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\110.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\111.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\112.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\113.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\114.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\115.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\116.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\117.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\118.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\119.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\120.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\121.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\122.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\123.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\124.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\125.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\126.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\127.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\128.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\129.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\130.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\131.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\132.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\133.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\134.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\135.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\136.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\137.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\138.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\139.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\140.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\150.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\151.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\152.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\153.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\154.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\155.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\156.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\157.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\158.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\159.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\160.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\161.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\162.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\163.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\164.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\165.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\166.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\167.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\168.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\169.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\170.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\171.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\172.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\173.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\174.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\175.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\176.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\177.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\178.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\179.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\180.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\181.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\182.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\183.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\184.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\185.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\186.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\187.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\188.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\189.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\190.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\191.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\192.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\193.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\194.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\200.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\201.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\202.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\203.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\204.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\205.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\206.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\207.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\208.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\209.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\210.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\211.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\212.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\213.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\214.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\215.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\216.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\217.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\218.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\219.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\220.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\221.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\222.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\223.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\224.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\225.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\226.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\227.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\228.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\229.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\230.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\231.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\232.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\233.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\234.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\235.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\236.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\238.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\239.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\240.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\241.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\242.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\243.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\244.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\245.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\246.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\247.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\248.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\249.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\250.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\251.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\252.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\253.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\254.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\255.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\256.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\257.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\258.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\259.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\260.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\261.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\262.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\263.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\264.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\265.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\266.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\267.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\268.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\269.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\270.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\271.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\272.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\273.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\274.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\275.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\276.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\277.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\278.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\279.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\280.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\281.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\282.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\283.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\284.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\285.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\286.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\287.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\288.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\289.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\290.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\291.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\292.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\293.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\294.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\295.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\296.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\297.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\298.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\299.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\300.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\301.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\302.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\303.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\304.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\305.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\306.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\307.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\308.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\309.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\310.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\311.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\312.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\313.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\314.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\315.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\316.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\317.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\318.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\319.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\320.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\321.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\322.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\323.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\324.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\325.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\326.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\327.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\328.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\329.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\330.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\331.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\332.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\333.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\334.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\335.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\336.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\337.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\338.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\339.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\340.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\341.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\342.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\343.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\344.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\345.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\346.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\347.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\348.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\349.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\350.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\351.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\352.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\353.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\354.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\355.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\356.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\357.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\358.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\359.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\360.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\361.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\362.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\363.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\364.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\365.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\366.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\367.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\368.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\369.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\370.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\371.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\372.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\373.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\374.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\375.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\376.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\377.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\378.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\379.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\380.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\381.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\382.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\383.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\384.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\385.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\386.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\387.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\388.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\389.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\390.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\391.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\392.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\393.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\394.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\395.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\396.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\397.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\398.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\399.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\400.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\401.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\402.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\403.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\404.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\405.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\406.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\407.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\408.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\409.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\410.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\411.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\412.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\413.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\414.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\415.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\416.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\417.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\418.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\419.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\420.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\421.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\422.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\423.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\424.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\425.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\426.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\427.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\428.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\429.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\430.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\431.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\432.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\433.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\434.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\435.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\436.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\437.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\438.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\439.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\440.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\441.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\442.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\443.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\444.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\445.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\446.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\447.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\448.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\449.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\450.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\451.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\452.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\453.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\454.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\455.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\456.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\457.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\458.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\459.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\460.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\461.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\462.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\463.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\464.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\465.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\466.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\467.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\468.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\469.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\470.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\471.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\472.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\473.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\474.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\475.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\476.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\477.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\500.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\501.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\502.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\503.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\504.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\505.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\506.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\507.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\508.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\509.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\510.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\511.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\512.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\513.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\514.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\515.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\516.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\517.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\518.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\519.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\520.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\521.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\522.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\523.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\524.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\525.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\526.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\527.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\528.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\529.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\530.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\531.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\532.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\533.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\534.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\535.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\536.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\537.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\538.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\539.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\540.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\541.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\542.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\543.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\544.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\545.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\546.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\547.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\548.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\549.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\550.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\551.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\552.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\553.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\554.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\555.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\556.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\557.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\558.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\559.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\560.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\561.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\562.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\563.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\564.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\565.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\566.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\567.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\568.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\569.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\570.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\571.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\572.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\573.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\574.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\575.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\576.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\577.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\578.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\579.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\580.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\581.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\582.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\583.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\584.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\585.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\586.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\587.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\588.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\589.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\590.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\591.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\592.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\593.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\594.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\595.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\598.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\599.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\600.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\601.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\602.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\603.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\604.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\605.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\606.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\607.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\650.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\651.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\652.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\653.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\659.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\660.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\662.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\677.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\713.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\727.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\728.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\M�sicas\GOSPEL\HINOS E C�NTICOS PPT\764.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
[Tasks]
Name: InstalarFW2; Description: Instalar Framework 2.0; Check: fw2Exists
Name: InstalarFW35; Description: Instalar Framework 3.5; Check: fw35Exists
Name: InstalarPdf; Description: Instalar Leitor PDF; Check: PDFExists
[Run]
Filename: {app}\Tools\Fw20.exe; Flags: skipifdoesntexist; StatusMsg: Instalando Framework 2.0. Aguarde...; Parameters: /q; Tasks: InstalarFW2
Filename: {app}\Tools\Fw35.exe; Flags: skipifdoesntexist; StatusMsg: Instalando Framework 3.5. Aguarde...; Parameters: /q; Tasks: InstalarFW35
Filename: {app}\Tools\Lpdf.exe; Flags: skipifdoesntexist; StatusMsg: Instalando Leitor PDF Aguarde...; Parameters: /q; Tasks: InstalarPdf
Filename: {app}\Templos.exe; WorkingDir: {app}; Flags: postinstall runmaximized

[Code]
function fw2Exists(): Boolean;

begin
  if RegKeyExists(HKLM,'SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727') = false then
  begin
     Result :=   true;
  end else
  begin
      Result := false;
  end;
end;


function fw35Exists(): Boolean;

begin
  if RegKeyExists(HKLM,'SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5') = false then
  begin
     Result :=   true;
  end else
  begin
      Result := false;
  end;
end;

function PDFExists(): Boolean;

begin
  if RegKeyExists(HKLM,'SOFTWARE\Foxit Software\Foxit Reader') = false then
  begin
     Result :=   true;
  end else
  begin
      Result := false;
  end;
end;
