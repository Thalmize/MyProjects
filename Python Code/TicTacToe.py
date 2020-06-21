import random


def game_board(marker):
    print(' ' + marker[7] + ' ' + '|' + ' ' + marker[8] + ' ' + '|' + ' ' + marker[9] + ' ')
    print('-----------')
    print(' ' + marker[4] + ' ' + '|' + ' ' + marker[5] + ' ' + '|' + ' ' + marker[6] + ' ')
    print('-----------')
    print(' ' + marker[1] + ' ' + '|' + ' ' + marker[2] + ' ' + '|' + ' ' + marker[3] + ' ')


def player_letter():
    letter = ' ' 
    
    letter = input('Player 1 which letter would you like? ').upper()
    
    if letter == 'X':
        
        return 'X', 'O'
    else:
        return 'O', 'X'


def who_is_starting():

    number = ' '
    number = random.randint(0, 1)

    if number == 0:
        return 'Player 1'
    else:
        return 'Player 2'


def player_ready():
    ready = ' '
    while ready == ' ':

        ready = input('Are you ready to play: Y or N? ')

        if ready == 'Y':
            return True
        else:
            'break'


def player_playing_mark():

    position = ''

    while position == '':
        position = input('Where would you like to place your letter! ')

        return position


def position_check(board, mark, position):

    if board[int(position)] == ' ':
        board[int(position)] = mark
    else:
        player_playing_mark()
        

def win_check(board, mark):
    if (board[1] == mark and board[2] == mark and board[3] == mark or
        board[4] == mark and board[5] == mark and board[6] == mark or
        board[7] == mark and board[8] == mark and board[9] == mark or
        board[1] == mark and board[4] == mark and board[7] == mark or
        board[2] == mark and board[5] == mark and board[8] == mark or
        board[3] == mark and board[6] == mark and board[9] == mark or
        board[1] == mark and board[5] == mark and board[9] == mark or
            board[3] == mark and board[5] == mark and board[7] == mark):

        return True
    else:
        return False


# START
print('Welcome to Tic-Tac-Toe')
grid = ['Z', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']

player_1_name = 'Player 1'
player_2_name = 'Player 2'

(player_1_letter, player_2_letter) = player_letter()

current_player = who_is_starting()
print(current_player + ' you will be starting first!')

game_active = player_ready()

while game_active is True:

    if current_player == 'Player 1':

        '''
        Player 1 turn
        '''
        game_board(grid)
        print(player_1_name)
        player_position = player_playing_mark()

        position_check(grid, player_1_letter, player_position)

        game_active = board_full_check(grid)

        game_over = win_check(grid, player_1_letter)

        if game_over is True:
            print('Player 1: You win')
            game_active = False
        else:
            current_player = 'Player 2'

    if current_player == 'Player 2':

        '''
        Player 2 turn
        '''
        game_board(grid)
        print(player_2_name)
        player_position = player_playing_mark()

        position_check(grid, player_2_letter, player_position)

        game_active = board_full_check(grid)

        game_over = win_check(grid, player_2_letter)

        if game_over is True:
            print('Player 2: You win')
            game_active = False
        else:
            current_player = 'Player 1'


else:
    'break'


