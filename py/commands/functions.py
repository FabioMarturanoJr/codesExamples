def imc(peso, altura):
    return peso / (altura / 100) ** 2


print(imc(80.5, 172))
print(imc(peso=100, altura=185))


def concat(*strings):
    print(strings[-2])
    final_string = ''
    for string in strings:
        final_string += string
# checa se a string da iteração não é ultima coloca uma virgula no final
        if not string == strings[-1]:
            final_string += ', '
    return final_string


print(concat('fabio', 'marturano'))
print(dict(nome="fabio", sobrenome="marturano"))

arr = [1, 2, 3, 4]
print(len(arr))
print('fabio', 'batata', sep=' gosta de ')
