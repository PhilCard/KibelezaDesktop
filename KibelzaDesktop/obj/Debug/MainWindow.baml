   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	       KibelzaDesktop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	   -   5          �Name$  FrmLogin��5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z   ��5	      
� 5
   
   .��5      �  � Color$ 	#FF9F87BB��6    � Offset$
 0.67Q�6-   � 5      $ 	#FF3B3B3B��6   $ 0.803Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ 
LblUsuario��5      $��Usuário��6$   $
��Left=�66   $��227,104,0,0q�6Q   $	��Top=�6f   $��41��6~   $��88��6�   $
��Bold"�6�   $��20(�6�   �� 5   
   -   5        $ LblSenha��5      $��Senha��6"   $
��Left=�62   $��227,163,0,0q�6M   $	��Top=�6b   $
��Bold"�6z   $��20(�6�   $��43��6�   $��73��6�   �� 5   
   -   5         ��Name$ 
TxtUsuario��5      $
��Left=�6&   $��41��6A   $��340,104,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��189��6�   $��20(�6�   6�   � 5   
   -   5        	 �Name$	 PgbLogin��5      $
��Left=�6(   $��11��6C   $��227,211,0,0q�6O   $	��Top=�6d   $	��302��6|   �� 5   
   -   5        
 ��Name$
 	BtnEntrar��5      $��Entrar��6$   $
��Left=�65   $��229,240,0,0q�6P   $	��Top=�6e   $��82��6}   $��33��6�   $��20(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   {�.  z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.087Q�6$   �� 5       �� Angle$ -0.836Q�6&   T� 5      5      5      �� 5   
   -   5        $
 BtnSair��5      $
��Sair��6"   $
��Left=�61   $��461,239,0,0q�6L   $	��Top=�6a   $��68��6y   $��20(�6�   $��34��6�   6�   �� 5   
   -   5         ��Name$ 
TxbCarrega��5      $
��Left=�6(   $��366,239,0,0q�6C   $
��Wrap=�6X   $��0%��6l   $	��Top=�6v   $ -0.125,-1.625&�6�   $��18��6�   $��37��6�   �� 5    
   $
��Left=�6   $	��163��6+   $	��Top=�68   $	��170��6P   $3��-pack://siteoforigin:,,,/img/favicon-32x32.png��6\   G� 5!   
   -	   5         G�Name$ TxtSenha��5!      $
��Left=�6(   $��340,163,0,0q�6C   $	��Top=�6X   $	��189��6p   $��34��6|   {�.  6�   5#      5$      