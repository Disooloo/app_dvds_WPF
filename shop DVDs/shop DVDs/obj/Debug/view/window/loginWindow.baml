   M S B A M L   `   `   `  ����A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:shop_DVDs.view.windowshop_DVDs.view.window  5   	   '    !shop_DVDs.view.window.loginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:shop_DVDs.view.window     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   6;   -   5          � Title$  loginWindow��5   	   $	��450��6   $	��380��6*   
������  � WindowStyle$
 None=�5	   "      MaterialDesignBody#���   5   	   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � Icon$ /assets/img/1110832.png��5   &   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      � 	 � Color$	 #673AB7��6'   
 � Offset$	
 0.0Q�67   � 5       $	 #318CE7��6'   $
 1Q�67   5!      5#      � 5%      .+�5&      �� -   5        $��close��5*      $��X��5&      $��10q�6%   ���#fff$��20(�5(       � Cursor$
 Hand��5)      $��20��5+      $��12��5,      $
��Left=�5-      $	��Top=�5.      5/      50      �� 52      $��Center=�6   .+�53      �� $��/assets/img/1110832.png��6   $��80��54      �� 55      $��DvD диски��6   $��Light"�56      $��	Helvetica)�57      $��22(�58      ���#fff$��Center=�5:      5<      �� 5>      $��1��6   .+�5?      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5@      .+�5A      �� -   5        $��loginbox��5G      $��Light"�5A      $��	Helvetica)�5B      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5C      $��20(�5D      $��Center=�5E      $	��235��5F      $��Center=�5H      ���#fff5I      '  !MaterialDesignThemes.Wpf.PackIcon  5K         Kind$ Account=�6.   ���#fff$��Center=�5M   .   $��Center=�5N   .   5O      �� 5P      $	��250��6   $��2��5Q      ���#fff J� Opacity$	 0.5Q�5S      �� 5U      $ 
Horizontal=�6   $��Center=�5V      $��0,10,0,0q�5W      .+�5X      G� -   5        $��passBox��5^   "   $��Light"�5X   "   $��	Helvetica)�5Y   "   $ Пароль��5Z   "   $��20(�5[   "   $��Center=�5\   "   $	��235��5]   "   $��Center=�5_   "   ���#fff5`   "     5b      $ Password=�6.   ���#fff$��Center=�5d   *   $��Center=�5e   *   5f      �� 5g      $	��250��6   $��2��5h      ���#fff$	 0.5Q�5j      �� 5l      $ 
Horizontal=�6   $��Center=�5m      .+�5n      �� -   5        $��enter��5s      $��
войти��5n       % !MaterialDesignOutlinedLightButton#���  5o      ���#fff
�������$
 Hand��5p   C   $��0,50,0,0q�5q      $��75��5r      5s   *   5t      5v      5w      5x      5y      