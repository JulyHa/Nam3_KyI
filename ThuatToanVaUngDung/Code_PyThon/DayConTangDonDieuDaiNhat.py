'''
if __name__ == '__main__':
    n = int(input())
    a=[-10000]+list(map(int, input().split()))
    c=[0]*(n+5)
    for i in range(1, n+1):
        p=0
        for j in range(1, i):
            if a[j]<a[i] and c[j]>p: p=c[j]
        c[i]=p+1
    print(max(c))
'''
import bisect

if __name__ == '__main__':
    input()
    a=list(map(int, input().split()))
    c=[a[0]]
    for x in a[1:]:
        if x > c[-1]: c.append(x)
        p = bisect.bisect_right(c,x)
    c[p]=x
    print(len(c))
    #bisect.bisect               #ham chat nhi phan