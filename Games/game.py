import pygame, sys

pygame.init()

windowSize = (800, 600)

screen = pygame.display.set_mode(windowSize)

myrianProFont = pygame.font.SysFont("Myriad Pro", 20)

helloWorld = myrianProFont.render("Hello, World!", 1, (255,0,255), (255,255,255) )

helloWorldSize = helloWorld.get_size()

x,y = 0,0 

clock = pygame.time.Clock()

directionX, directionY = 1, 1


while True:
	
	clock.tick(40)
	for event in pygame.event.get():
		if event.type == pygame.QUIT: sys.exit()
	
	screen.fill((0,0,0))
	
	screen.blit(helloWorld,(x,y)) 
	
	
	x += 5 * directionX
	y += 5 * directionY
	
	if x + helloWorldSize[0] > 800 or x <= 0:
		directionX *= -1
		
	elif y + helloWorldSize[0] > 600 or y <= 0:
		directionY *= -1
			
	pygame.display.update() 
