
def PromptPassword():
    return input("Please enter password: ")

import re
def CheckPassword(input):
    if len(input) < 8:
        return "Please have more than 8 characters!"
    elif not input.isalnum():
        return "Please do not enter special characters!"    
    elif input.isnumeric():
        return "Please at ensure password have alphabets!"
    elif input.isalpha():
        return "Please at ensure password have numbers!"
    elif not (any(i.isupper() for i in input)):
        return "Please at least have one upper-case alphabet!"    
    elif not (any(i.islower() for i in input)):
        return "Please at least have one lower-case alphabet!"
    else:
        myPassFlag=False
        return "That's a good password :)"

def InformResult(message):
    print(message,"\n")

myPassFlag = True

while myPassFlag==True:
    InformResult(CheckPassword(PromptPassword()))    
