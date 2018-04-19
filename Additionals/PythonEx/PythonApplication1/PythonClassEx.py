class BankAccount:
    def __init__(self, accNum, customer, balance):
        self.AccNum = accNum
        self.AccName = customer.Name
        self.Balance = balance
        self.BankCustomer=customer
        
class SavingsAccount(BankAccount):
    def __init__(self, accNum, accName, balance):
        self.IntRate = 0.01
        self.Acctype = "Savings"
        super().__init__(accNum, accName, balance)
        ListOfAccounts.append(self)    
        
class CurrentAccount(BankAccount):
    def __init__(self, accNum, accName, balance):
        self.IntRate = 0.025
        self.Acctype = "Current" 
        super().__init__(accNum, accName, balance)
        ListOfAccounts.append(self) 

class OverdraftAccount(BankAccount):
    def __init__(self, accNum, accName, balance):
        self.IntRate = 0.025
        self.Acctype = "Overdraft"
        super().__init__(accNum, accName, balance)
        ListOfAccounts.append(self)

class BankBranch:
    def __init__(self, branchName, branchMgrName, listofAccounts):
        self.BranchName = branchName
        self.BranchMgrName = branchMgrName
        self.AccountsList = listofAccounts
        
    def AddAccount(self):
        myAccNum = input("Account Number: ")
        myAccName = input("Account Holder Name: ")
        
        userinput = False
        while userinput == False:
            myAccBal = input("Balance: ")
            try:
                i=int(myAccBal)
                userinput=True
            except:
                print("Please enter a valid selection")
        
        userinput=False
        while userinput == False:
            myAcctype = input("Please choose account type:\n1. Savings\n2.Current\n3.Overdraft\nYour selection: ")
            try:
                j=int(myAcctype)
                if 0< j <4:
                    userinput=True
                else:
                    print("Please enter a valid selection")
            except:
                print("Please enter a valid selection")
        if j == 1:
            newcust = SavingsAccount(myAccNum,myAccName,i)
        elif j == 2:
            newcust = CurrentAccount(myAccNum,myAccName,i)
        elif j == 3:
            newcust = OverdraftAccount(myAccNum,myAccName,i)
        self.AccountsList.append(newcust)

    def TotalDeposits(self):
        Total = 0
        print("\nTotal Deposits\n")
        print("Account No\tAccount Name\tAccount Type\tAccount Balance\t")
        for X in self.AccountsList:
            print(str(X.AccNum),"\t",X.AccName,"\t\t",X.Acctype,"\t",str(X.Balance))
            Total +=X.Balance
        print("Total Depsits: ",str(Total))

    def TotalInterestPaid(self):
        Total = 0
        print("\nTotal Interest to be paid\n")
        print("Account No\tAccount Name\tAccount Type\tAccount Balance\t")
        for X in self.AccountsList:
            print(str(X.AccNum),"\t",X.AccName,"\t\t",X.Acctype,"\t",str(X.Balance))
            if X.Acctype == "Savings":
                Total += X.Balance * 0.01
            elif X.Balance < 0:
                pass
            else:
                Total+=X.Balance*0.025
        print("Total Interests to be paid: ",str(Total))

    def TotalInterestEarned(self):
        Total = 0
        print("\nInterest to be earned\n")
        print("Account No\tAccount Name\tAccount Type\tAccount Balance\t")
        for X in self.AccountsList:
            print(str(X.AccNum),"\t",X.AccName,"\t\t",X.Acctype,"\t",str(X.Balance))
            if X.Acctype == "Overdraft" and X.Balance < 0:
                Total += X.Balance * 0.06            
        print("Total Interests to be paid: ",str(Total))
    
    def PrintCustomers(self):
        print("\nCustomer List\n")
        print("Account No\tAccount Name\tAccount Type\tAccount Balance\t")
        for X in self.AccountsList:
            print(str(X.AccNum),"\t",X.AccName,"\t\t",X.Acctype,"\t",str(X.Balance))

class Customer:
    def __init__(self, name, address, passport,dob):
        self.Name=name
        self.Address=address
        self.Passport=passport
        self.DOB = dob
        ListOfCustomers.append(self)

class CustomerMenuOptions:
    def __init__(self, acc):
        self.Account = acc

    def Withdraw(self):
        uinput = False
        while uinput == False:
            withamt = input("\nPlease enter withdrawal amount : ")
            try:
                i=int(withamt)
                if 0< i and i < self.Account.Balance and self.Account.Acctype != "Overdraft":
                    self.Account.Balance -= i
                    uinput=True
                    print("Transaction successful/n","You have $",str(self.Account.Balance)," left in your account.\n")                
                elif 0< i and self.Account.Acctype == "Overdraft":
                    self.Account.Balance -= i
                    uinput=True
                    print("Transaction successful/n","You have $",str(self.Account.Balance)," in your account.\n")
                elif 0< i and i > self.Account.Balance:
                    print("You only have $",str(self.Account.Balance)," in your account.")
                else:
                    print("Please enter an valid amount")
            except:
                print("Please enter an valid amount")

    def Deposit(self):
        uinput = False
        while uinput == False:
            depamt = input("\nPlease enter Deposit amount : ")
            try:
                i=int(depamt)
                self.Account.Balance += i
                uinput=True
                print("Transaction successful/n","You have $",str(self.Account.Balance)," in your account now.\n")
            except:
                print("Please enter an valid amount")

    def Transfer(self):
        uinput = False
        while uinput == False:
            transamt = input("\nPlease enter Transfer amount : ")
            try:
                i=int(transamt)
                if 0< i and i < self.Account.Balance and self.Account.Acctype != "Overdraft":
                    self.Account.Balance -= i
                    uinput=True        
                elif 0< i and self.Account.Acctype == "Overdraft":
                    self.Account.Balance -= i
                    uinput=True
                elif 0< i and i > self.Account.Balance:
                    print("You only have $",str(self.Account.Balance)," in your account.")
                else:
                    print("Please enter an valid amount")
            except:
                print("Please enter an valid amount")
        tinput = False
        while tinput == False:
            transkey = input("\nPlease enter who you want to transfer to : ")
            for x in ListOfAccounts:
                if str(x.AccNum) == transkey:
                    target=x
                    tinput=True
            print("There is no such account num") if tinput == False else print("Account Holder found!\n")
        
               
        target.Balance+=i

        print("Transfer Transaction successful/n","You have $",str(self.Account.Balance)," in your account.")
        print("You have transferred $",transamt," to ",str(target.AccName),".\n")

    def CheckInterest(self):
        X = self.Account
        if X.Acctype == "Overdraft" and X.Balance < 0:
            interest = X.Balance * 0.06
        else:
            interest = X.Balance * X.IntRate
        
        print("\nMy Account\n")
        print("Account No\tAccount Name\tAccount Type\tAccount Balance\t")
        print(str(X.AccNum),"\t",X.AccName,"\t\t",X.Acctype,"\t",str(X.Balance))
        print("Interest for this year: ",str(interest))
        


    
def CommonInterface(Login):
    loginflag = False
    while loginflag == False:
        print("Welcome to Bank of ISS.""\n")
        print("Please enter your username and password")
        Username = input("Username : ")
        password = input("Password : ")
        if Login.get(Username) == password and Username == "admin":
            loginflag = True
            return "admin"
        elif Login.get(Username) == password:
            loginflag = True
        elif Login.get(Username) == "None":
            print("Invalid username")
        else:
            print("Invalid password")
    return Username


def CustomerPreInterface(w):
    print("\n")
    print("Please choose your Account ")
    a=1
    for X in ListOfAccounts:
        if X.AccName==w:
            print (str(a),". ", end="")
            a+=1
            if X.Acctype == "Savings":
                saveacc = X
                print("Savings")
            elif X.Acctype == "Current":
                curracc=X
                print("Current")
            else:
                overacc = X
                print("Overdraft")
      
    uinput = False
    while uinput == False:
        choice = input("Your choice is : ")
        try:
            i=int(choice)
            if 0< i <a:
                uinput=True
            else:
                print("Please enter a valid selection")
        except:
            print("Please enter a valid selection")
    if i == 1:
        return saveacc
    elif i == 2:
        return curracc
    elif i == 3:
        return overacc
 

def CustomerInterface(acc):
    print("\nDear ",acc.AccName,", Welcome to Bank of ISS.""\n")
    print("Please choose your desired transaction: ")
    print("1. Withdraw")
    print("2. Deposit")
    print("3. Transfer")
    print("4. Check Interest")    
    userinput = False
    newCMO = CustomerMenuOptions(acc)
    while userinput == False:
        choice = input("Your choice is : ")
        try:
            i=int(choice)
            if 0< i <5:
                userinput=True
            else:
                print("Please enter a valid selection")
        except:
            print("Please enter a valid selection")
    if i == 1:
        newCMO.Withdraw()
    elif i == 2:
        newCMO.Deposit()
    elif i == 3:
        newCMO.Transfer()
    elif i == 4:
        newCMO.CheckInterest()

def BranchMainInterface():
    print("Welcome to Bank of ISS.""\n")
    print("Please choose your desired transaction: ")
    print("1. Add an Account")
    print("2. Print customer list")
    print("3. Total deposits")
    print("4. Total Interest to be paid")    
    print("5. Total Interest to be earned")
    userinput = False
    newBranch = BankBranch("XC Branch","XC",ListOfAccounts)
    while userinput == False:
        choice = input("Your choice is : ")
        try:
            i=int(choice)
            if 0< i <6:
                userinput=True
            else:
                print("Please enter a valid selection")
        except:
            print("Please enter a valid selection")
    if i == 1:
        newBranch.AddAccount()
    elif i == 2:
        newBranch.PrintCustomers()
    elif i == 3:
        newBranch.TotalDeposits()
    elif i == 4:
        newBranch.TotalInterestPaid()
    elif i == 5:
        newBranch.TotalInterestEarned()
        
def Initialisation():
    from datetime import date
    XC = Customer("XC","Demon Island","GreatDemonXYZ",date(1995,1,1))
    JB = Customer("JB","Demon Cave","SmallDemonXYZ",date(1995,1,1))
    XCSavings=SavingsAccount(1234567,XC,10000)
    XCCurrent=CurrentAccount(1234568,XC,20000)
    XCOverdraft=OverdraftAccount(1234569,XC,-30000)
    JBSavings=SavingsAccount(2234567,JB,5000)
    JBCurrent=CurrentAccount(2234568,JB,1000)
    JBOverdraft=OverdraftAccount(2234569,JB,0)
    Login = {"XC" : "123456", "JB" : "123123", "admin" : "admin"}
    return Login


Username = ""
ListOfCustomers = []
ListOfAccounts = []
Login = Initialisation()
w = CommonInterface(Login)
if w=="admin":
    BranchMainInterface()
else:
    CustomerInterface(CustomerPreInterface(w))