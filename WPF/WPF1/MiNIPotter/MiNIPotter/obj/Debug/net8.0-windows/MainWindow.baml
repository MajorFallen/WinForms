   M S B A M L   `   `   `  ����E  AMiNIPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MiNIPotter
MiNIPotter  5   	       MiNIPotter.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MiNIPotter     5   	     � Title$  MiNIPotter Library��5   	   $
��1200��5	   	   $	��800��6   $
��1000��5
   	   $	��600��6      PrimaryBackgroundBrush#��[  5   	     PrimaryForegroundBrush#��[ 5   	    � Icon$ 
potter.png��5   	    � 	Resources 5        HarryPotterFont��%F   &	       *�5   
   ($pack://application:,,,/#Harry Potter)�6S   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $!��Potter Books Series Library��6   #��[ 5      $��40(�5      $
��Bold"�5      $��Center=�5      $��	0,20,0,20q�5      � 5!   
   $��1��6    � ColumnDefinitions 5"      �� 5#      $	��400 �6#   �� 5$      $��* �6#   .+�5(      �� $��Visible=�6   $��Disabled=�5)        SecondaryBackgroundBrush#��[ 5*      $��10q�5+      .��5,      �� ��6   �� *Books+��5-      �� 5.      .R�5/      �� $��5q�6%    �� Padding$ 10q�60   
������� �� CornerRadius$ 10��6P   ._�50   "   �  51   &   �� 52   *   $
��Auto �68   �� 53   *   $
��Auto �68   �� 54   *   $
��Auto �68   �� 55   *   $
��Auto �68   �� 56   *   $��* �68   �� 57   *   $
��Auto �68   .+�59   &   �� $	��100��5:   ,   $
��Auto��5;   ,   $��Uniform=�5<   ,   $
��Left=�5=   ,   ��59   ,   �� *Cover+5=   ,   �� 5>   &   $��1��5?   0   $��18(�5@   0   $
��Bold"�5A   0   $
��Wrap=�5B   0   $��0,10,0,0q�5C   0   ��5>   0   �� *Title+5C   0   �� 5D   &   $��2��5E   0   $��10(�5F   0   $��0,2,0,0q�5G   0   ��5D   0   �� *Author+5G   0   �� 5H   &   $��5��60   $��12(�5I   0   $
��Left=�5J   0   �� 5K   *   $�Pages: ��6.    �� 5L   *   �6.   �� *Pages+ �� 5M   *   $� | Released: ��6.    �� 5N   *   �6.   �� *ReleaseDate+ �� StringFormat$ {0:d MMMM yyyy}��5O   '   5P   #   5Q      5R      5T      5U      �� 5X      $��🗲 Załaduj dane��6   $	��180��5Y      $��50��5Z      $��16(�5[      $
��Bold"�5\      #��[ 5]        SecondaryForegroundBrush#��[ 5^      $��Center=�5_      $	��Top=�5`      $��1��5b      ��5a      �� *LoadBooksCommand+5b      5c      5d      5e      