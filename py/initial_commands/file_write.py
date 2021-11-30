# escrita

characters = open('meus-personagens.txt', mode='w')

characters.write('Neo\n')
characters.write('Kratos\n')
characters.write('Artorias\n')

print('Vai', file=characters)

more_characters = ['Eloy\n', 'Ash Ketchum\n']

characters.writelines(more_characters)

characters.close()

# leitura
file = open("meus-personagens.txt", mode="r")

# for line in file: o arquivo vem em um array/list
#     print(line)

content = file.read()
print(content)
file.close()
