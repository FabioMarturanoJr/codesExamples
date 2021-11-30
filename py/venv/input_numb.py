import random

random_numb = random.randint(1, 10)
guess = ''
attempts = 1

while guess != random_numb and attempts < 4:
    guess = int(input(f'Tentativa {attempts} - Qual seu palpite ? '))
    attempts += 1


print(f'O numero era {random_numb}')
