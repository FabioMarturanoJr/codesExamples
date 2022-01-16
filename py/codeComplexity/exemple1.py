# 3 * N * N = N²
def _checkSun(numbers, target):
    for i, num in enumerate(numbers):
        for num2 in numbers[i+1:]:
            if num + num2 == target:
                return True
    return False


# 2 + N*7 + 1 = N
# works only ordered list
def checkSun(numbers, target):
    leftIndex = 0
    rightIndex = len(numbers) - 1

    while leftIndex < rightIndex:
        testSum = numbers[leftIndex] + numbers[rightIndex]
        if testSum == target:
            return True
        elif testSum < target:
            leftIndex += 1
        else:
            rightIndex -= 1
    return False


if __name__ == "__main__":
    assert checkSun([-1, 1, 1, 2, 3, 4], 7)
    assert checkSun([1, 2, 5, 8, 13, 21], 3)
    assert checkSun([1, 2, 5, 8, 13, 21], 22)
    assert not checkSun([1, 1, 2, 4, 4], 7)
    assert not checkSun([1, 2, 3, 4], 9)
    assert not checkSun([1, 20, 300, 4000], 0)
