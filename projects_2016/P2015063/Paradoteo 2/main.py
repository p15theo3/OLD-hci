import pygame
import time

pygame.init()

white = (255,255,255)
black = (0,0,0)
red = (255,0,0)

display_width = 800
display_height = 600

gameDisplay = pygame.display.set_mode((display_width, display_height))
pygame.display.set_caption("2o paradoteo")
pygame.display.update()




clock = pygame.time.Clock()
FPS = 30
block_size = 10

font = pygame.font.SysFont(None, 25)
def message_to_screen(msg, color):
    screen_text = font.render(msg, True, color)
    gameDisplay.blit(screen_text, [display_width/2, display_height/2])



def gameloop():
    lead_x = display_width/2
    lead_y = display_height/2
    lead_x_change = 0
    lead_y_change = 0
    gameExit = False
    gameOver = False

    while not gameExit:
        while gameOver == True:
            gameDisplay.fill(white)
            message_to_screen("Game over, press C to play again, Q to  quit", red)
            pygame.display.update()

            for even in pygame.event.get():
                if event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_q:
                        gameExit = True
                        gameOver = False
                    if event.key == pygame.K_c:
                        gameLoop()

        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                gameExit = True
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_LEFT:
                    lead_x_change = -(block_size)
                    lead_y_change = 0
                elif event.key == pygame.K_RIGHT:
                    lead_x_change = block_size
                    lead_y_change = 0
                if event.key == pygame.K_UP:
                    lead_x_change = 0
                    lead_y_change = -(block_size)
                elif event.key == pygame.K_DOWN:
                    lead_x_change = 0
                    lead_y_change =  block_size

            if event.type == pygame.KEYUP:
                if event.key == pygame.K_LEFT or  event.key == pygame.K_RIGHT or  event.key == pygame.K_UP or  event.key == pygame.K_DOWN:
                    lead_x_change = 0
                    lead_y_change = 0


        lead_x += lead_x_change
        lead_y += lead_y_change
        gameDisplay.fill(white)
        pygame.draw.rect(gameDisplay, black, [lead_x, lead_y, block_size, block_size])
        pygame.display.update()
        clock.tick(30)

    message_to_screen("You lose", red)
    pygame.display.update()
    time.sleep(2)
    pygame.quit()
    quit()

gameloop()
