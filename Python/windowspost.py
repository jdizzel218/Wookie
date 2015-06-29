import subprocess


def networkgather():
	
	print "========================="
	print "   Network Information   "
	print "========================="
	
	arp = ("arp", "-a")
	netview = ("net", "view")
	
	ipconfig = ("ipconfig", "/all")
	#nbtstat = (" nbtstat", "-n") For some reason this command isn't being recognized.
	netstat = ("netstat", "-o")
	
	cmdlist = [arp, netview,ipconfig, netstat]
	
	
	for i in cmdlist:
			subprocess.Popen(i, 0, None, None, None, shell=True).wait() # loop through all the system information gathering commands.
	print ''
	 
def useraccountsenum():
	
	print ''
	print "===================="
	print "   User Accounts   "
	print "==================="
	print ''
	
	netuser = ("net", "user")
	
	subprocess.Popen(netuser, 0, None, None, None, shell=True).wait()
	
	print ''
	print ''
	
def systeminfogather():
	
	print ''
	print "========================"
	print "   System Information   "
	print "========================"
	print ''
	
	systeminfo = ("systeminfo")
	tasklist= ("tasklist")
	
	cmdlist = [systeminfo, tasklist]
	
	for i in cmdlist:
		subprocess.Popen(i, 0, None, None, None, shell=True).wait()
	
	print ''
	print ''

def endlog():
	print ""
	print ""
	print ""
	print "================"
	print "   END OF LOG   "
	print "================"

def main():
	useraccountsenum()
	systeminfogather()
	networkgather()
	endlog()
	
	
main()
