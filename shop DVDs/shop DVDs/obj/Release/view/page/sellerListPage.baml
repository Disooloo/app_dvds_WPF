   M S B A M L   `   `   `  ���� A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  (    "shop_DVDs.view.page.sellerListPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:shop_DVDs.view.page     c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   -     N� Title$  sellerListPage��.���  � RowDefinitions �� $	��19* ��� $	��71* �.+�� -   $	��top��.+��� $��Поставщики��$��50(�$
��Left=�$��Center=�$��20 0 0 0q�    MaterialDesignBody1TextBlock#��[  ���#673AB7�� -   $��storeSeller��$��Right=�$��Center=�$��0 0 20 0q�.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�$��Center=�$��Center=��� $+��%Добавить поставщика��$��Center=�$��Center=�$��5 0 0 5q�� -   $
��grid��$��1��.+���  �� CornerRadius$ 20��$��10q�._�&   System.Windows.Controls.DataGrid  -   $��DGrid��   AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�$
��Auto=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$
 C_id�  $ Компания��$	 * 
 �� $ company�  $ Телефон��$	 * 
 �� $ phone�  $
 Mail��$	 * 
 �� $
 mail�  $ Примечание��$	 * 
 �� $
 note�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��
showSeller��-   $��Подробнее��