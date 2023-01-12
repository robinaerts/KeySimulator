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
                simulator.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                for (int i = 0; i < 30; i++)
                {
                    simulator.Keyboard.KeyPress(VirtualKeyCode.LEFT).Sleep(10);
                    simulator.Keyboard.KeyPress(VirtualKeyCode.RIGHT).Sleep(10);
                }
                Thread.Sleep(delay*1000);
            }
        }
    }
}
