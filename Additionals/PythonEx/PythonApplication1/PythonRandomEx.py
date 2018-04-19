print("This is a program to throw a 8-sided die until you achieve your pattern (first number followed by second number).")
firstnumcheck,secondnumcheck = True,True
while firstnumcheck == True:
    userinput1 = input("Please enter the first number (1-8): ")
    try:
        numinput1 = int(userinput1)
        if 0<numinput1<9:
            firstnumcheck = False
    except:
        firstnumcheck = True
while secondnumcheck == True:
    userinput2 = input("Please enter the second number (1-8): ")
    try:
        numinput2 = int(userinput2)
        if 0<numinput2<9:
            secondnumcheck = False
    except:
        secondnumcheck = True

print("Generating Random Numbers...")

from random import randint as XiaoChuan
exitcheck = False
seedint = 1

# iteration
while exitcheck==False:
    #seeding
    if seedint == 1:  
        temp1 = XiaoChuan(1,8)
        print (temp1)
        seedint += 1
    else:
        temp2 = XiaoChuan(1,8)
        print (temp2)
        if temp1 == numinput1 & temp2 ==numinput2:
            break
        temp1 = temp2
        seedint += 1

print("Pattern is achieved after "+str(seedint)+" tries.")