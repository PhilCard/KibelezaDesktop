   M S B A M L   `   `   `  ����I  EKibelzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:KibelzaDesktopKibelzaDesktop  5   	   '    !KibelzaDesktop.FrmAgendaAtualizar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:KibelzaDesktop     5   	     � Title$  FrmAgendaAtualizar��5   	   $	��450��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�6=    � WindowStyle$
 None=�6b   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFB06FAD��6    � Offset$ 0.217Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      � .+�5   
   �� -   5         ��Name$ LblAtualizarAgendamento��5      $��Atualizar Agendamento��61   $
��Left=�6Q   $��
270,23,0,0q�6l   $	��Top=�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	LblCodigo��5      $��Código Agendamento��6#   $
��Left=�6@   $��	10,69,0,0q�6[   $	��Top=�6n   $��20(�6�   �� 5   
   -   5        $ LblNomeCliente��5      $��Nome Cliente��6(   $
��Left=�6?   $��
12,111,0,0q�6Z   $	��Top=�6n   $��20(�6�   �� 5   
   -   5        $ LblNomeServico��5      $��Nome Serviço��6(   $
��Left=�6?   $��
10,153,0,0q�6Z   $	��Top=�6n   $��20(�6�   �� 5   
   -   5        $ LblDataAgendamento��5      $��Data Agentamento��6,   $
��Left=�6G   $��
12,195,0,0q�6b   $	��Top=�6v   $��20(�6�   �� 5   
   -   5         ��Name$ TxtCodigoAgendamento��5      $
��Left=�60   $��37��6K   $��
221,69,0,0q�6W   	 �� TextWrapping$
	 Wrap=�6k   $	��Top=�6   $	��225��6�   $��20(�6�   {�.  6�   �� 5   
   -   5        $ 
TxtNomeCli��5      $
��Left=�6&   $��37��6A   $��221,111,0,0q�6M   $
	 Wrap=�6b   $	��Top=�6v   $	��429��6�   {�.  6�   �� 5   
   -   5        
 ��Name$
 FundoBranco��5      ���	#FFF4F4F5$
��Left=�6:   $	��173��6U   $��
12,237,0,0q�6b   
���   �$	��Top=�6�   $	��655��6�    �� RadiusX$ 60��6�    �� RadiusY$ 60��6�   �� 5   
   -	   5        $ TxtNomeServico��5      $
��Left=�6*   $��37��6E   $��221,153,0,0q�6Q   $
	 Wrap=�6f   $	��Top=�6z   $	��429��6�   {�.  $��20(�6�   �� 5   
   -
   5        $ TxtDataAgendamento��5      $
��Left=�6.   $��37��6I   $��221,195,0,0q�6U   $
	 Wrap=�6j   $	��Top=�6~   $	��225��6�   $��16(�6�   {�.  6�   �� 5   
   -   5        $ LblStatusAgendamento��5      $��Status Agendamento��6.   $
��Left=�6K   $��103,255,0,0q�6f   $	��Top=�6{   $��20(�6�   �� 5   
   $
��Left=�6   $��303,255,0,0q�6.   $	��Top=�6C   $	��200��6[   $��37��6g   $��20(�6s   �� 5   
   -   5         ��Name$ BtnAtualizar��5      $��Atualizar Status��6'   $
��Left=�6B   $��303,306,0,0q�6]   $	��Top=�6r   $	��200��6�   $��20(�6�   ���	#FF0E0000���	#FF8D6A95$��60��6�   �� 5   
   -   5        $ BtnSair��5      $
��Sair��6"   $
��Left=�61   $��672,379,0,0q�6L   $	��Top=�6a   $��75��6y   ���	#FF0E0000���	#FF8D6A95$��20(�6�   5      5       