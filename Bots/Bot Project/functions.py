
#################
#   Functions   #
#################


import time
import pyautogui
import os, sys
from classes import *

def get_mouse_position():
	
	x, y = pyautogui.position()
	
	return x,y
		
def get_screen_size():
	
	screen_size = pyautogui.size()
	
	return screen_size
	
def key_press(key):
	pyautogui.press(key)
		
def leftClick(cords):
	x,y = cords
	pyautogui.click(x, y)
	
def write_to_screen(message):
	pyautogui.typewrite(message, interval=0)
	
def alert(message):
	pyautogui.alert(message) #This will display a 'message' and an OK button
	
def confirm(message):
	m = pyautogui.confirm(message) #this will return an "ok" or a "cancel"
	m.upper()
	'''
	if m == "OK":
		print "Ok!"
		continue
	elif m == "CANCEL":
		print "Canceled."
		
	else:
		print "Exiting..."
	'''
	return m
	

def mario_move():
	print "Jumping..."
	key_press(Keyboard.A)
			
	
