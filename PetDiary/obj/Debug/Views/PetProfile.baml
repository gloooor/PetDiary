   M S B A M L   `   `   `  ����C  ?PetDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PetDiaryPetDiary  5   	       PetDiary.Views.PetProfile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   "localclr-namespace:PetDiary  5   	     � Icon$J  DC:\glorichkaProduction\курсачь\PetDiary\PetDiary\iconpage.png��5	   	    � Title$ Activity��5
   	    � WindowStyle$
 None=�6    � AllowsTransparency . $	��460��6J   $	��300��6W   
������  � WindowStartupLocation$ CenterScreen=�6|   .��5      � .+�5   
   �� ���#F9FADC �� CornerRadius$ 20��6&   $��20,20,20,30q�68   ._�5      � .+�5      �  � ColumnDefinitions 5      �� 5      $
��0.2* �6+   �� 5      $
��0.6* �6+   �� 5      $��* �6+   �� 5      $
��0.2* �6+    � RowDefinitions 5      �� 5      �� 5      $��4* �6(   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5%      �� $	��100��6r   $��2��6   $��1��6�   "  WpfAnimatedGif.ImageBehavior   AnimatedSource 6   �� *)'MainWindowViewModel.SelectedPet.ProfPic+6�   �� 5&      $��1��6   $��1��6-   ���#505050$ 10��6O   $��50��6a   ._�5'      �� .+�5(      �� 
�������$
��Hi, ��67   $��Center=�6F   6l   �� 5)      
�������$��Center=�6d   ��67   �� *UserViewModel.User.Login+6�   5*      5+      �� 5,      $
��Left=�6   $
��Name��6>   $��2��6M   $��1��6Z   $��Bottom=�6j   �� 5-      -   5        $��2��5-      $��2��6,   ���#F0F0F0���#C2CAD1$��12(�6f   ���	#FFABADB3.��6�   ��5.      �� 5/      	 �� Path$*	 $MainWindowViewModel.SelectedPet.Name�6&   
 �� Mode$
 TwoWay=�6R    �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�6}    �� ValidationRules 50   "   5  /System.Windows.Controls.DataErrorValidationRule  51   &   53      .��54   (   55      �� 56      $��Breed��6   $��3��6,   $��1��69   $
��Left=�6I   �� 57      -   5        $��3��57      $��2��6+   ���#F0F0F0���#C2CAD1$��12(�6�   ���	#FFABADB3.��6�   ��58      �� 59      $+	 %MainWindowViewModel.SelectedPet.Breed�6&   $
 TwoWay=�6S    . $ PropertyChanged=�6~    5:   "     5;   &   5=      .��5>   (   5?      �� 5@      $	��Age��6   $��4��6*   $��1��67   $
��Left=�6G   �� 5A      -   5        $��4��5A      $��2��6+   ���#F0F0F0���#C2CAD1$��12(�6e   ���	#FFABADB3.��6�   ��5B      �� 5C      $)	 #MainWindowViewModel.SelectedPet.Age�6&   $
 TwoWay=�6Q    . $ PropertyChanged=�6|    5D   "     5E   &   5G      .��5H   (   5I      �� 5J      $	��Sex��6   $��5��6*   $��1��67   $
��Left=�6G   �� 5K      -   5         ��Name$ sexlist��5K      $��5��60   $��2��6=   $
��auto��6N    �� SelectedValue 5L      �� 5M      $)	 #MainWindowViewModel.SelectedPet.Sex�6&    �� ValidatesOnDataErrors .  5N   "     5O   &   5Q      5S      �� 5T      $��Desexed��6   $��6��6.   $��1��6;   $
��Left=�6K   �� 5U      -   5         ��Name$ desexedcheck��5U      $��6��65   $��2��6B    d� 	IsChecked 6R   �� *)'MainWindowViewModel.SelectedPet.Desexed+�� 5W      $��Insured��6   $��7��6.   $��1��6;   $
��Left=�6K   �� 5X      -   5        $ insuredcheck��5X      $��7��65   $��2��6B    6R   �� *)'MainWindowViewModel.SelectedPet.Insured+�� 5Z      $
��Type��6   $��8��6+   $��1��68   $
��Left=�6H   �� 5[      -   5        $ typelist��5[      $��8��61   $��2��6>   $
��auto��6O    5\      �� 5]      $*	 $MainWindowViewModel.SelectedPet.Type�6&    .  5^   "     5_   &   5a      5c      �� 5e      $��DateOfBirth��6   $��9��62   $��1��6?   $
��Left=�6O   (  "System.Windows.Controls.DatePicker  5f      $��2��6!   $��9��61   $
��auto��6>      Text 5g      �� 5h      $1	 +MainWindowViewModel.SelectedPet.DateOfBirth�6&    �� StringFormat$ 
dd/MM/yyyy��6Y   $
 TwoWay=�6s    . $ PropertyChanged=�6�    5i   "     5j   &   5l      5n      � 5o      $��11��6   $��1��6)   $��2��69    5p      �� 5q      �� 5r      .+�5t      �� $��0��6!   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $
��Save��6�   $
��Auto��6�   ��61   �� *%#PetViewModel.ChangePetCancelCommand+6�   �� 5u      $��1��6!   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $��Cancel��6�   $
��Auto��6�   ��61   �� *)'MainWindowViewModel.CancelWindowCommand+6�   5v      5w      5x      5y      5z      5{      