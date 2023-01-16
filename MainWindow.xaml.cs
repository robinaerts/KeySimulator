using System;
using System.Windows;
using WindowsInput;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System.Threading;

namespace KeySimulator
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool started = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            started = !started;
            if (started)
            {
                start_btn.Content = "STOP";
                startKeyboardSimulation();
            } else
            {
                start_btn.Content = "START";
            }
            
        }


        private void startKeyboardSimulation()
        {
            Thread.Sleep(2000);
            InputSimulator simulator = new InputSimulator();
            int delay = Int16.Parse(delayInput.Text); 
            String key = keyInput.SelectedValue.ToString();

            while (started)
            {
                simulator.Keyboard.KeyPress(VirtualKeyCode.SPACE).Sleep(1000);
                simulator.Keyboard.KeyDown(VirtualKeyCode.LEFT).Sleep(2000);
                simulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                simulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT).Sleep(2000);
                simulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);

        }
        }
    }
}
