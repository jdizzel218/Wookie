import subprocess, os

DN = open(os.devnull, 'w')

def update_kali():
	
	cmd = ["apt-get", "autoremove", "-y"], ["apt-get", "update"], ["apt-get", "upgrade", "-y"], ["apt-get", "dist-upgrade", "-y"]
	
	cmd_list = ("Removing old files...."), "Updating repositories..."],["Checking for upgrades..."], ["Checking for Kali Upgrades..."]

	for i in cmd:
		print i
		for i in cmd_list:
			subprocess.Popen(i, 0, None, None, DN, DN)
			
		print "Done!"
def main():
	update_kali()
	
	
main()
 
