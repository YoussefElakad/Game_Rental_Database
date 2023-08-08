/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/24/2022 2:50:15 PM                         */
/*==============================================================*/

create database GameRental
go
use GameRental
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'DEV_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.DEV_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENTER')
            and   type = 'U')
   drop table RENTER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTING')
            and   name  = 'RENTING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTING.RENTING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTING')
            and   name  = 'RENTING_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTING.RENTING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENTING')
            and   type = 'U')
   drop table RENTING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENDOR')
            and   type = 'U')
   drop table VENDOR
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   GAME_ID              int                  not null,
   VENDOR_ID            int                  not null,
   NAME                 varchar(50)          not null,
   PRICE                int                  not null,
   NO_RENTED            int                  null,
   TOTAL_INCOME         int                  null,
   constraint PK_GAME primary key nonclustered (GAME_ID)
)
go

/*==============================================================*/
/* Index: DEV_FK                                                */
/*==============================================================*/
create index DEV_FK on GAME (
VENDOR_ID ASC
)
go

/*==============================================================*/
/* Table: RENTER                                                */
/*==============================================================*/
create table RENTER (
   RENTER_ID            int                  not null,
   EMAIL                varchar(50)          not null,
   PASSWORD             varchar(10)          not null,
   NAME                 varchar(50)          not null,
   NO_RENTED            int                  null,
   constraint PK_RENTER primary key nonclustered (RENTER_ID, EMAIL)
)
go

/*==============================================================*/
/* Table: RENTING                                               */
/*==============================================================*/
create table RENTING (
   RENTER_ID            int                  not null,
   EMAIL                varchar(50)          not null,
   GAME_ID              int                  not null,
   constraint PK_RENTING primary key (RENTER_ID, EMAIL, GAME_ID)
)
go

/*==============================================================*/
/* Index: RENTING_FK                                            */
/*==============================================================*/
create index RENTING_FK on RENTING (
RENTER_ID ASC,
EMAIL ASC
)
go

/*==============================================================*/
/* Index: RENTING2_FK                                           */
/*==============================================================*/
create index RENTING2_FK on RENTING (
GAME_ID ASC
)
go

/*==============================================================*/
/* Table: VENDOR                                                */
/*==============================================================*/
create table VENDOR (
   VENDOR_ID            int                  not null,
   NAME                 varchar(50)          not null,
   NO_RENTED            int                  null,
   constraint PK_VENDOR primary key nonclustered (VENDOR_ID)
)
go

