   M S B A M L   `   `   `  ����D  @Zadanie_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadanie_4.ViewZadanie_4.View  5   	   9!clr-namespace:Zadanie_4.ViewModelZadanie_4.ViewModel  5   	       Zadanie_4.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadanie_4.View     5   	   7	ViewModel!clr-namespace:Zadanie_4.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��990��6)    � DataContext 5      '  !Zadanie_4.ViewModel.MainViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$ DepartmentTlo2.jpg��6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Podaj Departament ID: ��6   $
��Left=�61   $��	21,12,0,0q�6L   $	��Top=�6_   ���	#FFFBFAFA6w   �� 5   
   $��Podaj nazwę: ��6   $
��Left=�6(   $��	21,68,0,0q�6C   $	��Top=�6V    J� RenderTransformOrigin$ 0.591,-0.692&�6n   $	��133��6�   
�������6�   �� 5   
   $��Podaj nazwę grupy: ��6   $
��Left=�6.   $��
21,129,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   
�������6�   �� 5   
   $��Dodaj nowy dział��64   $
��Left=�6O   $��
21,331,0,0q�6j   $	��Top=�6~   $	��296��6�   $��78��6�   $��14(�6�   $
��Bold"�6�   ��6   �� *AddDepartament+��6�   Z� ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5"      �  � Color$ Black��6#   	 � Offset$	 1Q�61   � 5#      $ 	#FFACA4A4��6#   5$      ��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ Black��6#   $	 0Q�61   � 5)      $ Black��6#   $	 1Q�61   5*      5,      �� 5-   
   $
��Left=�6   $��25��6-   $��	21,43,0,0q�69   
 �� TextWrapping$

 Wrap=�6L   $	��Top=�6�   $	��296��6�   ��6`   �� *NewDepartamentID+6�   �� 5.   
   $
��Left=�6   $��25��6-   $��	21,99,0,0q�69   $

 Wrap=�6L   $	��Top=�6y   $	��296��6�   ��6`   �� *	NewName+6�   �� 5/   
   $
��Left=�6   $��24��6-   $��
21,155,0,0q�69   $

 Wrap=�6M   $	��Top=�6   $	��296��6�   ��6a   �� *NewGroupName+6�   �� 51   
   $��Pokaż wszystkie działy��67   $��1��6X   $
��Left=�6h   $��
10,331,0,0q�6�   $	��Top=�6�   $	��307��6�   $��38��6�   $��14(�6�   $
��Bold"�6�   ��6   �� *GetAllDepartament+��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�67   .��54      � $ Black��6#   $	 0Q�61   � 55      $ White��6#   $	 1Q�61   56      58      �� 59   
   $��1��5<      $
��Left=�6"   $	��316��6=   $��	10,10,0,0q�6J   $	��Top=�6]   $	��307��6u   ��59      �� *Departament+ �� SelectedItem 5:      �� *ObecnyDepartament+��5=      �� 5>      .R�5?      ��  �� Orientation$ 
Horizontal=�6!   .+�5@      �� $��3q�6C   ��6$   �� *DepartmentID+6C   �� 5A      $��30,3,3,3q�6:   ��6$   �� *Name+6:   5B      5C      5E      �� 5F   
   $��Zaznacz i Usuń dział��66   $��1��6U   $
��Left=�6e   $��
10,373,0,0q�6�   $	��Top=�6�   $	��307��6�   $��38��6�   $��14(�6�   $
��Bold"�6�   ��6   �� *DeleteDepartment+��5G      �� 5H      $ 0.5,1&�6&   $ 0.5,0&�67   .��5I      � $ Black��6#   $	 1Q�61   � 5J      $ White��6#   5K      5M      5O      5P      