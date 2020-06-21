# Blackjack play by play
# *Player puts in bet
# dealer gets cards
# *1st card each player available(face-up)
# *1st card dealer(face up)
# *2nd card each player available(face-up)
# *2nd card dealer(face down)
# player option for hit/stay
# dealer reveals cards - hits to 17 /stays on 18
# determine if player wins or losses or busts


import random

# Classes and Variables

suits = ['h', 'd', 's', 'c']
ranks = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
values = {'2': 2, '3': 3, '4': 4, '5': 5, '6': 6, '7': 7, '8': 8, '9': 9, '10': 10, 'J': 10, 'Q': 10, 'K': 10, 'A': 11}


# Class Definitions

class Card:
    def __init__(self, suit, rank):
        self.suit = suit
        self.rank = rank

    def __str__(self):
        return self.rank + '' + self.suit


class Deck:

    def __init__(self):
        self.deck = []
        for suit in suits:
            for rank in ranks:
                self.deck.append(Card(suit, rank))

    def __str__(self):
        deck_comp = ''
        for card in self.deck:
            deck_comp += '\n ' + card.__str__()
        return 'The Deck has:' + deck_comp

    def shuffle(self):
        random.shuffle(self.deck)

    def deal(self):
        single_card = self.deck.pop()
        return single_card


class Hand:

    def __init__(self):
        self.cards = []
        self.value = 0
        self.aces = 0

    def add_card(self, card):
        self.cards.append(card)
        self.value += values[card.rank]
        if card.rank == 'A':
            self.aces += 1

    def adjust_for_ace(self):
        while self.value > 21 and self.aces == 0:
            self.value -= 10
            self.aces -= 1


class Chips:

    def __init__(self):
        self.total = 500
        self.bet = 0

    def win_bet(self):
        self.total += self.bet

    def lose_bet(self):
        self.total -= self.bet


# Function Definitions:

def take_bet(chips):

    while True:
        try:
            chips.bet = int(input('How many chips would you like to bet? '))
        except ValueError:
            print('Sorry, a bet must be a number!')
        else:
            if chips.bet > chips.total:
                print("Sorry, you bet can't exceed", chips.total)
            else:
                break


def hit(deck, hand):
    hand.add_card(deck.deal())
    hand.adjust_for_ace()


def hit_or_stand(deck, hand):
    global playing

    while True:
        x = input("Would you like to Hit or Stand? Enter 'h' or 's' ")

        if x[0].lower() == 'h':
            hit(deck, hand)

        elif x[0].lower() == 's':
            print('Player stands. Dealer is playing.')
            playing = False

        else:
            print("Sorry, please try again.")
            continue
        break


def show_some(player, dealer):
    print('----------------------------------')
    print('Dealer')
    print('Dealer Hand Value: X')
    print('Dealer Hand: X ', dealer.cards[1])
    print('')
    print('')
    print('')
    print('')
    print('')
    print('')
    print('Player Hand: ', *player.cards)
    print('Player Hand Value: ', player_hand.value)
    print('Bet: ', player_chips.bet)
    print('Player')


def show_all(player, dealer):
    print('----------------------------------')
    print('Dealer')
    print('Dealer Hand: ', *dealer.cards)
    print('Dealer Hand Value: ', dealer_hand.value)
    print('')
    print('')
    print('')
    print('')
    print('')
    print('')
    print('Player Hand Value: ', player_hand.value)
    print('Player Hand: ', *player.cards)
    print('Bet: ', player_chips.bet)
    print('Player')


def player_busts(player, dealer, chips):
    print("Player busts!")
    chips.lose_bet()


def player_wins(player, dealer, chips):
    print("Player wins!")
    chips.win_bet()


def dealer_busts(player, dealer, chips):
    print("Dealer busts!")
    chips.win_bet()


def dealer_wins(player, dealer, chips):
    print("Dealer wins!")
    chips.lose_bet()


def push(player, dealer):
    print("Dealer and Player tie! It's a push.")


# Start Game

# Create & shuffle deck deal two cards to each player
playing = True
while playing:
    deck = Deck()
    deck.shuffle()

    player_hand = Hand()
    player_hand.add_card(deck.deal())
    player_hand.add_card(deck.deal())

    dealer_hand = Hand()
    dealer_hand.add_card(deck.deal())
    dealer_hand.add_card(deck.deal())
# setup the players chips
    player_chips = Chips()

    take_bet(player_chips)

# show cards

    show_some(player_hand, dealer_hand)
    hit_or_stand(deck, player_hand)
    show_some(player_hand, dealer_hand)

    if player_hand.value > 21:
        player_busts(player_hand, dealer_hand, player_chips)
        break

    if player_hand.value <= 21:
        while dealer_hand.value < 17:
            hit(deck, dealer_hand)

            show_all(player_hand, dealer_hand)

        if dealer_hand.value > 21:
            dealer_busts(player_hand, dealer_hand, player_chips)

        elif dealer_hand.value > player_hand.value:
            dealer_wins(player_hand, dealer_hand, player_chips)

        elif dealer_hand.value < player_hand.value:
            player_wins(player_hand, dealer_hand, player_chips)

        else:
            push(player_hand, dealer_hand)

    print("\nPlayer's winnings stand at", player_chips.total)

    # ask to play again

    new_game = input("Would you like to play another hand? Enter 'y' or 'n' ")
    if new_game[0].lower() =='y':
        playing = True
        continue
    else:
        print("Thanks for playing!")
        break


