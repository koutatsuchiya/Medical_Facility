   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.DoctorProfilePage   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       N� Title$  DoctorProfilePage��.����  �� Orientation$ 
Horizontal=�.+��� $	��659��$��Images/doctorProfile.jpg��$
��Fill=�$	��453���� $	��871��$��20, 0, 0, 30q�$	��575��.+��� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
AccountKey=�
�������$��0, 4, 10, 0q��� $��Mã bác sĩ��$��Center=�$��0 0 20 0q�$	��100���� -    ��Name$ 	IdTextBox��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã nhân viên��$	��700��.���� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ Account=�
�������$��0, 4, 10, 0q��� $��	Họ tên��$��Center=�$��0 0 20 0q�$	��100���� -   $ NameTextBox��$ 	Họ tên��$	��700��.���� $ 
Horizontal=�$	��850��$��Bottom=�$
��Left=�$��20, 0, 0, 30q�.+�  $ CardAccountDetails=�
�������$��0, 4, 10, 0q��� $
��CMND��$��Center=�$��0 0 20 0q�$	��100���� -   $ IdCardTextBox��$
 CMND��$	��700��.���� $ 
Horizontal=�$	��850��$��Bottom=�$
��Left=�$��20, 0, 0, 30q�.+�  $
 Cake=�
�������$��0, 4, 10, 0q��� $��
Ngày sinh��$��Center=�$��0 0 20 0q�$	��100��(  "System.Windows.Controls.DatePicker  -   $��	DOBPicker��$	��700��$
��Left=�$��Bottom=�$ 
Ngày sinh���� $ 
Horizontal=�$��Bottom=�$
��Left=�$��20, 0, 0, 30q�.+�  $ GenderMaleFemale=�
�������$��0, 4, 10, 0q��� $��Phái��$��Center=�$��0 0 20 0q�$	��100���� -   $��GenderComboBox��$ Phái��$��Bottom=�$	��700��.@��� .��Nam�� .��Nữ�� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ 
HomeCircle=�
�������$��0, 4, 10, 0q��� $��
Quê quán��$��Center=�$��0 0 20 0q�$	��100���� -   $ HomeTownTextBox��$ 
Quê quán��$	��700��.���� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ 	Cellphone=�
�������$��0, 4, 10, 0q��� $��Số điện thoại��$��Center=�$��0 0 20 0q�$	��100���� -   $ PhoneTextBox��$ Số điện thoại��$	��700��.���� $ 
Horizontal=�$��Bottom=�$��20, 0, 0, 30q�$
��Left=�.+�  $ HospitalBuilding=�
�������$��0, 4, 10, 0q��� $��Mã CSYT��$��Center=�$��0 0 20 0q�$	��100���� -   $ HospitalBox��$ Cơ sở y tế��$	��700��.���� $ 
Horizontal=�$��20, 0, 0, 40q�$��Bottom=�$
��Left=�.+�  $ AccountCheck=�
�������$��0, 4, 10, 0q��� $��Chuyên khoa��$��Center=�$��0 0 20 0q�$	��100���� -	   $ SpecialistTextBox��$ Chuyên khoa��$	��700�� �� 
IsReadOnly$
 True��.���� -
    ��Name$ UpdateButton��$��Cập nhật�����#28d106$	��400��$��Right=���Z� 