#!/usr/bin/env python
# -*- coding: utf-8 -*-
#
#  sniperbot.py
#  
#  Copyright 2015 MCranfor <MCranfor@MCRANFORD-9010>
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


#################
#   Libraries   #
#################
#import ImageGrab
#import os
#import time 
#import win32api, win32con
#import ImageOps
#from numpy import *
#import socket
import smtplib


class Alert():
	
	def __init__(self):
		return
		
	def Email(self, sendTo, sendFrom):
		
		sender = str(sendTo)
		receiver = str(sendFrom)
		
		message = """From: From Person <from@fromdomain.com>
		To: To Person <to@todomain.com>
		Subject: SMTP e-mail test
		
		
		This is a test email message.
		
		
"""
		smtpObj = smtplib.SMTP('localhost')
		smtpObj.sendmail(sender, receiver, message)
		print "Succesfully send email!"
		
		
		

class Sniper():
	
	def __init__(self):
		return
	
	

def main():
	alert = Alert()
	
	alert.Email("m.cranford13@gmail.com", "m.cranford13@gmail.com")
	return 0

if __name__ == '__main__':
	main()

