   M S B A M L   `   `   `  ����B  >MatInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MatInfoMatInfo  5          MatInfo.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MatInfo     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��475��5
      $	��800��5       � DataContext 5         MatInfo.ApplicationData  5   
   -   5        applicationData��5       .��5      � .+�5   
   � $��0��5      $	��125��5      $	��Top=�5      ���	#FFB3AEAE.+�5      �� -   5         ��Name$ lbConsultationAttribution��5      $��70��5      $��0,28,0,0q�5      $��Center=�5      $	��Top=�5      $#��Consultation des attributions��5      $��Adobe Gothic Std B)�5      $��40(�5      5       &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ 	dgConcess��5"      $	��150��5#      $��10,156,10,0q�5$      $	��Top=�5%         AutoGenerateColumns$ false��5&      ���	#FFD2D2D2   CanUserAddRows$ False��5(         CanUserDeleteRows$ False��5)         CanUserSortColumns$ False��5*         
IsReadOnly$
 True��5+      ��5,      �� *LesAttributions+	   Columns	 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 1.5* 5/         Header$ 
Code barre��51      1  +System.Windows.Controls.DataGridBoundColumn   Binding 50      �� *Materiel.CodeBarre+51        52      $

 1.5* 53      $ Nom matériel��55       54      �� *Materiel.NomMateriel+55        56      $

 1.5* 57      $ Référentiel��59       58      �� *Materiel.RefConstructeur+59        5:      $
 * 5;      $
 Mail��5=       5<      �� *Personnel.MailPerso+5=        5?      $
 1* 5@      $	 Nom��5B       5A      �� *Personnel.NomPerso+5B        5C      $
 1* 5D      $ Prénom��5F       5E      �� *Personnel.PrenomPerso+5F        5G      $

 1.5* 5H      $ Commentaire��5J       5I      �� *Commentaire+5J        5K      $
 * 5L      $
 Date��5N       5M      �� *DateAttribution+ �� StringFormat$ dd MMM yyyy��5N      5P      �� 5Q   
   -   5         ��Name$ btAjouterAttribution��5R      $	��120��5S      $��26��5T      $��138,327,0,0q�5U      $
��Left=�5V      $	��Top=�5W      $��Ajouter attribution��5Y      �� 5Z   
   -   5        $ btSupprimerAttribution��5[      $	��120��5\      $��26��5]      $��540,327,0,0q�5^      $
��Left=�5_      $	��Top=�5`      $��Supprimer attribution��5a      �� 5b   
   -   5        $ btModifPersonnel��5c      $	��150��5d      $��49��5e      $��50��5f      $��125,380,0,0q�5g      $
��Left=�5h      $	��Top=�5i      $��Gérer personnels��5k      �� 5l   
   -   5        $ btModifMateriel��5m      $	��150��5n      $��49��5o      $��50��5p      $��525,380,0,0q�5q      $
��Left=�5r      $	��Top=�5s      $��Gérer matériels��5u      �� 5v   
   -   5        $ btEnregistrerAttribution��5w      $	��150��5x      $��49��5y      $��50��5z      $��	0,380,0,0q�5{      $��Center=�5|      $	��Top=�5}      $"��Enregistrer des attributions��5      5�      5�      