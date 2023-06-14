// File:    Crud.cs
// Author:  phamhuyt
// Created: lundi 5 juin 2023 10:05:07
// Purpose: Definition of Interface Crud

using System;
using System.Collections.ObjectModel;
using MatInfo;

public interface Crud<T>
{
   void Create();
   
   void Read();
   
   void Update();
   
   void Delete();
   
   ObservableCollection<T> FindAll();
   ObservableCollection<T> FindBySelection(string criteres);

}