   M S B A M L   `   `   `  ����C  ?PetDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PetDiaryPetDiary  5   	       PetDiary.ReportFeeding   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PetDiary     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Icon$J  DC:\glorichkaProduction\курсачь\PetDiary\PetDiary\iconpage.png��5	   	    � Title$ Activity��5
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
��0.3* �6$   .+�5      �� $��Report Note about feeding��6   $��1��6<   $��1��6I   $��2��6Y   $��25(�6m   $��Center=�6{   $��Center=�6�   $
��auto��6�   �� 5!      $��2��6   $��1��6*   $��2��6:   �� 5"      $��3��6   ���#505050$ 10��6;    �� Padding$ 7q�6N   $��1��6Z   $��4��6j   ._�5#      �  5$      �� 5%      $
��0.2* �6/   �� 5&      $
��0.5* �6/   �� 5'      $��* �6/   �� 5(      $
��0.2* �6/    5*      �� 5+      �� 5,      �� 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      .+�54      �� $
��Date��6    $��6��6/   $��1��6<   
�������$��Bottom=�6`   $
��Left=�6�   $��28��6�   (  "System.Windows.Controls.DatePicker  55      $��2��6%   $��6��65   $
��auto��6B   	   Text	 56      �� 57   "   
 �� Path$!
 ReportFeedingViewModel.Date�6*    �� Mode$ TwoWay=�6M    �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�6x    �� ValidationRules 58   &   5  /System.Windows.Controls.DataErrorValidationRule  59   *   5;   #   5=      �� 5>      $
��Left=�6    
�������$��WetFood��6V   $��1��6h   $��1��6u   $��Bottom=�6�   $��28��6�   �� 5?      -   5         ��Name$ wetcheck��5?   #   $��1��65   $��2��6B    d� 	IsChecked 6R   �� * ReportFeedingViewModel.WetFood+�� 5@      $
��Left=�6    
�������$��DryFood��6V   $��2��6h   $��1��6u   $��Bottom=�6�   $��28��6�   �� 5A      -   5        $ drycheck��5A   #   $��2��65   $��2��6B    6R   �� * ReportFeedingViewModel.DryFood+�� 5B      $
��Left=�6    
�������$
��Meat��6W   $��3��6f   $��1��6s   $��Bottom=�6�   $��28��6�   �� 5C      -   5        $ 	meatcheck��5C   #   $��3��66   $��2��6C    6S   �� *ReportFeedingViewModel.Meat+�� 5D      $
��Left=�6    
�������$��	Medicines��6U   $��4��6i   $��1��6v   $��Bottom=�6�   $��28��6�   �� 5E      -   5        $ medcheck��5E   #   $��4��65   $��2��6B    6R   �� *" ReportFeedingViewModel.Medicines+�� 5F      $
��Left=�6    
�������$��Other��6V   $��5��6f   $��1��6s   $��Bottom=�6�   $��28��6�   �� 5G      -   5        $ 
othercheck��5G   #   $��5��67   $��2��6D    6T   �� *ReportFeedingViewModel.Other+5H      5I      �� 5J      $	��224��6n   $��2��6{   $��3��6�   "  WpfAnimatedGif.ImageBehavior   AnimatedSource 6   �� *)'MainWindowViewModel.SelectedPet.FoodPic+6�   �� 5L      $��2��6   $��5��6)   $��20,0,0,0q�67   ���#505050
�������$��18(�6�   $��PG Isadora Cyr Pro)�6�   $
��Save��6�   ��6I   �� *(&FeedingNoteViewModel.AddFeedingCommand+6�   �� 5M      $��2��6   $��6��6e   $��20,0,0,0q�6r   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $��18(�6�   $��Cancel��6�   ��6)   �� *)'MainWindowViewModel.CancelWindowCommand+6�   5N      5O      5P      5Q      