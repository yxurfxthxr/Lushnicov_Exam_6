   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PharmacyPharmacy  5   	       Pharmacy.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Pharmacy     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $-��'Ассортимент лекарств��6   $��20(�60   $
��Bold"�6>   $��0,0,0,10q�6P   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ MedicinesGrid��5      $��1��6*      AutoGenerateColumns .     
IsReadOnly . ��. $��0,0,0,10q�5   J      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *name+  5      $ Описание��6%   $ * 67   	 6A   �� *description+  5      $  Производитель��6%   $ * 6<   	 6F   �� *manufacturer+  5      $ Цена��6%   $ * 63   	 6=   �� *price+  5      $' !Единица измерения��6%   $ * 6@   	 6J   �� *unitOfMeasure+  5      $, &Количество в наличии��6%   $ * 6C   	 6M   �� *stockQuantity+  5      $ Скидка��6%   $ * 65   	 6?   �� *
discount+5      �� 5   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��Right=�6;   .+�5       �� -   5         ��Name$ OrderButton��5       $!��Оформить заказ��6*   $��35��6C   $	��100��6O   $��0,10,0,0q�6[   6m   �� 5!      -   5        $��
Войти��5!      $��35��6%   $	��100��61   $��	10,10,0,0q�6>   6Q   5"      5#      5$      