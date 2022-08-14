import collections

if __name__ == "__main__":
    [n, q, c] = [int(x) for x in input().split()]
    a = map(int, )
    p = []
    for i in range(2):
        a.append(input())
    da = collections.Counter(a)
    for t in (1, c):
        for i in (1, 100):
            for j in (1, 100):
                a[t][i][j] += a[t][i-1][j] + a[t][i][j-1] - a[t][i-1][j-1]
