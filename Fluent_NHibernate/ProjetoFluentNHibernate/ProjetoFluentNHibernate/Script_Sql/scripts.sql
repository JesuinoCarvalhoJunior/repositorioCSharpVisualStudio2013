
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE3CB0D1CF4B877CB]') AND parent_object_id = OBJECT_ID('GruposToPessoa'))
alter table GruposToPessoa  drop constraint FKE3CB0D1CF4B877CB


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE3CB0D1CB8320817]') AND parent_object_id = OBJECT_ID('GruposToPessoa'))
alter table GruposToPessoa  drop constraint FKE3CB0D1CB8320817


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE9D358C3E5A008D9]') AND parent_object_id = OBJECT_ID('[Pessoa]'))
alter table [Pessoa]  drop constraint FKE9D358C3E5A008D9


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKC5C048FEF4B877CB]') AND parent_object_id = OBJECT_ID('[PessoaFisica]'))
alter table [PessoaFisica]  drop constraint FKC5C048FEF4B877CB


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB4F7BA74F4B877CB]') AND parent_object_id = OBJECT_ID('[PessoaJuridica]'))
alter table [PessoaJuridica]  drop constraint FKB4F7BA74F4B877CB


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKC40561A0F4B877CB]') AND parent_object_id = OBJECT_ID('[Telefone]'))
alter table [Telefone]  drop constraint FKC40561A0F4B877CB


    if exists (select * from dbo.sysobjects where id = object_id(N'[Departamento]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Departamento]

    if exists (select * from dbo.sysobjects where id = object_id(N'[Grupo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Grupo]

    if exists (select * from dbo.sysobjects where id = object_id(N'GruposToPessoa') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table GruposToPessoa

    if exists (select * from dbo.sysobjects where id = object_id(N'[Pessoa]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Pessoa]

    if exists (select * from dbo.sysobjects where id = object_id(N'[PessoaFisica]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [PessoaFisica]

    if exists (select * from dbo.sysobjects where id = object_id(N'[PessoaJuridica]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [PessoaJuridica]

    if exists (select * from dbo.sysobjects where id = object_id(N'[Telefone]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Telefone]

    create table [Departamento] (
        Codigo INT IDENTITY NOT NULL,
       Nome NVARCHAR(80) not null,
       Descricao NVARCHAR(100) null,
       DataCadastro DATETIME not null,
       primary key (Codigo)
    )

    create table [Grupo] (
        Codigo INT IDENTITY NOT NULL,
       Nome NVARCHAR(80) not null,
       Descricao NVARCHAR(100) null,
       DataCadastro DATETIME not null,
       primary key (Codigo)
    )

    create table GruposToPessoa (
        Grupo_id INT not null,
       Pessoa_id INT not null
    )

    create table [Pessoa] (
        Codigo INT IDENTITY NOT NULL,
       Nome NVARCHAR(80) not null,
       Endereco NVARCHAR(100) null,
       Cep NVARCHAR(10) null,
       Email NVARCHAR(100) null,
       DataCadastro DATETIME not null,
       Status INT null,
       Departamento_id INT not null,
       primary key (Codigo)
    )

    create table [PessoaFisica] (
        Pessoa_id INT not null,
       Cpf NVARCHAR(14) not null,
       Nacionalidade NVARCHAR(30) null,
       primary key (Pessoa_id)
    )

    create table [PessoaJuridica] (
        Pessoa_id INT not null,
       Cnpj NVARCHAR(18) not null,
       WebSite NVARCHAR(100) null,
       primary key (Pessoa_id)
    )

    create table [Telefone] (
        Codigo INT IDENTITY NOT NULL,
       CodigoDdd INT not null,
       Numero INT not null,
       Pessoa_id INT null,
       primary key (Codigo)
    )

    alter table GruposToPessoa 
        add constraint FKE3CB0D1CF4B877CB 
        foreign key (Pessoa_id) 
        references [Pessoa]

    alter table GruposToPessoa 
        add constraint FKE3CB0D1CB8320817 
        foreign key (Grupo_id) 
        references [Grupo]

    alter table [Pessoa] 
        add constraint FKE9D358C3E5A008D9 
        foreign key (Departamento_id) 
        references [Departamento]

    alter table [PessoaFisica] 
        add constraint FKC5C048FEF4B877CB 
        foreign key (Pessoa_id) 
        references [Pessoa]

    alter table [PessoaJuridica] 
        add constraint FKB4F7BA74F4B877CB 
        foreign key (Pessoa_id) 
        references [Pessoa]

    alter table [Telefone] 
        add constraint FKC40561A0F4B877CB 
        foreign key (Pessoa_id) 
        references [Pessoa]
