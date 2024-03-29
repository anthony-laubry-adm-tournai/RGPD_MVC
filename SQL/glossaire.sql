USE [RegistreTraitementContext]
GO
SET IDENTITY_INSERT [dbo].[CauseIncident] ON 

INSERT [dbo].[CauseIncident] ([Id], [Libelle]) VALUES (1, N'Accidentel')
INSERT [dbo].[CauseIncident] ([Id], [Libelle]) VALUES (2, N'Volontaire')
SET IDENTITY_INSERT [dbo].[CauseIncident] OFF
GO
SET IDENTITY_INSERT [dbo].[DonneeCaracterePersonnel] ON 

INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Nom', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Prénom', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Âge', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Date de naissance', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Lieu de naissance', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (6, N'Ancienne adresse', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (7, N'Adresse actuelle', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (8, N'Situation familiale', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (9, N'État civil', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (10, N'Numéro de registre national', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (11, N'Numéro de carte d''identité', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (12, N'Passeport', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (13, N'Amendes', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (14, N'Numéro de téléphone privé', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (15, N'Numéro de téléphone professionnel', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (16, N'Permis de conduire', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (17, N'Plaque d''immatriculation', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (18, N'Appréciation de la solvabilité ', N'Statut financier')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (19, N'Dépenses', N' Loyer, prêts, hypothèques, ...')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (20, N'Revenus', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (21, N'Biens immobiliers', N'Types, nombre, parcelle cadastrale,...')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (22, N'Numéro de carte de crédits', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (23, N'Numéro de carte de débits', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (24, N'Numéro de compte bancaire', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (25, N'Parcours scolaire', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (26, N'Diplôme(s)', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (27, N'Recrutement', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (28, N'Profession', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (29, N'Pension', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (30, N'Adresse IP', N'Numéro d''identification qui est attribué de façon permanente ou provisoire à chaque branchement à un réseau informatique utilisant l''Internet Protocol')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (31, N'Historique de connexion', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (32, N'Identifiant de connexion', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (33, N'Mot de passe', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (34, N'Composition de ménage', N'Concerne une personne vivant habituellement seule ou par 2 ou plusieurs personnes qui, unies ou non par des liens de parenté, occupent habituellement un même logement et y vivent en commun')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (35, N'adresse mail ', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (36, N'Identité du genre', N'Homme, femme')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (37, N'Code PIN/PUK GSM', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (38, N'Service/Direction/Département ', N'dans lequel l''agent est affecté')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (39, N'filiation', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (40, N'nationalité', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (41, N'numéro de l''acte', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (42, N'Signature', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (43, N'Code PIN carte bancaire', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (44, N'numéro TVA', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (45, N'Numéro de dossier ', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (46, N'Mandat', N'administrateur de société, gérant, ....')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (67, N'Numéro de contrat', N'')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (68, N'Numéro d''électeur', NULL)
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (69, N'Numéro de permis de conduire', N'A distinguer du permis en lui-même')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (70, N'Données Judiciaires', N'Condamnation, casier judiciaire ')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (71, N'Numéro client ', NULL)
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (72, N'Numéro article de rôle', NULL)
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (74, N'Mutuelle', NULL)
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (75, N'Statut', N'réfugié, apatride, regroupement familial,...')
INSERT [dbo].[DonneeCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (76, N'Numéro de matricule', NULL)
SET IDENTITY_INSERT [dbo].[DonneeCaracterePersonnel] OFF
GO
SET IDENTITY_INSERT [dbo].[DonneeCaractereSensible] ON 

INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Données physiques', N'Taille, poids, couleurs des cheveux et/ou yeux, signe distinctif')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Données ADN', N'Cartographie de la séquence ADN')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Données génétiques', N'Cartographie du génome, etc ...')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Empreinte digitale', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Données médicales', N'Dossier médical, invalidité, etc ...')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (6, N'Origine ethnique', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (7, N'vie sexuelle/ orientation sexuelle', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (8, N'Conviction philosophique/religieuse', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (9, N'Affiliations politiques', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (10, N'Affiliations syndicales', N'')
INSERT [dbo].[DonneeCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (12, N'Images, vidéo de surveillance', N'Photographies, Caméra dans les rues, biométrie')
SET IDENTITY_INSERT [dbo].[DonneeCaractereSensible] OFF
GO
SET IDENTITY_INSERT [dbo].[DureeConservationDonnee] ON 

INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (1, N'1 Jour', N'1')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (2, N'1 semaine', N'7')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (3, N'1 mois', N'30')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (4, N'3 mois', N'91')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (5, N'6 mois', N'182')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (6, N'1 an', N'365')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (7, N'1 an 6 mois', N'547')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (8, N'2 ans', N'730')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (9, N'2 ans 6 mois', N'912')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (10, N'3 ans', N'1095')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (11, N'3 ans 6 mois', N'1277')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (12, N'4 ans', N'1460')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (13, N'4 ans 6 mois', N'1642')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (14, N'5 ans', N'1825')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (15, N'10 ans', N'3650')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (16, N'15 ans', N'5475')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (17, N'20 ans', N'7300')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (18, N'25 ans', N'9125')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (19, N'30 ans', N'10950')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (20, N'50 ans', N'18250')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (21, N'100 ans', N'36500')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (23, N'illimité', N'365250')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (28, N'6 ans', N'')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (29, N'4 mois', N'')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (30, N'45 ans', N'')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (31, N'60 ans', N'')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (32, N'55 ans', N'')
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (33, N'7 ans', NULL)
INSERT [dbo].[DureeConservationDonnee] ([Id], [Libelle], [Tooltip]) VALUES (34, N'2 semaines', NULL)
SET IDENTITY_INSERT [dbo].[DureeConservationDonnee] OFF
GO
SET IDENTITY_INSERT [dbo].[FinaliteDonnee] ON 

INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Recrutement du personnel', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Administration des salaires', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Gestion du personnel', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Contrôle sur le lieu de travail', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Gestion des commandes', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (6, N'Gestion du contentieux', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (7, N'Évènements culturels', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (8, N'Sécurité', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (9, N'Impôts (taxes, redevances, ...)', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (10, N'Recouvrement de créance', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (11, N'Subventions', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (12, N'Permis', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (13, N'Tenue des registres', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (14, N'Élections', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (15, N'Administration des étrangers', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (16, N'Cadastre', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (17, N'Casier judiciaire', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (18, N'Défense judiciaire', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (19, N'Administration des élèves ', N'Organisation de l''enseignement, examens, résultats scolaires, diplômes, délibération jury, gestion des repas scolaires')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (20, N'Gestion des inscriptions', N'paiement minerval, bourse, ...')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (21, N'Gestion des membres de bibliothèques', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (22, N'Statistiques', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (23, N'Archives', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (24, N'Recensement de population', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (25, N'Registre national', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (26, N'Enquêtes publiques', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (27, N'Facturation', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (28, N'Perception des amendes', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (29, N'Exécution d''un marché public', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (30, N'Inspection des bâtiments', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (31, N'exécution d''une mesure judiciaire alternative', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (32, N'Gestion des courriers en interne', N'pour assurer un bon dispatching')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (33, N'gestion des accès aux zones piétonnes', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (34, N'gestion d''une commission', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (35, N'règlement complémentaire de circulation routière', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (36, N'Poursuite d''infractions', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (37, N'Médiation', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (38, N'Gestion de la communication digitale', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (39, N'Aide sociale', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (40, N'Gestion des impressions', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (41, N'Gestion des demandes citoyennes', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (42, N'Participation citoyenne', N'Participation citoyenne dans les projets de la Ville')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (43, N'Gestion des documents internes', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (44, N'Vente de gré à gré avec publicité ', N'attribution au soumissionnaire ayant formulé l''offre la plus importante')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (45, N'Taxation des immeubles inoccupés ', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (46, N'Concours', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (47, N'Evènements protocolaires', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (48, N'Promotion', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (49, N'Gestion du conseil communal', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (50, N'Attribution de places PMR', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (51, N'Aide à l''indemnisation', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (52, N'Enquête', N'sondage (citoyens, associations,...)')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (53, N'Saisie', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (54, N'Activités de loisirs', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (55, N'Gestion des cimetières', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (56, N'Gestion des documents d''identité et des passeports', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (57, N'Constitution des jurés d''assises', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (58, N'Gestion des permis de conduire', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (59, N'Gestion du patrimoine', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (60, N'Exécution et suivi de chantier', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (61, N'Octroi d''un titre de séjour', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (62, N'Service au citoyen ', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (63, N'Santé publique ', N'')
INSERT [dbo].[FinaliteDonnee] ([Id], [Libelle], [Tooltip]) VALUES (64, N'Accueil des Ukrainiens', N'')
SET IDENTITY_INSERT [dbo].[FinaliteDonnee] OFF
GO
SET IDENTITY_INSERT [dbo].[Gravite] ON 

INSERT [dbo].[Gravite] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Impact négligeable', N'')
INSERT [dbo].[Gravite] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Impact limité', N'')
INSERT [dbo].[Gravite] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Impact important', N'')
INSERT [dbo].[Gravite] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Impact maximal', N'')
SET IDENTITY_INSERT [dbo].[Gravite] OFF
GO
SET IDENTITY_INSERT [dbo].[LegitimationCaracterePersonnel] ON 

INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Consentement', N'Donné par la personne concernée (écrit)')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Éxecution d''un contrat', N'Donné par la personne concernée (écrit)')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Obligation légale', N'')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Intérêt vital', N'')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Mission d''intérêt public', N'')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (10, N'Intérêt légitime', N'Balance des intérêts à prévoir  (voir avec DPO)')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (11, N'Intérêts légitimes', N'Nécessite au préalable une balance des intérêts entre les intérêts de l''institution et les droits de la personne concernée. A documenter')
INSERT [dbo].[LegitimationCaracterePersonnel] ([Id], [Libelle], [Tooltip]) VALUES (12, N'Sans objet', N'Si aucune donnée à caractère personnel n''est cochée')
SET IDENTITY_INSERT [dbo].[LegitimationCaracterePersonnel] OFF
GO
SET IDENTITY_INSERT [dbo].[LegitimationCaractereSensible] ON 

INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Consentement', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Obligation en droit du travail', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Sécurité sociale', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Protection sociale', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Intérêt vital', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (6, N'Données rendues publiques', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (7, N'Droit de défense en justice', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (8, N'Intérêt public', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (9, N'Nécessité pour la médecine préventive', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (10, N'Nécessité pour la médecine du travail', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (11, N'Fins archivistiques d’intérêt public', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (12, N'Recherche scientifique', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (13, N'Recherche historique', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (14, N'Statistiques', N'')
INSERT [dbo].[LegitimationCaractereSensible] ([Id], [Libelle], [Tooltip]) VALUES (15, N'Sans Objet', NULL)
SET IDENTITY_INSERT [dbo].[LegitimationCaractereSensible] OFF
GO
SET IDENTITY_INSERT [dbo].[LieuIncident] ON 

INSERT [dbo].[LieuIncident] ([Id], [Libelle]) VALUES (1, N'Bâtiment')
INSERT [dbo].[LieuIncident] ([Id], [Libelle]) VALUES (2, N'Service')
INSERT [dbo].[LieuIncident] ([Id], [Libelle]) VALUES (3, N'Bureau')
INSERT [dbo].[LieuIncident] ([Id], [Libelle]) VALUES (4, N'Pc')
INSERT [dbo].[LieuIncident] ([Id], [Libelle]) VALUES (5, N'Autre (à préciser)')
SET IDENTITY_INSERT [dbo].[LieuIncident] OFF
GO
SET IDENTITY_INSERT [dbo].[Mesure] ON 

INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (1, N'Mesure sur les données', N'Chiffrement', N'Moyens mis en œuvre pour assurer la confidentialité des données conservées (en base de données, dans des fichiers plats, dans les sauvegardes, etc.) ainsi que les modalités de gestion des clés de chiffrement (création, conservation, modification en cas de suspections de compromission, etc.). 

Détaillez les moyens de chiffrement employés pour les flux de données (VPN, TLS, etc.) intégrés dans le traitement.', N'Décrivez ici les moyens cryptographiques mis en oeuvre pour assurer la confidentialité et l''intégrité des données.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (2, N'Mesure sur les données', N'Anonymisation', N'Description des mécanismes d’anonymisation, des garanties qu''ils apportent contre une réidentification éventuelle et à quelle fin ils sont mis en oeuvre.', N'Décrivez ici les mécanismes d''anonymisation mis en oeuvre.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (3, N'Mesure sur les données', N'Cloisonnement', N'Méthodes utilisées pour cloisonner le traitement.', N'Indiquez ici si un cloisonnement du traitement est prévu, et comment il est réalisé.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (4, N'Mesure sur les données', N'Contrôle des accès logiques', N'Description de la manière dont les profils utilisateurs sont définis et attribués. Il conviendra de détailler les moyens d’authentification mis en œuvre en précisant, le cas échéant précisez les règles applicables aux mots de passe (longueur minimale, structure obligatoire, durée de validité, nombre de tentatives infructueuses avant blocage du compte, etc.).', N'Indiquez ici comment les profils utilisateurs sont définis et attribués.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (5, N'Mesure sur les données', N'Journalisation', N'Politiques de journalisation des événements et de conservation des traces qui en résultent.', N'Indiquez ici si des évènements sont journalisés et la durée de conservation de ces traces.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (6, N'Mesure sur les données', N'Archivage', N'Politique de conservation et gestion d’archives électroniques contenant des données à caractère personnel destinées à garantir leur valeur, notamment juridique, pendant toute la durée nécessaire (versement, stockage, migration, accessibilité, élimination, politique d''archivage, protection de la confidentialité, etc.).', N'Indiquez ici l''ensemble des modalités de conservation et gestion d''archives électroniques contenant des données à caractère personnel.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (7, N'Mesure sur les données', N'Sécurisation des documents papier', N'Politiques concernant les documents papiers contenant des données sont utilisés dans le cadre du traitement. Elles décrivent comment ils sont imprimés, stockés, détruits et échangés.', N'Indiquez ici les procédures concernant le cycle de vie des documents papier contenant des données à caractère personnel.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (8, N'Mesure sur les données', N'Minimisation des données', N'La sensibilité des données peut être réduite à l''aide des méthodes suivantes : filtrage et retrait, réduction de la sensibilité par transformation, réduction du caractère identifiant des données, réduction de l''accumulation de données, restriction de l’accès aux données', N'Décrivez ici les méthodes mises en oeuvre pour réduire la sensibilité des données.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (9, N'Mesure générale de sécurité du système', N'Sécurisation de l''exploitation', N'Politiques permettant de limiter la vraisemblance et la gravité des risques visant les biens supports utilisés en exploitation (documenter les procédures d''exploitation, inventaire et mise à jour des logiciels et matériels, correction des vulnérabilités, duplication des données, limiter l''accès physique au matériel, etc.).', N'Décrivez ici les moyens mis en oeuvre pour garantir la mise à jour et le niveau de sécurité des logiciels utilisés.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (10, N'Mesure générale de sécurité du système', N'Lutte contre les logiciels malveillants', N'Mesures destinées à protéger les accès vers des réseaux publics (Internet) ou non maîtrisés (partenaires), ainsi que les postes de travail et les serveurs contre les codes malveillants qui pourraient affecter la sécurité les données à caractère personnel.', N'Décrivez ici les mesures de protection contre les codes malveillants lors d''accès à des réseaux d''un niveau de sécurité moindre.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (11, N'Mesure générale de sécurité du système', N'Gestion des postes de travail', N'Mesures prises afin de diminuer la possibilité que les caractéristiques des logiciels (systèmes d’exploitation,applications métiers, logiciels bureautiques, paramétrages…) ne soient exploitées pour porter atteinte aux données à caractère personnel (mises à jour, protection physique et des accès, travail sur un espace réseau sauvegardé, contrôleurs d’intégrité, journalisation, etc.).', N'Décrivez ici les mesures prises afin de diminuer les risques d''attaques contre les logiciels exploités par le traitement.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (12, N'Mesure générale de sécurité du système', N'Protection des sites web', N'Méthodes et moyens mis en place pour diminuer la possibilité que les caractéristiques des sites web soient exploitées pour porter atteinte aux données à caractère personnel (référentiel général de sécurité, chiffrement TLS des flux, politique de dépôt de cookies, audits de sécurité, etc.).', N'Décrivez ici les méthodes et moyens mis en oeuvre pour protéger les sites web.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (13, N'Mesure générale de sécurité du système', N'Sauvegarde des données', N'Existence d''une politique de sauvegarde permettant d''assurer la disponibilité et/ou l’intégrité des données à caractère personnel, tout en protégeant leur confidentialité (régularité des sauvegardes, chiffrement du canal de transmission des données, test d''intégrité, etc.).', N'Indiquez ici comment les sauvegardes sont gérées et conservées.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (14, N'Mesure générale de sécurité du système', N'Maintenance', N'Existence d''une politique de maintenance physique des équipements, précisant le recours éventuel à la sous-traitance.
Elle devra encadrer la maintenance à distance si elle est autorisée, et préciser les méthodes de gestion des matériels défectueux.', N'Décrivez ici comment est gérée la maintenance physique des équipements.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (15, N'Mesure générale de sécurité du système', N'Contrat de sous-traitance', N'Les données à caractère personnel communiquées à ou gérées par des sous-traitants doivent bénéficier de garanties suffisantes. Faire appel uniquement à des sous-traitants présentant des garanties suffisantes (notamment en termes de connaissances spécialisées, de fiabilité et de ressources). Exiger la communication par le prestataire de sa politique de sécurité des systèmes d’information. 
Prendre et documenter les moyens (audits de sécurité, visite des installations, etc.) permettant d’assurer l’effectivité des garanties offertes par le sous-traitant en matière de protection des données. Ces garanties incluent notamment :
- le chiffrement des données selon leur sensibilité ou à défaut l’existence de procédures garantissant que la société de prestation n’a pas accès aux données qui lui sont confiées
- le chiffrement des transmissions de données (ex : connexion de type HTTPS, VPN, etc.)
- des garanties en matière de protection du réseau, de traçabilité (journaux, audits), de gestion des habilitations, d’authentification, etc.
Prévoir un contrat avec les sous-traitants, qui définit notamment l’objet, la durée, la finalité du traitement et les obligations des parties. S’assurer qu’il contient en particulier des dispositions fixant :
- leur obligation en matière de confidentialité des données personnelles confiées
- des contraintes minimales en matière d’authentification des utilisateurs
- les conditions de restitution et/ou de destruction des données en fin du contrat
- les règles de gestion et de notification des incidents. Celles-ci devraient comprendre une information du responsable de traitement en cas de découverte de faille de sécurité ou d’incident de sécurité et cela dans les plus brefs délais lorsqu’il s’agit d’une violation de données à caractère personnel.
- Dans le cas de l’utilisation de fournisseur de cloud computing :
1. identifier clairement les données et les traitements qui passeront dans le cloud ;
2. définir ses propres exigences de sécurité technique et juridique ;
3. conduire une étude de risques afin d''identifier les mesures de sécurité appropriées ;
4. identifier le type de cloud pertinent pour le traitement envisagé ;
5. choisir un prestataire présentant des garanties suffisantes ;
6. revoir la politique de sécurité interne ;
7. surveiller les évolutions dans le temps.', N'Décrivez ici les garanties contractuelles assurant la protection des données à caractère personnel confiées à des sous traitant.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (16, N'Mesure générale de sécurité du système', N'Sécurisation des canaux informatiques', N'En fonction du type de réseau sur lequel le traitement est mis en œuvre (isolé, privé, ou Internet), le responsable de traitement doit mettre en place des systèmes de protection adéquats : pare-feu, sondes de détection d''intrusion ou autres dispositifs actifs ou passifs sont chargés d''assurer la sécurité du réseau.', N'Indiquez ici sur quel type de réseau le traitement est mis en oeuvre et les équipements assurant sa sécurisation.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (17, N'Mesure générale de sécurité du système', N'Sécurité physique', N'Existence d''un contrôle des accès physique aux locaux hébergeant le traitement (zonage, accompagnement des visiteurs, port de badge, portes verrouillées, etc.).
Indiquez s’il existe des moyens d’alerte en cas d’effraction.
', N'Indiquez ici la manière dont est réalisée le contrôle d''accès physique aux locaux hébergeant le traitement.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (18, N'Mesure générale de sécurité du système', N'Traçabilité', N'Existence de mesures mises en place pour être capable de détecter les incidents concernant des données à caractère personnel de façon précoce et de disposer d’éléments exploitables pour les étudier ou pour fournir des preuves dans le cadre d’enquêtes (architecture et politique de journalisation, respect des obligation en matière de protection des données à caractère personnel, etc.).', N'Décrivez ici les mesures mises en place pour être capable de détecter les incidents concernant des données à caractère personnel.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (19, N'Mesure générale de sécurité du système', N'Sécurisation des matériels', N'Existence de mesures prises pour diminuer la possibilité que les caractéristiques des matériels (serveurs, postes fixes, ordinateurs portables, périphériques, relais de communication, supports amovibles, etc.) soient exploitées pour porter atteinte aux données à caractère personnel (inventaire, cloisonnement, redondance matérielle, limiter l''accès, etc.).', N'Décrivez ici les méthodes et moyens mis en place pour limiter les risques d''attaques contre le matériel utilisé par le traitement.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (20, N'Mesure générale de sécurité du système', N'Eloignement des sources de risques', N'Existence de mesures pour éviter que des sources de risques, humaines ou non humaines, auxquelles il est possible de ne pas être confronté, portent atteinte aux données à caractère personnel (produits dangereux, zones géographiques dangereuses, transfert des données en dehors de l''UE, etc.).', N'Décrivez ici les méthodes et moyens mis en place pour éviter les risques qui peuvent l''être.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (30, N'Mesure générale de sécurité du système', N'Protection contre les sources de risques non humaines', N'Existence de mesures pour réduire ou éviter les risques liés à des sources non humaines (phénomènes climatiques, incendie, dégât des eaux, accidents internes ou externes, animaux, etc.) qui pourraient affecter la sécurité des données à caractère personnel (mesures de prévention, détection, protection, etc.).', N'Décrivez ici les mesures prises pour réduire ou éviter les risques liés à des sources non humaines.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (31, N'Mesure organisationnelle', N'Organisation de la politique de protection de la vie privée', N'Existence d’une organisation apte à diriger et contrôler la protection des données à caractère personnel au sein de l’organisme (désignation d''un un CIL/DPD, création d''un comité de suivi, etc.).', N'Décrivez ici l''organisation de la protection de la vie privée au sein de votre organisme.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (32, N'Mesure organisationnelle', N'Gérer la politique de protection de la vie privée', N'Le Responsable de traitement doit disposer d’une base documentaire formalisant les objectifs et les règles à appliquer dans le domaine « Informatique et libertés » (plan d''action, révision régulière de la politique « Informatique et libertés », etc.).', N'Décrivez ici les méthodes de gestion de la base documentaire encadrant l''organisation de la protection de la vie privée au sein de votre organisme.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (33, N'Mesure organisationnelle', N'Gérer les risques', N'Existence d''une politique définissant les processus destinés à maîtriser les risques que les traitements de l’organisme font peser sur les droits et libertés des personnes concernées (recensement des traitements de données à caractère personnel, des données, des supports, appréciation des risques, déterminer les mesures existantes ou prévues, etc.).', N'Décrivez ici les processus destinés à maîtriser les risques que les traitements de l''organisme font peser sur les droits et libertés des personnes concernées. ')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (34, N'Mesure organisationnelle', N'Intégrer la protection de la vie privée dans les projets', N'Existence de procédures décrivant les méthodes destinées à prendre en compte la protection des données à caractère personnel dans tout nouveau traitement (labels de confiance, référentiels, gestion des risques pour la personne concernée selon la méthodologie CNIL ou une méthode interne, etc.).', N'Décrivez ici les méthodes assurant la prise en compte de la protection des données à caractère personnel dès l''initiation d''un nouveau projet.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (35, N'Mesure organisationnelle', N'Gérer les incidents de sécurité et les violations de données', N'Existence d’une organisation opérationnelle permettant de détecter et de traiter les événements susceptibles d’affecter les libertés et la vie privée des personnes concernées (définition des responsabilités, plan de réaction, qualifier les violations, etc.).', N'Décrivez ici les processus opérationnels destinés à détecter et traiter les évènements susceptibles d''affecter la vie privée des personnes concernées.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (36, N'Mesure organisationnelle', N'Gestion des personnels', N'Existence d''un plan encadrant les mesures de sensibilisation prises à l’arrivée d’une personne dans sa fonction et d''une procédure décrivant les mesures prises au départ des personnes accédant aux données.', N'Indiquez ici les mesures de votre politique de ressource humaine répondant aux problématiques informatique et libertés dans votre organisme.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (37, N'Mesure organisationnelle', N'Superviser la protection de la vie privée', N'Existence de mesures permettant de disposer d’une vision globale et à jour de l’état de protection des données et de la conformité au RGPD (contrôler la conformité des traitements, objectifs et indicateurs, responsabilités, etc.).', N'Décrivez ici les processus qui assurent un contrôle régulier des traitments de données.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (38, N'Mesure organisationnelle', N'Gestion des tiers accédant aux données.', N'Existence d''une procédure visant à réduire les risques que les accès légitimes aux données par des tiers peuvent faire peser sur les libertés et la vie privée des personnes concernées (identification des tiers, contrat de sous-traitance, convention, BCR, etc.).', N'Indiquez ici, pour les tiers amenés à avoir accès aux données, les modalités et les mesures de sécurités mises en oeuvre pour ces accès.')
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (39, N'Définition', N'Chiffrement', N'Le chiffrement d’un message permet de garantir que seuls l’émetteur et le(s) destinataire(s) légitime(s) d’un message en connaissent le contenu. C’est une sorte d’enveloppe scellée numérique. Une fois chiffré, faute d''avoir la clé spécifique, un message est inaccessible et illisible, que ce soit par les humains ou les machines.
Il existe deux grandes familles de chiffrement : le chiffrement symétrique et le chiffrement asymétrique.
- Le chiffrement symétrique permet de chiffrer et de déchiffrer un contenu avec la même clé, appelée alors la « clé secrète ». Le chiffrement symétrique est particulièrement rapide mais nécessite que l’émetteur et le destinataire se mettent d’accord sur une clé secrète commune ou se la transmettent par un autre canal. Celui-ci doit être choisi avec précautions, sans quoi la clé pourrait être récupérée par les mauvaises personnes, ce qui n’assurerait plus la confidentialité du message.
- Le chiffrement asymétrique suppose que le (futur) destinataire est muni d’une paire de clés (clé privée, clé publique) et qu’il a fait en sorte que les émetteurs potentiels aient accès à sa clé publique. Dans ce cas, l’émetteur utilise la clé publique du destinataire pour chiffrer le message tandis que le destinataire utilise sa clé privée pour le déchiffrer. Parmi ses avantages, la clé publique peut être connue de tous et publiée. Mais attention : il est nécessaire que les émetteurs aient confiance en l’origine de la clé publique, qu’ils soient sûrs qu’il s’agit bien de celle du destinataire. Autre point fort : plus besoin de partager une même clé secrète ! Le chiffrement asymétrique permet de s’en dispenser mais il est plus lent.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (40, N'Définition', N'Anonymisation', N'Le but d''une solution d''anonymisation est de faire perdre le caractère identifiant des données à caractère personnel. Une solution d’anonymisation doit être construite au cas par cas et adaptée aux usages prévus. Pour aider à évaluer une bonne solution d’anonymisation, le G29 propose trois critères :
- L’individualisation : est-il toujours possible d’isoler un individu ?
- La corrélation : est-il possible de relier entre eux des ensembles de données distincts concernant un même individu ?
- L’inférence : peut-on déduire de l’information sur un individu ? 
Ainsi : un ensemble de données pour lequel il n’est possible ni d’individualiser ni de corréler ni d’inférer est a priori anonyme ;
un ensemble de données pour lequel au moins un des trois critères n’est pas respecté ne pourra être considéré comme anonyme qu’à la suite d’une analyse détaillée des risques de ré-identification.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (41, N'Définition', N'Pseudonymisation', N'Traitement des données à caractère personnel de telle façon que celles-ci ne puissent plus être attribuées à une personne concernée précise sans avoir recours à des informations supplémentaires, pour autant que ces informations supplémentaires soient conservées séparément et soumises à des mesures techniques et organisationnelles afin de garantir que les données à caractère personnel ne sont pas attribuées à une personne physique identifiée ou identifiable.
La pseudonymisation réduit le risque de mise en corrélation d’un ensemble de données avec l’identité originale d’une personne concernée; à ce titre, c’est une mesure de sécurité utile, mais non une méthode d''anonymisation.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (42, N'Définition', N'Cloisonnement', N'Ensemble de méthodes permettant de réduire la possibilité de corréler des données à caractère personnel et de provoquer une violation de l’ensemble des données .
On pourra par exemple identifier les données propres à chaque métier, les séparer logiquement, etc.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (43, N'Définition', N'Contrôle d''accès logique', N'Il consiste à limiter les risques que des personnes non autorisées accèdent aux données à caractère personnel sous forme numérique.
Pour cela, il convient de :
- définir des profils d’habilitation dans les systèmes en séparant les tâches et les domaines de responsabilité, afin de limiter l’accès des utilisateurs aux seules données strictement nécessaires à l’accomplissement de leurs missions. 
- supprimer les permissions d’accès des utilisateurs dès qu’ils ne sont plus habilités à accéder à un local ou à une ressource informatique, ainsi qu’la fin de leur contrat. 
- Réaliser une revue annuelle des habilitations afin d’identifier et de supprimer les comptes non utilisés et de réaligner les droits accordés sur les fonctions de chaque utilisateur.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (44, N'Définition', N'Mot de passe', N'Basée sur la gestion d’un secret, l’authentification par identifiant et mot de passe est un moyen simple et peu coûteux à déployer pour contrôler un accès. Toutefois, cette méthode d’authentification présente un niveau de sécurité faible.
Les exigences minimales de la CNIL en termes de taille et de complexité du mot de passe varient en fonction des mesures complémentaires mises en place pour fiabiliser le processus d’authentification :
ainsi, si une authentification est basée exclusivement sur un mot de passe, cela implique a minima l’utilisation d’un mot de passe complexe d’au moins 12 caractères composé de majuscules de minuscules, de chiffres et de
caractères spéciaux. Des mesures complémentaires à la saisie d’un mot de passe (restrictions, d’accès, collecte d’autres donnée, support détenu en propre par l’utilisateur) permettent de réduire la longueur et la complexité du mot de passe, car ces mesures permettent d’assurer un niveau de sécurité équivalent au mot de passe seul.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (45, N'Définition', N'Authentification', N'L''authentification est une opération par laquelle l''utilisateur apporte la preuve de son identité, pour cela il existe plusieurs mécanismes catégorisés selon qu’ils font intervenir :
- ce que l’on sait, par exemple un mot de passe ;
- ce que l’on a, par exemple une carte à puce ;
- une caractéristique qui nous est propre, par exemple une empreinte digitale ou encore la manière de rédiger une signature manuscrite.
Pour rappel, la loi Informatique et Libertés subordonne l’utilisation de la biométrie à l’autorisation préalable de la CNIL
L’authentification d’un utilisateur est qualifiée de forte lorsqu’elle a recours à une combinaison d’au moins deux de ces catégories.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (46, N'Définition', N'Journalisation', N'Dispositif permettant d’enregistrer des actions effectuées sur le système informatique afin de pouvoir identifier un accès frauduleux ou une utilisation abusive de données personnelles, ou de déterminer l’origine d’un incident. Il convient d’enregistrer certaines des actions effectuées sur les systèmes informatiques. Pour ce faire, un dispositif de gestion des traces et des incidents doit être mis en place. Celui-ci doit enregistrer les évènements pertinents et garantir que ces enregistrements ne peuvent être altérés. Dans tous les cas, il ne faut pas conserver ces éléments pendant une durée excessive.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (47, N'Définition', N'Archivage', N'Les données qui ne sont plus utilisées au quotidien mais qui n’ont pas encore atteint leur durée limite de conservation, par exemple parce qu’elles sont conservées en cas de contentieux, devraient être archivées.

Les archives doivent être sécurisées notamment si les données archivées sont des données sensibles, ou des données qui pourraient avoir des impacts graves sur les personnes concernées.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (48, N'Définition', N'Filtrage et retrait', N'Lors de l''importation de données, différents types de métadonnées (par exemple, des données EXIF attachées avec un fichier d''image) peuvent être involontairement collectés.
Ces métadonnées doivent être identifiées et éliminées si elles ne sont pas nécessaires aux finalités spécifiées.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (49, N'Définition', N'Réduction de la sensibilité par transformations', N'Après réception de données sensibles, faisant partie d’un lot d’informations générales ou transmises à des fins statistiques uniquement, celles-ci peuvent être converties en une forme moins sensible ou pseudonymisée. Par exemple :
- si le système collecte l’adresse IP pour déterminer l''emplacement de l’utilisateur dans un but statistique, l’adresse IP peut être supprimées après déduction de la ville ou du quartier ;
- si le système reçoit des données vidéo à partir de caméras de surveillance, il peut reconnaître les personnes debout ou en mouvement dans la scène et les flouter ;
- si le système est un compteur intelligent, il peut agréger l''utilisation de l''énergie sur une certaine période, sans l’enregistrer en temps réel.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (50, N'Définition', N'Gestion de projet', N'Démarche consistant à prendre en compte la protection des données à caractère personnel dans tout nouveau traitement (labels de confiance, référentiels, gestion des risques pour la personne concernée selon la méthodologie de la CNIL ou une méthode interne, etc.), notamment :
- Utiliser la démarche de gestion des risques de la CNIL dès l’élaboration d’un service ou la conception d’une application.
- Privilégier le recours à des labels de confiance dans les domaines de la SSI et « Informatique et libertés » (procédures, produits, systèmes de management, organismes, personnes, etc.).
- Privilégier le recours à des référentiels éprouvés et reconnus.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (51, N'Définition', N'Violation de données', N'Violation de la sécurité entraînant, de manière accidentelle ou illicite, la destruction, la perte, l''altération, la divulgation non autorisée de données à caractère personnel transmises, conservées ou traitées d''une autre manière, ou l''accès non autorisé à de telles données.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (52, N'Définition', N'Réduction du caractère identifiant des données', N'Le système peut faire en sorte que :
- l’utilisateur peut utiliser une ressource ou un service sans risque de divulguer son identité (données anonymes) ;
- l’utilisateur peut utiliser une ressource ou un service sans divulguer son identité, mais reste identifiable et responsable de cette utilisation (données pseudonymes) ;
- l’utilisateur peut faire de multiples utilisations des ressources ou des services sans risque que ces utilisations puissent être reliées ensemble (données non corrélables) ;
- l’utilisateur peut utiliser une ressource ou un service sans risque que d’autres, en particulier des tiers, puissent être en mesure d''observer que la ressource ou le service est utilisé (non-observabilité).
Le choix d''une méthode de la liste ci-dessus doit dépendre des menaces identifiées. Pour certains types de menaces sur la vie privée, la pseudonymisation sera plus appropriée que l''anonymisation (par exemple, s''il y a un besoin de traçabilité). En outre, certaines menaces sur la vie privée seront traitées par une combinaison de plusieurs méthodes.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (53, N'Définition', N'Réduction de l''accumulation de données', N'Le système peut être structuré en parties indépendantes avec des fonctions de contrôle d''accès distinctes. Les données peuvent également être réparties entre ces sous-systèmes indépendants et contrôlées par chaque sous-système en utilisant différents mécanismes de contrôle d''accès. Si un sous-système est compromis, les impacts sur l’ensemble des données peuvent ainsi être réduits.', NULL)
INSERT [dbo].[Mesure] ([Id], [Type], [Titre], [Description], [Tooltip]) VALUES (54, N'Définition', N'Restriction de l’accès aux données', N'Le système peut limiter l''accès aux données selon le principe du « besoin d’en connaître ». Le système peut séparer les données sensibles et appliquer des politiques de contrôle d''accès spécifiques.
Le système peut aussi chiffrer les données sensibles pour protéger leur confidentialité lors de la transmission et du stockage. L’accès aux fichiers cachés temporaires qui sont produits au cours du traitement des données devrait également être protégé.', NULL)
SET IDENTITY_INSERT [dbo].[Mesure] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonneConcernee] ON 

INSERT [dbo].[PersonneConcernee] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Citoyen', N'')
INSERT [dbo].[PersonneConcernee] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Interne', N'')
SET IDENTITY_INSERT [dbo].[PersonneConcernee] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (1, N'Agent')
INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (2, N'Contact')
INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (3, N'DPD')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[SourceMenace] ON 

INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Administrateur informatique', N'')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Agent interne', N'Membre du personnel de l''administration, volontaire ou non')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Intervention externe', N'volontaire ou non')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Concurrent', N'')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (5, N'Inondation ', N'')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (6, N'Incendie ', N'')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (7, N'Matériaux dangereux', N'')
INSERT [dbo].[SourceMenace] ([Id], [Libelle], [Tooltip]) VALUES (8, N'Virus informatique', N'')
SET IDENTITY_INSERT [dbo].[SourceMenace] OFF
GO
SET IDENTITY_INSERT [dbo].[SourceRisque] ON 

INSERT [dbo].[SourceRisque] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Source humaine interne', N'Il peut s''agir :
- d''un employé, malintentionné, utilisant sa proximité du système, ses compétences, ses privilèges et un temps disponible potentiellement élevés ou commettant une négligence due à un possible manque de formation et de sensibilisation.
- d''un utilisateur ou de son entourage, négligent ou malintentionné, ayant accès au service.
Ses motivations peuvent être multiples : maladresse, erreur, négligence, vengeance, volonté d’alerter, malveillance, appât du gain, espionnage')
INSERT [dbo].[SourceRisque] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Source humaine externe', N'Il peut s''agir :
- d''un tiers malintentionné ou ignorant utilisant sa proximité physique pour accéder frauduleusement au service
- d''un attaquant ciblant un utilisateur en utilisant sa connaissance de l’utilisateur et de certaines des informations le concernant
- d''un attaquant ciblant une des sociétés en charge du traitement utilisant sa connaissance des sociétés pouvant permettre d’attenter à leur image
- d''un organisme tiers autorisé utilisant ses accès privilégiés pour accéder illégitimement à des informations. Les motivations peuvent être multiples : jeu, nuisance, malveillance, vengeance, espionnage, appât du gain, acquisition de données en vue de les exploiter')
INSERT [dbo].[SourceRisque] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Source non humaine', N'Il peut s''agir d''un incident ou sinistre chez un des organismes en charge du traitement (coupure de courant, incendie, inondation, etc.)')
SET IDENTITY_INSERT [dbo].[SourceRisque] OFF
GO
SET IDENTITY_INSERT [dbo].[SupportDonnee] ON 

INSERT [dbo].[SupportDonnee] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Support papier', N'')
INSERT [dbo].[SupportDonnee] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Logiciel métiers', N'')
INSERT [dbo].[SupportDonnee] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Fichiers informatiques (Excel, Word,...)', N'')
INSERT [dbo].[SupportDonnee] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Plateforme externe', N'')
SET IDENTITY_INSERT [dbo].[SupportDonnee] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeIncident] ON 

INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (1, N'Piratage informatique (confidentialité et disponibilité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (2, N'Vol (confidentialité et disponibilité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (3, N'Perte (confidentialité et disponibilité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (4, N'Destruction (disponibilité et intégrité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (5, N'Modification non désirée (intégrité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (6, N'Divulgation non autorisée (confidentialité des données)')
INSERT [dbo].[TypeIncident] ([Id], [Libelle]) VALUES (7, N'Autre (à préciser) ')
SET IDENTITY_INSERT [dbo].[TypeIncident] OFF
GO
SET IDENTITY_INSERT [dbo].[Vraisemblance] ON 

INSERT [dbo].[Vraisemblance] ([Id], [Libelle], [Tooltip]) VALUES (1, N'Vraisemblance négligeable', N'Il ne semble pas possible que les sources de risques retenues puissent réaliser la menace en s’appuyant sur les caractéristiques des supports (ex. : vol de supports papiers stockés dans un local de l’organisme dont l’accès est contrôlé par badge et code d’accès).')
INSERT [dbo].[Vraisemblance] ([Id], [Libelle], [Tooltip]) VALUES (2, N'Vraisemblance limitée', N'Il semble difficile pour les sources de risques retenues de réaliser la menace en s’appuyant sur les caractéristiques des supports (ex. : vol de supports papiers stockés dans un local de l’organisme dont l’accès est contrôlé par badge).')
INSERT [dbo].[Vraisemblance] ([Id], [Libelle], [Tooltip]) VALUES (3, N'Vraisemblance importante', N'il semble possible pour les sources de risques retenues de réaliser la menace en s’appuyant sur les caractéristiques des supports (ex. : vol de supports papiers stockés dans les bureaux d’un organisme dont l’accès est contrôlé par une personne à l’accueil).')
INSERT [dbo].[Vraisemblance] ([Id], [Libelle], [Tooltip]) VALUES (4, N'Vraisemblance maximale', N'il semble extrêmement facile pour les sources de risques retenues de réaliser la menace en s’appuyant sur les caractéristiques des supports (ex. : vol de supports papier stockés dans le hall public de l’organisme).')
SET IDENTITY_INSERT [dbo].[Vraisemblance] OFF
GO

SET IDENTITY_INSERT [dbo].[Service] ON

INSERT INTO [Service] (Id,Libelle) VALUES (1,'Service DPO')
INSERT INTO [Service] (Id,Libelle) VALUES (2,'Service Test')
SET IDENTITY_INSERT [dbo].[Service] OFF
GO

SET IDENTITY_INSERT [dbo].Utilisateur ON
INSERT INTO Utilisateur (Id,DisplayName,LogonName,IdService,IdRole,LocalPwd) VALUES (1, 'user normal', 'user.normal', 2, 1, 'test')
INSERT INTO Utilisateur (Id,DisplayName,LogonName,IdService,IdRole,LocalPwd) VALUES (2, 'user contact', 'user.contact', 2, 2, 'test')
INSERT INTO Utilisateur (Id,DisplayName,LogonName,IdService,IdRole,LocalPwd) VALUES (3, 'user DPO', 'user.dpo', 1,3, 'test')

SET IDENTITY_INSERT [dbo].Utilisateur OFF
GO