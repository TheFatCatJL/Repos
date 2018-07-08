import System.Windows
import clr
import _wpf
from Level import *
from Easy import *

clr.AddReference("System.Windows.Forms")
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
from System.Windows import Application, Window
from System.ComponentModel import  *

class Hangman(Window):
    def __init__(self):
        self.ui=_wpf.LoadComponent(self, 'Hangman.xaml')
        
    def Start_Click(self, sender, e):
        form1 = Level()
        form1.Show()
        self.Close()


if __name__ == '__main__':
    Application().Run(Hangman())
