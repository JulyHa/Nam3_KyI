#Cat LInh Ha Dong
from collections import Counter
# from collections import Counter

import collections

if __name__ == '__main__':
    input()
    a = list(map(int, input().split()))
    b = list(map(int, input().split()))
    da = collections.Counter(a)
    db = collections.Counter(b)
    res = 0
    for x in da.keys():
        if x in db.keys():
            res += min(da[x], db[x])
    print(res)