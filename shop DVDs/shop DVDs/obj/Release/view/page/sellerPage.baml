   M S B A M L   `   `   `  ���� A  =ень, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:shop_DVDs.view.pageshop_DVDs.view.page  $    shop_DVDs.view.page.sellerPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:shop_DVDs.view.page     c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     N� Title$  
sellerPage��.���  � RowDefinitions �� $	��49* ��� $
��176* �.+�� -   $	��top��.+�]� $
��Left=�$��Center=�.+��� $��Поставщик: ��$��30(�$��	10 0 10 0q��� $��30(����#673AB7$��0 0 10 0q�����  �� Path$ surname��� $��30(����#673AB7���� $
 name��� $��50�� �� CornerRadius$ 20��$��50��$��Right=�$��0 0 50 0q����� .���  � Color$ #673AB7�� � Offset$ 0Q�� $ #318CE7��$ 1Q�._��� $��Center=�$��Center=����#fff$��30(����� $
 C_id�� -   $��contet��$��1��.+��� $ 20��._�#  MaterialDesignThemes.Wpf.Card  $��
10 0 0 100q�.���� $��10q�.+�]� $��0 0 0 10q�.+��� $
��Left=�$��Компания:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ company�]� $��0 0 0 10q�.+��� $
��Left=�$��mail:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $
 mail�]� $��0 0 0 10q�.+��� $
��Left=�$��Телефон:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $ phone�]� $��0 0 0 10q�.+��� $
��Left=�$��	Сайт:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $
 site�]� $��0 0 0 10q�.+��� $
��Left=�$��Заметки:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7���� $
 note�]� $��0 0 0 10q�.+��� $
��Left=�$��Статус:��$��18(��� $��Right=�$��18(�$
��Bold"����#673AB7$
��Wrap=����� $ status��� $��1��$
��Left=�$��Bottom=�.+�]� .+��� -   $
��back��$��Bottom=�$��1��$
��Left=�$��10q�   MaterialDesignPaperButton#���   .���� .+�]� .+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$��Center=�   Kind$ 
Backburger=��� $��
Назад��$��Center=�$��Center=��� -   $
��edit��$��Bottom=�$
��Left=�$��10q�#���   .���� .+�]� .+�  $��Center=�$��Center=�$
 Edit=��� $ ��Редактировать��$��Center=�$��Center=��� -   $��remove��$��Bottom=�$
��Left=�$��10q�#���   .���� .+�]� .+�  $��Center=�$��Center=�$ Remove=��� $��Удалить��$��Center=�$��Center=�