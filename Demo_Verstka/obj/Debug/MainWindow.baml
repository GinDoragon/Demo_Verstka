   M S B A M L   `   `   `  ����G  CDemo_Verstka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Demo_VerstkaDemo_Verstka  5   	       Demo_Verstka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Demo_Verstka     5   	     � Title$  Попрыженок��5   	   $	��500��6   $	��800��6)    � Icon$ Resources/icon.ico��65   .��5	      �  � RowDefinitions 5
   
   �� 5      -   5         ��Name$ Header��5      $��50 �6,   �� 5      $��1* �6   �� 5      -   5        $ Border��5      $��49 �6,   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   ���#43DCFE.+�5      �� $��Попрыженок��6    K� ZIndex$ 1��6)    	  Title#��[  6:   $��	300,0,0,0q�6Y   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   ���#43DCFE.+�5      �� -   5         ��Name$
 Back��5      $��
Назад��6#   $��10q�63   $	��100��6?   6K   5      �� 5   
   $��Resources/logo.png��6   $��Right=�6,   $��0, 0, 10, 0q�6H    � 5   
   -   5        $��	MainFrame��5      $
��auto��6!     � NavigationUIVisibility$ Hidden=�6/   $��1��6O   5      5      