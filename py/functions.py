def imc(peso, altura):
    return peso / (altura / 100) ** 2


print(imc(80.5, 172))
print(imc(peso=100, altura=185))
