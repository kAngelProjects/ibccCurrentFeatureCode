   M S B A M L   `   `   `  ����  IBCCProject.1    IBCCProject._1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Wartime Memories��5   	   $	��700��6"   $
��1150��6/    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6   .��5      � ��5   
   !� 5	       !� Visual 5
      r� 5      -   5        $��BackgroundVideo��5   �    r� Source$ Images/filmEffect.wmv?�6#   $	��800��6B   $	��700��6N    r� Stretch$
 Fill=�6[    r� LoadedBehavior$ Manual=�6�   5      5      .+�5   
   �� -   5        $��button1��5   ]   $��START��6   $��71��6!   $
��Left=�6-   $��311,575,0,0q�6H   $	��Top=�6l   $	��532��6�   $��20(�6�   ���	#FF949392$��SemiBold"�6�   �� 5   
   -   5        $��image1��5   L   $	��187��6   $
��Left=�6   $��
411,12,0,0q�68   $
��Fill=�6Z   $	��Top=�6i   $	��328��6�   $:��4/IBCCProject.1;component/Images/IBCCTransparent2.png��6�    K� ZIndex$ 10��6�   �� 5   
   -   5        $��adminButton��5   b   $��Admin Login��6   $��71��6'   $
��Left=�63   $��
88,575,0,0q�6N   $	��Top=�6u   $	��150��6�   ���	#FF949392$��SemiBold"�6�   $��20(�6�   �� 5   
   -   5        $��aboutButton��5   ]   $��About��6   $��71��6!   $
��Left=�6-   $��907,575,0,0q�6H   $	��Top=�6p   $	��128��6�   $��20(�6�   $��SemiBold"�6�   ���	#FF9493926�   �� 5   
   -   5         ��Name$ border1��5      ���#9c4a0e$��5q�68   	 �� CornerRadius$	 50��6L   $��95,202,726,250q�6^   
���   �$	��300��6�   ._�5      �� -   5        
 ��Name$
 canvas1��5      $	��200��6&   $	��150��62   .+�5      r� -   5         r�Name$ channel1��5      $��60,120,200,30q�61    �� Left$	 -60��6H   
 �� Top$
 -120��6Z   $
 Fill=�6l   $	��150��6{   $	��200��6�   $ 10��6�    r� Volume$ 0Q�6�   $ Manual=�6�   $ Images/RAF_Night_Raid.wmv?�6�   6  5      5      �� 5   
   -	   5        $ border3��5      ���#9c4a0e$��5q�68   $	 50��6L   $��741,213,69,250q�6^   
���   �$	��300��6�   ._�5      �� -
   5        $
 canvas3��5      $	��200��6&   $	��150��62   .+�5      r� -   5        $ thirdChannel��5      $# Images/War_Pictorial_News.wmv?�65   $��60,120,200,30q�6\   $	 -60��6s   $
 -120��6�   $
 Fill=�6�   $	��150��6�   $	��200��6�   $ 10��6�   $ 0Q�6�   $ Manual=�6�   6  5       5!      �� 5"   
   -   5        $��title��5#   D   $��WARTIME��5"      $��84��6"   $��48(�6.   $��Interface Regular)�6<   $��Center=�5#      $��458,263,391,0q�6-   $	��Top=�6Q   $	��295��6i   ���	#FF9C4A0E$��	ExtraBold"�6�   �� 5%   
   -   5        $��AnimatedText��5%      $��64,481,69,110q�6(   $��32(�6?   $
��Bold"�6M   ���	#FF9C4A0E �� TextAlignment$ Center=�6v   $��Interface Regular)�5&      $
��Wrap=�63   75Read memories in the words of the veterans themselves � Triggers 5)      :� 5*       :� RoutedEvent$ TextBlock.Loaded��6   .[�5+      �� .��5,      �� .��5-      W�  �� 
TargetName$ AnimatedText��5.       �� TargetProperty$ (TextBlock.Opacity)�5/       W� From$	 1.0X�50      	 W� To$	 0.0X�6$    g� Duration$ 0:0:5D�6-    g� AutoReverse .  g� RepeatBehavior$ Forever��51   ,   52      54      55      57      �� 58   
   -   5         ��Name$ 
title_Copy��59   >   $��MEMORIES��58      $��84��6#   $��48(�6/   $��Interface Regular)�6=   $��Center=�59   
   $��444,311,423,0q�6'   $	��Top=�6R   $	��277��6j   ���	#FF9C4A0E$��	ExtraBold"�6�   5=      5>      