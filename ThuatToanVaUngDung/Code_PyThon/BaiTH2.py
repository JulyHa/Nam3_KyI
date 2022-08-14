#
# if __name__ == '__main__':
#     t = "123,4,45,67"
#     a = list(map(int,t.split(',')))
#     print(a)
#     y="Le Hong Dung 13 4.3 7"
#     ten,tuoi,toan,ly = y.rsplit(' ',3)
#     print("Ten la: ",ten);
#     tuoi = int(tuoi)
#     toan = float(toan)
#     ly = float(ly)
#     print("Tuoi:%d\nDiem tb: %f"%(tuoi, (toan+ly)/2))


# Tính tiền điện (ltol)
"""
if __name__ == '__main__':
    s, n = 0, int(input())
    if n > 500:
        s += (n-500)*2.2
        n = 500
    if n > 250:
        s += (n-250)*1.7
        n = 250
    if n > 100:
        s += (n-100)*1.2
        n = 100
    print("%0.3f" % (s+n))
"""

# Lại là tính tiền điện(ltol)
#
# def tinh(a, b, n):
#     s = 0
#     for x, y in zip(a, b):
#         if n > x:
#             s += (n - x) * y
#             n = x
#     return s
# if __name__ == '__main__':
#     a, b = [], []
#     for i in range(int(input())):
#         x, y = input().split()
#         a.append(int(x))
#         b.append(float(y))
#     input()
#     a = a[::-1] #a = dao cua a
#     b = b[::-1]
#     for n in input().split(): print("%.3f"%tinh(a,b,int(n)))


# Lý thuyết

"""
def chan(x): return x%2==0
if __name__=='__main__':
    a = [3,3,6,2]   #list
    b = (3,6,3,7,9,0,6)     #tuble
    c = {2:3, 4:-2, 7:2}    #dic(giống map)
    for x in a : print(x, end = " ")
    print()
    for y in b: print(y, end=" ")
    print()
    for z in c: print(z," : ",c[z])
    print("dao nguoc a: ", a[::-1])
    print("dao nguoc b: ", b[::-1])

    #c = list(filter(lambda x:x%2==0,a))  #filter là hàm lặp
    c = list(filter(chan, a))
    print(c)
"""
# planting tree(ltol)
#
# import sys
# if __name__ == '__main__':
#     input()
#     a = list(map(int, sys.stdin.read().split()))
#     a.sort(reverse=True)
#     b = [i+x for i, x in enumerate(a)]
#     print(max(b) + 2)

"""
#dem
import sys
if __name__=='__main__':
    n = input()
    #c, d = [int(x) for x in input().split()]
    c, d = map(int, input().split())
    a = list(map(int, input().split()))
    check = "YES"
    print(sum([1 for x in a if -c <= x<=d]))
    for x, y in zip(a, a[1:]):
        if x >= y: check = "NO"
    print(check)
"""
# import collections
# if __name__ == '__main__':
#     diem = collections.namedtuple("diem", "x,y")
#     check = "NO"
#     n = int(input())
#     a = []
#     for i in range(n):
#         x, y = map(float, input().split())
#         a.append(diem(x,y))
#     d = {}
#     for p in a: d[p] = True
#     if n != len(d): check = "YES"
#     print(check)

#Sinh dãy nhị phân
# def sol( k, n):
#     a = []
#     while n:
#         a.append((n%2))
#         n//=2
#     print("0"*(k-len(a)),end="") #end="" không xuống dòng
#     print(*a[::-1], sep="") # không in [] khi in dãy
#
# if __name__ == '__main__':
#     k = int(input())
#     for i in range(2**k):
#         sol(k,i)
if __name__=='__main__':
    input()
    res = 0
    dem = 0
    for x in input().split():
        if x == '0':
            dem+=1
            res = max(res, dem)
        else: dem = 0
    print(res)