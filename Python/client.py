import socket

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

PORT = 50002

s.connect(('127.0.0.1', PORT))
option = (str(raw_input("What would you like to do? [upload] [download]")))
s.send(option)

recieve_file = s.recv(1024)
print recieive_file