   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.Login   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  Login��$	��450��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� ����  �� 
StartPoint$ 0.1,0&� �� EndPoint$ 0.9,1&�.���  � Color$ #ebe302�� � Offset$ 1Q�� $ #ba3606��$ 0Q�.+��� $	��390��$	��Top=� �� CornerRadius$ 	0 0 180 0�����#100E17�� 	 �� Orientation$	 
Horizontal=�.+��� $	��350��.+��� $��Images/thumbnail.jpg��$	��300��$��Center=�$��30, 100q�$
��Fill=��� $	��350��.+��� $��20 40q�.+��� $-��'Hệ thống Quản lí Cơ Sở Y Tế��$��20q�
�������
 �� TextAlignment$
 Center=�$��20(�$��	San Serif)��� $	 
Horizontal=�$��10q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�$��25��$��25��
��������� -    ��Name$ UsernameTextBox��$
��10 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��
�������$	��250��
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448�� $	 
Horizontal=�$��10q�.+�  $
 Lock=�$��25��$��25��
�������G� -    G�Name$ PasswordTextBox��$
��10 0q�$ ********��
�������$	��250��
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448�� $��10q�$��Center=�.+��� -   $��LoginButton��$	��120��$��40��   MaterialDesignRaisedButton#��[  $��2q����#e82b0e���#e82b0e
������� � ToolTip$ Login��$��Đăng nhập���� $	��100��.+��� -    ��Name$ btnExit��$��10 20q�  MaterialDesignFlatButton#��[ $ Close��$��0q���Z� .��  $ Close=�
�������$��30��$��30��