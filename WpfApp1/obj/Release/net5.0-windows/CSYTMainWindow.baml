   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.CSYTMainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  CSYTMainWindow��$	��450��$	��800��.��� .+��� 
���   ���Z� .@��� $$��Quản Lý Hồ Sơ Bệnh Án�� �� 
IsSelected$
 True��
���   ���Z� .��� ���	#FFE5E5E5 � ColumnDefinitions �� $
��265* ��� $
��271* ��� $
��258* �.+��� -    ��Name$ 	labelMABN��$��Mã bệnh nhân:��$
��Left=�$��	33,73,0,0q�$	��Top=�$	��130��$��16(��� -    ��Name$ 
txtboxMABN��$
��Left=�$��
195,77,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��133��$��30��$��16(�$��2���� -   $ 	labelNGAY��$��Ngày:��$
��Left=�$��
96,120,0,0q�$	��Top=�$��66��$��16(��� -   $ 
txtboxNGAY��$
��Left=�$��195,124,0,0q�$
 Wrap=�$	��Top=�$	��133��$��24��$��16(�$��2���� -   $ labelCHUANDOAN��$��Chuẩn đoán:��$
��Left=�$��
49,164,0,0q�$	��Top=�$��98��$��16(��� -   $ txtboxCHUANDOAN��$
��Left=�$��	195,0,0,0q�$
 Wrap=�$��Center=�$	��240��$��70��$��16(�$��2���� -   $ 	labelMABS��$��Mã bác sĩ:��$
��Left=�$��
192,73,0,0q�$	��Top=�$��98��$��16(�$��1��$��2���� -   $ 
txtboxMABS��$
��Left=�$��	51,77,0,0q�$
 Wrap=�$	��Top=�$	��133��$��24��$��16(�$��2���� -	   $ labelMACSYT��$��
Mã CSYT: ��$
��Left=�$��200,168,0,0q�$	��Top=�$��90��$��16(�$��1��$��2���� -
   $ MACSYT��$��MÃ CSYT��$
��Left=�$��
51,168,0,0q�$	��Top=�$	��134��$��16(�$��2���� -   $ labelMAKHOA��$��	Mã khoa:��$
��Left=�$��200,120,0,0q�$	��Top=�$��82��$��16(�$��1��$��2���� -   $ txtboxMAKHOA��$
��Left=�$��
51,124,0,0q�$
 Wrap=�$	��Top=�$	��133��$��30��$��16(�$��2���� -   $ labelKETLUAN��$��Kết luận:��$
��Left=�$��
69,263,0,0q�$	��Top=�$��78��$��16(�$��30���� -   $ txtboxKETLUAN��$
��Left=�$��194,267,0,0q�$
 Wrap=�$	��Top=�$	��240��$��70��$��16(�$��2���� -    ��Name$ btnTHEM��$��THÊM��$
��Left=�$��
20,241,0,0q�$	��Top=�$��37��$��98��$��2���� -   $ btnXOA��$
��XÓA��$
��Left=�$��
20,300,0,0q�$	��Top=�$��37��$��98��$��2���� -   $ labelMAHSBA��$��	Mã HSBA:��$
��Left=�$��
192,19,0,0q�$	��Top=�$��83��$��16(�$��1��$��2��(  "System.Windows.Controls.DatePicker  -     Name$ datepickNGAY��$
��Left=�$��194,125,0,0q�$	��Top=�$��22��$	��128��   SelectedDateFormat$ Short=�	 J� RenderTransformOrigin$	 0.5,0.5&�$��2��z�V� .~��� 
 �� ScaleX$
 1Q� �� ScaleY$	 1.5Q��� �� T� �� -   $ txtboxMAHSBA��$
��Left=�$��	52,23,0,0q�$
 Wrap=�$	��Top=�$	��133��$��30��$��16(�$��2���� -   $ 	btnSEARCH��$
��Tìm��$��2��$
��Left=�$��
190,23,0,0q�$	��Top=�$��30��$��61��	� -    	�Name$ radioTHEM_HSBA��$��
Thêm HSBA��$
��Left=�$��	50,23,0,0q�$	��Top=�$��25��$	��116��$��16(� d� 	IsChecked$
 TrueY�$	 0.5,0.5&�z�V� .~��� �� �� T�  T� X$ 0Q� T� Y$ 0Q�	� -   $ radioXOA_HSBA��$��	Xóa HSBA��$
��Left=�$��
212,23,0,0q�$	��Top=�$��25��$	��116��$��16(�$	 0.5,0.5&�$��2��z�V� .~��� �� �� T� $ 0Q�$ 0Q��� $0��*Quản Lý Hồ Sơ Bệnh Án Dịch Vụ����Z� .��� ���	#FFE5E5E5.+��� -   $ labelMAHSBA_DV��$��	Mã HSBA:��$
��Left=�$��
266,31,0,0q�$	��Top=�$��83��$��16(��� -   $ txtboxMAHSBA_DV��$
��Left=�$��
397,35,0,0q�$
 Wrap=�$	��Top=�$	��133��$��30��$��16(��� -   $ labelNGAY_DV��$��Ngày:��$
��Left=�$��
293,76,0,0q�$	��Top=�$��56��$��16(��� -   $ 
txtboxMADV��$
��Left=�$��397,125,0,0q�$
 Wrap=�$	��Top=�$	��133��$��30��$��16(��� -   $ 	labelMADV��$��Mã dịch vụ:��$
��Left=�$��256,121,0,0q�$	��Top=�$��93��$��16(��� -   $ 
labelMAKTV��$��Mã kỹ thuật viên:��$
��Left=�$��215,172,0,0q�$	��Top=�$	��134��$��16(��� -   $ txtboxMAKTV��$
��Left=�$��397,175,0,0q�$
 Wrap=�$	��Top=�$	��133��$��30��$��16(��� -   $ labelKETQUA��$��Kết quả:��$
��Left=�$��282,221,0,0q�$	��Top=�$��67��$��16(��� -   $ txtboxKETQUA��$
��Left=�$��397,225,0,0q�$
 Wrap=�$	��Top=�$	��253��$��74��$��16(��� -    $ 
btnTHEM_DV��$��THÊM��$��Center=�$��	0,321,0,0q�$	��Top=�$��37��$��98���� -!   $ btnSEARCH_DV��$
��Tìm��$
��Left=�$��
557,35,0,0q�$	��Top=�$��30��$��60��  -"   $ datepickNGAY_DV��$
��Left=�$��
396,81,0,0q�$	��Top=�$��22��$	��128��$ Short=�$	 0.5,0.5&�z�V� .~��� $
 1Q�$	 1.5Q��� �� T� �� -#   $ 	btnXOA_DV��$
��XÓA��$��Center=�$��495,321,0,0q�$	��Top=�$��37��$��98��	� -$   $ radioTHEM_DV��$��Thêm Dịch Vụ
��$
��Left=�$��	49,40,0,0q�$	��Top=�$��25��$	��132��$��16(�$
 TrueY�$	 0.5,0.5&�z�V� .~��� �� �� T� $ 0Q�$ 0Q�	� -%   $ radioXOA_DV��$��Xóa Dịch Vụ��$
��Left=�$��	49,92,0,0q�$	��Top=�$��25��$	��116��$��16(�$	 0.5,0.5&�z�V� .~��� �� �� T� $ 0Q�$ 0Q�