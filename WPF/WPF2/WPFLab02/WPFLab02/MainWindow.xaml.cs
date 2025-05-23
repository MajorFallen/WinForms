using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPFLab02
{
    public partial class MainWindow : Window
    {
        private bool isConnected = false;
        private DispatcherTimer timer;
        private int messageCount = 0;  // do naprzemiennego nadawcy (0,1)
        private readonly string[] users = { "Alice", "Bob" };

        public MainWindow()
        {
            InitializeComponent();
            UpdateMenuState();

            // Timer do odświeżania timestampów co minutę
            timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(10) };
            timer.Tick += (s, e) => UpdateTimestamps();
            timer.Start();
        }

        #region Menu handlers

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            if (!isConnected)
            {
                isConnected = true;
                UpdateMenuState();
                AddSystemMessage("Connected");
            }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                isConnected = false;
                UpdateMenuState();
                AddSystemMessage("Disconnected");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chat that can't be leaked :P\nVersion 1.0\nCreated by Mistery Trader", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UpdateMenuState()
        {
            MenuConnect.IsEnabled = !isConnected;
            MenuDisconnect.IsEnabled = isConnected;
        }

        #endregion

        #region Sending messages

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            TrySendMessage();
        }

        private void MessageInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Keyboard.Modifiers == ModifierKeys.None)
            {
                // Enter bez Shift = wyślij wiadomość
                e.Handled = true; // zapobiega dodaniu nowej linii
                TrySendMessage();
            }
            else if (e.Key == Key.Enter && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                // Shift + Enter = nowa linia, nic nie blokujemy
            }
        }

        private void TrySendMessage()
        {
            if (!isConnected)
            {
                MessageBox.Show("You must be connected to send a message.", "Not Connected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string message = MessageInput.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                string user = users[messageCount % users.Length];
                AddUserMessage(user, message, DateTime.Now);
                messageCount++;
                MessageInput.Clear();
                MessageInput.Height = Double.NaN; // reset wysokości textboxa po wysłaniu
            }
        }

        #endregion

        #region Message UI

        private void AddUserMessage(string username, string text, DateTime time)
        {
            var container = new Grid
            {
                Margin = new Thickness(0, 5, 0, 5),
                HorizontalAlignment = (messageCount % 2 == 0) ? HorizontalAlignment.Left : HorizontalAlignment.Right,
                MaxWidth = 350
            };

            // Zaokrąglony prostokąt (Border)
            var border = new Border
            {
                Background = Brushes.DarkOrange,
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(10),
                MaxWidth = 350
            };

            // StackPanel w borderze dla nazwy, tekstu i czasu
            var stack = new StackPanel();

            // Nazwa użytkownika - pogrubiona, biała
            var userText = new TextBlock
            {
                Text = username,
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.White,
                Margin = new Thickness(0, 0, 0, 5)
            };
            stack.Children.Add(userText);

            // Treść wiadomości - biała, tylko do odczytu, zaznaczalna
            var messageText = new TextBox
            {
                Text = text,
                IsReadOnly = true,
                Background = Brushes.Transparent,
                BorderThickness = new Thickness(0),
                Foreground = Brushes.White,
                TextWrapping = TextWrapping.Wrap,
                IsReadOnlyCaretVisible = false,
                Cursor = Cursors.Arrow,
                MaxHeight = 200,
                MinWidth = 50
            };
            stack.Children.Add(messageText);

            // Znacznik czasu - jasnoszary, prawy dolny róg
            var timeText = new TextBlock
            {
                Foreground = Brushes.LightGray,
                FontSize = 10,
                HorizontalAlignment = HorizontalAlignment.Right,
                Text = FormatTimestamp(time)
            };
            // Tooltip ze szczegółową datą i godziną
            timeText.ToolTip = time.ToString("dd/MM/yyyy HH:mm:ss");

            stack.Children.Add(timeText);

            border.Child = stack;
            container.Children.Add(border);

            MessagesPanel.Children.Add(container);
        }

        private void AddSystemMessage(string text)
        {
            var systemText = new TextBlock
            {
                Text = text,
                Foreground = Brushes.DarkGray,
                FontStyle = FontStyles.Italic,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 10, 0, 10)
            };

            MessagesPanel.Children.Add(systemText);
        }

        #endregion

        #region Timestamp update

        private void UpdateTimestamps()
        {
            // Przechodzimy po dzieciach MessagesPanel, szukamy Gridów z wiadomościami użytkownika
            for (int i = 0; i < MessagesPanel.Children.Count; i++)
            {
                if (MessagesPanel.Children[i] is Grid container && container.Children.Count > 0 && container.Children[0] is Border border)
                {
                    if (border.Child is StackPanel stack && stack.Children.Count >= 3)
                    {
                        var timeText = stack.Children[2] as TextBlock;
                        var userText = stack.Children[0] as TextBlock;

                        if (timeText?.ToolTip is string tooltip)
                        {
                            if (DateTime.TryParse(tooltip, out DateTime time))
                            {
                                timeText.Text = FormatTimestamp(time);
                            }
                        }
                    }
                }
            }
        }

        private string FormatTimestamp(DateTime time)
        {
            var now = DateTime.Now;
            var diff = now - time;

            if (diff.TotalMinutes < 1)
                return "Now";
            else if (diff.TotalMinutes < 15)
                return $"{(int)diff.TotalMinutes}m ago";
            else if (diff.TotalDays < 1)
                return time.ToString("HH:mm");
            else
                return time.ToString("dd/MM/yyyy");
        }

        #endregion
    }
}
