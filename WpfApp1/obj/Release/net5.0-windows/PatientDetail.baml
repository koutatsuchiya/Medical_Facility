   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.PatientDetail   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  Chi tiết bệnh nhân��$	��690��$
��1050�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�.���� .+���  �� Orientation$ 
Horizontal=�.+��� $	��659��$��Images/patient.jpg��$
��Fill=�$	��453���� $	��549��$��20, 30, 0, 30q�$	��631��.+��� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
AccountKey=�
�������$��0, 4, 10, 0q��� $��Mã bệnh nhân��$��Center=�$��0 0 20 0q�$	��100���� -    ��Name$ 	IdTextBox��$	��300�� �� 
IsReadOnly$
 True��.���� $ 
Horizontal=�$��Bottom=�$��20, 0, 0, 30q�$
��Left=�.+�  $ HospitalBuilding=�
�������$��0, 4, 10, 0q��� $��Mã CSYT��$��Center=�$��0 0 20 0q�$	��100���� -   $ HospitalBox��$	��300��$
 True��.���� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ Account=�
�������$��0, 4, 10, 0q��� $��	Họ tên��$��Center=�$��0 0 20 0q�$	��100���� -   $ NameTextBox��$	��300��$
 True��.���� $ 
Horizontal=�$��Bottom=�$
��Left=�$��20, 0, 0, 30q�.+�  $ CardAccountDetails=�
�������$��0, 4, 10, 0q��� $
��CMND��$��Center=�$��0 0 20 0q�$	��100���� -   $ IdCardTextBox��$	��300��$
 True��.���� $ 
Horizontal=�$��Bottom=�$
��Left=�$��20, 0, 0, 30q�.+�  $
 Cake=�
�������$��0, 4, 10, 0q��� $��
Ngày sinh��$��Center=�$��0 0 20 0q�$	��100���� -   $	 DOB��$	��300��$
 True��.���� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ 
HomeCircle=�
�������$��0, 4, 10, 0q��� $��Địa chỉ��$��Center=�$��0 0 20 0q�$	��100���� -   $ AddressTextBox��$	��300��$
 True��.���� $ 
Horizontal=�$��20, 0, 0, 30q�$��Bottom=�$
��Left=�.+�  $ History=�
�������$��0, 4, 10, 0q��� $��Tiền sử bệnh��$��Center=�$��0 0 20 0q�$	��100���� -   $ HistoryTextBox��$	��300��$
 True��.���� $ 
Horizontal=�$��20, 0, 0, 40q�$��Bottom=�$
��Left=�.+�  $ 	Timetable=�
�������$��0, 4, 10, 0q��� $��Tiền sử bệnh GĐ��$��Center=�$��0 0 20 0q�$	��100���� -   $ HistoryFamilyTextBox��$	��300��$
 True��.���� $ 
Horizontal=�$��20, 0, 0, 40q�$��Bottom=�$
��Left=�.+�  $ CloseOctagonOutline=�
�������$��0, 4, 10, 0q��� $��
Dị ứng��$��Center=�$��0 0 20 0q�$	��100���� -	   $ AllergyTextBox��$	��300��$
 True��.���� -
    ��Name$ UpdateButton��$��Xác nhận�����#28d106$	��400��$��Center=���Z� 