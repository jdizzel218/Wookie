import subprocess


def networkgather():
	
	arp = ("arp", "-a")
	netview = ("net", "view")
	netuser = ("net", "user")
	ipconfig = ("ipconfig", "/all")
	#nbtstat = (" nbtstat", "-n") For some reason this command isn't being recognized.
	netstat = ("netstat", "-o")
	
	cmdlist = [arp, netview, netuser, ipconfig, netstat]
	
	
	for i in cmdlist:
			subprocess.Popen(i, 0, None, None, None, shell=True).wait() # loop through all the system information gathering commands.
	
	


def systeminfogather():
	
	systeminfo = ("systeminfo")
	tasklist= ("tasklist")
	
	cmdlist = [systeminfo, tasklist]
	
	for i in cmdlist:
		subprocess.Popen(i, 0, None, None, None, shell=True).wait()


def main():
	systeminfogather()
	networkgather()
	
main()
