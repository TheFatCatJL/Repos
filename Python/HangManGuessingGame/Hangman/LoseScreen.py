import System.Windows
import clr
import _wpf
from Level import *
from Hangman import *
from System.Threading import *

clr.AddReference("System.Windows.Forms")
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
from System.Windows import Application, Window
from System.ComponentModel import  *


class LoseScreen(Window):
    def __init__(self):
        _wpf.LoadComponent(self, 'LoseScreen.xaml')
    
