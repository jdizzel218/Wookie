import subprocess, socket, time, struct
from _winreg import *

def recv_data(sock):
	data_len, = struct.unpack("!I", sock.recv(4))
	return sock.recv(data_len)
	
def send_data(sock,data):
	data_len, = struct.unpack("!I", data_len))
	sock.send(data)
	return
	
	
def networkgather():
	
	print "========================="
	print "   Network Information   "
	print "========================="
	
	arp = ("arp", "-a")
	netview = ("net", "view")
	
	ipconfig = ("ipconfig", "/all")
 #	nbtstat = (" nbtstat", "-n") For some reason this command isn't being recognized.
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

def createuser(name, pwd, log_file):
	cmd = ["net", "user", "/add", name, pwd]
	subprocess.Popen(cmd, 0, None, None, log_file, log_file, shell=True).wait()
	log_file.close()
	return
	
def deleteuser(name, log_file):
	cmd = ["net", "user" "/del", name]
	subprocess.Popen(cmd, 0, None, None, log_file,log_file, shell=True).wait()
	log_file.close()

	return
	
def download_registry(root, path, sock):
	
	key_hdl = OpenKey(root,path)
	num_subkeys, num_values, last_modified = QueryInfoKey(key_hdl)
	
	return

def download_file():
	return
	
def execute_command():
	return
	

def endlog():
	print ""
	print ""
	print ""
	print "================"
	print "   END OF LOG   "
	print "================"

def main():
	f = open("log.txt","w")
	useraccountsenum()
	systeminfogather()
	networkgather()
	endlog()
	
	
main()
