   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1       WpfApp1.AllPrivilegeOfRole   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$#  Danh sách Quyền của Role��$	��680��$
��1250�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���� $��
0,-14,0,14q�.+��� -    ��Name$ userBox��$
��Role��$��75�� �� Left$ 40��
 �� Top$ 33��$	��796�����	#FF161617��Z� .��� $
��Left=�$��50��$	��Top=�$	��756��$��30,0,0,0q�.+��� -    ��Name$ userIDLabel��$
��Role��$��31��$ 35��$ 73��$��15,10,677,9q��� -    ��Name$ roleTextBox�� �� 
IsReadOnly$
 True��$��25��$	 380��$ 28��	 �� TextWrapping$
	 Wrap=����	#FF0B0F1B$��84,12,572,12q��� -   
 ��Name$
 RevokeButton��$��	Thu hồi��$��50��$	 856��$ 58��$	��148��$��15(�
���  ��${�False���� -   $
 GrantButton��$��Cấp quyền��$��50��$
 1042��$ 58��$	��148��$��15(�
��� � ��� -   $ groupBox��$��Quyền trên bảng��$	��495��$ 40��$	 133��$	��640�����	#FF0D0D0E��Z� � $	��460��$ 65��$	 153��$	��585��.+��� -   $ viewBox��$
��View�����	#FF0E0E0E$��8,0,299,240q���Z� .���� -    ��Name$ viewlistBox��$	��195��$	��Top=�$��0,0,-2,0q� J� RenderTransformOrigin$ 0.5,0.5&��� -	   $ 	insertBox��$��Insert�����	#FF0E0E0E$��298,0,9,240q���Z� .���� -
   $ insertlistBox��$	��195��$	��Top=�$��0,0,-2,0q�$ 0.5,0.5&��� -   $ 	deleteBox��$��Delete�����	#FF0E0E0E$��6,240,301,0q���Z� .���� -   $ deletelistBox��$	��195��$	��Top=�$��0,0,-2,0q�$ 0.5,0.5&��� -   $ editBox��$
��Edit�����	#FF0E0E0E$��301,240,7,0q���Z� .���� -   $ updatelistBox��$	��195��$	��Top=�$��0,0,-2,0q�$ 0.5,0.5&��� -   $ roleBox��$
��Role�����	#FF0E0E0E$	 711��$	 153��$	��439����Z� .���� -   $ roleListBox��$	��195��$	��Top=�$��0,0,-2,0q�$ 0.5,0.5&��� -   $ sysPrivilegeBox��$��Quyền hệ thống�����	#FF0E0E0E$	 711��$	 395��$	��439����Z� .���� -   $ sysPrivilegeListBox��$	��195��$	��Top=�$��0,0,-2,0q�$ 0.5,0.5&�