   M S B A M L   `   `   `  ����C  ?PetDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PetDiaryPetDiary  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   G4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	       PetDiary.Statistics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PetDiary     5   	   Dwpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5	   	     � Icon$J  DC:\glorichkaProduction\курсачь\PetDiary\PetDiary\iconpage.png��5   	    � Title$ AddPet��5   	    � WindowStyle$
 None=�6    � AllowsTransparency . $	��440��6H   $	��620��6U   
������  � WindowStartupLocation$ CenterScreen=�6z   .��5      � .+�5   
   �� ���#F9FADC �� CornerRadius$ 20��6&   $��20,20,20,30q�68   ._�5      �  � ColumnDefinitions 5      �� 5      $
��0.3* �6'   �� 5      $��5* �6'   �� 5      $��2* �6'   �� 5      $
��0.3* �6'    � RowDefinitions 5      �� 5      $
��0.3* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.1* �6$   �� 5      $
��1.5* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.5* �6$   �� 5      $
��0.3* �6$   .+�5       �� $��	Statistic��6   $��1��6,   $��1��69   $��2��6I   $��25(�6]   $��Center=�6k   $��Center=�6�   $
��auto��6�   �� 5"      $��2��6   $��1��6*   $��2��6:   #  LiveCharts.Wpf.CartesianChart  5#      $��3��6%   $��2��62   $��1��6C   &   LiveCharts.Wpf.Charts.Base.Chart   Series 6T   �� * StatViewModel.SeriesCollection+	   AxisY	 5%        LiveCharts.Wpf.Axis  
   Title$
 Weight��6#      LabelFormatter 62   �� *StatViewModel.YFormatter+6h   5'      �� 5(      $	��224��6p   $��2��6}   $��3��6�   "  WpfAnimatedGif.ImageBehavior   AnimatedSource 6   �� *+)MainWindowViewModel.SelectedPet.StaticPic+6�   �� 5)      $��5��6   $��	100,0,0,0q�6*   $��1��6=    �� Orientation$ 
Horizontal=�6M   .+�5*      �� $
��Left=�6   $��Weight��6>   $��Center=�6O   $��0,19,0,-0.2q�6q   �� 5+      -   5        $��4��5+   X   $��1��6e   $��50��6u   $��30��6�   $��Bottom=�6�   $��19,0,0,0q�6�   $��14(�6�   ���#F0F0F0���#C2CAD1���	#FFABADB3��6   �� *ReportStatViewModel.Weight+ �� Mode$ TwoWay=�.��66  5-      �� 5.      $��70��6   $
��Left=�6)   $	��Add��6D   $��15,21,0,-0.2q�6�   ���#505050
�������$��10(�6�   $��PG Isadora Cyr Pro)�6�   $
��Auto��6�   ��6S   �� *StatViewModel.AddStatCommand+6�   5/      �� 50      -   5         ��Name$ butcancelpet��50   r   $��2��6U   $��5��6e   $��15,0,0,0q�6�   ���#505050
�������$��PG Isadora Cyr Pro)�6�   $��18(�6�   $��Cancel��6�   ��6   �� *)'MainWindowViewModel.CancelWindowCommand+6�   51      52      53      54      