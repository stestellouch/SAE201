   M S B A M L   `   `   `  ����B  >MatInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MatInfoMatInfo  5      '    !MatInfo.WindowCreationAttribution   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MatInfo     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  WindowCreationAttribution��5      $	��800��5	      $	��450��5
       � DataContext 5         MatInfo.ApplicationData  5   
   -   5        ApplicationData��5       .��5      � .+�5   
   �� -   5         ��Name$! labelEnregistrerAttribution��5      $��61��5      $��198,2,198,0q�5      $	��Top=�5      $!��Enregistrer une attribution��5      $��30(�5      $
��Bold"�5      �� 5   
   $��	73,48,0,0q�5      $
��Left=�5      $	��Top=�5      $��Personnel :��5      $��20(�5      �� 5   
   -   5         ��Name$ txtBoxSaisiePersonnel��5      $	��170��5       $��26��5!      $��
44,120,0,0q�5"      $
��Left=�5#      $	��Top=�5$      $�� ��5%       �� TextWrapping$
 Wrap=�5&      �� 5'   
   $	��174��5(      $��26��5)      $��	44,89,0,0q�5*      $
��Left=�5+      $	��Top=�5,      $"��Faire une recherche par nom:��5-      �� 5.   
   $��0,45,0,0q�5/      $��Center=�50      $	��Top=�51      $��Matériel :��52      $��20(�53      �� 54   
   -   5         ��Name$ cbCategorie��55      $	��170��56      $��26��57      $��	0,114,0,0q�58      $��Center=�59      $	��Top=�5:      ���	#FFCCE8FF �� DisplayMemberPath$ nomCategorie��5<      ��5=      ��  �� Path$ LesCategories� �� SelectedItem 5>      �� $ LesCategories�5A      �� 5B   
   $	��226��5C      $��29��5D      $��0,89,0,0q�5E      $��Center=�5F      $	��Top=�5G      $/��)Sélectionnez une catégorie de matériel��5H      �� 5I   
   $��
609,55,0,0q�5J      $
��Left=�5K      $	��Top=�5L      $��Date :��5M      $��20(�5N      (  "System.Windows.Controls.DatePicker  5O   
   -   5        	  Name$	 dpSaisieDate��5P      $	��170��5Q      $��26��5R      $��555,114,0,0q�5S      $
��Left=�5T      $	��Top=�5U      �� 5V   
   $	��150��5W      $��31��5X      $��
54,183,0,0q�5Y      $
��Left=�5Z      $	��Top=�5[      $ ��Sélectionnez le personnel��5\      �� 5]   
   -   5        
 ��Name$
 lvSaisiePersonnel��5^      $	��240��5_      $	��179��5`      $��	9,209,0,0q�5a      $
��Left=�5b      $	��Top=�5c       �� SelectionMode$ Single=�5e      ��5d      �� *LesEnseignants+ �� View 5f      �� 5g      .P�5h      ��  �� Width$	 100��5i      $��Nom employé��5k       �� DisplayMemberBinding 5j      �� *
NomPerso+5k      �� 5l      $	 110��5m      $��Prénom employé��5o       5n      �� *PrenomPerso+5o      5p      5r      �� 5s   
   $	��150��5t      $��31��5u      $��	0,178,0,0q�5v      $��Center=�5w      $	��Top=�5x      $ ��Sélectionnez le matériel��5y      �� 5z   
   -   5        $
 lvSaisieMateriel��5{      $	��200��5|      $	��179��5}      $��	0,201,0,0q�5~      $��Center=�5      $	��Top=�5�      $ Single=�5�      ��5�      �� *LesMateriels+ 5�      �� 5�      .P�5�      �� $	 170��5�      $��Libellé matériel��5�       5�      �� *NomMateriel+5�      5�      5�      �� 5�   
   $	��253��5�      $��522,168,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Commentaire (optionnel):��5�      $��20(�5�      �� 5�   
   -   5        $ txtBoxSaisieCommentaire��5�      $	��256��5�      $��58��5�      $��519,240,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $�� ��5�      $
 Wrap=�5�      �� 5�   
   $	��184��5�      $��30��5�      $��555,206,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $*��$Rédigez le commentaire ci-dessous :��5�      �� 5�   
   -	   5         ��Name$ btBack��5�      $��659,327,25,54q�5�      $
��Back��5�      �� 5�   
   -
   5        $ 	btAjouter��5�      $��522,327,162,54q�5�      $��Ajouter��5�      5�      5�      