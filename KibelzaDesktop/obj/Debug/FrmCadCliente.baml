   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	   "    KibelzaDesktop.FrmCadCliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	   -   5          �Name$  
CadCliente��5   	    � Title$ Cadastro de Cliente��5   	   $	��379��6%   $	��748��62    � WindowStyle$
 None=�6>    � WindowStartupLocation$ CenterScreen=�6Q   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF705591��6    � Offset$
 0.05Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      � .+�5   
   �� -   5         ��Name$ LblCadCliente��5      $��Cadastro de Cliente��6'   $
��Left=�6E   $��
266,40,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��24(�6�   �� 5   
   -   5        $ LblNome��5      $
��Nome��6!   $
��Left=�60   $��
40,120,0,0q�6K   $	��Top=�6_   $��20(�6w   �� 5   
   -   5        $ LblEmail��5      $��E-mail��6"   $
��Left=�63   $��
40,160,0,0q�6N   $	��Top=�6b   $��20(�6z   �� 5   
   -   5        $ LblSenha��5      $��Senha��6"   $
��Left=�62   $��
40,200,0,0q�6M   $	��Top=�6a   $��20(�6y   �� 5   
   -   5        $ 	LblStatus��5      $��Status��6#   $
��Left=�64   $��264,204,0,0q�6O   $	��Top=�6d   $��16(�6|   �� 5   
   -   5        $ LblDataCadastro��5      $��Data Cadastro��6)   $
��Left=�6A   $��
40,245,0,0q�6\   $	��Top=�6p   $��20(�6�   �� 5   
   -   5        $ LblFoto��5      $
��Foto��6!   $
��Left=�60   $��556,150,0,0q�6K   $	��Top=�6`   $��20(�6x   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 -89.908Q�6&   T� 5      5      5      �� 5    
   -	   5         ��Name$ TxtNome��5       $
��Left=�6#   $��30��6>   $��109,120,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��300��6�   $��20(�6�    �� 	IsEnabled . {�.  6�   �� 5!   
   -
   5        $ TxtEmail��5!      $
��Left=�6$   $��30��6?   $��109,160,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��300��6�   $��20(�6�   {�.  6�   �� 5"   
   -   5        $ TxtSenha��5"      $
��Left=�6$   $��30��6?   $��109,203,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��150��6�   $��20(�6�   {�.  6�   �� 5#   
   -   5         ��Name$ 	ChkStatus��5#      $��Ativo?��6&   $
��Left=�67   $��328,210,0,0q�6R   $	��Top=�6g   $��16(�6   {�.  6�   �� 5$   
   -   5        $ TxtDataCadastro��5$      $
��Left=�6+   $��30��6F   $��180,245,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��150��6�   $��20(�6�   {�.  6�   �� 5%   
   -   5        $ TxtFoto��5%      $
��Left=�6#   $��30��6>   $��524,225,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��180��6�   $��20(�6�   {�.  6�   �� 5&   
   -   5         ��Name$ ImgFoto��5&      $
��Left=�6!   $	��100��6<   $��604,120,0,0q�6I   $	��Top=�6^   $	��100��6v   �� 5'   
   -   5         ��Name$ BtnFoto��5'      $��Inserir Foto��6"   $
��Left=�69   $��
524,0,0,81q�6T   $��Bottom=�6h   $	��180��6�   $��20(�6�   $��30��6�   6�   �� 5(   
   -   5        $ BtnNovo��5(      $
��Novo��6"   $
��Left=�61   $��
40,298,0,0q�6L   $	��Top=�6`   $��80��6x   $��20(�6�   $��30��6�   6�   �� 5)   
   -   5        $ 	BtnSalvar��5)      $��Salvar��6$   $
��Left=�65   $��140,298,0,0q�6P   $	��Top=�6e   $��80��6}   $��20(�6�   $��30��6�   {�.  6�   �� 5*   
   -   5        $ 	BtnLimpar��5*      $��Limpar��6$   $
��Left=�65   $��240,298,0,0q�6P   $	��Top=�6e   $��80��6}   $��20(�6�   $��30��6�   {�.  6�   �� 5+   
   -   5        $ BtnSair��5+      $
��Sair��6"   $
��Left=�61   $��340,298,0,0q�6L   $	��Top=�6a   $��80��6y   $��20(�6�   $��30��6�   6�   5-      5.      