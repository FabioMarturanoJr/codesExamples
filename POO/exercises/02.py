from collections import Counter


class Estatistica:
    @classmethod
    def media(cls, numbs):
        return sum(numbs) / len(numbs)

    @classmethod
    def mediana(cls, numbers):
        numbers.sort()
        index = len(numbers) // 2
        if len(numbers) % 2 == 0:
            return (numbers[index - 1] + numbers[index]) / 2

        return numbers[index]

    @classmethod
    def moda(cls, numbers):
        number, _ = Counter(numbers).most_common()[0]
        return number


print(Estatistica.media([5, 5]))
