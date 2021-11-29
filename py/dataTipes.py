# LIST

myList = ['a', 'b', 'c']

newList = ['d', 'e']

myList.extend(newList)

print('myList', myList)


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


# Dictionary

user = { 'name': 'fabio', 'idade': 26 }

print('user', user)


# Set

adminUser = {'fabio'}

devSquat = {'fabio', 'ravena', 'matheus'}

allUsers = {'fabio', 'bruna', 'ravena', 'matheus'}

print('intersection, is admin and dev', adminUser.intersection(devSquat))
print('difference, is not admin in all users', allUsers.difference(adminUser))