###############################################################################################
#																							  #	
#									Sushi Go Round Bot										  #
#										by Matthew Cranford									  #
#															aka ^graff						  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
#																							  #
###############################################################################################

#################
#   Libraries   #
#################

import ImageGrab
import os
import time 
import win32api, win32con
import ImageOps
from numpy import *

########################
#   Global Variables   #
########################
'''
This defines any and all 'magic numbers' and the like. 

Note: All global variables will be written in CAPS for ease of use.

'''

CWD = os.getcwd() #This grabs the current working directory.
X_PAD = 464
Y_PAD = 223


foodOnHand = { 'shrimp':5,
			   'rice':10,
			   'nori':10,
			   'roe':10,
			   'salmon':5,
			   'unagi':5}

###############
#   Classes   #
###############


'''

Recipes

Onigiri:

2 x rice
1 x nori


California roll:

1 x rice 
1 x nori
1 x roe

gunkan maki:

1 x rice 
1 x nori
2 x roe



'''

class Cord():
	
	f_shrimp = (75,323)
	f_rice   = (95,333)
	f_nori   = (26,385)
	f_roe    = (86,381)
	f_salmon = (35,441)
	f_unagi  = (94,438)
	
 #----------------------------#
	phone = (580,358)
	
	menu_toppings = (524,269)
	
	t_shrimp = (491, 221)
	t_nori   = (491, 277)
	t_roe    = (577, 272)
	t_salmon = (491, 328)
	t_unagi  = (572, 217)
	t_exit   = (592, 336)
	
	menu_rice = (502, 292)
	buy_rice  = (545, 281)
	
	menu_sake = (507, 314)
	buy_sake  = (539, 272)
	
	delivery_norm = (484, 287)
	
 #----------------------------#
 
	def clear_tables():
		mousePos((90, 204))
		leftClick()
		
		mousePos((191,202))
		leftClick()
		
		mousePos((291,203))
		leftClick()
		
		mousePos((389,202))
		leftClick()
		
		mousePos((493,202))
		leftClick()
		
		mousePos((595,201))
		leftClick()
		time.sleep(1)
	
	
	
	

#-------------Functions Start---------------#


	
def screenGrab(): #This grabs a screenshot and saves in the current working directory as a '.png' file.
	box = (X_PAD + 1, Y_PAD +1,X_PAD + 640, Y_PAD + 480)
	im = ImageGrab.grab()
	
	#im.save(CWD + '\\ful_snap__' + str(int(time.time())) + '.png', 'PNG') #(directory, (name, timestamp), fileformat)
	
	return im
	
def grab():
	def screenGrab(): #This grabs a screenshot and saves in the current working directory as a '.png' file.
	box = (X_PAD + 1, Y_PAD +1,X_PAD + 640, Y_PAD + 480)
	im = ImageOps.grayscale(ImageGrab.grab(box))
	a = array(im.getcolors())
	a = a.sum()
	print a
	return a

######################
#   Mouse Controls   #
######################

def leftClick():
	win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0) #This clicks the mouse down.
	time.sleep(.1)
	win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0) #This releases the click on the mouse.
	print "Left Click." # Optional but nice for debugging

def leftDown():
	win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0) #This is for holding the left button down. It will be used for dragging or holding.
	time.sleep(.1)
	print "Left Click Held"
	
def leftUp():
	win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0) #This just releases the mouse click for us.
	time.sleep(.1)
	print "Left Click Released."
	
def mousePos(cord): #This is expecting a tulple
	win32api.SetCursorPos((X_PAD + cord[0], Y_PAD + cord[1]))
	
def get_cords():
	x,y = win32api.GetCursorPos()
	x = x - X_PAD
	y = y - Y_PAD
	print x,y	
	
	
###########################
#   Navigate start menu   #
###########################
def start_game():
	#Location of first menu
	
	mousePos((298,196))
	leftClick()
	time.sleep(.1)	
	
	#Location of second menu
	
	mousePos((324,388))
	leftClick()
	time.sleep(.1)	
	
	#Location of third menu
	
	mousePos((573,448))
	leftClick()
	time.sleep(.1)	
	
	#Location of fourth menu
	
	mousePos((311,378))
	leftClick()
	time.sleep(.1)	
	
	
#---------- Make Food -----------#
def makeFood(food):
	if food == "caliroll":
		print "Making a california roll..."
		foodOnHand['rice'] -= 1
		foodOnHand['nori'] -= 1
		foodOnHand['roe'] -= 1
		mousePos(Cord.f_rice)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_nori)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_roe)
		leftClick()
		time.sleep(.1)
		foldMat()
		print "Done!"
		time.sleep(1.5)
		
		
	elif food == 'onigiri':
		print "Making a Onigiri..."	
		foodOnHand['rice'] -= 2
		foodOnHand['nori'] -= 1
		mousePos(Cord.f_rice)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_rice)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_nori)
		leftClick()
		time.sleep(.1)
		foldMat()
		print "Done!"
		time.sleep(0.5)
		
		
	elif food == 'gunkan':
		print "Making a Gunkan..."
		foodOnHand['rice'] -= 1
		foodOnHand['nori'] -= 1
		foodOnHand['roe' ] -= 2	
		mousePos(Cord.f_rice)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_nori)
		leftClick()
		time.sleep(.05)
		mousePos(Cord.f_roe)
		leftClick()
		time.sleep(.1)
		mousePos(Cord.f_roe)
		leftClick()
		time.sleep(.1)
		foldMat()
		print "Done!"
		time.sleep(1.5)
		
		
def foldMat():
	mousePos((Cord.f_rice[0]+40, Cord.f_rice[1]))
	leftClick()
	time.sleep(.1)
	
#-------------End Make Food---------------#
def buyFood(food):
	
	if food == 'rice':
		mousePos(Cord.phone)
		leftClick()
		time.sleep(.5)
		mousePos(Cord.menu_rice)
		leftClick()
		s = screenGrab()
		if s.getpixel(Cord.buy_rice) != (149, 182, 192):
			print "Rice is available."
			mousePos(Cord.buy_rice)
			time.sleep(.1)
			leftClick()
			mousePos(Cord.delivery_norm)
			time.sleep(.1)
			leftClick()
			foodOnHand['rice'] += 10
			time.sleep(2.5)
		else:
			print "Rice is not available, will wait."
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)
	
	elif food == 'nori':
		mousePos(Cord.phone)
		time.sleep(.1)
		mousePos(Cord.menu_toppings)
		time.sleep(.05)
		leftClick()
		s = screenGrab()
		print 'Testing...'
		time.sleep(.1)
		if s.getpixel(Cord.t_nori) != (137,168,201):
			print "Nori is available"
			mousePos(Cord.t_nori)
			leftClick()
			mousePos(Cord.delivery_norm)
			time.sleep(.1)
			leftClick()
			foodOnHand['nori'] += 10
			time.sleep(2.5)
		else:
			print "Nori is not available! :("
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)
	
	elif food == 'shrimp':
		mousePos(Cord.phone)
		time.sleep(.1)
		leftClick()
		mousePos(Cord.menu_toppings)
		time.sleep(.1)
		leftClick()
		s = screenGrab()
		time.sleep(.1)
		if s.getpixel(Cord.t_shrimp) != (255,255,255):
			print "Shrimp is available!"
			mousePos(Cord.t_shrimp)
			leftClick()
			time.sleep(.1)
			mousePos(Cord.delivery_norm)
			leftClick()
			time.sleep(2.5)
		else:
			print "Shrimp is not available! :("
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)
	
		
	elif food == 'roe':
		mousePos(Cord.phone)
		time.sleep(.1)
		leftClick()
		mousePos(Cord.menu_toppings)
		time.sleep(.1)
		leftClick()
		s = screenGrab()
		time.sleep(.1)
		if s.getpixel(Cord.t_roe) != (225,181,105):
			print "Fish eggs is available!"
			mousePos(Cord.t_roe)
			leftClick()
			time.sleep(.1)
			mousePos(Cord.delivery_norm)
			leftClick()
			foodOnHand['roe'] += 10
			time.sleep(2.5)
		else:
			print "Fish eggs are not available! :("
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)
		
	elif food == 'salmon':
		mousePos(Cord.phone)
		time.sleep(.1)
		leftClick()
		mousePos(Cord.menu_toppings)
		time.sleep(.1)
		leftClick()
		s = screenGrab()
		time.sleep(.1)
		if s.getpixel(Cord.t_salmon) != (146,174,175):
			print "Salmon is available!"
			mousePos(Cord.t_salmon)
			leftClick()
			time.sleep(.1)
			mousePos(Cord.delivery_norm)
			leftClick()
			time.sleep(2.5)
		else:
			print "Salmon is not available! :("
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)
		
	elif food == 'unagi':
		mousePos(Cord.phone)
		time.sleep(.1)
		leftClick()
		mousePos(Cord.menu_toppings)
		time.sleep(.1)
		leftClick()
		s = screenGrab()
		time.sleep(.1)
		if s.getpixel(Cord.t_unagi) != (255,255,255):
			print "Unagi is available!"
			mousePos(Cord.t_unagi)
			leftClick()
			time.sleep(.1)
			mousePos(Cord.delivery_norm)
			leftClick()
			time.sleep(2.5)
		else:
			print "Unagi is not available! :("
			mousePos(Cord.t_exit)
			leftClick()
			time.sleep(1)
			buyFood(food)	
	
	
def checkFood():
	for i, j in foodOnHand.items():
		if i == 'nori' or i == 'rice' or i == 'roe':
			if j <= 4:
				print "%s is low and needs to be replenished." % i
				buyFood(i)



def get_seat_one():
	box = (26,61,36+63,61+16)
	im = ImageOps.grayscale(ImageGrab.grab(box))
	a = array(im.getcolors())
	a = a.sum()
	print a
	im.save(CWD + "\\seat_one__" + str(int(time.time())) +	'.png', "PNG")	
	return a		
#-------------End Functions---------------#
	
def main():
	start_game()
	time.sleep(3)
	
	
	
	
if __name__ == '__main__':
	main()
