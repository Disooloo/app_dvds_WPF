   M S B A M L   `   `   `  ���� A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  )    #shop_DVDs.view.page.productShowPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:shop_DVDs.view.page     c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     N� Title$  productShowPage��.���  � RowDefinitions �� $��7* ��� $	��43* �.+�� -   $	��top��.+��� $
��Left=�$��Center=�$��50 0 0 0q�.+�]� .+��� $ ��Наименование: ��$��30(��� $��30(�$��10 0 0 0q����#673AB7����  �� Path$ title��� $��50�� �� CornerRadius$ 20��$��50��$��Right=�$��0 0 50 0q����� .���  � Color$ #673AB7�� � Offset$ 0Q�� $ #318CE7��$ 1Q�._��� $��Center=�$��Center=����#fff$��30(����� $
 C_id�� -   $��center��$��1�� � ColumnDefinitions �� $	��67* ��� $	��33* �.+�� -   $��contet��.+��� $ 20��._�#  MaterialDesignThemes.Wpf.Card  $��
10 0 0 100q�.���� $��10q�.+�]� $��0 0 0 10q�.+��� $
��Left=�$��Категория:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ category�]� $��0 0 0 10q�.+��� $
��Left=�$��Рейтинг:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ rating�]� $��0 0 0 10q�.+��� $
��Left=�$��Поставщик:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ seller�]� $��0 0 0 10q�.+��� $
��Left=�$$��Стоимость за 1шт:��$��18(�]� $��Right=�.+��� $��18(�$
��Bold"����#673AB7���� $ price��� $	��₽��$��18(�$��5 0 0 0q����#673AB7]� $��0 0 0 10q�.+��� $
��Left=�$��Остаток:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ inStock�]� $��0 0 0 10q�.+��� $
��Left=�$��Описание:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7$
��Wrap=����� $ description�]� .+��� -   $
��back��$��Bottom=�$
��Left=�$��10q�   MaterialDesignPaperButton#���   .���� .+�]� .+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$��Center=�   Kind$ 
Backburger=��� $��
Назад��$��Center=�$��Center=��� -   $
��edit��$��Bottom=�$
��Left=�$��10q�#���   .���� .+�]� .+�  $��Center=�$��Center=�$
 Edit=��� $ ��Редактировать��$��Center=�$��Center=��� -   $��remove��$��Bottom=�$
��Left=�$��10q�#���   .���� .+�]� .+�  $��Center=�$��Center=�$ Remove=��� $��Удалить��$��Center=�$��Center=�� -   $��
sellerInfo��$��1��.+��� $ 20��._�  $��	10 0 0 10q�.��&   System.Windows.Controls.DataGrid  -   $��DBlist��   AutoGenerateColumns .  	   
IsReadOnly	 . ��. $
��Auto=�$
��Auto=�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 C_id�  $ Компания��$ *  �� $ company�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��
sellerShow��-	   $��Подробнее��