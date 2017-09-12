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
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\001.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\002.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\003.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\004.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\005.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\006.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\007.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\008.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\009.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\010.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\011.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\012.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\013.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\014.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\015.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\016.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\017.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\018.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\019.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\020.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\021.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\022.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\023.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\024.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\025.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\026.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\027.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\028.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\029.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\030.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\031.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\032.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\033.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\034.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\035.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\036.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\037.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\038.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\039.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\040.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\041.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\042.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\043.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\044.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\045.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\046.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\047.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\048.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\049.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\050.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\051.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\052.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\053.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\054.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\055.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\056.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\057.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\058.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\059.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\060.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\061.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\062.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\063.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\064.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\065.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\066.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\067.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\068.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\069.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\070.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\071.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\072.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\073.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\074.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\075.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\076.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\077.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\078.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\079.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\080.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\081.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\082.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\083.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\084.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\085.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\086.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\087.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\088.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\089.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\090.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\091.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\092.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\093.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\094.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\095.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\096.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\097.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\098.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\099.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\100.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\101.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\102.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\103.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\104.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\105.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\106.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\107.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\108.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\109.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\110.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\111.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\112.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\113.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\114.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\115.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\116.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\117.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\118.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\119.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\120.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\121.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\122.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\123.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\124.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\125.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\126.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\127.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\128.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\129.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\130.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\131.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\132.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\133.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\134.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\135.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\136.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\137.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\138.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\139.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\140.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\150.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\151.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\152.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\153.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\154.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\155.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\156.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\157.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\158.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\159.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\160.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\161.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\162.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\163.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\164.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\165.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\166.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\167.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\168.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\169.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\170.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\171.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\172.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\173.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\174.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\175.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\176.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\177.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\178.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\179.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\180.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\181.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\182.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\183.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\184.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\185.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\186.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\187.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\188.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\189.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\190.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\191.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\192.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\193.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\194.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\200.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\201.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\202.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\203.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\204.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\205.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\206.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\207.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\208.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\209.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\210.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\211.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\212.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\213.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\214.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\215.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\216.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\217.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\218.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\219.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\220.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\221.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\222.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\223.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\224.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\225.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\226.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\227.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\228.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\229.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\230.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\231.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\232.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\233.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\234.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\235.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\236.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\238.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\239.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\240.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\241.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\242.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\243.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\244.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\245.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\246.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\247.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\248.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\249.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\250.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\251.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\252.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\253.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\254.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\255.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\256.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\257.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\258.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\259.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\260.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\261.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\262.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\263.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\264.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\265.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\266.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\267.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\268.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\269.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\270.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\271.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\272.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\273.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\274.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\275.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\276.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\277.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\278.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\279.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\280.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\281.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\282.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\283.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\284.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\285.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\286.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\287.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\288.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\289.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\290.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\291.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\292.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\293.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\294.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\295.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\296.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\297.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\298.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\299.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\300.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\301.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\302.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\303.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\304.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\305.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\306.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\307.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\308.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\309.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\310.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\311.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\312.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\313.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\314.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\315.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\316.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\317.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\318.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\319.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\320.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\321.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\322.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\323.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\324.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\325.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\326.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\327.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\328.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\329.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\330.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\331.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\332.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\333.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\334.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\335.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\336.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\337.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\338.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\339.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\340.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\341.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\342.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\343.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\344.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\345.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\346.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\347.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\348.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\349.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\350.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\351.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\352.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\353.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\354.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\355.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\356.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\357.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\358.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\359.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\360.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\361.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\362.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\363.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\364.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\365.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\366.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\367.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\368.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\369.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\370.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\371.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\372.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\373.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\374.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\375.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\376.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\377.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\378.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\379.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\380.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\381.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\382.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\383.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\384.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\385.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\386.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\387.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\388.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\389.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\390.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\391.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\392.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\393.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\394.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\395.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\396.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\397.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\398.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\399.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\400.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\401.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\402.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\403.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\404.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\405.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\406.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\407.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\408.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\409.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\410.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\411.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\412.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\413.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\414.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\415.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\416.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\417.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\418.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\419.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\420.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\421.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\422.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\423.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\424.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\425.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\426.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\427.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\428.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\429.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\430.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\431.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\432.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\433.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\434.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\435.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\436.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\437.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\438.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\439.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\440.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\441.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\442.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\443.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\444.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\445.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\446.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\447.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\448.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\449.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\450.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\451.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\452.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\453.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\454.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\455.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\456.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\457.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\458.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\459.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\460.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\461.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\462.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\463.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\464.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\465.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\466.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\467.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\468.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\469.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\470.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\471.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\472.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\473.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\474.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\475.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\476.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\477.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\500.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\501.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\502.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\503.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\504.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\505.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\506.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\507.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\508.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\509.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\510.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\511.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\512.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\513.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\514.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\515.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\516.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\517.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\518.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\519.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\520.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\521.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\522.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\523.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\524.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\525.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\526.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\527.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\528.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\529.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\530.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\531.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\532.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\533.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\534.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\535.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\536.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\537.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\538.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\539.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\540.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\541.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\542.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\543.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\544.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\545.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\546.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\547.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\548.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\549.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\550.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\551.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\552.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\553.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\554.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\555.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\556.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\557.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\558.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\559.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\560.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\561.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\562.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\563.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\564.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\565.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\566.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\567.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\568.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\569.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\570.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\571.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\572.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\573.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\574.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\575.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\576.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\577.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\578.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\579.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\580.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\581.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\582.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\583.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\584.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\585.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\586.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\587.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\588.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\589.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\590.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\591.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\592.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\593.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\594.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\595.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\598.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\599.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\600.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\601.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\602.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\603.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\604.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\605.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\606.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\607.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\650.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\651.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\652.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\653.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\659.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\660.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\662.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\677.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\713.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\727.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\728.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
Source: E:\Downloads\Músicas\GOSPEL\HINOS E CÂNTICOS PPT\764.pps; DestDir: {app}\HC\; Flags: onlyifdoesntexist
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
