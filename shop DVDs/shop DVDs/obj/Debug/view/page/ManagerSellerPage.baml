   M S B A M L   `   `   `  ����A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  5      +    %shop_DVDs.view.page.ManagerSellerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:shop_DVDs.view.page     5      c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   67   -   5          N� Title$  ManagerSellerPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��71* �6   .+�5   
   � -   5        $	��top��5      .+�5      �� $��Поставщики��6   $��50(�6*   $
��Left=�5      $��Center=�5      $��20 0 0 0q�63       MaterialDesignBody1TextBlock#��[  5      ���#673AB75      5      � 5   
   -   5        $
��grid��5      $��1��6   .+�5      ��  �� CornerRadius$ 20��6   $��10q�6'   ._�5      &   System.Windows.Controls.DataGrid  -   5        $��DGrid��5         AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�5      $
��Auto=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� 	 �� Path$
	 C_id�  5!      $ Компания��6-   $ * 6?    6I   �� $	 company�  5"      $ Телефон��6-   $ * 6>    6H   �� $	 phone�  5#      $
 Mail��6-   $ * 6;    6E   �� $
	 mail�  5$      $ Примечание��6-   $ * 6A    6K   �� $
	 note�4  .System.Windows.Controls.DataGridTemplateColumn  5%      
   CellTemplate
 5&      �� 5'   "   .R�5(   &   �� $��
showSeller��6A   -   5        $��Подробнее��5(   -   6o   5)   #   5+      5-      5.      5/      50      52      