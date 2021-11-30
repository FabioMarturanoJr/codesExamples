all_numbs = input('digite seu numeros: ').split(' ')

wrong_input = ''

for numb in all_numbs:
    if not numb.isdigit():
        wrong_input = numb
        break

if wrong_input:
    print(f'Erro ao somar valores, "{wrong_input}" é um valor inválido')
else:
    print(all_numbs)
