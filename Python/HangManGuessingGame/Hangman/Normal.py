import System.Windows
import clr
import _wpf
import _random
from HangManEngine import *

clr.AddReference("System.Windows.Forms")
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
from System.Windows import Application, Window
from System.ComponentModel import  *

def runStarter(buttonarray,tbArray,baseword,settings0):
    LetterRandomisation(buttonarray,baseword,settings0)
    setTArray(tbArray,baseword,buttonarray)

class Normal(Window):
    def __init__(self,settings):
        _wpf.LoadComponent(self, 'Normal.xaml')
        self.ButtonArray = [self.Button1,self.Button2,self.Button3,self.Button4,self.Button5,self.Button6,self.Button7,self.Button8,self.Button9,self.Button10,self.Button11,self.Button12,self.Button13,self.Button14,self.Button15,self.Button16]
        self.bw = retrieveWord(settings)
        self.Settings = settings
        self.tba = [self.T1,self.T2,self.T3,self.T4,self.T5,self.T6,self.T7,self.T8]          
        self.LP = 5
        self.hms=self.HangManStatus
        self.LifeLabel.Content = str(self.LP)
        runStarter(self.ButtonArray,self.tba,self.bw,self.Settings) 
    
    def Button1_Click(self, sender, e):
        self.Button1.IsEnabled = False
        checkBaseword(self.Button1.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)

    def Button2_Click(self, sender, e):
        self.Button2.IsEnabled = False
        checkBaseword(self.Button2.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
            
    def Button3_Click(self, sender, e):
        self.Button3.IsEnabled = False        
        checkBaseword(self.Button3.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button4_Click(self, sender, e):
        self.Button4.IsEnabled = False
        checkBaseword(self.Button4.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)

    def Button5_Click(self, sender, e):
        self.Button5.IsEnabled = False
        checkBaseword(self.Button5.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button6_Click(self, sender, e):
        self.Button6.IsEnabled = False
        checkBaseword(self.Button6.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
            
    def Button7_Click(self, sender, e):
        self.Button7.IsEnabled = False		
        checkBaseword(self.Button7.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)

    def Button8_Click(self, sender, e):
        self.Button8.IsEnabled = False
        checkBaseword(self.Button8.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
            
    def Button9_Click(self, sender, e):
        self.Button9.IsEnabled = False
        checkBaseword(self.Button9.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
            
    def Button10_Click(self, sender, e):
        self.Button10.IsEnabled = False
        checkBaseword(self.Button10.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button11_Click(self, sender, e):
        self.Button11.IsEnabled = False
        checkBaseword(self.Button11.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button12_Click(self, sender, e):
        self.Button12.IsEnabled = False
        checkBaseword(self.Button12.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button13_Click(self, sender, e):
        self.Button13.IsEnabled = False
        checkBaseword(self.Button13.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button14_Click(self, sender, e):
        self.Button14.IsEnabled = False
        checkBaseword(self.Button14.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def Button15_Click(self, sender, e):
        self.Button15.IsEnabled = False
        checkBaseword(self.Button15.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
            
    def Button16_Click(self, sender, e):
        self.Button16.IsEnabled = False
        checkBaseword(self.Button16.Content,self.bw, self.tba,self.LifeLabel.Content,self.LifeLabel,self.hms,self.ButtonArray)
    
    def LifeLabel_IsEnabledChanged(self, sender, e):
        self.Close()
        
