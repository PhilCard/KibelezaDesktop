   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	   %    KibelzaDesktop.FrmCadTelCliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	   -   5          �Name$  FrmCadTelCliente1��5   	    � Title$% Cadastro do Telefone do Cliente��5   	   $	��450��61   $��576.721��6>    � WindowStartupLocation$ CenterScreen=�6N    � SizeToContent$ Height=�6s    � WindowStyle$
 None=�6�   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFB06FAD��6    � Offset$ 0Q�6-   � 5      $ White��6   $
 0.74Q�6)   5      .��5      � .+�5   
   �� -   5        	 ��Name$	 LblCadTelCliente��5      $%��Cadastro do telefone do Cliente��6*   $
��Left=�6T   $��	84,49,0,0q�6o   $	��Top=�6�   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5        $	 LblNome��5      $
��Nome��6!   $
��Left=�60   $��
84,144,0,0q�6K   $	��Top=�6_   $��20(�6w   �� 5   
   -   5        $	 LblTel��5      $��Telefone��6    $
��Left=�63   $��
87,205,0,0q�6N   $	��Top=�6b   $��20(�6z   �� 5   
   -   5        $	 LblTipo��5      $
��Tipo��6!   $
��Left=�60   $��
87,247,0,0q�6K   $	��Top=�6_   $��20(�6w   �� 5   
   -   5        $	 LblDescricao��5      $��Descrição��6&   $
��Left=�6:   $��
87,289,0,0q�6U   $	��Top=�6i   $��20(�6�   �� 5   
   -   5        
 ��Name$
 CmbNome��5      $
��Left=�6$   $��160,148,0,0q�6?   $	��Top=�6T   $	��250��6l   $��20(�6x   6�   �� 5   
   -   5         ��Name$ TxtTelefone��5      $
��Left=�6'   $��34��6B   $��190,205,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��200��6�   $��20(�6�   {�.  6�   �� 5   
   -	   5        $
 CmbTipo��5      $
��Left=�6$   $��190,247,0,0q�6?   $	��Top=�6T   $	��200��6l   {�.  $��35��6�   .@�5      �� $��Claro��6   $��20(�6+   �� 5      $	��Tim��6   $��20(�6)   �� 5      $
��Vivo��6   $��20(�6*   �� 5      $��Nextel��6   $��20(�6,   �� 5      $��Oi��6   $��24(�6(   �� 5      $��Outros��6   $��20(�6,   5      �� 5   
   -
   5        $
 CmbDescricao��5      $
��Left=�6)   $��190,291,0,0q�6D   $	��Top=�6Y   $	��200��6q   {�.  $��35��6�   .@�5       �� $
��Fixo��6   $��20(�6*   �� 5!      $��Celular��6   $��20(�6-   �� 5"      $��Recado��6   $��20(�6,   5#      �� 5$   
   -   5         ��Name$ 	BtnSalvar��5$      $��SALVAR��6$   $
��Left=�65   $��103,356,0,0q�6P   $	��Top=�6e   $��80��6}   {�.  ���	#FF8D6A95���	#FFF9F9F9$��20(�6�   $��30��6�   6�   �� 5%   
   -   5        $ 	BtnLimpar��5%      $��LIMPAR��6$   $
��Left=�65   $��216,356,0,0q�6P   $	��Top=�6e   $��80��6}   {�.  ���	#FF8D6A95���	#FFF9F9F9$��20(�6�   $��30��6�   6�   �� 5&   
   -   5        $ BtnSair��5&      $
��SAIR��6"   $
��Left=�61   $��330,356,0,0q�6L   $	��Top=�6a   $��80��6y   ���	#FF0E0000���	#FF8D6A95$��20(�6�   $��30��6�   ��6�   Z� 6�   5(      5)      