# LIST

myList = ['a', 'b', 'c']

newList = ['d', 'e']

myList.extend(newList)

print('myList', myList)
print(' ')

# Tuple

myTuple = ('fabio', 1)

listTuples = [myTuple]

listTuples.extend(
  [
    ('bruna', 2),
    ('ravena', 3)
  ]
)

print('listTuples', listTuples)
print(' ')

# Dictionary

user = {'name': 'fabio', 'idade': 26}

print('user', user)
print('user', user.items())
del user['idade']
print('user', user)
user.update({'salario': 'mais de 8 mil'})
print('user', user)

print(' ')

# Set

adminUser = {'fabio'}

devSquat = {'fabio', 'ravena', 'matheus'}

allUsers = {'fabio', 'bruna', 'ravena', 'matheus'}

allUsers.add('ana')

print('intersection, is admin and dev', adminUser.intersection(devSquat))
print('difference, is not admin in all users', allUsers.difference(adminUser))
print(' ')

# Frozenset

permissions = frozenset(['member', 'group'])

permissions.union({'user'})

print('permissions', permissions)
print('permissions', permissions.intersection({"user", "member"}))
print(' ')

# Range

rangeListDefaut = list(range(5))
rangeInitFinal = list(range(1, 6))
rangeByTwo = list(range(1, 11, 2))
rangeReverse = list(range(10, 0, -1))

print('rangeListDefaut', rangeListDefaut)
print('rangeInitFinal', rangeInitFinal)
print('rangeReverse', rangeReverse)
