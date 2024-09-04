﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GameLobbyClient
{
    /// <summary>
    /// Interaction logic for PrivateMessagePage.xaml
    /// </summary>
    public partial class PrivateMessagePage : Page
    {
        public ObservableCollection<string> PrivateChatMessages { get; set; }
        public ObservableCollection<string> testPrivateUsers { get; set; }

        /*
         * Might take in person object
         * Will make similar to ChatLobbyPage for now
         * Might implement a back button to return to ChatLobbyPage
         *  that user was previously in or MainLobbyPage to re-enter
         */
        public PrivateMessagePage(string userName)
        {
            InitializeComponent();
            PrivateNameBlock.Text = userName;
            DataContext = this; // Review in ChatLobbyPage for details
            PrivateChatMessages = new ObservableCollection<string>(); //Testing chat messages
            testPrivateUsers = new ObservableCollection<string>(); //Testing users

            testPrivateUsers.Add("Joe");
            testPrivateUsers.Add("Bob");

            PrivateChatMessages.Add("Joe: Hello!");
            PrivateChatMessages.Add("Joe: Finished the assignment yet?");
        }


        /*
         * User send message button, takes input from box and saves into collection
         */
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = $"{testPrivateUsers[0]}: {UserInputBox.Text}";
            PrivateChatMessages.Add(message);
            UserInputBox.Clear();
        }

        /*
         * Copied above function just to test SendMessageButton_Click
         * Make popout warning to say already in private message
         */
        private void PrivateMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = $"{testPrivateUsers[0]}: {UserInputBox.Text}";
            PrivateChatMessages.Add(message);
            UserInputBox.Clear();
        }

        /*
         * Simple logout button returns to LoginPage
         */
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }

        /*
         * Simple back button to return to ChatLobbyPage
         */
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
