   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MedicalRecordPage   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1       N� Title$  UserPage��.���� .+��� .+�]� $
��1400��$��0 20 0 0q�.+�#  MaterialDesignThemes.Wpf.Card  $��50,0,0,0q�$��34��$
��1000��$	��Top=�$
��Left=�.����  �� Orientation$ 
Horizontal=�$��28��$
��1000��$��Center=�.+��� -   $��keywordTextbox��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã HSBA��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��950���� -   $��SearchButton�����#44eb07$��20, 0, 0, 0q�$	��150����Z� .���� $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�
��������� $��Champagne & Limousines)�Tìm kiếm  $
��1300��$��0, 50, 25, 0q�.���� -   $��ListViewMedicalRecord��$��Visible=�$��False��$	��550�� �� View �� .P��� $��Mã HSBA�� �� Width$	 120�� �� DisplayMemberBinding �� *Id+�� $��Mã BN��$	 100�� �� *	PatientId+�� $��Ngày��$	 200�� �� *DateChecked+�� $��Chẩn đoán��$	 200�� �� *
Diagnose+�� $��Mã CSYT��$	 120�� �� *CSYTId+�� $��Mã bác sĩ��$	 150�� �� *
DoctorId+�� $��Kết luận��$	 300�� �� *
Conclusion+�� $ 50�� �� CellTemplate �� .R��� -   $��40��
��� � �$��0q�	 � ToolTip$	 Xem thông tin quyền����Z� 

 � Tag
 �� *Id+��  $	 Eye=�
�������$��Center=�$��16(�