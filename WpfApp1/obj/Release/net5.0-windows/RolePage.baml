   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.RolePage   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1       N� Title$  UserPage��.���� .+��� .+�]� $
��1400��.+�#  MaterialDesignThemes.Wpf.Card  $��20,0,0,0q�$��34��$
��1000��$	��Top=�$
��Left=�.����  �� Orientation$ 
Horizontal=�$��34��$
��1000��$��Center=�.+��� -   $��keywordTextbox��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Role��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��950��$��Center=��� -   $��SearchButton�����#44eb07$��20, 0, 0, 0q���Z� .���� $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�
��������� $��Champagne & Limousines)�Tìm kiếm�� -   $��AddRoleButton��$��Right=�
���  ��$��0, 0, 50, 0q���Z� .���� $ 
Horizontal=�.+�  $ AccountPlus=�
��������� $��Champagne & Limousines)�
Thêm Role  $
��1300��$��0, 50, 25, 0q�.���� -   $��ListViewRole��$��Visible=�$��False��$	��550�� �� View �� .P��� $��Id�� �� Width$	 100�� �� DisplayMemberBinding �� *Id+�� $
��Role��$	 200�� �� *
RoleName+�� $��Password Required��$	 200�� �� *PasswordRequired+�� $��Authentication Type��$	 200�� �� *AuthenticationType+�� $��Common��$	 150�� �� *Common+�� $��	Inherited��$	 150�� �� *	Inherited+�� $��Implicit��$	 150�� �� *
Implicit+�� $ 50�� �� CellTemplate �� .R��� -   $��40��
��� � �$��0q�	 � ToolTip$	 Xem thông tin quyền����Z� 

 � Tag
 �� *
RoleName+��  $ FileDocumentBox=�
�������$��Center=�$��16(��� $ 50�� �� .R��� -   $��40��
���  ��$��0q�$	 Delete Role����Z� 
 �� *
RoleName+��  $ Delete=�
�������$��Center=�$��16(�