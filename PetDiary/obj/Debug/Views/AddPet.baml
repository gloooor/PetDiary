   M S B A M L   `   `   `  ����C  ?PetDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PetDiaryPetDiary  5   	   9!clr-namespace:PetDiary.ConvertersPetDiary.Converters  5   	       PetDiary.AddPet   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PetDiary     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   .local1!clr-namespace:PetDiary.Converters  5   	     � Icon$J  DC:\glorichkaProduction\курсачь\PetDiary\PetDiary\iconpage.png��5
   	    � Title$ AddPet��5   	    � WindowStyle$
 None=�6    � AllowsTransparency . $	��440��6H   $	��620��6U   
������  � WindowStartupLocation$ CenterScreen=�6z   .��5      � .+�5   
   �� ���#F9FADC �� CornerRadius$ 20��6&   $��20,20,20,30q�68   ._�5      �  � ColumnDefinitions 5      �� 5      $
��0.3* �6'   �� 5      $��2* �6'   �� 5      $��* �6'   �� 5      $
��0.3* �6'    � RowDefinitions 5      �� 5      $
��0.3* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.1* �6$   �� 5      $
��1.5* �6$   �� 5      $
��0.3* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.3* �6$   .+�5       �� $��Add Pet��6   $��1��6*   $��1��67   $��2��6G   $��25(�6[   $��Center=�6i   $��Center=�6�   $
��auto��6�   �� 5"      $��2��6   $��1��6*   $��2��6:   �� 5#      $��3��6   ���#505050$ 10��6;    �� Padding$ 7q�6N   $��1��6Z   $��4��6j   ._�5$      �  5%      �� 5&      $
��0.2* �6/   �� 5'      $
��0.5* �6/   �� 5(      $��* �6/   �� 5)      $
��0.2* �6/    5+      �� 5,      �� 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      �� 53      �� 54      �� 55      .+�57      �� $
��Left=�6    
�������$
��Name��6U   $��1��6d   $��1��6q   $��Bottom=�6�   �� 58      -   5        $��1��58   #   $��2��60   ���#F0F0F0���#505050$��12(�6�   ���	#FFABADB3��6U   �� *AddPetViewModel.Name+	 �� Mode$	 TwoWay=�.��6�   5:      �� 5;      $��Breed��6    
�������$��2��6C   $��1��6P   $
��Left=�6`   �� 5<      -   5        $��2��5<   "   $��2��6/   ���#F0F0F0���#505050$��12(�6i   ���	#FFABADB3.��6�   ��5=      �� 5>   "   
 �� Path$
 AddPetViewModel.Breed�6*   $	 TwoWay=�6G    �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�6r    �� ValidationRules 5?   &   5  /System.Windows.Controls.DataErrorValidationRule  5@   *   5B   #   .��5C   ,   5D      �� 5E      $	��Age��6    
�������$��3��6A   $��1��6N   $
��Left=�6^   �� 5F      -   5        $��3��5F   "   $��2��6/   ���#F0F0F0���#505050$��12(�6i   ���	#FFABADB3.��6�   ��5G      �� 5H   "   $
 AddPetViewModel.Age�6*   $	 TwoWay=�6E    . $ PropertyChanged=�6p    5I   &     5J   *   5L   #   .��5M   ,   5N      �� 5O      $	��Sex��6    
�������$��4��6A   $��1��6N   $
��Left=�6^   �� 5P      -   5         ��Name$ sexlist��5P   #   $��4��64   $��2��6A   $
��auto��6R    �� SelectedValue 5Q      �� 5R   "   $
 AddPetViewModel.Sex�6*    �� ValidatesOnDataErrors .  5S   &     5T   *   5V   #   5X      �� 5Y      $��Desexed��6    
�������$��5��6E   $��1��6R   $
��Left=�6b   �� 5Z      -   5         ��Name$ desexedcheck��5Z   #   $��5��69   $��2��6F    d� 	IsChecked 6V   �� *AddPetViewModel.Desexed+�� 5\      $��Insured��6    
�������$��6��6E   $��1��6R   $
��Left=�6b   �� 5]      -   5        $ insuredcheck��5]   #   $��6��69   $��2��6F    6V   �� *AddPetViewModel.Insured+�� 5_      $
��Type��6    $��7��6/   
�������$��1��6O   $
��Left=�6_   �� 5`      -   5        $ typelist��5`   #   $��7��65   $��2��6B   $
��auto��6S    5a      �� 5b   "   $
 AddPetViewModel.Type�6*    .  5c   &     5d   *   5f   #   5h      �� 5j      $��DateOfBirth��6    
�������$��8��6I   $��1��6V   $
��Left=�6f   (  "System.Windows.Controls.DatePicker  5k      $��2��6%   $��8��65   $
��auto��6B      Text 5l      �� 5m   "   $!
 AddPetViewModel.DateOfBirth�6*    �� StringFormat$ 
dd/MM/yyyy��6M   $	 TwoWay=�6g    . $ PropertyChanged=�6�    5n   &     5o   *   5q   #   5s      5t      5u      �� 5v      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$C =C:\glorichkaProduction\курсачь\PetDiary\PetDiary/1.gif��6   $	��224��6s   $��2��6�   $��3��6�   �� 5w      -   5         ��Name$ 
butsavepet��5w   6   $��2��6   $��5��6)   $��15,0,0,0q�6y   ���#505050
�������$��18(�6�   $��PG Isadora Cyr Pro)�6�   $
��Save��6�   ��6J   �� *PetViewModel.AddPetCommand+6�   �� 5x      -	   5        $ butcancelpet��5x   6   $��2��6   $��6��6)   $��15,0,0,0q�6�   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $��18(�6�   $��Cancel��6�   ��6L   �� *)'MainWindowViewModel.CancelWindowCommand+6�   5y      5z      5{      5|      