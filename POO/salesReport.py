from abc import ABC, abstractmethod
import gzip
import json
from zipfile import ZipFile


class Serializer(ABC):
    @abstractmethod
    def serialize(cls, data):
        raise NotImplementedError

# métodos de classe são chamados diretamente da classe, sem instâncias,
# e utilizam algum atributo ou função auxiliar da classe para funcionar!
# Métodos estáticos são chamados diretamente da classe e não utilizam nada dela


class ZipCompressor(Serializer):
    FILE_PATH = './'

    '''Um método de classe é chamado diretamente da classe,
    sem uma instância, e ACESSA algum atributo ou método da classe!'''
    @classmethod
    def compress(cls, file_name):
        '''Repare que, acima, o atributo cls é como o self: o
        cls é a própria classe, passada automaticamente para
        um método de classe, enquanto o self é a instância'''
        with ZipFile(cls.FILE_PATH + file_name + '.zip', 'w') as zip_file:
            zip_file.write(file_name)


class GzCompressor(Serializer):
    '''Um método estático é chamado diretamente da classe,
    sem uma instância, e NÃO ACESSA nenhum atributo ou método da classe!'''
    @staticmethod
    def compress(file_name):
        '''Como métodos estáticos não acessam classe nem instância,
        o Python não dá a eles nenhum primeiro parâmetro'''
        with open(file_name, 'rb') as content:
            with gzip.open(file_name + '.gz', 'wb') as gzip_file:
                gzip_file.writelines(content)


class SalesReport(ABC):
    # Aqui temos um atributo de classe!
    FILE_EXTENSION = ''

    # Nossa classe agora espera *instâncias* de compressor como um parâmetro.
    # Temos um valor padrão para suportar o código que usava as SalesReport
    # sem parâmetros -- não precisa correr pra re-escrever nada ;)
    def __init__(self, export_file, compressor=GzCompressor):
        self.export_file = export_file
        self.compressor = compressor

    def build(self):
        return [{
                'Coluna 1': 'Dado 1',
                'Coluna 2': 'Dado 2',
                'Coluna 3': 'Dado 3'
                },
                {
                'Coluna 1': 'Dado A',
                'Coluna 2': 'Dado B',
                'Coluna 3': 'Dado C'
                }]

    def get_export_file_name(self):
        # Aqui usamos o atributo de classe
        # Vai fazer mais sentido nas classes herdeiras!
        return self.export_file + self.FILE_EXTENSION

    def compress(self):
        self.serialize()
        self.compressor.compress(self.get_export_file_name())

    # @abstractmethod
    # def serialize(self):
    #     raise NotImplementedError


class SalesReportJSON(SalesReport):
    # Nós não reimplementamos o get_export_file_name
    # mas como ele usa um atributo de classe pra pegar a extensão
    # só de redefinir o atributo já vamos conseguir mudar o resultado!
    FILE_EXTENSION = '.json'

    def serialize(self):
        with open(self.get_export_file_name(), 'w') as file:
            json.dump(self.build(), file)


class SalesReportCSV(SalesReport):
    # Sua implementação vai aqui
    pass


# Para testar
relatorio_de_compras = SalesReportJSON('meu_relatorio_1')
relatorio_de_vendas = SalesReportJSON('meu_relatorio_2', ZipCompressor)

relatorio_de_compras.compress()
relatorio_de_vendas.compress()
