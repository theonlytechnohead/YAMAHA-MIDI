   M S B A M L   `   `   `  ����   TouchFaders MIDI!    TouchFaders_MIDI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  
mainWindow�� � Icon$ icon.ico�� � Title$ TouchFaders MIDI�� � WindowStartupLocation$ CenterScreen=�$	��500��$	��275��$	��600��$	��300�� � 	Resources    BorderGapMaskConverter  GroupBoxSquareStyle �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels
 � ColumnDefinitions � RowDefinitions �� CornerRadius J� OpacityMask `� ConverterParameter `� 	Converter �� ElementName �� Path �� RelativeSource ��Name �� Padding  FaderProgressBar �Name �� Triggers P� Property P� Value �� 
TargetName �� Angle  ProgressBar.Progress �� Color  ProgressBar.Background  ProgressBar.Border  ProgressBarNarrowStyle'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� RepeatBehavior  �� TargetProperty! �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame" O� KeyTime# O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame$ $� KeyTime% $� Value& ��Name' J� RenderTransformOrigin�� %�  &	        &	      7   &	 �    &	 .    &	 C    &	 X    &	 m    7  7  7  �� �� " ��.���  � �� �#ABADB3��  � ��$ 1q���  � �� �� " ��.R�� 	 . 
 �� $��6 ��� $
��Auto ��� $��* ��� $��6 � �� $
��Auto ��� $
��Auto ��� $��* ��� $��6 �.+��� 
������ #��z��#��z��$��4��$��0��$ 4��$��1��$��3���� 
�������#��z��$��4��$��1��$��3�� `� $ 7��8   .1��� $ Header��$ ActualWidth��� $ ActualWidth� �� *Self+�� $ ActualHeight� �� *Self+._��� #��z��#��z��._��� 
�������#��z���� $ Header��$��1��$ 3,1,3,0q�$��0��$��2��._��� $��Header����. #	 z	 �� $��2��$��1��#��z��$��2��#	 z	 �� " �.���  � �� �� " �.R��� ���#BCBCBC$��1q�$��0q�._�� $ 
PART_Track��$��0q�.+��� ���#E6E6E6$��0q�{� $��PART_Indicator��$��0q�$
��Left=�$��Stretch=�._�� $��
Foreground��.+��� $��	Indicator�����#06B025$��	-1,1,-1,1q� P�  �@�Orientation$ Vertical=�. ��� $ 
PART_Track�� �@�LayoutTransform �� $	 -90Q��� $ 	#FF06B025���� $ 	#FFE6E6E6���� $ 	#FFBCBCBC���� " �.���  � ��8   ��  � ��8  ��  � ��8  ��  � ��$ 1q���  � �� �� " �.R�� $ TemplateRoot��   CommonStates��.   Determinate��  Indeterminate��. �� $ Forever��.��U� $V  P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$! 	Animation��.\�  $" 0��$
# 0.25Q�  $" 0:0:1��$
# 0.25Q�  $" 0:0:2��$
# 0.25Q�*� $'  !(UIElement.RenderTransformOrigin)�$! 	Animation��.'�  $$ 0��$% -0.5,0.5&�  $$ 0:0:1��$% 0.5,0.5&�  $$ 0:0:2��$% 1.5,0.5&�.+��� #��z��#��z��#��z���� $& 
PART_Track��� $ PART_Indicator��}�. $
��Left=�.+��� $& 	Indicator��#��z��$��
0, 1, 0, 1q��� $& 	Animation��#��z��$��
0, 1, 0, 1q�$' 0.5,0.5&�z�V� .~��� �� �� T�  P�  �@�Orientation$ Vertical=�. ��� $ TemplateRoot�� �@�LayoutTransform �� $	 -90Q�P�  �@�IsIndeterminate . . ��� $ 	Indicator�� � y�$ 	Collapsed=�.��� -   $ mainGrid��( � LayoutTransform( �� -   ApplicationScaleTransform��) �� CenterX$) 0Q�* �� CenterY$* 0Q�+ �� ScaleX+ �� *
ScaleValue+$ 
mainWindow��, �� ScaleY, �� *
ScaleValue+$ 
mainWindow��.+�� 
 �� ��  �� �� .+��� $��MIDI control��$��
5, 5, 0, 0q�#���  .���  �� �� 
 �� �� $��2* �.+��� -   - ��Name$- startMIDIButton��$��
Start MIDI��$��Center=�$��Center=�$	��5,1q�$��76��$��0q�{�.  �� -   $- refreshMIDIButton��$��Refresh MIDI��$��Center=�$��Center=�$��1q�$��76��{�.  $��2���� -   $- stopMIDIButton��$��	Stop MIDI��$��Center=�$��Center=�$��1q�$��76��$��1��{�.  �� -   . ��Name$. inputMIDIComboBox��$��1��$��Center=�{�.  $��0,22,0,0q��� -   $. outputMIDIComboBox��$��1��$��Center=�{�.  $��1��$��0,22,0,0q��� $��MIDI input device��$��1��$��Center=�$��22��$��Center=�$��0q�$��0,0,0,22q��� $��MIDI output device��$��1��$��Center=�$��24��$��Center=�$��0q�$��1��$��0,0,0,22q��� $��1��$��Console��$��
5, 0, 0, 5q�#���  .���  �� �� 
 �� �� .+��� -	   $- infoWindowButton��$��Open status��$��Center=�$��Center=�$��1q�$��76���� -
   $- configWindowButton��$��Edit config��$��Center=�$��Center=�$��1��$��1q�$��76��� $��1��$��2�� �� �� 
 �� $��3* ��� .+��� -   / ��Name$/ selectedChannelName��$
��Name��$��14(�$��Center=�$
��Left=�$��Center=�$��Center=�$��5,0,0,0q�$��2q�� -   0 �Name$0 selectedChannelFader��1 � Maximum$
1 1023Q�2 � Orientation$2 Vertical=�$��1��#���  $��2��3 � Value$	3 823Q��� -   $& selectedChannelColour�����	#FFF4F4F5$��1��
���   �$��0��$��5q��� -   4 ��Name$4 selectedChannelImage��$��1��5 J� Opacity$
5 0.56Q��� $��OSC devices��$��1��$��
5, 5, 5, 5q�#���  $��2��.���  �� �� �� $��2* �
 �� �� .+��� -   $- addDeviceButton��$��
Add device��$��Center=�$��Center=�$��1q�$��76���� -   $- refreshOSCButton��$��Refresh OSC��$��Center=�$��Center=�$��1q�$��76��{�.  $��1��$��1���� -   $- deleteDeviceButton��$��Delete device��$��Center=�$��Center=�$��1q�$��86��$��1��{�.  �� -   6 ��Name$6 deviceListBox��$��0��$��2��$��2��$��0,4,0,0q����	#FFDDDDDD���	#FFFAFAFA$��0q�   OSC_device_menu7 m� Icon��%�   &	       '�� _     7  �� .@�m� -   $��Delete��7 �� $6��0/TouchFaders MIDI;component/Resources/delete.png���� " ��.���  �@�ContextMenu8   ���� .R��� ���� *Name+�� -   $- editDeviceButton��$��Edit device��$��Center=�$��Center=�$��1q�$��76��$��1��{�.  