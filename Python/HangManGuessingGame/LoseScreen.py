import clr
clr.AddReference("PresentationCore")
clr.AddReference("System.Xaml")
clr.AddReference("WindowsBase")
clr.AddReference("PresentationFramework")
clr.AddReference('IronPython.wpf')
import wpf

from System.Windows import Application, Window


class LoseScreen(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'LoseScreen.xaml')

    

    
        
if __name__ == '__main__':
    Application().Run(LoseScreen())

