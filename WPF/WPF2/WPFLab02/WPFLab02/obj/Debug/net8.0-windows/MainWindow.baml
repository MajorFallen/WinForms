   M S B A M L   `   `   `  ����  WPFLab02    WPFLab02.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ChatApp��5   	   $	��480��6   $	��800��6&   $	��240��62   $	��420��6B   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      �� 5      $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ MenuConnect��5   ,   $��Connect��6   6A   m� 5      -   5        $ MenuDisconnect��5   /   $��
Disconnect��6   ${�False��6`   �� 5      m� 5      -   5        $
��Exit��5      6)   5      m� 5      $
��Help��6   .@�5      m� -   5        $��About��5      6*   5      5      �� 5   
   $��1��6   $
��Auto=�6$   $��10q�6G   .��5      �� -   5         ��Name$ MessagesPanel��5      5      � 5"   
   $��2��6   $��10q�6    � ColumnDefinitions 5#      �� 5$      �� 5%      $
��Auto �6#   .+�5(      �� -   5         ��Name$ MessageInput��5(      $��0��6,   $��Center=�6<    �� AcceptsReturn$
 True��6W    �� TextWrapping$
 Wrap=�6l   " �� VerticalScrollBarVisibility$ Disabled=�5)      $��25��6j   $	��100��6y   �� 5+      -   5        $
��Send��5+      $��1��6$   $��80��64   $��5,0,0,0q�6?   $��Center=�6c   5,      5-      5.      