create table Categoria
(
	ID		int  identity(1,1),
	Codigo	varchar(20) primary key,
	Descricao	varchar(100) not null
)
go
create table Produto
(
	ID		int  identity(1,1),
	CodigoFabricacao	varchar(20) primary key,
	NomeProduto	varchar(100) not null,
	Categoria	varchar(20) not null,
	Peso float
)
go
alter table Produto
add constraint FK_Categoria_Produto Foreign Key (Categoria) references Categoria (Codigo)
go
insert into Categoria (Codigo, Descricao) values ('A1','Bebidas')
insert into Categoria (Codigo, Descricao) values ('A2', 'Carne')
go
insert into Produto (CodigoFabricacao, NomeProduto, Categoria, Peso) values ('AA1', 'Vinho',  'A1',1.0)
insert into Produto (CodigoFabricacao, NomeProduto, Categoria, Peso) values ('AA2', 'Picanha','A2',1.5)
go
	select Produto.Categoria,
	       Produto.NomeProduto,
		   Produto.Peso,
		   Categoria.Codigo,
		   Categoria.Descricao       
	  from Produto (nolock)
    inner join Categoria (nolock) on Produto.Categoria = Categoria.Codigo