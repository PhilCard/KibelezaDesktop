   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	   )    #KibelzaDesktop.FrmCadTelFuncionario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	   -   5          �Name$  FrmCadTelFuncionario1��5   	    � Title$) #Cadastro do Telefone do Funcionario��5   	   $	��450��65   $��659.302��6B    � WindowStartupLocation$ CenterScreen=�6R    � WindowStyle$
 None=�6w   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFB06FAD��6    � Offset$
 0.11Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      � .+�5   
   �� -   5         ��Name$ LblCadTelFuncionario��5      $*��$Cadastro do Telefone do Funcionário��6.   $
��Left=�6\   $��
110,56,0,0q�6w   $	��Top=�6�   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5        $ LblNome��5      $
��Nome��6!   $
��Left=�60   $��
63,144,0,0q�6K   $	��Top=�6_   $��20(�6w   �� 5   
   -   5        $ LblTel��5      $��Telefone��6    $
��Left=�63   $��
90,200,0,0q�6N   $	��Top=�6b   $��20(�6z   �� 5   
   -   5        $ LblTipo��5      $
��Tipo��6!   $
��Left=�60   $��
90,242,0,0q�6K   $	��Top=�6_   $��20(�6w   �� 5   
   -   5        $ LblDescricao��5      $��Descrição��6&   $
��Left=�6:   $��
90,284,0,0q�6U   $	��Top=�6i   $��20(�6�   �� 5   
   -   5        	 ��Name$	 CmbNome��5      $
��Left=�6$   $��155,148,0,0q�6?   $	��Top=�6T   $	��394��6l   $��20(�6x   6�   �� 5   
   -   5        
 ��Name$
 TxtTelefone��5      $
��Left=�6'   $��37��6B   $��200,200,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��240��6�   $��20(�6�   {�.  6�   �� 5   
   -	   5        $	 CmbTipo��5      $
��Left=�6$   $��200,246,0,0q�6?   $	��Top=�6T   $	��240��6l   $��20(�6x   {�.  .@�5      �� $��Claro��6   �� 5      $	��Tim��6   �� 5      $
��Vivo��6   �� 5      $��Nextel��6   �� 5      $��Outros��6   5      �� 5   
   -
   5        $	 CmbDescricao��5      $
��Left=�6)   $��200,288,0,0q�6D   $	��Top=�6Y   $	��240��6q   $��20(�6}   {�.  .@�5      �� $
��Fixo��6   �� 5       $��Celular��6   �� 5!      $��Recado��6   5"      �� 5#   
   -   5         ��Name$ 	BtnSalvar��5#      $��SALVAR��6$   $
��Left=�65   $��
90,371,0,0q�6P   $	��Top=�6d   $��90��6|   ���	#FF8D6A95
�������$��20(�6�   $��35��6�   {�.  6�   �� 5$   
   -   5        $ 	BtnLimpar��5$      $��LIMPAR��6$   $
��Left=�65   $��220,371,0,0q�6P   $	��Top=�6e   $��90��6}   ���	#FF8D6A95
�������$��20(�6�   $��35��6�   {�.  6�   �� 5%   
   -   5        $ BtnSair��5%      $
��SAIR��6"   $
��Left=�61   $��346,371,0,0q�6L   $	��Top=�6a   $��90��6y   $��20(�6�   ���	#FF0E0000���	#FF8D6A95$��35��6�   6�   5'      5(      