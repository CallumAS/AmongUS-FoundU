   M S B A M L   `   `   `  ����C  ?FoundYou, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FoundYouFoundYou  5   	       FoundYou.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NNHotkey.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=a76ffb086700b11cH 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FoundYou     5   	     � WindowState$  	Maximized=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � Topmost .  � ShowInTaskbar .  
������  � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 5q�6      GlassFrameThickness$ 5q�61   	 J� InputBindings	 5      �� 5   
   
 �� Gesture$
 Ctrl+1��6     NHotkey.Wpf.HotkeyManager   RegisterGlobalHotkey .  �� Command 6&   �� *
Teleport+5      �� 5   
   $
 Ctrl+2��6    .  6&   �� *Skip+5      �� 5   
   $
 Ctrl+3��6    .  6&   �� *	Rainbow+5      �� 5   
   $
 Ctrl+4��6    .  6&   �� *Flash+5      .��5      �  � ColumnDefinitions 5   
   �� 5       $	��250 �6   �� 5!      $
��100* �6    � RowDefinitions 5#   
   �� 5$      $	��30* �6   �� 5%      $	��30* �6   �� 5&      $	��30* �6   �� 5'      $	��125 �6   .+�5)   
   �� $��3��6.   $��Center=�6;   $��Center=�6X   
�������
����  ���6   �� *	Imposters+6�   5*      5+      