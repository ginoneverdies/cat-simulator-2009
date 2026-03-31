!define NAME "Cat Simulator 2009"
!define VERSION "1.0"
!define COMPANY "Your Company"

OutFile "${NAME} Setup.exe"
InstallDir "$PROGRAMFILES\${NAME}"

Section "Install"
    SetOutPath "$INSTDIR"
    File "YourGameExecutable.exe"
    CreateShortCut "$DESKTOP\${NAME}.lnk" "$INSTDIR\YourGameExecutable.exe"
    CreateShortCut "$STARTMENU\${NAME}.lnk" "$INSTDIR\YourGameExecutable.exe"
SectionEnd

Section "Uninstall"
    Delete "$INSTDIR\YourGameExecutable.exe"
    Delete "$DESKTOP\${NAME}.lnk"
    Delete "$STARTMENU\${NAME}.lnk"
    RMDir "$INSTDIR"
SectionEnd