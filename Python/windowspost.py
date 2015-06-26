import os
import subprocess
import socket



def writelog(logfile):
	pass
	 



def networkgather():
	
	arp = ("arp", "-a")
	netview = ("net", "view")
	netuser = ("net", "user")
	ipconfig = ("ipconfig", "/all")
	systeminfo = ("systeminfo")
	tasklist= ("tasklist")
	powershell = ("powershell")
	nbtstat = ("nbtstat", "-h")
	netstat = ("netstat", "-o")
	
	cmdlist = [arp, netview, netuser, ipconfig, systeminfo, nbtstat, netstat]
	
	subprocess.Popen(powershell, 0, None, None, None, shell=True) #Open powershell so that commands run in memory.
	for i in cmdlist:
			subprocess.Popen(i, 0, None, None, None, shell=True).wait() # loop through all the system information gathering commands.
	
	


















def main():
	networkgather()
	
	
	
main()
