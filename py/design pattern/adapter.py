class G3000LoaderAdapter:
    # aqui o loader é uma instancia do gerenciator3000.ReportLoader!
    def __init__(self, loader):
        self.loader = loader

    def load_data(self):

        # o zip junta uma lista de chaves e uma lista de valores
        # e cria um dicionário! por exemplo:
        # zip(['nome', 'idade'], ['Capi', 34]) => {'nome': 'Capi', 'idade': 34}

        return [zip(loader.headers, row) for row in loader.rows]  # tcharans
