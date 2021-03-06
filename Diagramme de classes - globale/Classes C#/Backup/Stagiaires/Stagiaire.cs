/***********************************************************************
 * Module:  Stagiaire.java
 * Author:  Abdellah
 * Purpose: Defines the Class Stagiaire
 ***********************************************************************/

using System;
import java.util.*;

namespace Stagiaires
{
   public class Stagiaire
   {
      private int id;
      private String nom;
      private String prenom;
      private DateTime datenaissance;
      private bool sexe;
      private String cin;
      private String email;
      private String telephone;
      private String adress;
      private String profilImage;
      private int etat;
      
      public Filieres.Filiere filiere;
      
      /// <summary>
      /// Property for Filieres.Filiere
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Filieres.Filiere Filiere
      {
         get
         {
            return filiere;
         }
         set
         {
            this.filiere = value;
         }
      }
      public System.Collections.Generic.List<Groupe> groupe;
      
      /// <summary>
      /// Property for collection of Groupe
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Groupe> Groupe
      {
         get
         {
            if (groupe == null)
               groupe = new System.Collections.Generic.List<Groupe>();
            return groupe;
         }
         set
         {
            RemoveAllGroupe();
            if (value != null)
            {
               foreach (Groupe oGroupe in value)
                  AddGroupe(oGroupe);
            }
         }
      }
      
      /// <summary>
      /// Add a new Groupe in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddGroupe(Groupe newGroupe)
      {
         if (newGroupe == null)
            return;
         if (this.groupe == null)
            this.groupe = new System.Collections.Generic.List<Groupe>();
         if (!this.groupe.Contains(newGroupe))
            this.groupe.Add(newGroupe);
      }
      
      /// <summary>
      /// Remove an existing Groupe from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveGroupe(Groupe oldGroupe)
      {
         if (oldGroupe == null)
            return;
         if (this.groupe != null)
            if (this.groupe.Contains(oldGroupe))
               this.groupe.Remove(oldGroupe);
      }
      
      /// <summary>
      /// Remove all instances of Groupe from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllGroupe()
      {
         if (groupe != null)
            groupe.Clear();
      }
   
   }
}