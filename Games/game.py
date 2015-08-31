import pygame, sys

pygame.init()

windowSize = (800, 600)

screen = pygame.display.set_mode(windowSize)

myrianProFont = pygame.font.SysFont("Myriad Pro", 20)

pikachuMoveSprite = pygame.image.load("pikachu.jpg")

pikachuMoveSpriteSize = pikachuMoveSprite.get_size()

x,y = 0,0 

clock = pygame.time.Clock()

directionX, directionY = 1, 1


while True:
	
	clock.tick(40)
	
	for event in pygame.event.get():
		if event.type == pygame.QUIT: sys.exit()
	
	screen.fill((0,0,0))
	
	mousePosition = pygame.mouse.get_pos()
	
	x,y = mousePosition
	
	
	if x + pikachuMoveSpriteSize[0] > 800:
		x = 800 - helloWorldSize[0]
	if y + pikachuMoveSpriteSize[1] > 600:
		y = 600 - helloWorldSize[1]
	
	screen.blit(pikachuMoveSprite,(x,y)) 
	
	
			
	pygame.display.update() 
