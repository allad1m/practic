   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $%��Длина пароля (4-50):��6   $��	10,10,0,0q�6/   �� 5   
   -   5         ��Name$ PasswordLengthTextBox��5      $��
10,30,10,0q�61   $��25��6E   $	��Top=�6Q   �� 5   
   $(��"Латинские символы:��6   $��	10,70,0,0q�6-   �� 5   
   -   5        $ LatinCharsTextBox��5      $��
10,90,10,0q�6-   $��25��6A   $	��Top=�6M   �� 5   
   $��Цифры:��6   $��
10,130,0,0q�6!   �� 5   
   -   5        $ DigitsTextBox��5      $��10,150,10,0q�6)   $��25��6>   $	��Top=�6J   �� 5   
   $"��Прочие символы:��6   $��
10,190,0,0q�6*   �� 5   
   -   5        $ SpecialCharsTextBox��5      $��10,210,10,0q�6/   $��25��6D   $	��Top=�6P    �� 
IsReadOnly$
 True��6h   �� 5   
   -   5        $-��'Сгенерировать пароль��5      $��10,250,10,0q�60   $��30��6E   $	��Top=�6Q   6i   �� 5   
   -   5        $:��4Показать сохраненные пароли��5      $��200,250,10,0q�67   $��30��6M   $	��Top=�6Y   6q   5      5      