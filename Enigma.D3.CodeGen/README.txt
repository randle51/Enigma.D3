
For a new patch, begin by running:
>Enigma.D3.CodeGen -memory -deploy

This will update version information and search for some core pointers and constants in the exe file.
The -deploy switch updates the shared project Enigma.D3.Core.Generated in the solution. If the switch
is omitted, copy-paste the files manually (output created next to generator).

In order to update  Enigma.D3.Core and Enigma.D3.Assets we need a minidump of a D3 process. The game
needs to be fully initialized, getting to the login screen is enough. The minidump needs to be located
at "%TEMP%\Diablo III.DMP". Some additional offsets can be generated for "-memory", these require the
minidump to contain a populated PlayerData structure, meaning player must be inside a game.

To create a dump using Task Manager:
	Open the "Windows Task Manager"
	Select the "Processes" tab
	Right click the process you wish to take a dump of
	Select "Create Dump File

NB: If you create multiple minidumps, a number will be appended to the file name "Diablo III (2).DMP"
    and so on. The code generator uses the first file, "Diablo III.DMP". Keep in mind these files are
	large (>1.3GB) so you might want to delete it afterwards (Windows will delete it eventually).


Now you can run the following to update both Core and Assets. You can also do one at a time and as
before, the -deploy switch can be omitted if you don't want it to overwrite the solution files.
>Enigma.D3.CodeGen -core -assets -deploy