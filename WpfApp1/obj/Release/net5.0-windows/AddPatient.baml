   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.AddPatient   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  AddUser��$	��380��$	��850�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������  � WindowStartupLocation$ CenterScreen=�.����  �� CornerRadius$ 30��$��10q����#ebd07a._��� ���#ebd07a.+�� $	��790��$	��350�� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��3* �.+���  �� Orientation$ 
Horizontal=�$��20, 0, 0, 0q�$��Bottom=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�
�������$��0, 4, 10, 0q��� -   	 ��Name$	 NameTextBox��)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	Họ tên��$	��150��.���� $��0��$��1��$ 
Horizontal=�$	��110��$��Bottom=�$
��Left=�$��20, 0, 0, 0q�.+�  $ 
CreditCard=�
�������$��0, 4, 10, 0q��� -   $	 IdCardTextBox��$

 CMND��$��80��.��(  "System.Windows.Controls.DatePicker  -     Name$ birthPicker��$	��100��$��0��$��2��$
��Left=�$��Bottom=�$
 
Ngày sinh��$��20, 0, 0, 0q��� $��0��$��3��$ 
Horizontal=�$��Bottom=�$
��Left=�$��20, 0, 0, 0q�.+�  $ HospitalBuilding=�
�������$��0, 4, 10, 0q��� -   $	 csytTextBox��$
 Cơ sở y tế��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��1��$��0��$��Bottom=�.+�  $
 Home=�
�������$��0, 4, 10, 0q��� -   $	 HomeNumberTextBox��$
 	Số nhà��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��1��$��2��$��Bottom=�.+�  $ 
HomeModern=�
�������$��0, 4, 10, 0q��� -   $	 DistrictTextBox��$
 Quận/Huyện��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��1��$��3��$��Bottom=�.+�  $
 City=�
�������$��0, 4, 10, 0q��� -   $	 CityTextBox��$
 Tỉnh/Thành phố��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��1��$��1��$��Bottom=�.+�  $ Highway=�
�������$��0, 4, 10, 0q��� -   $	 StreetTextBox��$
 Tên đường��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��2��$��0��$��Bottom=�.+�  $ History=�
�������$��0, 4, 10, 0q��� -	   $	 HisotryTextBox��$
 Tiền sử bệnh��$	��150��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��2��$��1��$��2��$��Bottom=�.+�  $ History=�
�������$��0, 4, 10, 0q��� -
   $	 FamilyHisotryTextBox��$#
 Tiền sử bệnh gia đình��$	��300��.���� $ 
Horizontal=�$��20, 0, 0, 0q�$��2��$��3��$��Bottom=�.+�  $ CloseOctagonOutline=�
�������$��0, 4, 10, 0q��� -   $	 AllergyTextBox��$
 Dị ứng thuốc��$	��150��.���� -   $��AddPatientButton��$��2��$��3��$��Thêm Bệnh Nhân�����#28d106$��10q���Z� �� -   $��CancelButton��$��3��$��3��$��Hủy��
���  ��$��10q���Z� 