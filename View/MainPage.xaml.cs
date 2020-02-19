using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DelayLoopGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu1.Title = "Soubor";
            menu2.Title = "Pomoc";
            userInput.Text = "Vstup uživatele";
            asmSource.Text = "Generovaný zdroj ASM";
            firstText.Text = "1. Vyberte druh vstupu";
            cyclesRadionButton.Content = "Cykly: ";
            timeCyclesRadioButton.Content = "Čas a frekvence cyklu: ";
            timeText.Text = "Čas/sec: ";
            cycleRate.Text = "Frekvence: ";
            secondText.Text = "Stiskněte tlačítko GO: ";
            thirdText.Text = "3. Uložit si zdrojový kód: ";
            fourthText.Text = "4. Kopírovat a Kopírovat/Vložit: ";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            menu1.Title = "File";
            menu2.Title = "Help";
            userInput.Text = "User input";
            asmSource.Text = "Generated ASM source";
            firstText.Text = "1. Decide wether to input: ";
            cyclesRadionButton.Content = "Cycles: ";
            timeCyclesRadioButton.Content = "Time and cycle rate: ";
            timeText.Text = "Time/sec: ";
            cycleRate.Text = "Cycle rate: ";
            secondText.Text = "2. Click on GO-Button: ";
            thirdText.Text = "3. Save the source code: ";
            fourthText.Text = "4. Copy for Copy/Paste: ";
        }
    }
}
