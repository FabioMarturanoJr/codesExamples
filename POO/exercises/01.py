class Tv:
    def __init__(self, size):
        self.__volume = 50
        self.__canal = 1
        self.__tamanho = size
        self.__ligada = False

    def aumentar_volume(self):
        if self.__volume <= 99:
            self.__volume += 1
        return self.__volume

    def diminuir_volume(self):
        if self.__volume >= 0:
            self.__volume -= 1
        return self.__volume

    def modifica_canal(self, canal):
        if canal <= 1 or canal >= 99:
            raise ValueError('canal indisponivel')
        self.__canal = canal
        return self.__canal

    def ligar_desligar(self):
        self.__ligada = not self.__ligada
        return self.__ligada


my_tv = Tv(47)

print(my_tv.aumentar_volume())
print(my_tv.diminuir_volume())
print(my_tv.modifica_canal(42))
print(my_tv.ligar_desligar())
