from random import randint

dice_roll = randint(1, 20)

if dice_roll == 1:
    print('Deu Ruim...')
elif 2 < dice_roll < 15:
    print('Ta quase, pode melhorar')
elif dice_roll > 15:
    print('Agora sim !!!')

print(' ')

pantheon = [
    {'name': 'wynna', 'dominio': 'magia'},
    {'name': 'Nimb', 'dominio': 'Sorte'},
    {'name': 'Ahadarak', 'dominio': 'Tormenta'},
]

god_names = []

for god in pantheon:
    god_names.append(god['name'])

filtred_pantheon = [god for god in pantheon if god['dominio'] != 'Tormenta']
filtred_pantheon_name = [
    god['name'] for god in pantheon if god['dominio'] != 'Sorte'
]

print(pantheon)
print(god_names)
print(filtred_pantheon)
print(filtred_pantheon_name)

print(' ')

fibo = []
n = 15
last, next = 0, 1
while last < n:
    fibo.append(last)
    last, next = next, last + next

print('fibo', fibo)
