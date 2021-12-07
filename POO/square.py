class Square:
    def __init__(self, side):
        self.side = side

    def calc_area(self):
        return self.side * self.side

    def calc_perimeter(self):
        return 4 * self.side


my_square = Square(10)

print(my_square.side)
print(my_square.calc_area())
print(my_square.calc_perimeter())
