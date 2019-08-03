using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebSocketSharp;
using System.Threading;

namespace WebSocketClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var websocket = new WebSocket("ws://127.0.0.1:8080/socket");
            websocket.OnMessage += Websocket_OnMessage;
            websocket.Connect();
            websocket.Send("Hello World!");
        }

        private void Websocket_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("ReceiveMessage: " + e.Data);
        }
    }
}
