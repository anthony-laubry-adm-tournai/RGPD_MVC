# RGPD
Registre des traitements

Mise en place :

  1) Installation du serveur IIS.
  2) Installation d'un SQL server Express.
  3) Sous Sql server créé la base de données et les tables avec le script db_schema.sql qui se trouvent dans le repertoire "SQL".
  4) Ajouter les données de glossaire avec le script : Glossaire.sql
  5) Ne pas oublier de donner les droits en INSERT,SELECT,DELETE et UPDATE (clic droit sur la base de donnée => properties => permission).
  6) Attention : avant de définir les utilisateurs, il convient d'ajouter les services en premier lieu dans la table service.
  7) Les utilisateurs doivent être importer de l'AD dans la table Utilisateur. Les informations nécessaires sont le "DisplayName" et       "LogonName".
  7) Ajouter les fichiers au sein du projet DEPLOY_RGPD dans un site IIS.
  8) Configurer les droits du répertoire de l'application dans wwwroot (Tout le monde => controle total, IIS_IUSRS => controle total).
  9) Ajouter le répertoire "Fichier" dans la racine de l'application.
  10) Dans le fichier web.config de l'application :
      ---------------------------------------------
   
      <add name="ADConnectionString" connectionString="LDAP://xxxxx.xx" />
        => remplacer xxxxx.xx par votreNomDeDomaine.be ou adresse IP du controleur de domaine.
      
      <add name="RegistreTraitementContext" connectionString="data source=srv-rgpd,49356;initial catalog=RegistreTraitementContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
        => remplacer la valeur de data source par l'adresse IP/nom de votre serveur (eventuellement ajouter le port après adresse IP/nom : ,port) qui heberge l'application.
