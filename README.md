# RGPD
Registre des traitements

Mise en place :

  1) Installation du serveur IIS.
  2) Installation d'un SQL server Express (ou non).
  3) Sous Sql server créé la base de données et les tables avec les scripts .sql qui se trouvent dans le repertoire "table_base".
  4) Ajouter les données de la table Glossaire et Mesure avec les scripts : dbo.Glossaire.data.sql et dbo.Mesure.data.sql
  5) Ajouter les données du script dbo.Utilisateur.data.sql et dbo.Role.data.sql et dbo.RoleUtilisateur.data.sql sans quoi il n'est pas 
     possible de se connecter. Attention : Avant de définir les utilisateurs, il convient d'ajouter les services en premier lieu. 
  6) Ne pas oublier de donner les droits en INSERT,SELECT,DELETE et UPDATE (clic droit sur la base de donnée => properties => permission)
      (idem pour la procédure stockée).
  7) Ajouter le projet dans un site IIS.
  8) Configurer les droits du répertoire de l'application dans wwwroot (Tout le monde => controle total, IIS_IUSRS => controle total).
  9) Ajouter le repertoire "Fichier" dans la racine de l'application.
  10) Dans le fichier web.config de l'application :
      ---------------------------------------------
   
      <add name="ADConnectionString" connectionString="LDAP://xxxxx.xx" />
        => remplacer xxxxx.xx par votreNomDeDomaine.be ou adresse IP du controleur de domaine.
      
      <add name="RegistreTraitementContext" connectionString="data source=srv-rgpd,49356;initial catalog=RegistreTraitementContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
        => remplacer la valeur de data source par l'adresse IP/nom de votre serveur (eventuellement ajouter le port après adresse IP/nom : ,port) qui heberge l'application.
