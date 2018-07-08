from random import randint as XiaoChuan

array1 = [[[0 for a in range(3)] for b in range(3)] for c in range(3)]

for i in  range(0,3):
    for j in range (0,3):
        for k in range(0,3):
            array1[i][j][k] = XiaoChuan(1,9)
print("Original 3D Array:")
tempcounter=1
tempcountera = 1
tempcounterb = 1
print("( ")
for d2 in array1:
    print("( ",end="")
    for d1 in d2:
        print("(",end="")
        for x in d1:
            if tempcounterb < 3:
                print(str(x) + " , ",end="")
            else:
                print(str(x),end="")
            tempcounterb += 1
        if tempcountera < 3:
            print("),",end="")
        else:
            print(")",end="")
        tempcounterb = 1
        tempcountera+=1
    tempcountera=1
    if tempcounter < 3:
            print(" ),")
    else:
            print(" )")
    tempcounter+=1 
print(")")
from statistics import mean as XiaoChuan2
array2 = [[0 for a in range(3)] for b in range(3)]
for i in  range(0,3):
    for j in range (0,3):        
        array2[i][j] = int(XiaoChuan2([array1[i][j][0], array1[i][j][1], array1[i][j][2]]))

print("Average Value Array - 2D:")
tempcountera = 1
tempcounterb = 1
print("( ")
for d1 in array2:
    print("( ",end="")
    for x in d1:
        if tempcounterb < 3:
            print(str(x) + " , ",end="")
        else:
            print(str(x),end="")
            tempcounterb += 1
    if tempcountera < 3:
        print("),")
    else:
        print(")")
    tempcounterb = 1
    tempcountera+=1
print(")")

