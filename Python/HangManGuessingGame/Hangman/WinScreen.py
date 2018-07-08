import System.Windows
import clr
import _wpf
from Level import *

clr.AddReference("System.Windows.Forms")
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
from System.Windows import Application, Window
from System.ComponentModel import  *
from System.Windows import Application, Window

class WinScreen(Window):
    def __init__(self):
        self.ui=_wpf.LoadComponent(self, 'WinScreen.xaml')

        

    
        


        
    
