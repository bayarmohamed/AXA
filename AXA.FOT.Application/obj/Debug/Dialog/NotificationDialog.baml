   M S B A M L   `   `   `  ����  AXA.FOT.Application3    -AXA.FOT.Application.Dialog.NotificationDialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Y UPrism.Unity.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $	��300��5      $	��150��6   #  Prism.Services.Dialogs.Dialog   WindowStyle 5      �� 5   
    �� 
TargetType" �6   .�5	      ��  �� Property �@ WindowStartupLocation �� Value$ CenterScreen=�6C   �� 5
       �@�
ResizeMode$ NoResize=�6+   �� 5       �@�ShowInTaskbar .  6.   �� 5       �@�SizeToContent$ WidthAndHeight=�6.   5      .��5      � -   5         �Name$ 
LayoutRoot��5      $��5q�6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��Stretch=�6-   $��Stretch=�6K   $��0��6g   $
��Wrap=�6t   ��6   �� *	Message+6t   �� 5   
   $
��true��68   $��OK��6P   $��75��6]   $��25��6h   $��Right=�6t   $��0,10,0,0q�6�   $��1��6�    �� 	IsDefault . ��6   �� *CloseDialogCommand+6�   5      5      