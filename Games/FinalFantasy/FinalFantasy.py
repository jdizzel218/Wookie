import pygame,sys
#from GameObject import GameObject



class Hero():
	
	def __init__(self, sprite = '', name = '',level = 1, experience = 0, health = 1, magic = 1, job = '', weapon = '',inventory = '', equipment = '', x = 0, y = 0):
		self.name = name
		self.sprite = sprite
		self.level = level
		self.experience = experience
		self.health = health
		self.magic = magic
		self.job = job
		self.weapon = weapon
		self.inventory = inventory
		self.equipment = equipment
		self.x = x
		self.y = y
		return
		
	def hero_stats(self):
		
		print "Name: %s"   % self.name
		print "Level: %s " % self.level
		print "Health: %s" % self.health
		print "MP: %d"     % self.magic
		print "Equipment: \n\tWeapon: %s \n\tArmor: %s" % (self.weapon, Item.hero_armor)
		print "Inventory: \t%s" %  (self.inventory)
		
	def hero_skills():
		
		skill_list = ["attack"], ["defend"],["magic"],["inventory"],["run"]
		 	
	def take_damage(self,damage):
		totalHealth = self.health - damage
		return totalHealth
		
class Enemy():
	
	def __init__(self, sprite, level, health, job, weapon, item_drop, x, y):
		self.sprite    = sprite
		self.level     = level
		self.health    = health
		self.job       = job
		self.weapon    = weapon
		self.item_drop = item_drop
		self.x         = x
		self.y         = y
		
		
	def have_weapon(self):
		if self.weapon == '' or self.weapon == "None":
			have_weapon = False
		else:
			have_weapon = True
			
	def is_defeated(self):
		if self.health <= 0:
			return True
		else:
			return False
			
	def deal_damage(self):
		
		if Enemy.have_weapon == True:
			dmg_dealt = Weapon.dmg
			
		else:
			return
	
	def take_damage(self,damage):
		totalHealth = self.health - damage
		return totalHealth
		
class Weapon():
	
	weapon_list = ["Sword", "Axe", "Knife", "Bow", "Staff"]
	
	def __init__(self, wpn_type, wpn_dmg, wpn_skill):
		
		self.wpn_type  = wpn_type
		self.wpn_dmg   = wpn_dmg
		self.wpn_skill = wpn_skill
	
	
	
	
	
		
class Level():
	
	def __init__():
		return
		
	def render():
		return
		
class Magic():
	pass
	
class LevelUp():
	
	def gain_experience():
		
		if Enemy.is_defeated == True:
			Hero.experience = total_experience + gained_experience
		else:
			return
			
class Item():
	
	def __init__(item_id, item_dmg, item_action, item_location):
		return
		
	def hero_armor():
		
		head     = ''
		body     = ''
		arms     = ''
		legs     = ''
		ring     = ''
		necklace = ''
		
	
		
class Map():
	def __init__():
		return
		
	
	
def inital_setup():
	
	return
		
class Game(): 
	
	def __init__():
		return
		
	def start():
		return
		
	def render():
		return
		
	def changeScene():
		return
		
	def getLives():
		return
		
	def playSound():
		return
		
	def Controller():
		return
	
	
	
	

	
def main():
	pygame.init()
	pygame.mixer.init()
	windowSize = (1000, 700)
	screen = pygame.display.set_mode(windowSize)
	pygame.mouse.set_visible(0)
	clock = pygame.time.Clock()
	
	
	player1 = Hero()
	player1.hero_stats()
	 
	pygame.display.update() 
	
	
main()
