   M S B A M L   `   `   `  ����?  ;VCPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VCPOVCPO  5   	       VCPO.Window2   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:VCPO     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   �� $��-10,-10,10,10q�6   .+�5      �� -   5         ��Name$ inputN1��5      $	��100��6'   $��30��63   $
��Left=�5   
   $	��Top=�6%    �� Left$	 497��6=   
 �� Top$ 52��6O   �� 5      -   5        $ inputN2��5      $	��100��6'   $��30��63   $
��Left=�5      $	��Top=�6-   $	 500��6E   $	 118��6W   �� 5      -   5        $ inputN3��5      $	��100��6'   $��30��63   $
��Left=�5      $	��Top=�6-   $	 500��6E   $	 184��6W   �� 5      $>��8Введите размерность массива n1 ��6   $	 497��6>   $ 10��6P   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	dataGridA��5         AutoGenerateColumns$
 True��6*   $
��Left=�5      $	��400��6.   $	��170��6;   $	��Top=�6G      	RowHeight$ 30Q�5         VerticalGridLinesBrush
 ���� 	   CanUserResizeColumns$	 False��5      $ 10��64   $ 10��6E     5      -   5        $ 	dataGridB��5      $
 True��6*   $
��Left=�5      $	��400��6.   $	��117��6;   $��Center=�6G   $	 False��6b   $	 185��6   $ 10��6�   
   HeadersVisibility$
 Column=�6�   $ 30Q�5      
 ���� 5         5#      -   5        $ 	dataGridC��5#      $
 True��6*   $
��Left=�5$      $	��400��6.   $	��160��6;   $��Center=�6G   $	 307��6b   $ 10��6t   $ 30Q�5%   !   
 ���� $	 False��5'      �� 5)      -   5        $��Создать��5)      $
��Left=�6'   $��Center=�6B   $	��100��5*      $��30��6   $	 497��6@   $	 312��6R   �� 5+      $=��7Введите размерность массива n2��6   $	 500��6=   $ 87��6O    J� RenderTransformOrigin$ 0.481,1.799&�6_   $��Center=�6�   $	��Top=�6�   �� 5,      $=��7Введите размерность массива n3��6   $	 500��6=   $	 153��6O   51      54      55      