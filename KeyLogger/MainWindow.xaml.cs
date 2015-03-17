﻿using System;
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

namespace KeyLogger
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private KeyboardListener listener;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			listener = new KeyboardListener();
			listener.OnKeyPressed += listener_OnKeyPressed;
			listener.HookKeyboard();
		}

		public void listener_OnKeyPressed(object sender, KeyPressedArgs e)
		{
			txtBlock.Text += e.KeyPressed.ToString();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			listener.UnHookKeyboard();
		}
	}
}
