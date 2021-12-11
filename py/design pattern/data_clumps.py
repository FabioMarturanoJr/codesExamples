from collections import namedtuple


class Address:
    def __init__(self, street, number, district):
        self.street = street
        self.number = number
        self.district = district


class User:
    def __init__(self, name, address):
        self.name = name
        self.address = address


casaFabio = Address("Minha Rua", 2026, "meu distrito")
fabio = User("fabio", casaFabio)

print(fabio.name)
print(fabio.address.district)

# --------------------------------------------------

# GeoPoint = namedtuple("GeoPoint", ['lat', 'lon'])
GeoPoint = namedtuple("GeoPoint", "lat lon")
location = GeoPoint(-22.81711234090266, -47.069559317039655)
print(location.lat)  # muito melhor do que location[0]
