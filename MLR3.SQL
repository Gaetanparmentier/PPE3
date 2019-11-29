/*
 ----------------------------------------------------------------------------
             Génération d'une base de données pour
                      Microsoft SQL Server
                       (29/11/2019 16:03:34)
 ----------------------------------------------------------------------------
     Nom de la base : MCDPPE4
     Projet : Espace de travail
     Auteur : LMC
     Date de dernière modification : 29/11/2019 16:02:42
 ----------------------------------------------------------------------------
*/

drop database MCDPPE4
go

/* -----------------------------------------------------------------------------
      OUVERTURE DE LA BASE MLR3
----------------------------------------------------------------------------- */

create database MCDPPE4
go

use MCDPPE4
go



/* -----------------------------------------------------------------------------
      TABLE : ASSOCIATIONS
----------------------------------------------------------------------------- */

create table ASSOCIATIONS
(
     IDASSOCIATIONS int ,
     IDPAYSDEPENDANCE int not null,
     NOM char(32) ,
     MISSION char(255) ,
     NOMRESPONSABLE char(32) 
)
go



/*      INDEX DE ASSOCIATIONS      */


sp_primarykey ASSOCIATIONS, IDASSOCIATIONS
go



/* -----------------------------------------------------------------------------
      TABLE : CATÉGORIE
----------------------------------------------------------------------------- */

create table CATÉGORIE
(
     IDCATEGORIE int ,
     LIBELLECATEGORIE char(64) 
)
go


sp_primarykey CATÉGORIE, IDCATEGORIE
go



/* -----------------------------------------------------------------------------
      TABLE : ACTIONMENEE
----------------------------------------------------------------------------- */

create table ACTIONMENEE
(
     IDACTION int ,
     LIBELLE char(255) 
)
go


sp_primarykey ACTIONMENEE, IDACTION
go



/* -----------------------------------------------------------------------------
      TABLE : CONTROLE
----------------------------------------------------------------------------- */

create table CONTROLE
(
     IDCONTROLE int ,
     IDTYPECONTROLE int not null,
     IDENTREPRISE int not null,
     IDZONE int not null,
     DATE datetime ,
     RESUMÉ char(64) ,
     MONTANT bigint 
)
go



/*      INDEX DE CONTROLE      */


sp_primarykey CONTROLE, IDCONTROLE
go



/* -----------------------------------------------------------------------------
      TABLE : ARTISTE
----------------------------------------------------------------------------- */

create table ARTISTE
(
     IDARTISTE int ,
     NOM char(32) ,
     PRENOM char(32) ,
     TEL char(12) ,
     ADRS char(40) ,
     MOUVEMENTS char(60) 
)
go


sp_primarykey ARTISTE, IDARTISTE
go



/* -----------------------------------------------------------------------------
      TABLE : EVÈNEMENTS
----------------------------------------------------------------------------- */

create table EVÈNEMENTS
(
     IDEVENEMENTS int ,
     IDTHEME int not null,
     DATEDEBUT datetime ,
     VILLE char(32) ,
     DATEFIN datetime 
)
go



/*      INDEX DE EVÈNEMENTS      */


sp_primarykey EVÈNEMENTS, IDEVENEMENTS
go



/* -----------------------------------------------------------------------------
      TABLE : PAYSDEPENDANCE
----------------------------------------------------------------------------- */

create table PAYSDEPENDANCE
(
     IDPAYSDEPENDANCE int ,
     PAYSDEPENDANCE char(50) 
)
go


sp_primarykey PAYSDEPENDANCE, IDPAYSDEPENDANCE
go



/* -----------------------------------------------------------------------------
      TABLE : CATPRODUIT
----------------------------------------------------------------------------- */

create table CATPRODUIT
(
     CATPRODUIT int ,
     LIBELLE char(45) 
)
go


sp_primarykey CATPRODUIT, CATPRODUIT
go



/* -----------------------------------------------------------------------------
      TABLE : VIP
----------------------------------------------------------------------------- */

create table VIP
(
     IDVIP int ,
     IDCATEGORIE int not null,
     NOM char(20) ,
     ADR char(32) ,
     EMAIL char(32) ,
     VILLE char(32) 
)
go



/*      INDEX DE VIP      */


sp_primarykey VIP, IDVIP
go



/* -----------------------------------------------------------------------------
      TABLE : ENTREPRISECONTROLE
----------------------------------------------------------------------------- */

create table ENTREPRISECONTROLE
(
     IDENTREPRISE int ,
     NOM char(128) ,
     ADR char(128) ,
     EMAIL char(40) 
)
go


sp_primarykey ENTREPRISECONTROLE, IDENTREPRISE
go



/* -----------------------------------------------------------------------------
      TABLE : THEME
----------------------------------------------------------------------------- */

create table THEME
(
     IDTHEME int ,
     LIBELLE char(150) 
)
go


sp_primarykey THEME, IDTHEME
go



/* -----------------------------------------------------------------------------
      TABLE : ZONE_DE_STOCKAGE
----------------------------------------------------------------------------- */

create table ZONE_DE_STOCKAGE
(
     IDZONE int ,
     CATPRODUIT int not null,
     NOM char(32) ,
     EMPLACEMENT char(100) 
)
go



/*      INDEX DE ZONE_DE_STOCKAGE      */


sp_primarykey ZONE_DE_STOCKAGE, IDZONE
go



/* -----------------------------------------------------------------------------
      TABLE : CAMPAGNES_DE_SENSIBILISATION
----------------------------------------------------------------------------- */

create table CAMPAGNES_DE_SENSIBILISATION
(
     IDCAMPAGNES int ,
     IDAGENCE int not null,
     INTITULÉ char(50) ,
     OBJECTIF char(128) ,
     PUBLICCIBLÉ char(50) ,
     DATEDEBUT datetime ,
     DATEFIN datetime 
)
go



/*      INDEX DE CAMPAGNES_DE_SENSIBILISATION      */


sp_primarykey CAMPAGNES_DE_SENSIBILISATION, IDCAMPAGNES
go



/* -----------------------------------------------------------------------------
      TABLE : AGENCE
----------------------------------------------------------------------------- */

create table AGENCE
(
     IDAGENCE int ,
     NOMAGENCE char(32) ,
     LIBELLEACTIVITÉ char(32) ,
     ADRESSEAGENCE char(60) ,
     TELEPHONE char(12) ,
     EMAIL char(32) ,
     URLSITEWEB char(120) ,
     TYPEAGENCE char(32) ,
     CONNUES bit 
)
go


sp_primarykey AGENCE, IDAGENCE
go



/* -----------------------------------------------------------------------------
      TABLE : PARTENARIAT
----------------------------------------------------------------------------- */

create table PARTENARIAT
(
     IDPARTENARIAT int ,
     IDASSOCIATIONS int not null,
     IDACTION int not null,
     IDPAYSDEPENDANCE int not null,
     BUDGETPREVISIONNEL bigint ,
     BUDGETREEL bigint ,
     DATE datetime 
)
go



/*      INDEX DE PARTENARIAT      */


sp_primarykey PARTENARIAT, IDPARTENARIAT
go



/* -----------------------------------------------------------------------------
      TABLE : TYPEDECONTROLE
----------------------------------------------------------------------------- */

create table TYPEDECONTROLE
(
     IDTYPECONTROLE int ,
     LIBELLE char(255) 
)
go


sp_primarykey TYPEDECONTROLE, IDTYPECONTROLE
go



/* -----------------------------------------------------------------------------
      TABLE : ENVOI
----------------------------------------------------------------------------- */

create table ENVOI
(
     IDCATEGORIE int not null,
     IDEVENEMENTS int not null,
     MESSAGE char(80) ,
     DATEENVOI datetime 
)
go



/*      INDEX DE ENVOI      */


sp_primarykey ENVOI, IDCATEGORIE, IDEVENEMENTS
go



/* -----------------------------------------------------------------------------
      TABLE : A
----------------------------------------------------------------------------- */

create table A
(
     IDZONE int not null,
     IDTYPECONTROLE int not null
)
go



/*      INDEX DE A      */


sp_primarykey A, IDZONE, IDTYPECONTROLE
go



/* -----------------------------------------------------------------------------
      TABLE : CONVIER
----------------------------------------------------------------------------- */

create table CONVIER
(
     IDVIP int not null,
     IDEVENEMENTS int not null
)
go



/*      INDEX DE CONVIER      */


sp_primarykey CONVIER, IDVIP, IDEVENEMENTS
go



/* -----------------------------------------------------------------------------
      TABLE : EST_COMPOSÉ
----------------------------------------------------------------------------- */

create table EST_COMPOSÉ
(
     IDCAMPAGNES int not null,
     IDEVENEMENTS int not null
)
go



/*      INDEX DE EST_COMPOSÉ      */


sp_primarykey EST_COMPOSÉ, IDCAMPAGNES, IDEVENEMENTS
go



/* -----------------------------------------------------------------------------
      TABLE : POSSEDE
----------------------------------------------------------------------------- */

create table POSSEDE
(
     IDENTREPRISE int not null,
     IDTYPECONTROLE int not null
)
go



/*      INDEX DE POSSEDE      */


sp_primarykey POSSEDE, IDENTREPRISE, IDTYPECONTROLE
go



/* -----------------------------------------------------------------------------
      TABLE : INTERVIENT
----------------------------------------------------------------------------- */

create table INTERVIENT
(
     IDARTISTE int not null,
     IDEVENEMENTS int not null,
     CACHET bigint 
)
go



/*      INDEX DE INTERVIENT      */


sp_primarykey INTERVIENT, IDARTISTE, IDEVENEMENTS
go



/* -----------------------------------------------------------------------------
      REFRENCES SUR LES TABLES
----------------------------------------------------------------------------- */


sp_foreignkey ASSOCIATIONS, PAYSDEPENDANCE, IDPAYSDEPENDANCE
go


sp_foreignkey CONTROLE, TYPEDECONTROLE, IDTYPECONTROLE
go


sp_foreignkey CONTROLE, ENTREPRISECONTROLE, IDENTREPRISE
go


sp_foreignkey CONTROLE, ZONE_DE_STOCKAGE, IDZONE
go


sp_foreignkey EVÈNEMENTS, THEME, IDTHEME
go


sp_foreignkey VIP, CATÉGORIE, IDCATEGORIE
go


sp_foreignkey ZONE_DE_STOCKAGE, CATPRODUIT, CATPRODUIT
go


sp_foreignkey CAMPAGNES_DE_SENSIBILISATION, AGENCE, IDAGENCE
go


sp_foreignkey PARTENARIAT, ASSOCIATIONS, IDASSOCIATIONS
go


sp_foreignkey PARTENARIAT, ACTIONMENEE, IDACTION
go


sp_foreignkey PARTENARIAT, PAYSDEPENDANCE, IDPAYSDEPENDANCE
go


sp_foreignkey ENVOI, CATÉGORIE, IDCATEGORIE
go


sp_foreignkey ENVOI, EVÈNEMENTS, IDEVENEMENTS
go


sp_foreignkey A, ZONE_DE_STOCKAGE, IDZONE
go


sp_foreignkey A, TYPEDECONTROLE, IDTYPECONTROLE
go


sp_foreignkey CONVIER, VIP, IDVIP
go


sp_foreignkey CONVIER, EVÈNEMENTS, IDEVENEMENTS
go


sp_foreignkey EST_COMPOSÉ, CAMPAGNES_DE_SENSIBILISATION, IDCAMPAGNES
go


sp_foreignkey EST_COMPOSÉ, EVÈNEMENTS, IDEVENEMENTS
go


sp_foreignkey POSSEDE, ENTREPRISECONTROLE, IDENTREPRISE
go


sp_foreignkey POSSEDE, TYPEDECONTROLE, IDTYPECONTROLE
go


sp_foreignkey INTERVIENT, ARTISTE, IDARTISTE
go


sp_foreignkey INTERVIENT, EVÈNEMENTS, IDEVENEMENTS
go



/*
 -----------------------------------------------------------------------------
               FIN DE GENERATION
 -----------------------------------------------------------------------------
*/