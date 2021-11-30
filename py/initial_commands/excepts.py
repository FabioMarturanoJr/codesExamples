while True:
    try:
        x = int(input('enter number: '))
        break
    except ValueError:
        print('Oops! that was no valid Number')
