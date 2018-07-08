import random
from LoseScreen import *
from WinScreen import *
from System import Uri
from System.Windows.Media.Imaging import BitmapImage
Words = ['COIN','VENT','BEAN','FISH','GONE','SHOE','PICK','PICKLE','MASON','PERSON','LITTLE','FROG','PRUNE','LUNAR','POWER','WATER','BEACH','SHOVEL','MAGNET','POLAR','ERROR','PRIME','PHOTO','JASON','LIFU']
Words2 = ['BOTTOM','LOZENGES','NUMBER','FENCING','PRISON','MANAGE','FRINGE','BENEFIT','LASTING','GRUDGES','JIANBIN','WINTER','QUERIES','HOLISTIC','HORRIFIC','MORTIFY','MUMMER','PROTECT','SUMMON','JINGYU']
Words3 = ['NEFARIOUS','MATRICES','LACERATE','CULTIVATE','MONOLITH','MINSTREL','VICTORIOUS','LISTENER','PLAGARISM','MASTERIES','MONASTERY','EXPECTED','DEMOSTRATE','XIAOCHUAN']
Referencing = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

def retrieveWord(settings):
    if settings == 1:
        GeneratedWord=random.choice(Words)
    if settings == 2:
        GeneratedWord=random.choice(Words2)
    if settings == 3:
        GeneratedWord=random.choice(Words3)
    return GeneratedWord

def checkBaseword(thischar,bw,tarray,lifepoint,lplabel,HMS,bArray):
    gdflag = False
    counter = 0
    for X in bw:
        if X == thischar:
            tarray[counter].Text = thischar
            gdflag=True
        counter+=1    
    lifepoints = int(lifepoint)
    if gdflag == False:
        lifepoints -= 1
        if lifepoints ==4:
            uri = Uri("D:\Repos\HangManEngine\HM7.jpg")
            HMS.Source = BitmapImage(uri)
        elif lifepoints ==3:
            uri = Uri("D:\Repos\HangManEngine\HM8.jpg")
            HMS.Source = BitmapImage(uri)
        elif lifepoints ==2:
            uri = Uri("D:\Repos\HangManEngine\HM9.jpg")
            HMS.Source = BitmapImage(uri)
        elif lifepoints ==1:
            uri = Uri("D:\Repos\HangManEngine\HM10.jpg")
            HMS.Source = BitmapImage(uri)
        elif lifepoints ==0:
            uri = Uri("D:\Repos\HangManEngine\HM11.jpg")
            HMS.Source = BitmapImage(uri)
            lplabel.Content = str(lifepoints)
            for X in bArray:
                X.IsEnabled = False
            form = LoseScreen()
            form.Show()
            lplabel.IsEnabled=False

    lplabel.Content = str(lifepoints)
    myString=""
    for Y in tarray:
        myString = myString+Y.Text
    if myString == bw:
        for X in bArray:
                X.IsEnabled = False
        form = WinScreen()
        form.Show()
        lplabel.IsEnabled=False

def PreIOFeed(baseword):
    preprocessword = baseword
    preprocessFeed = Referencing
    for X in preprocessword:
        if X in preprocessFeed:
            preprocessFeed = preprocessFeed.replace(X,"")
    return preprocessFeed

def ProcessBaseword(baseword):
    modbaseword = ""
    for X in baseword:
        if X not in modbaseword:
            modbaseword += X
    return modbaseword

def IOFeedPreRandom(prefeed, settings1,baseword):
     myIOFeed = ProcessBaseword(baseword)
     counter = 0
     if settings1 == 1:
        counter =12
     elif settings1 ==2:
        counter = 16
     elif settings1 == 3:
        counter =20
     counter = counter - len(myIOFeed)
     for X in range(counter):
        Y=random.choice(prefeed)
        myIOFeed+=Y
        prefeed = prefeed.replace(Y,"")
     return myIOFeed

def IOFeedRandom(IOFeedPre,settings2):
    IOFeed=""
    if settings2 == 1:
        counter =12
    elif settings2 ==2:
        counter = 16
    elif settings2 == 3:
        counter =20
    for X in range(counter):
        Y = random.choice(IOFeedPre)
        IOFeed +=Y
        IOFeedPre = IOFeedPre.replace(Y,"")
    return IOFeed

def setTArray(tarray,bw,buttonlist):
    for X in tarray:
        X.Text = ""
    randchar = random.choice(bw)
    counter = 0
    for Y in bw:
        if Y == randchar:
            tarray[counter].Text = randchar
        counter+=1
    for Z in buttonlist:
        if Z.Content == str(randchar):
            Z.IsEnabled=False

def LetterRandomisation(buttonList,bw,settings3):
    counter =0
    myString = IOFeedRandom(IOFeedPreRandom(PreIOFeed(bw),settings3,bw),settings3)
    for X in buttonList:
        X.Content = myString[counter]
        counter +=1