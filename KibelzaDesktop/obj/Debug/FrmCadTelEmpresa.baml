   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	   %    KibelzaDesktop.FrmCadTelEmpresa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	   -   5          �Name$  FrmCadTelEmpresa1��5   	    � Title$% Cadastro do Telefone da Empresa��5   	   $	��450��61   $��702.326��6>    � WindowStartupLocation$ CenterScreen=�6N    � WindowStyle$
 None=�6s   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFB06FAD��6    � Offset$
 0.11Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5        	 ��Name$	 LblCadTelEmpresa��5      $%��Cadastro do Telefone da Empresa��6*   $
��Left=�6T   $��
154,25,0,0q�6o   $	��Top=�6�   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5        $	 
LblEmpresa��5      $��Empresa��6$   $
��Left=�66   $��110,130,0,0q�6Q   $	��Top=�6f   $��20(�6~   �� 5   
   -   5        $	 LblTel��5      $��Telefone��6    $
��Left=�63   $��154,191,0,0q�6N   $	��Top=�6c   $��20(�6{   �� 5   
   -   5        $	 LblTipo��5      $
��Tipo��6!   $
��Left=�60   $��154,233,0,0q�6K   $	��Top=�6`   $��20(�6x   �� 5   
   -   5        $	 LblDescricao��5      $��Discrição��6&   $
��Left=�6:   $��154,275,0,0q�6U   $	��Top=�6j   $��20(�6�   �� 5   
   -   5        
 ��Name$
 
CmbEmpresa��5      $
��Left=�6'   $��220,130,0,0q�6B   $	��Top=�6W   $	��319��6o   $��20(�6{   $��37��6�   6�   �� 5   
   -   5         ��Name$ TxtTelefone��5      $
��Left=�6'   $��37��6B   $��250,191,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��289��6�   $��20(�6�   {�.  6�   �� 5   
   -	   5        $
 CmbTipo��5      $
��Left=�6$   $��250,233,0,0q�6?   $	��Top=�6T   $	��289��6l   $��37��6x   $��20(�6�   {�.  .@�5      �� $��Claro��6   �� 5      $	��Tim��6   �� 5      $
��Vivo��6   �� 5      $��Nextel��6   �� 5      $��Outros��6   5       �� 5!   
   -
   5        $
 CmbDescricao��5!      $
��Left=�6)   $��250,275,0,0q�6D   $	��Top=�6Y   $	��289��6q   $��37��6}   $��20(�6�   {�.  .@�5"      �� $
��Fixo��6   �� 5#      $��Celular��6   �� 5$      $��Recado��6   5%      �� 5&   
   -   5         ��Name$ 	BtnSalvar��5&      $��Salvar��6$   $
��Left=�65   $��164,370,0,0q�6P   $	��Top=�6e   $��80��6}   $��20(�6�   ���	#FF8D6A95
�������{�.  6�   �� 5'   
   -   5        $ 	BtnLimpar��5'      $��Limpar��6$   $
��Left=�65   $��299,370,0,0q�6P   $	��Top=�6e   $��80��6}   $��20(�6�   ���	#FF8D6A95
�������{�.   J� RenderTransformOrigin$ 
0.59,0.513&�6�   6�   �� 5(   
   -   5        $ BtnSair��5(      $
��Sair��6"   $
��Left=�61   $��434,370,0,0q�6L   $	��Top=�6a   $��80��6y   ���	#FF8D6A95���	#FF0E0000$��20(�6�   6�   5*      5+      