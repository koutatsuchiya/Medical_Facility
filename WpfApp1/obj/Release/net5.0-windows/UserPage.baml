   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.UserPage   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1       N� Title$  UserPage��.���� .+��� .+�]� $
��1400��.+�#  MaterialDesignThemes.Wpf.Card  $��20,0,0,0q�$��34��$
��1000��$	��Top=�$
��Left=�.����  �� Orientation$ 
Horizontal=�$��34��$
��1000��$��Center=�.+��� -   $��keywordTextbox��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��950��$��Center=��� -   $��SearchButton�����#44eb07$��20, 0, 0, 0q���Z� .���� $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�
��������� $��Champagne & Limousines)�Tìm kiếm�� -   $��AddUserButton��$��Right=�
���  ��$��0, 0, 50, 0q���Z� .���� $ 
Horizontal=�.+�  $ AccountPlus=�
��������� $��Champagne & Limousines)�
Thêm User  $
��1300��$��0, 50, 25, 0q�.���� -   $��ListViewUser��$��Visible=�$��False��$	��550�� �� View �� .P��� $��Id�� �� Width$	 100�� �� DisplayMemberBinding �� *Id+�� $��Username��$	 200�� �� *
Username+�� $��Account Status��$	 200�� �� *AccountStatus+�� $��Created��$	 200�� �� *	Created+�� $��Expiry Date��$	 200�� �� *
ExpiryDate+�� $��
Last Login��$	 200�� �� *	LastLogin+�� $ 50�� �� CellTemplate �� .R��� -   $��40��
��� � �$��0q�	 � ToolTip$	 Xem thông tin quyền����Z� 

 � Tag
 �� *
Username+��  $ FileDocumentBox=�
�������$��Center=�$��16(��� $ 50�� �� .R��� -   $��40��
��� ���$��0q�$#	 Xem thông tin cá nhân user����Z� 
 �� *
Username+��  $	 Eye=�
�������$��Center=�$��16(��� $ 50�� �� .R��� -   $��40��
���  ��$��0q�$	 	Xóa User����Z� 
 �� *
Username+��  $ Delete=�
�������$��Center=�$��16(�