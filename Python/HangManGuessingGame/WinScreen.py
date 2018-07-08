import clr
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        self.ui=wpf.LoadComponent(self, 'WinScreen.xaml')
        
    def PGG_MouseLeftButtonDown(self, sender, e):
        self.ui=wpf.LoadComponent(self, 'Test.xaml')
        self.Hide()
        #self.ui=wpf.LoadComponent(self, 'LoseScreen.xaml')
       

if __name__ == '__main__':
    Application().Run(MyWindow())    

        

    
        


        
    
