def binary_search_iterative(array, element):
    mid = 0
    start = 0
    end = len(array)
    step = 0

    while (start <= end):
        print(f"start : {start}")
        print(f"end : {end}")
        mid = (start + end) // 2
        print(f"mid : {mid}")
        print("Subarray in step {}: {}".format(step, str(array[start:end+1])))
        step = step + 1

        if not array[start:end+1]:
            return -1

        if element == array[mid]:
            return mid

        if element < array[mid]:
            end = mid - 1
        else:
            start = mid + 1
        print("-----------------------------")
        print(f"start : {start}")
        print(f"end : {end}")
        print(f"mid : {mid}")
        print("=============================")

    return - 1


data = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

if __name__ == "__main__":
    print(binary_search_iterative(data, 55))
