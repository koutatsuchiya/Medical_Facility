   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.NCV_HSBA   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  NCV_HSBA��.��� 
�����_�.+��� $$��Danh sách hồ sơ bệnh án��$��0,20,0,0q�
������� �� TextAlignment$ Center=�$��30(�$
��Bold"�$��	San Serif)���  �� Orientation$ 
Horizontal=�.+��� $	��900��.+��� $��
0 110 0 10q�.+��� $ 
Horizontal=�$��10q�.+��� -    ��Name$ SearchTextBox��$
��20 0q�
�������$	��600��
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448�� -    ��Name$ 
search_btn��$��Tìm Kiếm Chẩn Đoán��$	��200��&   System.Windows.Controls.DataGrid  -     Name$ dgv_hsba��$	��420��$	��876��   AutoGenerateColumns$ False��	   
IsReadOnly$
	 True������ 
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	Ma_HSBA+  $ Ngày khám bệnh��$	 200  �� *Ngay+  $ Chẩn đoán��$	 250  �� *	Chan_Doan+  $ Kết Luận��$	 175  �� *
Ket_Luan+  $ Mã Cơ Sở�� �� *	Ma_CSYT+  $ Mã Khoa�� �� *	Ma_Khoa+�� .+�  -   $ dgv_hsba_dv��$
��Left=�$	��420��$��20,172,20,0q�$	��440��$
	 True��$ False������ 
   $ Mã DV��$ 80  �� *Ma_DV+  $ Ngày dịch vụ��$	 200  �� *Ngay+  $ Kết Quả��$	 175  �� *	Ket_Qua+