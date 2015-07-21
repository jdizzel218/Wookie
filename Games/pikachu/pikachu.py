import pygame, sys

pygame.init()
pygame.mixer.init()

windowSize = (800, 600)

screen = pygame.display.set_mode(windowSize)

myrianProFont = pygame.font.SysFont("Myriad Pro", 20)

pikachuMoveSprite = pygame.image.load("pikachu.png")

pikachuMoveSpriteSize = pikachuMoveSprite.get_size()

# sound = pygame.mixer.Sound('') Add sound here

pygame.mouse.set_visible(0)

x,y = 0,0 

clock = pygame.time.Clock()

directionX, directionY = 1, 1


while True:
	
	clock.tick(40)
	
	for event in pygame.event.get():
		if event.type == pygame.QUIT: sys.exit()
		
		if event.type == pygame.KEYDOWN:
			
			while event.key == pygame.K_RIGHT:
				pygame.image.load("pikachu.png")
				pygame.image.load("pikachu1.png")
				pygame.image.load("pikachu2.png")
				pygame.image.load("pikachu3.png")
				x += 5
			else:
				break
				
			if event.key == pygame.K_LEFT:
				x -= 5
			if event.key == pygame.K_DOWN:
				y += 5
			if event.key == pygame.K_UP:
				y -= 5	
			
	
	screen.fill((0,0,0))
	

	
	if x + pikachuMoveSpriteSize[0] > 800: #checks for when the sprite hits the 'wall' of the application
		x = 800 - pikachuMoveSpriteSize[0]
	if y + pikachuMoveSpriteSize[1] > 600: 
		y = 600 - pikachuMoveSpriteSize[1]
	
	if x <= 0: 
		x = 0
	if y <= 0:
		y = 0
		
		#sound.stop()
		#sound.play()
		
	screen.blit(pikachuMoveSprite,(x,y)) 
	
	
			
	pygame.display.update() 
