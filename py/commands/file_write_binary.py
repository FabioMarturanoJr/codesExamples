# escrita
file = open("arquivo.dat", mode="wb")
# o prefixo b em uma string indica que seu valor está codificado em bytes
file.write(b"C\xc3\xa1ssio 30")
file.close()

# leitura
file = open("arquivo.dat", mode="rb")
content = file.read()
print(content)  # saída: b'C\xc3\xa1ssio 30'
file.close()  # não podemos esquecer de fechar o arquivo
