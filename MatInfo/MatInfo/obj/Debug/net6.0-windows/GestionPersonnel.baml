   M S B A M L   `   `   `  ����B  >MatInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MatInfoMatInfo  5          MatInfo.GestionPersonnel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MatInfo     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  GestionPersonnel��5      $	��800��5	      $	��450��5
       � DataContext 5         MatInfo.ApplicationData  5   
   -   5        applicationData��5       .��5      � .+�5   
   � $��0��5      $��	0,0,0,334q�5      ���	#FFB3AEAE.+�5      �� -   5         ��Name$ lbGestionPersonnel��5      $��70��5      $��Center=�5      $��Center=�5      $��Gestion du personnel��5      $��Adobe Gothic Std B)�5      $��40(�5      5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dgPersonnel��5!      $	��150��5"      $��10,181,10,0q�5#      $	��Top=�5$         AutoGenerateColumns$ False��5%         
IsReadOnly$
 True��5&      ��5'      �� *LesPersonnels+   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5+         Header$ Email perso��5-      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5,      �� *	MailPerso+5-        5.      $ 1* 5/      $	 Nom��51      	 50      �� *
NomPerso+51        52      $ 1* 53      $ Prénom��55      	 54      �� *PrenomPerso+55      57      �� 58   
   -   5        
 ��Name$
 btModifPersonnel��59      $��50��5:      $��121,351,529,34q�5;      $��Modifier personnel��5<      �� 5=   
   -   5        $
 btAjouterPersonnel��5>      $��50��5?      $��521,351,129,34q�5@      $��Ajouter personnel��5A      �� 5B   
   -   5        $��10,105,674,258q�5B      $
��Back��6)   68   �� 5C   
   -   5        $
 btSupPersonnel��5D      $��50��5E      $��321,351,329,34q�5F      $��Supprimer personnel��5G      5I      5J      