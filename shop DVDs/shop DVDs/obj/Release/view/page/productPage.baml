   M S B A M L   `   `   `  ���� A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  %    shop_DVDs.view.page.productPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:shop_DVDs.view.page     c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   -     N� Title$  productPage��.���  � RowDefinitions �� $	��19* ��� $	��71* �.+�� -   $	��top��.+��� $��DvD диски��$��50(�$
��Left=�$��Center=�$��20 0 0 0q�    MaterialDesignBody1TextBlock#��[  ���#673AB7�� -   $��storeProduct��$��Right=�$��Center=�$��0 0 20 0q�.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�$��Center=�$��Center=��� $��Добавить диск��$��Center=�$��Center=�$��5 0 0 5q��� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 
Horizontal=�.+�]� .+��� $$��Всего в наличии: ��$��18(�#��[  $��Center=�$��Center=��� -   $��	countItem��$�� ��$��18(�$��5 0 0 0q����#673AB7#��[  $��Center=�$��Center=�$
��Bold"�� -   $
��grid��$��1��.+���  �� CornerRadius$ 20��$��10q�._�&   System.Windows.Controls.DataGrid  -   $��DGrid��   AutoGenerateColumns .  ��. $
��Auto=�$
��Auto=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 title�  $ Категория��$ * 	 �� $
 category�  $ Поставщик��$ * 	 �� $
 seller�  $ Цена��$ * 	 �� $
 price�  $# Кол-во в наличии��$ * 	 �� $
 inStock�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��showProduct��-   $��Подробнее��