   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1       WpfApp1.ThanhTraMainWindow   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5fa5%http://schemas.fontawesome.com/icons/     'localclr-namespace:WpfApp1     -     � Title$)  #Xem thông tin cơ sở dữ liệu��$	��700��$
��1400�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 	Resources    	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%0  &	        &	     �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ GridMenu��.\�  $ 0��$	 250Q�  $ 0:0:0.5��$ 0Q�U� $ (UIElement.Opacity)�$ GridBackground��.\�  $ 0��$ 1Q�  $ 0:0:0.5��$ 0Q��� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ GridMenu��.\�  $ 0��$ 0Q�  $ 0:0:0.5��$	 250Q�U� $ (UIElement.Opacity)�$ GridBackground��.\�  $ 0��$ 0Q�  $ 0:0:0.5��$ 1Q� � Triggers :� 	 :� RoutedEvent$	 ButtonBase.Click��
 :� 
SourceName$
 ButtonClose��.[��� -    ��Name$ CloseMenu_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 
hsbaButton��.[��� -   $  hsbaButton_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 hsba_dvButton��.[��� -   $# hsba_dvButton_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 bnButton��.[��� -   $ bnButton_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 
csytButton��.[��� -   $  csytButton_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 nvButton��.[��� -   $ nvButton_BeginStoryboard��#��[  :� $	 ButtonBase.Click��$
 
ButtonOpen��.[��� #��[ .��� .+�� -    �Name$ GridBackground�����	#55313131 J� Opacity$ 0Q��� -	    ��Name$ 
ButtonOpen��$
��Left=�$	��Top=�$��30��$��30��$��0q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=����	#FF313131� -
   $ GridMenu��$	��250��$
��Left=�$��
-250,0,0,0q�
������� J� RenderTransformOrigin$ 0.5,0.5&� K� ZIndex$
 1000��z�V� .~��� �� �� T� .+��� .+��� $	��160��$��Images/inspector.png��$
��Fill=��� ���	#FF313131$��Champagne & Limousines)�$��18(�.@��� $��60��$��0q�.���� -   $��
hsbaButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .����  �� Orientation$ 
Horizontal=�$
��10 0q�.+�  $ 
AccountBox=�$��30��$��30��
�������$��5q�$��Center=��� $
��HSBA��$��10q�$��20(����#36454F�� $��60��$��0q�.���� -   $��hsba_dvButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountBox=�$��30��$��30��
�������$��5q�$��Center=��� $��DV HSBA��$��10q�$��20(����#36454F�� $��60��$��0q�.���� -   $��bnButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountBox=�$��30��$��30��
�������$��5q�$��Center=��� $��Bệnh nhân��$��10q�$��20(����#36454F�� $��60��$��0q�.���� -   $��
csytButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountBox=�$��30��$��30��
�������$��5q�$��Center=��� $
��CSYT��$��10q�$��20(����#36454F�� $��60��$��0q�.���� -   $��nvButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountBox=�$��30��$��30��
�������$��5q�$��Center=��� $��Nhân viên��$��10q�$��20(����#36454F�� $��60��$��0q�.���� -   $ LogoutButton��$��60��$	��250��$��0q�$
��Left=���Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ Logout=�$��30��$��30��
�������$��5q�$��Center=��� $��Đăng xuất��$��10q�$��20(����#36454F�� -   $ ButtonClose��$��Right=�$	��Top=�$��30��$��30��$��0q���Z� ��Z� .��  $ Close=�
������� � -   $
��Main��  � NavigationUIVisibility$ Hidden=�$��0,35,0,0q�