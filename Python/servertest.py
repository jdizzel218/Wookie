import socket
import errno
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = ''
port = 50000
sock.bind((host,port))
sock.listen(50)

while True:
	try:
		conn, addr = sock.accept()
		print sock.recv(1024)
	except socket.error:
		socket.close()
		
		
		

	
