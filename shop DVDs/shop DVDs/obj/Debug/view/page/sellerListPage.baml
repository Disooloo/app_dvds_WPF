   M S B A M L   `   `   `  ����A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  5      (    "shop_DVDs.view.page.sellerListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:shop_DVDs.view.page     5      c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   67   -   5          N� Title$  sellerListPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��71* �6   .+�5   
   � -   5        $	��top��5      .+�5      �� $��Поставщики��6   $��50(�6*   $
��Left=�5      $��Center=�5      $��20 0 0 0q�63       MaterialDesignBody1TextBlock#��[  5      ���#673AB75      �� 5      -   5        $��storeSeller��5      $��Right=�5      $��Center=�5      $��0 0 20 0q�5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�6.   $��Center=�5   *   $��Center=�5   *   �� 5       $+��%Добавить поставщика��6    $��Center=�6;   $��Center=�5!       $��5 0 0 5q�5"       5$      5%      5'      � 5(   
   -   5        $
��grid��5(      $��1��6   .+�5)      ��  �� CornerRadius$ 20��6   $��10q�6'   ._�5*      &   System.Windows.Controls.DataGrid  -   5        $��DGrid��5*         AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�5,      $
��Auto=�5-         Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик��6-   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6@   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6J   ��  �� Path$
 C_id�  51      $ Компания��6-   $	 * 6?   
 6I   �� $ company�  52      $ Телефон��6-   $	 * 6>   
 6H   �� $ phone�  53      $
 Mail��6-   $	 * 6;   
 6E   �� $
 mail�  54      $ Примечание��6-   $	 * 6A   
 6K   �� $
 note�4  .System.Windows.Controls.DataGridTemplateColumn  55         CellTemplate 56      �� 57   "   .R�58   &   �� $��
showSeller��6A   -   5        $��Подробнее��58   -   6o   59   #   5;      5=      5>      5?      5@      5B      