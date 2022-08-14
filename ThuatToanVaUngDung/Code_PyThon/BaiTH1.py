# from builtins import input
import math
def cp(x):
    if(x < 0): return False
    y = math.floor(math.sqrt(x))
    return y * y == x
if __name__ == '__main__':
    input()
    a = list(map(int, input().split()))
    print(sum([1 for x in a if x % 3 != 0]))
    print(sum([1 for x in a if cp(x)]))
    b = zip(a, a[1:])
    print(sum([1 for x, y in b if x != 0 and y % x == 0]))

    dc = sum([1 for x in a if x % 2 == 0])
    dl = sum([1 for x in a if x % 2 != 0])
    print(dc * (dc - 1) // 2 + dl * (dl - 1) // 2)
    c = zip(a, a[1:], a[2:])
    print(sum([1 for x, y, z in c if x < y < z]))