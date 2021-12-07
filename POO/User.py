class User:
    def __init__(self, name, email, password):
        self.name = name
        self.email = email
        self.password = password

    def reset_password(self):
        print('Enviar email de reset de senha')


my_user = User('fabio', 'fabio@gmail.com', 'cançado')

print(my_user)
print(my_user.name)
print(my_user.email)
print(my_user.password)
my_user.reset_password()
