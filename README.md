# RGPD
Registre des traitements

Mise en place :

  1) Installation du serveur IIS.
  2) Installation d'un SQL server Express V17.7 (nous pouvons mettre l'installateur à disposition). Ne pas oublier de vérifier si le service SQL Server Browser est configurer en démarrage automatique.
  3) Sous Sql server créé la base de données et les tables avec le script db_schema.sql qui se trouvent dans le repertoire "SQL".
  4) Ajouter les données de glossaire avec le script : Glossaire.sql
  5) Ne pas oublier de donner les droits en INSERT,SELECT,DELETE et UPDATE (clic droit sur la base de donnée => properties => permission).
  6) Attention : avant de définir les utilisateurs, il convient d'ajouter les services en premier lieu dans la table service.
  7) Les utilisateurs doivent être importés de l'AD dans la table Utilisateur. Les informations nécessaires sont le "DisplayName" et       "LogonName". Il est possible de fournir un petit projet d'import d'utilisateur et service via l'AD, mais il faut au moins Visual studio 2013 afin de l'ouvrir pour changer la valeur des connexions et l'exécuter.
  8) Ajouter les fichiers au sein du projet DEPLOY_RGPD dans un site IIS.
  9) Le framework utiliser lors de la configuration du site IIS est .NET framework 4.5
  10) Configurer les droits du répertoire de l'application dans wwwroot (Tout le monde => controle total, IIS_IUSRS => controle total).
  11) Navigateur compatible: Google Chrome.
  12) Dans le fichier web.config de l'application :
      ---------------------------------------------
   
    <add name="ADConnectionString" connectionString="LDAP://xxxxx.xx" />
        => remplacer xxxxx.xx par votreNomDeDomaine.be ou adresse IP du controleur de domaine.
      
      <add name="RegistreTraitementContext" connectionString="data source=server,port;initial catalog=RegistreTraitementContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
        => remplacer la valeur de data source par l'adresse IP/nom de votre serveur (eventuellement ajouter le port après adresse IP/nom : ,port) qui heberge l'application.
