import System.Windows
import System.Threading
import clr
import _wpf
from Easy import *
from Normal import *
from Hard import *

clr.AddReference("System.Windows.Forms")
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
from System.Windows import Application, Window
from System.ComponentModel import  *

from System.Windows import Application, Window

class Level(Window):
    def __init__(self):
        self.ui=_wpf.LoadComponent(self, 'Level.xaml')

    def level1_Click(self, sender, e):        
        form2=Easy(1)
        form2.ShowDialog()
    
    def level2_Click(self, sender, e):
        form3=Normal(2)
        form3.ShowDialog()

    
    def level3_Click(self, sender, e):
        form4=Hard(3)
        form4.ShowDialog()

   
