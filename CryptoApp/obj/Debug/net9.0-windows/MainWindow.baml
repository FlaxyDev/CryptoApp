   M S B A M L   `   `   `  ����D  @CryptoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CryptoApp.ViewModelsCryptoApp.ViewModels  5   	       CryptoApp.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1vm"clr-namespace:CryptoApp.ViewModels     5   	     � Title$  	CryptoApp��5   	   $	��820��6   $	��485��6(    � 
ResizeMode$ NoResize=�5	   	    � DataContext 5      (   "CryptoApp.ViewModels.CoinViewModel  5   
   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�6-   � 5      $ DarkBlue��6   $	 1.0Q�6,   5      .��5      � 
������ .+�5   
   �� -   5         ��Name$ SearchTextBox��5      $��
24,24,24,0q�5      $��Stretch=�5      $	��Top=�5      $��35��5      $��16(�5      ��5      �� *SearchQuery+5      �� 5    
   -   5        $��Search��5       $	��Top=�5!      $��Right=�5"      $��	0,24,24,0q�5#      $��80��5$      $��35��5%      5&      �� 5(   
   $��0 70 0 0q�69   
������ ��6   �� *FilteredCoins+��5)      �� 5*      .R�5+      ��  �� Orientation$ 
Horizontal=�6!   ���	#7DD4D4D4$	��436��6Q   $��70��6]   .+�5,      �� $��5,0,0,0q�69   $��50��6K   $��50��6V   ��6    �� *Image+6V   �� 5-      $��10,0,0,0q�6%   $	��280��67   $��64��6C   .+�5.      �� $��25(�6>   $
��Bold"�6L   $	��128��6^   $
��Left=�6j   ��6(   �� *Name+6j   �� 5/      $��18(�6Z   $	��128��6h   $
��Left=�6t   ��6(   �� *
PriceUsd+	 �� StringFormat$	 ${0:F2}��6t   50      �� 51      $��Details��6!   $��85��54   !   $��Center=�55   !   $��1��56   !   $��33��6.   $��16(�57   !   ��52   !   �� * DataContext.OpenDetailsCommand+
 �� RelativeSource
 ��  �� AncestorType" ���53   !   �� ��58      �� 59   "    �� 
TargetType" ��62   .R�5:   &   �� #��z��6-   #��z��5;   )   $��1q�5<   )    �� CornerRadius$ 7��5=   )   ._�5>   *   �� $��Center=�6;   $��Center=�6X   5?   '   5@   #   5B      5C      5D      5F      5G      5H      