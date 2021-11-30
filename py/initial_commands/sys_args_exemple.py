import sys

if __name__ == '__main__':
    for argument in sys.argv:
        print("Received -> ", argument)

    err = 'Arquivo não encontrado'
    print(f'Erro aconteceu: {err}', file=sys.stderr)
