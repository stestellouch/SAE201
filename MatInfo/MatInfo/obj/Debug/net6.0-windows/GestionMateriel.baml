   M S B A M L   `   `   `  ����B  >MatInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MatInfoMatInfo  5          MatInfo.GestionMateriel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MatInfo     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  GestionMateriel��5      $	��800��5	      $	��450��5
       � DataContext 5         MatInfo.ApplicationData  5   
   -   5        applicationData��5       .��5      � .+�5   
   � $��	0,0,0,334q�6   ���	#FFB3AEAE.+�5      �� -   5         ��Name$ lbGestoinMateriel��5      $��70��5      $��Center=�5      $��Center=�5      $��Gestion du matériel��5      $��Adobe Gothic Std B)�5      $��40(�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgMateriel��5      $	��150��5      $��10,163,10,0q�5      $	��Top=�5          AutoGenerateColumns$ False��5!         
IsReadOnly$
 True��5"      ��5#      �� *LesMateriels+   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5'         Header$ 
Code bare ��5)      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5(      �� *	CodeBarre+5)        5*      $ 1* 5+      $ Nom matériel��5-      	 5,      �� *NomMateriel+5-        5.      $ 1* 5/      $ Référentiel��51      	 50      �� *RefConstructeur+51        52      $ 1* 53      $ Nom catégorie��55      	 54      �� *UneCategorie.NomCategorie+55      57      �� 58   
   -   5        
 ��Name$
 btModifMateriel��59      $��50��5:      $��125,330,525,55q�5;      $��Modifier matériel��5<      �� 5=   
   -   5        $
 btAjouterMateriel��5>      $��50��5?      $��525,330,125,55q�5@      $��Ajouter matériel��5A      �� 5B   
   -   5        $��10,105,674,276q�5C      $
��Back��5E      �� 5F   
   -   5        $
 btSupMateriel��5G      $��50��5H      $��325,330,325,55q�5I      $��Supprimer matériel��5J      5L      5M      