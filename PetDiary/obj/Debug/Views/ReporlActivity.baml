   M S B A M L   `   `   `  ����C  ?PetDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PetDiaryPetDiary  5   	       PetDiary.ReporlActivity   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   "localclr-namespace:PetDiary  5   	     � Icon$J  DC:\glorichkaProduction\курсачь\PetDiary\PetDiary\iconpage.png��5	   	    � Title$ Activity��5
   	    � WindowStyle$
 None=�6    � AllowsTransparency . $	��440��6J   $	��620��6W   
������  � WindowStartupLocation$ CenterScreen=�6|   .��5      � .+�5   
   �� ���#F9FADC �� CornerRadius$ 20��6&   $��20,20,20,30q�68   ._�5      �  � ColumnDefinitions 5      �� 5      $
��0.3* �6'   �� 5      $��2* �6'   �� 5      $��* �6'   �� 5      $
��0.3* �6'    � RowDefinitions 5      �� 5      $
��0.3* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.1* �6$   �� 5      $
��1.5* �6$   �� 5      $
��0.3* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.3* �6$   .+�5      �� $ ��Report Note about activity��6   $��1��6=   $��1��6J   $��2��6Z   $��25(�6n   $��Center=�6|   $��Center=�6�   $
��auto��6�   �� 5!      $��2��6   $��1��6*   $��2��6:   �� 5"      $��3��6   ���#505050$ 10��6;    �� Padding$ 7q�6N   $��1��6Z   $��4��6j   ._�5#      �  5$      �� 5%      $
��0.2* �6/   �� 5&      $
��0.5* �6/   �� 5'      $��* �6/   �� 5(      $
��0.2* �6/    5*      �� 5+      �� 5,      �� 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      �� 53      �� 54      .+�57      �� $��Hours��6    $��2��60   $��1��6=   
�������$
��Left=�6`   �� 58      -   5        	 ��Name$	 txthours��58   "   $��2��64   $��2��6A   ���#F0F0F0���#505050$��12(�6{   ���	#FFABADB3.��6�   ��59      �� 5:   "   
 �� Path$#
 ReportActivityViewModel.Hours�6*    �� Mode$ TwoWay=�6O    �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�6z    �� ValidationRules 5;   &   5  /System.Windows.Controls.DataErrorValidationRule  5<   *   5>   #   .��5?   ,   5@      �� 5A      $��Minutes��6    $��3��62   $��1��6?   
�������$
��Left=�6b   �� 5B      -   5        $	 
txtminutes��5B   "   $��3��66   $��2��6C   ���#F0F0F0���#505050$��12(�6�   ���	#FFABADB3.��6�   ��5C      �� 5D   "   $%
 ReportActivityViewModel.Minutes�6*   $ TwoWay=�6Q    . $ PropertyChanged=�6|    5E   &     5F   *   5H   #   .��5I   ,   5J      �� 5K      $��Comment��6    $��4��62   $��1��6?   
�������$
��Left=�6b   �� 5L      -   5        $	 
txtcomment��5L   "    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6K   $��4��6`   $��2��6m   $��2��6~   ���#F0F0F0���#505050$��12(�6�   ���	#FFABADB3.��6�   ��5M      �� 5N   "   $%
 ReportActivityViewModel.Comment�6*   $ TwoWay=�6Q    . $ PropertyChanged=�6|    5O   &     5P   *   5R   #   .��5S   ,   5T      �� 5U      $��Location��6    $��1��63   $��1��6@   
�������$
��Left=�6c   �� 5V      -   5        $	 	txtcoment��5V   "   $��1��65   $��12(�6B   $��2��6Q   ���#F0F0F0���#505050���	#FFABADB3.��6�   ��5W      �� 5X   "   $&
  ReportActivityViewModel.Location�6*   $ TwoWay=�6R    . $ PropertyChanged=�6~    5Y   &     5Z   *   5\   #   .��5]   ,   5^      �� 5_      $
��Date��6    $��6��6/   $��1��6<   
�������$
��Left=�6_   (  "System.Windows.Controls.DatePicker  5`         SelectedDateFormat$ Short=�6%   $��2��6@   $��6��6P   $
��auto��6]      Text 5a      �� 5b   "    �� StringFormat$ 
dd/MM/yyyy��6*   $"
 ReportActivityViewModel.Date�6D   $ TwoWay=�6h    . $ PropertyChanged=�6�    5c   &     5d   *   5f   #   5h      �� 5i      $��Rating��6    $��8��61   $��1��6>   
�������$
��Left=�6a   �� 5j      -   5        $��slider��5j   >   $��8��6!   $��2��6.    � Minimum$ 0Q�6L    � Maximum$ 10Q�6X    � Value 6e   �� * ReportActivityViewModel.Rating+$ TwoWay=�6�   5k      5l      �� 5m      $	��224��6m   $��2��6z   $��3��6�   "  WpfAnimatedGif.ImageBehavior   AnimatedSource 6   �� *(&MainWindowViewModel.SelectedPet.ActPic+6�   �� 5o      $��2��6   $��5��6)   ���#505050$��Center=�6�   
�������$��18(�6�   $��20,0,0,0q�6�   $��PG Isadora Cyr Pro)�6�   $
��Save��6�   ��66   �� **(ActivityNoteViewModel.AddActivityCommand+6�   �� 5p      $��2��6   $��6��6)   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $��18(�6�   $��Cancel��6�   $��20,0,0,0q�6�   ��66   �� *)'MainWindowViewModel.CancelWindowCommand+6�   5q      5r      5s      5t      